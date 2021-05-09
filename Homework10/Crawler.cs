using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace crawler
{
    class Info
    {
        public string Url { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
        public string FileName { get; set; }
        public Info(string url)
        {
            Url = url;
        }
    }

    class SimpleCrawler
    {
        static object listLock = new object();
        private int Threads = 0;
        public int MaxCount = 10;
        private readonly Hashtable urls = Hashtable.Synchronized(new Hashtable());
        private int count = 0;
        public List<Info> InfoList = new List<Info>();
        public bool IsCrawling;
        public string BaseUrl;
        public void Crawl()
        {
            ThreadPool.SetMaxThreads(Environment.ProcessorCount, Environment.ProcessorCount);
            Threads = 0;
            count = 0;
            InfoList.Clear();
            IsCrawling = true;
            urls.Clear();
            urls[BaseUrl] = false;
            var uri = new Uri(BaseUrl);
            BaseUrl = uri.Host;
            while (true)
            {
                string current = null;
                lock (urls.SyncRoot)
                {
                    foreach (string url in urls.Keys)
                    {
                        if ((bool) urls[url]) continue;
                        current = url;
                    }
                }
                while (current == null && Threads != 0) // 没有网页要爬了，等待线程结束再重新统计
                {
                    Thread.Sleep(200);
                }

                if (current == null)
                {
                    lock (urls.SyncRoot)
                    {
                        foreach (string url in urls.Keys)
                        {
                            if ((bool)urls[url]) continue;
                            current = url;
                        }
                    }
                }
                if (current == null || count >= MaxCount) break;
                urls[current] = true;
                lock(listLock)
                {
                    InfoList.Add(new Info(current));
                }
                lock (this)
                {
                    Threads++;
                }
                ThreadPool.QueueUserWorkItem(new WaitCallback(Work), current);
            }
            IsCrawling = false;
        }

        private void Work(object obj)
        {
            var current = (string) obj;
            string html;
            var nowcount = 0;
            try
            {
                lock (this)
                {
                    nowcount = ++count;
                }

                html = DownLoad(current, nowcount); // 下载
            }
            catch (Exception e)
            {
                lock (listLock)
                {
                    InfoList[nowcount - 1].Success = false;
                    InfoList[nowcount - 1].Error = e.ToString();
                }
                lock (this)
                {
                    Threads--;
                }
                return;
            }
            Parse(current, html);//解析,并加入新的链接
            lock (listLock)
            {
                InfoList[nowcount - 1].Success = true;
                InfoList[nowcount - 1].FileName = nowcount.ToString() + ".html";
            }
            lock (this)
            {
                Threads--;
            }
        }
        public string DownLoad(string url, int count)
        {
            var webClient = new WebClient {Encoding = Encoding.UTF8};
            var html = webClient.DownloadString(url);
            var fileName = count.ToString() + ".html";
            File.WriteAllText(fileName, html, Encoding.UTF8); 
            return html;
        }

        private void Parse(string current, string html)
        {
            var strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            var matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                    .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                // strRef[strRef.Length - 1] != '/'?
                if (!strRef.Contains("htm") && !strRef.Contains("aspx") && !strRef.Contains("jsp")) continue;
                if (strRef[0] == '/') strRef = Path.Combine(BaseUrl, strRef.TrimStart('/')); // 相对路径，/开始，拼接域名。
                else if (strRef.Contains("http") == false) strRef = Path.Combine(current, strRef); // 相对路径，没有/开始，拼接正在打开的网页。
                if (strRef.Contains(BaseUrl) == false) continue; // 不是指定的网站
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
    }
}

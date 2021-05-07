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
        public int MaxCount = 10;
        private Hashtable urls = new Hashtable();
        private int count = 0;
        public List<Info> InfoList;
        public bool IsCrawling = false;
        public string BaseUrl;
        public void Crawl()
        {
            count = 0;
            InfoList = new List<Info>();
            IsCrawling = true;
            urls = new Hashtable {{BaseUrl, false}};
            var uri = new Uri(BaseUrl);
            BaseUrl = uri.Host;
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > MaxCount) break;
                InfoList.Add(new Info(current));
                string html;
                try
                {
                    html = DownLoad(current); // 下载
                }
                catch (Exception e)
                {
                    InfoList[InfoList.Count - 1].Success = false;
                    InfoList[InfoList.Count - 1].Error = e.ToString();
                    urls[current] = true;
                    continue;
                }

                InfoList[InfoList.Count - 1].Success = true;
                InfoList[InfoList.Count - 1].FileName = count.ToString() + ".html";
                urls[current] = true;
                count++;
                Parse(current, html);//解析,并加入新的链接
                //Console.WriteLine("爬行结束");
            }

            IsCrawling = false;
            urls = new Hashtable();
        }

        public string DownLoad(string url)
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
                if (!strRef.Contains("htm") && !strRef.Contains("aspx") && !strRef.Contains("jsp")) continue;
                if (strRef[0] == '/') strRef = Path.Combine(BaseUrl, strRef); // 相对路径，/开始，拼接域名。
                else if (strRef.Contains("http") == false) strRef = Path.Combine(current, strRef); // 相对路径，没有/开始，拼接正在打开的网页。
                if (strRef.Contains(BaseUrl) == false) continue; // 不是指定的网站
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crawler
{
    public partial class CrawlerView : Form
    {
        private readonly SimpleCrawler sc = new SimpleCrawler();
        public CrawlerView()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //sc.urls.Add(txtURL.Text, false);
            sc.BaseUrl = txtURL.Text;
            sc.MaxCount = (int)nudMaxCount.Value;
            new Thread(sc.Crawl).Start();
        }

        private void dgvInfo_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bdsInfo.DataSource = sc.InfoList;
            bdsInfo.ResetBindings(false);
            lbState.Text = sc.IsCrawling == false ? "未开始" : "爬行中";
            btnStart.Enabled = sc.IsCrawling == false;
        }
    }
}

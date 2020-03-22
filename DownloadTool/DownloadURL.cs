using System;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace DownloadTool
{
    public partial class frmDownload : Form
    {
        public frmDownload()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            GetDownloaded(txtDownloadURL.Text);
        }
        private void GetDownloaded(string downloadURL)
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            // use the html agility pack: http://www.codeplex.com/htmlagilitypack
            HtmlAgilityPack.HtmlDocument doc = htmlWeb.Load(downloadURL);
            var nodes = doc.DocumentNode.Descendants("img")
                .Where(img => img.Attributes["alt"].Value == "directory")
                .Select(n => n.NextSibling)
                .Select(cn => cn.NextSibling);

        }
        private bool DownloadURL(string downloadURL, string savePath)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFile(downloadURL, savePath);
            return true;
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download completed!");
        }
    }
}

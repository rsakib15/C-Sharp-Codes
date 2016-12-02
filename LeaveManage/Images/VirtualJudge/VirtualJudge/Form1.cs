using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;

namespace VirtualJudge
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("http://codeforces.com/problemset");
            int i = 0;
            foreach (HtmlNode table in doc.DocumentNode.SelectNodes("//table/tr"))
            {
                i++;
                //Console.WriteLine("row " + i);

                foreach (HtmlNode cell in table.SelectNodes("//td[2]/div[1]"))
                {
                    //Console.WriteLine("cell: " + cell.InnerText);
                    webBrowser1.DocumentText = cell.InnerText;
                }
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}

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

namespace Leave
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void webBrowser1_DocumentCompleted(object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();


        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Registration l = new Registration();
            l.Show();
            this.Hide();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            EnterExitTime l = new EnterExitTime();
            l.Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}

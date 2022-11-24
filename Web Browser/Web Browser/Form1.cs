using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.Hide();
        }

        private void btn_search1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(browser_comboBox.Text);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void btn_forword_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btn_refrash_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btn_search2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www." + search_textBox.Text + ".com");
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                progressBar1.Value = Convert.ToInt32(e.CurrentProgress);
                progressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
            }
            catch
            {

            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            browser_comboBox.Text = webBrowser1.Url.ToString();
            History.Items.Add(browser_comboBox.Text);
        }

        private void btn_historyClear_Click(object sender, EventArgs e)
        {
            History.Items.Clear();
        }

        private void btn_historyHide_Click(object sender, EventArgs e)
        {
            tabControl1.Hide();
        }

        private void btn_favorite_Clear_Click(object sender, EventArgs e)
        {
            Favorite.Items.Clear();
        }

        private void btn_favoriteHide_Click(object sender, EventArgs e)
        {
            tabControl1.Hide();
        }

        private void btn_favorite_Click(object sender, EventArgs e)
        {
            Favorite.Items.Add(browser_comboBox.Text);
        }

        private void btn_setings_Click(object sender, EventArgs e)
        {
            tabControl1.Show();
        }

        private void new_window_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void btn_source_Click(object sender, EventArgs e)
        {
            String source = ("viewsource.txt");
            StreamWriter writer = File.CreateText(source);
            writer.Write(webBrowser1.DocumentText);
            writer.Close();
            Process.Start("notepad.exe", source);
        }
    }
}

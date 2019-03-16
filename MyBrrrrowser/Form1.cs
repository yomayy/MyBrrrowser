using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBrrrrowser.Models;

namespace MyBrrrrowser
{
    public partial class Browser1 : Form
    {
        private DbContext db;

        public Browser1()
        {
            InitializeComponent();
            db = new DbContext();
            comboBox1.DataSource = db.Categories;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void GoToPage()
        {
            string addr = textBox1.Text;
            if(addr == "")
            {
                MessageBox.Show("Vi ne vveli adresok", "Ворнинг", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                webBrowser1.Navigate(addr);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GoToPage();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                GoToPage();
        }

        private void Back_but_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Forw_but_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object id = comboBox1.SelectedValue;

            var res = db.Sites.Where(s => s.CategoryId == (int)id).ToList();


            listBox1.DataSource = res;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = listBox1.SelectedIndex;
            if (k == -1)
                MessageBox.Show("Vi ne vibrali sait");
            else
            {
                object id = listBox1.SelectedValue;
                var site = db.Sites.Where(s => s.Id == (int)id).FirstOrDefault();
                if(site != null)
                {
                    webBrowser1.Navigate(site.Address);
                }
            }
        }
    }
}

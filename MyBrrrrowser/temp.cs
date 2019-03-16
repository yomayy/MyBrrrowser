using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrrrrowser
{
    public partial class temp : Form
    {
        public temp()
        {
            InitializeComponent();
        }

        private void Calc_but_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void Note_but_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void OpenPDF_but_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Загрузки\Telegram Desktop\2 курс 126 спец..pdf");
        }

        private void OpenMP3_but_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Netflix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("www.netflix.com/mx/title/81028336");
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("www.youtube.com/watch?v=gwMa6gpoE9I");
            Form Dale = new GifBiTiEz();
            Dale.Show();
        }
    }
}

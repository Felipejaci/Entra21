using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormExecs2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExec02_Click(object sender, EventArgs e)
        {
            new Exec02().Show();
            this.Hide();
        }

        private void btnExec03_Click(object sender, EventArgs e)
        {
            new Exec03().Show();
            this.Hide();
        }

        private void btnExec01WF04_Click(object sender, EventArgs e)
        {
            new Exec01().Show();
            this.Hide();
        }

        private void btnExec02WF04_Click(object sender, EventArgs e)
        {
            new WinForm04Exec02().Show();
            this.Hide();
        }

        private void btnExec03WF05_Click(object sender, EventArgs e)
        {
            new Exec03WinForm05().Show();
            this.Show();
        }
    }
}

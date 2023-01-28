using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task21._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 47, 255);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(77, 255, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(242, 255, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(238, 0, 255);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 119, 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_603410156_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); 
            f2.ShowDialog();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3(); 
            f2.ShowDialog(); 
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4(); 
            f2.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f2 = new Form5(); 
            f2.ShowDialog(); 
        }
    }
}

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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton81_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Close();
        }

        bool ok = false;
        private void button4_Click(object sender, EventArgs e)
        {           
            if (ok == false)
            {
                tabControl1.TabPages.Insert(1,tabPage2);
                tabControl1.SelectedIndex = 1;
               ok = true;
                tabControl1.SelectedTab = tabPage2;
            }
            else tabControl1.SelectedTab = tabPage2;          
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           tabControl1.TabPages.Remove(tabPage5);
           tabControl1.TabPages.Remove(tabPage4);
           tabControl1.TabPages.Remove(tabPage3);
           tabControl1.TabPages.Remove(tabPage2);
        }

        bool g = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (g == false)
            {
                tabControl1.TabPages.Insert(2, tabPage3);
                tabControl1.SelectedIndex = 2;
                ok = true;
                tabControl1.SelectedTab = tabPage3;
            }
            else tabControl1.SelectedTab = tabPage3;
        }


        bool y = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (y == false)
            {
                tabControl1.TabPages.Insert(3, tabPage4);
                tabControl1.SelectedIndex = 3;
                ok = true;
                tabControl1.SelectedTab = tabPage4;
            }
            else tabControl1.SelectedTab = tabPage4;
        }


        bool t = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (t == false)
            {
                tabControl1.TabPages.Insert(4, tabPage5);
                tabControl1.SelectedIndex = 4;
                ok = true;
                tabControl1.SelectedTab = tabPage5;
            }
            else tabControl1.SelectedTab = tabPage5;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }
    }
}

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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/sasithon2541/Grammar");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.co.th/search?q=grammar&client=firefox-b-ab&dcr=0&source=lnms&tbm=isch&sa=X&ved=0ahUKEwi58p-GsPfXAhXBQ48KHaO5AD8Q_AUICigB&biw=1366&bih=656#imgrc=TjU_o7Mpdl214M:");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.กริยา3ช่อง.com/");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.tonamorn.com/grammar/");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Process.Start("https://srikranuan610.wordpress.com/%E0%B8%82%E0%B9%89%E0%B8%AD%E0%B8%AA%E0%B8%AD%E0%B8%9A%E0%B9%80%E0%B8%A3%E0%B8%B7%E0%B9%88%E0%B8%AD%E0%B8%87-tense/");
        }
    }
}

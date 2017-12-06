using Iveonik.Stemmers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_603410156_1
{
    public partial class Form2 : Form
    {
        IStemmer stemmer = new EnglishStemmer();
        public Form2()
        {
            InitializeComponent();
        }

        private void find_data(string y)
        {
            string[] k = System.IO.File.ReadAllLines(Application.StartupPath + @"\Ir.txt");
            string kk = String.Empty;
            int i = 0;
            while (i < k.Length)
            {
                string[] AA = k[i].Split('|');
                if (y == AA[0])
                {
                    kk = "Present (V1) =   " + AA[0] + "\r\n" + "Past Simple (V2) =   " + AA[1] + "\r\n" + "Past Participle (V3) =   " + AA[2] + "\r\n" + "Meaning =   " + AA[3];
                    break;
                }
                i++;
            }
            textBox2.Text += "\r\n" + kk.ToLower();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text; // ตัดพวกคำลงท้ายให้เหลือแต่คำแม่
            textBox2.Text = stemmer.Stem(word);
            

            String AllowedChars = @"^[a-zA-Z]+";
            if (Regex.IsMatch(textBox1.Text,AllowedChars))
            {

                find_data(stemmer.Stem(word));
            }
            else
            {
                
                
                MessageBox.Show("กรุณาใส่ตัวอักษรภาษาอังกฤษ");
            }
        }
    }
}

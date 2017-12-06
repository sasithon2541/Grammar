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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string k;
            switch (comboBox1.Text)
            {
                case "Present Simple Tense":
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Present Simple Tense.txt");
                    tb1.Text = k.ToString();
                    break;
                case "Present Continuous Tense ":
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Present Continuous Tense.txt");
                    tb1.Text = k.ToString();
                    break;
                case "Present Perfect Tense ":
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Present Perfect Tense .txt");
                    tb1.Text = k.ToString();
                    break;
                case "Present Perfect Continuous Tense":
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Present Perfect Continuous Tense.txt");
                    tb1.Text = k.ToString();
                    break;
                case "Past Simple Tense":
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Past Simple Tense.txt");
                    tb1.Text = k.ToString();
                    break;
                case "Past Continuous Tense ":
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Past Continuous Tense.txt");
                    tb1.Text = k.ToString();
                    break;
                case "Past Perfect Tense":
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Past Perfect Tense.txt");
                    tb1.Text = k.ToString();
                    break;
                case "Past Perfect Continuous Tense":
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Past Perfect Continuous Tense..txt");
                    tb1.Text = k.ToString();
                    break;
                case "Future Simple Tense":
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Future Simple Tense.txt");
                    tb1.Text = k.ToString();
                    break;
                case "Future Continuous Tense":
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Future Continuous Tense.txt");
                    tb1.Text = k.ToString();
                    break;
                case "Future Perfect Tense":
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Future Perfect Tens.txt");
                    tb1.Text = k.ToString();
                    break;
                case "Future Perfect Continuous Tense":
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Future Perfect Continuous Tens .txt");
                    tb1.Text = k.ToString();
                    break;
                default: break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("Present Simple Tense");
            comboBox1.Items.Add("Present Continuous Tense ");
            comboBox1.Items.Add("Present Perfect Tense ");
            comboBox1.Items.Add("Present Perfect Continuous Tense");
            comboBox1.Items.Add("Past Simple Tense");
            comboBox1.Items.Add("Past Continuous Tense ");
            comboBox1.Items.Add("Past Perfect Tense");
            comboBox1.Items.Add("Past Perfect Continuous Tense");
            comboBox1.Items.Add("Future Simple Tense");
            comboBox1.Items.Add("Future Continuous Tense");
            comboBox1.Items.Add("Future Perfect Tense");
            comboBox1.Items.Add("Future Perfect Continuous Tense");
        }

        private void button3_Click(object sender, EventArgs e)
        {           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

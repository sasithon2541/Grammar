using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_603410156_1
{
    public partial class Form4 : Form
    {      
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            comboBox1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t;
            switch (comboBox1.Text)
            {
                case "Part Of Speech":
                    t = File.ReadAllText("Part of speech1.txt");
                    tb1.Text = t.ToString();
                    break;
                case "Nouns":
                    t = File.ReadAllText("Nouns.txt");
                    tb1.Text = t.ToString();
                    break;
                case "Pronoun":
                    t = File.ReadAllText("Pronoun.txt");
                    tb1.Text = t.ToString();
                    break;
                case "Adjective":
                    t = File.ReadAllText("Adjective.txt");
                    tb1.Text = t.ToString();
                    break;
                case "Verb":
                    t = File.ReadAllText("Verb.txt");
                    tb1.Text = t.ToString();
                    break;
                case "Preposition":
                    t = File.ReadAllText("Preposition.txt");
                    tb1.Text = t.ToString();
                    break;
                case "Adverb":
                    t = File.ReadAllText("Adverb.txt");
                    tb1.Text = t.ToString();
                    break;
                case "Conjunction":
                    t = File.ReadAllText("Conjunction.txt");
                    tb1.Text = t.ToString();
                    break;
                case "Active & Passive Voice":
                    t = File.ReadAllText("Active & Passive Voice.txt");
                    tb1.Text = t.ToString();
                    break;
                default: MessageBox.Show("กรุณาเลือกข้อมูล"); break;
            }
        }
        

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("Part Of Speech");
            comboBox1.Items.Add("Nouns");
            comboBox1.Items.Add("Pronoun");
            comboBox1.Items.Add("Adjective");
            comboBox1.Items.Add("Verb");
            comboBox1.Items.Add("Preposition");
            comboBox1.Items.Add("Adverb");
            comboBox1.Items.Add("Conjunction");
            comboBox1.Items.Add("Interjection");
            comboBox1.Items.Add("Active & Passive Voice");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

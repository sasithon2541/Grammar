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
            tb1.Text = ""; //เมื่อคลิ๊กปุ่ม Clear tb1 จะว่างเปล่า
            comboBox1.SelectedIndex = 0; //เมื่อคลิ๊กปุ่ม Clear comboBox1 จะว่างเปล่า
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close(); //คำสั่งออกจากโปรแกรมโดยใช้ Close(); เพราะจะออกทีละหน้า
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t; //กำหนด t ให้เป็นตัวหนังสือ  
            switch (comboBox1.Text)  //กำหนดเงื่อนไขใน comboBox1.Text
            {
                case "Part Of Speech": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Part Of Speech
                    t = File.ReadAllText("Part of speech1.txt");//กำหนดตัวแปร t เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = t.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Nouns": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Nouns
                    t = File.ReadAllText("Nouns.txt");//กำหนดตัวแปร t เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = t.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Pronoun": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Pronoun
                    t = File.ReadAllText("Pronoun.txt");//กำหนดตัวแปร t เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = t.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Adjective": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Adjective
                    t = File.ReadAllText("Adjective.txt");//กำหนดตัวแปร t เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = t.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Verb": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Verb
                    t = File.ReadAllText("Verb.txt");//กำหนดตัวแปร t เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = t.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Preposition": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Preposition
                    t = File.ReadAllText("Preposition.txt");//กำหนดตัวแปร t เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = t.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Adverb": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Adverb
                    t = File.ReadAllText("Adverb.txt");//กำหนดตัวแปร t เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = t.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Conjunction": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Conjunction
                    t = File.ReadAllText("Conjunction.txt");//กำหนดตัวแปร t เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = t.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Interjection": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Interjection
                    t = File.ReadAllText("Interjection.txt");//กำหนดตัวแปร t เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = t.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Active & Passive Voice": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Active & Passive Voice
                    t = File.ReadAllText("Active & Passive Voice.txt");//กำหนดตัวแปร t เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = t.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                default: MessageBox.Show("กรุณาเลือกข้อมูล"); break;//เมื่อไม่เข้าตามเงื่อนไขจะแสดง  MessageBox กรุณาเลือกข้อมูล
            }
        }
        

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; //ทำให้ comboBox1 พิมพ์ข้อความไม่ได้
            comboBox1.Items.Add(" "); //คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ " "
            comboBox1.Items.Add("Part Of Speech");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Part Of Speech
            comboBox1.Items.Add("Nouns");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Nouns
            comboBox1.Items.Add("Pronoun");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Pronoun
            comboBox1.Items.Add("Adjective");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Adjective
            comboBox1.Items.Add("Verb");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Verb
            comboBox1.Items.Add("Preposition");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Preposition
            comboBox1.Items.Add("Adverb");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Adverb
            comboBox1.Items.Add("Conjunction");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Conjunction
            comboBox1.Items.Add("Interjection");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Interjection
            comboBox1.Items.Add("Active & Passive Voice");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Active & Passive Voice
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

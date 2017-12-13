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
            string k; //กำหนด k ให้เป็นตัวหนังสือ   
            switch (comboBox1.Text) //กำหนดเงื่อนไขใน comboBox1.Text
            {
                case "Tense": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Tense
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Tense1.txt");//กำหนดตัวแปร k เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = k.ToString(); //แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Present Simple Tense": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Present Simple Tense
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Present Simple Tense.txt");//กำหนดตัวแปร k เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = k.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Present Continuous Tense ": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Present Continuous Tense 
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Present Continuous Tense.txt");//กำหนดตัวแปร k เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = k.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Present Perfect Tense ": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Present Perfect Tense 
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Present Perfect Tense .txt");//กำหนดตัวแปร k เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = k.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Present Perfect Continuous Tense": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Present Perfect Continuous Tense
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Present Perfect Continuous Tense.txt");//กำหนดตัวแปร k เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = k.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Past Simple Tense": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Past Simple Tense
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Past Simple Tense.txt");//กำหนดตัวแปร k เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = k.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Past Continuous Tense ": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Past Continuous Tense 
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Past Continuous Tense.txt");//กำหนดตัวแปร k เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = k.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Past Perfect Tense": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Past Perfect Tense
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Past Perfect Tense.txt");//กำหนดตัวแปร k เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = k.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Past Perfect Continuous Tense": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Past Perfect Continuous Tense
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Past Perfect Continuous Tense..txt"); //กำหนดตัวแปร k เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = k.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Future Simple Tense": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Future Simple Tense
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Future Simple Tense.txt");//กำหนดตัวแปร k เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = k.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Future Continuous Tense": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Future Continuous Tense
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Future Continuous Tense.txt"); //กำหนดตัวแปร k เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = k.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Future Perfect Tense": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Future Perfect Tense
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Future Perfect Tens.txt");//กำหนดตัวแปร k เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = k.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                case "Future Perfect Continuous Tense": //เมื่อเข้าเงื่อนไขที่กำหนด คือ Future Perfect Continuous Tense
                    k = System.IO.File.ReadAllText(Application.StartupPath + @"\Future Perfect Continuous Tens .txt");//กำหนดตัวแปร k เก็บชนิดข้อมูล string ที่อ่านข้อมูลได้จาก text file 
                    tb1.Text = k.ToString();//แสดงข้อความจากไฟล์ที่อ่านใน tb1 คือ textBox1
                    break;//หยุด
                default: MessageBox.Show("กรุณาเลือกข้อมูล"); break; //เมื่อไม่เข้าตามเงื่อนไขจะแสดง  MessageBox กรุณาเลือกข้อมูล
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb1.Text = "";  //เมื่อคลิ๊กปุ่ม Clear tb1 จะว่างเปล่า
            comboBox1.SelectedIndex = 0;  //เมื่อคลิ๊กปุ่ม Clear comboBox1 จะว่างเปล่า
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;//ทำให้ comboBox1 พิมพ์ข้อความไม่ได้
            comboBox1.Items.Add(" ");  //คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ " "
            comboBox1.Items.Add("Tense");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Tense
            comboBox1.Items.Add("Present Simple Tense");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Present Simple Tense
            comboBox1.Items.Add("Present Continuous Tense "); //คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Present Continuous Tense
            comboBox1.Items.Add("Present Perfect Tense ");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Present Perfect Tense
            comboBox1.Items.Add("Present Perfect Continuous Tense");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Present Perfect Continuous Tense
            comboBox1.Items.Add("Past Simple Tense");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Past Simple Tense
            comboBox1.Items.Add("Past Continuous Tense "); //คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Past Continuous Tense
            comboBox1.Items.Add("Past Perfect Tense");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Past Perfect Tense
            comboBox1.Items.Add("Past Perfect Continuous Tense");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Past Perfect Continuous Tense
            comboBox1.Items.Add("Future Simple Tense");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Future Simple Tense
            comboBox1.Items.Add("Future Continuous Tense");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Future Continuous Tense
            comboBox1.Items.Add("Future Perfect Tense");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Future Perfect Tense
            comboBox1.Items.Add("Future Perfect Continuous Tense");//คลิ๊กปุ่ม comboBox1 จะพบว่ารายการไอเท็มใหม่ที่เรากำหนด จะเข้าไปอยู่ใน comboBox1 คือ Future Perfect Continuous Tense
        }

        private void button3_Click(object sender, EventArgs e)
        {           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close(); //คำสั่งออกจากโปรแกรมโดยใช้ Close(); เพราะจะออกทีละหน้า
        }
    }
}

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
        IStemmer stemmer = new EnglishStemmer(); //เรียกใช้ EnglishStemmer จาก Iveonik.Stemmers เก็บบไว้ใน stemmer
        public Form2()
        {
            InitializeComponent();
        }

        private void find_data(string y) //สร้าง Method ที่ชื่อ find_data แทนข้อมูลที่รับมา คือ string y เรียกง่ายว่า พารามิเตอร์
        {
            string[] k = System.IO.File.ReadAllLines(Application.StartupPath + @"\Ir.txt"); //กำหนด k ในชนิด Array ที่อ่านข้อมูลได้จาก text file 
            string kk = String.Empty; //กำหนด kk ในชนิด string เท่ากับ ว่างเปล่า  
            int i = 0; //ให้ i = 0
            while (i < k.Length) //ใช้ loop while คือ i น้อยกว่า k ตามลำดับ
            {
                string[] AA = k[i].Split('|'); //กำหนด AA ในชนิด Array จาก k[0]คือ ข้อมูลจากไฟล์ txt ที่มี | ขั้นอยู่ ของแต่ละช่อง
                if (y == AA[0]) //ถ้า y เท่ากับ AA[0] 
                {
                    kk = "Present (V1) =   " + AA[0] + "\r\n" + "Past Simple (V2) =   " + AA[1] + "\r\n" + "Past Participle (V3) =   " + AA[2] + "\r\n" + "Meaning =   " + AA[3];
                    //kk เท่ากับ Present (V1) + กริยาช่องที่ 1 เว้นบรรทัด + Past Simple (V2) + กริยาช่องที่ 2 เว้นบรรทัด + Past Participle (V3) + กริยาช่องที่ 3 เว้นบรรทัด + Meaning คำแปล
                    break; //หยุด
                }
                i++; //เพิ่มค่าทีละ 1
            }
            textBox2.Text += "\r\n" + kk.ToLower(); //แสดงที่ textBox2 เพิ่มทีละ 1 แล้วเว้นบรรทัด + เปลี่ยน kk ให้เป็นพิมพ์ตัวพิมพ์เล็กทั้งหมด
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close(); //คำสั่งออกจากโปรแกรมโดยใช้ Close(); เพราะจะออกทีละหน้า
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; //เมื่อคลิ๊กปุ่ม Clear textBox1 จะว่างเปล่า
            textBox2.Text = ""; //เมื่อคลิ๊กปุ่ม Clear textBox2 จะว่างเปล่า
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text; // ตัดพวกคำลงท้ายให้เหลือแต่คำแม่ เมื่อเราเติม กริยา 3 ช่อง ที่เติม -ing -es อื่น ใน textBox1 เก็บไว่ใน Word
            textBox2.Text = stemmer.Stem(word); // stemmer คือ เติม -ing -es อื่น จะแสดงกริยา 3 ช่อง แสดงที่ textBox2 


            String AllowedChars = @"^[a-zA-Z]+"; ///เมื่อเราพิมพ์ตัวเลขหรือตัวอักษรที่ไม่ใช่ภาษาอังกฤษ
            if (Regex.IsMatch(textBox1.Text,AllowedChars)) //ถ้าตรวจสอบว่าตัวเลขหรือตัวอักษรที่ไม่ใช่ภาษาอังกฤษ
            {

                find_data(stemmer.Stem(word)); //stemmer คำที่พิมพ์ แล้วไปค้นหาที่ find_data
            }
            else //หรือ
            {                               
                MessageBox.Show("กรุณาใส่ตัวอักษรภาษาอังกฤษ"); //เมื่อเราพิมพ์ตัวเลขหรือตัวอักษรจะแสดง MessageBox.Show ว่า กรุณาใส่ตัวอักษรภาษาอังกฤษ
            }
        }
    }
}

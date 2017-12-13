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

        private void bt1_Click(object sender, EventArgs e)//เมื่อคลิ๊ก bt1 ที่ชื่อ Irregular Verbs
        {
            Form2 f2 = new Form2(); //คำสั่งเปิดฟรอมที่ 2 เพื่อไปยังโปรแกรมหาจำนวนพลังงาน โดย Form2 f2 = new Form2();
            f2.ShowDialog(); //แสดงฟรอมที่ 2 และล็อกฟรอมที่เหลือ
        }

        private void bt2_Click(object sender, EventArgs e)//เมื่อคลิ๊ก bt1 ที่ชื่อ Tense
        {
            Form3 f2 = new Form3(); //คำสั่งเปิดฟรอมที่ 3 เพื่อไปยังโปรแกรมหาจำนวนพลังงาน โดย Form3 f2 = new Form3();
            f2.ShowDialog(); //แสดงฟรอมที่ 3 และล็อกฟรอมที่เหลือ
        }

        private void bt3_Click(object sender, EventArgs e)//เมื่อคลิ๊ก bt1 ที่ชื่อ Part Of Speech
        {
            Form4 f2 = new Form4(); //คำสั่งเปิดฟรอมที่ 4 เพื่อไปยังโปรแกรมหาจำนวนพลังงาน โดย Form4 f2 = new Form4();
            f2.ShowDialog(); //แสดงฟรอมที่ 4 และล็อกฟรอมที่เหลือ
        }

        private void button1_Click(object sender, EventArgs e)//เมื่อคลิ๊ก bt1 ที่ชื่อ Exercise
        {
            Form5 f2 = new Form5(); //คำสั่งเปิดฟรอมที่ 5 เพื่อไปยังโปรแกรมหาจำนวนพลังงาน โดย Form4 f2 = new Form4();
            f2.ShowDialog(); //แสดงฟรอมที่ 5 และล็อกฟรอมที่เหลือ
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)//label3 ชื่อ GitHub
        {
            Process.Start("https://github.com/sasithon2541/Grammar"); //เมื่อเราคลิ๊กที่ About จะเห็นที่มา GitHub:https://github.com/sasithon2541/Grammar เมื่อคลิ๊กจะขึ้นที่ Bowser 
        }

        private void label1_Click(object sender, EventArgs e)//label1 ชื่อ Picture
        {
            Process.Start("https://www.google.co.th/search?q=grammar&client=firefox-b-ab&dcr=0&source=lnms&tbm=isch&sa=X&ved=0ahUKEwi58p-GsPfXAhXBQ48KHaO5AD8Q_AUICigB&biw=1366&bih=656#imgrc=TjU_o7Mpdl214M:");
            //เมื่อเราคลิ๊กที่ About จะเห็นที่มา Picture : https://www.google.co.th/search?q=grammar&client=firefox-b-ab&dcr=0&source=lnms&tbm=isch&sa=X&ved=0ahUKEwi58p-GsPfXAhXBQ48KHaO5AD8Q_AUICigB&biw=1366&bih=656#imgrc=TjU_o7Mpdl214M: เมื่อคลิ๊กจะขึ้นที่ Bowser 
        }

        private void label4_Click(object sender, EventArgs e)//label4 ชื่อ Verbs 
        {
            Process.Start("http://www.กริยา3ช่อง.com/"); //เมื่อเราคลิ๊กที่ About จะเห็นที่มา Verbs : http://www.กริยา3ช่อง.com เมื่อคลิ๊กจะขึ้นที่ Bowser 
        }
    

        private void label5_Click(object sender, EventArgs e)//label5 ชื่อ Content 
        {
            Process.Start("http://www.tonamorn.com/grammar/"); ////เมื่อเราคลิ๊กที่ About จะเห็นที่มา Content : http://www.tonamorn.com/grammar/  เมื่อคลิ๊กจะขึ้นที่ Bowser 
        }

        private void label6_Click(object sender, EventArgs e)//label6 ชื่อ Exercise
        {
            Process.Start("https://srikranuan610.wordpress.com/%E0%B8%82%E0%B9%89%E0%B8%AD%E0%B8%AA%E0%B8%AD%E0%B8%9A%E0%B9%80%E0%B8%A3%E0%B8%B7%E0%B9%88%E0%B8%AD%E0%B8%87-tense/");
            //เมื่อเราคลิ๊กที่ About จะเห็นที่มา Exercise : https://srikranuan610.wordpress.com/%e0%b8%82%e0%b9%89%e0%b8%ad%e0%b8%aa%e0%b8%ad%e0%b8%9a%e0%b9%80%e0%b8%a3%e0%b8%b7%e0%b9%88%e0%b8%ad%e0%b8%87-tense/ เมื่อคลิ๊กจะขึ้นที่ Bowser 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

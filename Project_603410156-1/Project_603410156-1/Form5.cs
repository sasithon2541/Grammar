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
            //เมื่อคลิ๊ก Restart
            Form5 f5 = new Form5(); //คำสั่งเปิดฟรอมที่ 5 เพื่อไปยังโปรแกรมหาจำนวนพลังงาน โดย Form5 f2 = new Form5();
            f5.Show(); //แสดงฟรอมที่ 5
            this.Close(); //คำสั่งออกจากโปรแกรมโดยใช้ Close(); เพราะจะออกทีละหน้า
        }

        bool ok = false; //กำหนดค่า bool ok = 0
        private void button4_Click(object sender, EventArgs e)
        {           
            if (ok == false) //เปรียบเทียบว่า ok มันเท่ากันหรือไม่กับ false
            {
                tabControl1.TabPages.Insert(1,tabPage2); //เพิ่มไปแทบที่ 2
                tabControl1.SelectedIndex = 1; //ให้แสดงแถบ 2 ใน Index ที่ 1
                ok = true; // ถ้า ok ถูกต้อง
                tabControl1.SelectedTab = tabPage2; // จะโชว์ tabPage2 ใน tabControl1
            }
            else tabControl1.SelectedTab = tabPage2;  //ในกรณีที่ ok ยังไม่เป็น false จะโชว์ tabPage2 ใน tabControl1       
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           tabControl1.TabPages.Remove(tabPage5); //ลบแถบที่ยังไม่ได้ใช้งานออกก่อน(tabPage5)
           tabControl1.TabPages.Remove(tabPage4); //ลบแถบที่ยังไม่ได้ใช้งานออกก่อน(tabPage4)
           tabControl1.TabPages.Remove(tabPage3); //ลบแถบที่ยังไม่ได้ใช้งานออกก่อน(tabPage3)
           tabControl1.TabPages.Remove(tabPage2); //ลบแถบที่ยังไม่ได้ใช้งานออกก่อน(tabPage2)
        }

        bool g = false; //กำหนดค่า bool g = 0
        private void button1_Click(object sender, EventArgs e)
        {
            if (g == false)//เปรียบเทียบว่า g มันเท่ากันหรือไม่กับ false
            {
                tabControl1.TabPages.Insert(2, tabPage3); //เพิ่มไปแทบที่ 3
                tabControl1.SelectedIndex = 2;//ให้แสดงแถบ 3 ใน Index ที่ 1
                g = true;  // ถ้า g ถูกต้อง
                tabControl1.SelectedTab = tabPage3;// จะโชว์ tabPage3 ใน tabControl1
            }
            else tabControl1.SelectedTab = tabPage3;//ในกรณีที่ ok ยังไม่เป็น false  จะโชว์ tabPage2 ใน tabControl1 
        }


        bool y = false; //กำหนดค่า bool y = 0
        private void button2_Click(object sender, EventArgs e)
        {
            if (y == false)//เปรียบเทียบว่า y มันเท่ากันหรือไม่กับ false
            {
                tabControl1.TabPages.Insert(3, tabPage4); //เพิ่มไปแทบที่ 4
                tabControl1.SelectedIndex = 3;//ให้แสดงแถบ 4 ใน Index ที่ 1
                y = true;  // ถ้า y ถูกต้อง
                tabControl1.SelectedTab = tabPage4;// จะโชว์ tabPage4 ใน tabControl1
            }
            else tabControl1.SelectedTab = tabPage4;//ในกรณีที่ ok ยังไม่เป็น false จะโชว์ tabPage2 ใน tabControl1  
        }


        bool t = false; //กำหนดค่า bool t = 0
        private void button3_Click(object sender, EventArgs e)
        {
            if (t == false)//เปรียบเทียบว่า y มันเท่ากันหรือไม่กับ false
            {
                tabControl1.TabPages.Insert(4, tabPage5); //เพิ่มไปแทบที่ 5
                tabControl1.SelectedIndex = 4;//ให้แสดงแถบ 5 ใน Index ที่ 1
                t = true;  // ถ้า t ถูกต้อง
                tabControl1.SelectedTab = tabPage5;// จะโชว์ tabPage5 ใน tabControl1
            }
            else tabControl1.SelectedTab = tabPage5;//ในกรณีที่ ok ยังไม่เป็น false จะโชว์ tabPage2 ใน tabControl1  
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //เมื่อคลิ๊กปุ่ม Check
            int a =0; //กำหนด a ชนิดตัวเลขเท่ากับ 0
            if (radioButton3.Checked == true) //ถ้าคลิ๊กที่ radioButton3 จะถูกต้อง คำตอบ คือ c
            {
                a += 1; //a เพิ่มค่าทีละ 1
            }
            if (radioButton5.Checked == true) //ถ้าคลิ๊กที่ radioButton5 จะถูกต้อง คำตอบ คือ a
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton10.Checked == true) //ถ้าคลิ๊กที่ radioButton10 จะถูกต้อง คำตอบ คือ b
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton16.Checked == true) //ถ้าคลิ๊กที่ radioButton16 จะถูกต้อง คำตอบ คือ d
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton18.Checked == true) //ถ้าคลิ๊กที่ radioButton18 จะถูกต้อง คำตอบ คือ b
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton40.Checked == true) //ถ้าคลิ๊กที่ radioButton40 จะถูกต้อง คำตอบ คือ a
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton36.Checked == true) //ถ้าคลิ๊กที่ radioButton36 จะถูกต้อง คำตอบ คือ a
            {
                a += 1;//a เพิ่มค่าที่ละ 1
            }
            if (radioButton32.Checked == true) //ถ้าคลิ๊กที่ radioButton32 จะถูกต้อง คำตอบ คือ a
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton28.Checked == true) //ถ้าคลิ๊กที่ radioButton28 จะถูกต้อง คำตอบ คือ a
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton24.Checked == true) //ถ้าคลิ๊กที่ radioButton24 จะถูกต้อง คำตอบ คือ a
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton122.Checked == true) //ถ้าคลิ๊กที่ radioButton122 จะถูกต้อง คำตอบ คือ b
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton56.Checked == true) //ถ้าคลิ๊กที่ radioButton56 จะถูกต้อง คำตอบ คือ a
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton46.Checked == true) //ถ้าคลิ๊กที่ radioButton46 จะถูกต้อง คำตอบ คือ c
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton42.Checked == true) //ถ้าคลิ๊กที่ radioButton42 จะถูกต้อง คำตอบ คือ c
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton84.Checked == true) //ถ้าคลิ๊กที่ radioButton84 จะถูกต้อง คำตอบ คือ a
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton90.Checked == true) //ถ้าคลิ๊กที่ radioButton90 จะถูกต้อง คำตอบ คือ b
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton86.Checked == true) //ถ้าคลิ๊กที่ radioButton86 จะถูกต้อง คำตอบ คือ c
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton94.Checked == true) //ถ้าคลิ๊กที่ radioButton94 จะถูกต้อง คำตอบ คือ c
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton58.Checked == true) //ถ้าคลิ๊กที่ radioButton58 จะถูกต้อง คำตอบ คือ c
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton106.Checked == true) //ถ้าคลิ๊กที่ radioButton106 จะถูกต้อง คำตอบ คือ c
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton103.Checked == true) //ถ้าคลิ๊กที่ radioButton103 จะถูกต้อง คำตอบ คือ b
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton99.Checked == true) //ถ้าคลิ๊กที่ radioButton99 จะถูกต้อง คำตอบ คือ b
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton75.Checked == true) //ถ้าคลิ๊กที่ radioButton75 จะถูกต้อง คำตอบ คือ b
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton72.Checked == true) //ถ้าคลิ๊กที่ radioButton72 จะถูกต้อง คำตอบ คือ b
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton67.Checked == true) //ถ้าคลิ๊กที่ radioButton67 จะถูกต้อง คำตอบ คือ a
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton61.Checked == true) //ถ้าคลิ๊กที่ radioButton61 จะถูกต้อง คำตอบ คือ b
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton10.Checked == true) //ถ้าคลิ๊กที่ radioButton10จะถูกต้อง คำตอบ คือ d
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton115.Checked == true) //ถ้าคลิ๊กที่ radioButton115 จะถูกต้อง คำตอบ คือ b
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton77.Checked == true) //ถ้าคลิ๊กที่ radioButton77 จะถูกต้อง คำตอบ คือ a
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }
            if (radioButton111.Checked == true) //ถ้าคลิ๊กที่ radioButton111 จะถูกต้อง คำตอบ คือ b
            {
                a += 1;//a เพิ่มค่าทีละ 1
            }           
            label34.Text = a.ToString(); //เมื่อคลิ๊ก Check จะแสดงจำนวนข้อที่ถูกใน label34

            label36.Text = ((double.Parse(a.ToString()) / 30) * 100 + " %").ToString(); //คิดเป็นเปอร์เซนต์โดยนำข้อที่ถูกมาหาร 30 x 100
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form13 : Form
    {
        private Timer timer;//คำสั่งเปิดใช้งาน timer
        private Random random;//คำสั่งเปิดใช้งาน random

        private int countdown = 15;//คำสั่งการ ใช้ int ให้ตัว countdown ทำงานให้แค่ 15 วิ
        private bool a = false;// การกำหนดค่า ให้ปิดใช้งาน

        public Form13()
        {
            InitializeComponent();
            random = new Random();//คำสั่ง random ให้ทำงานการใช้งานให้โปรแกรมที่เรากำหนด
            timer = new Timer();//คำสั่ง timer ให้ทำงานการใช้งานให้โปรแกรมที่เรากำหนด
            timer.Interval = 1000;//กำหนดค่าให้นับวิ ละ 1 วิ
            timer.Tick += OnTick;//การใช้ timer ให้ บวกหรือเท่ากับ OnTick
        }
        private void OnTick(object sender, EventArgs e)
        {
            if (countdown == 0)// คำสั่งตัว coundown เท่ากับ 0
            {
                label2.Text = "0";//การกำหนดค่า label ให้ ทำงานด้วยเลข 0
                timer.Enabled = false;//การหยุดใช้คำสั่งของ timer
                MessageBox.Show("wrong!");//เมื่อ MessagBox ขึ้น คำสั่งด้านบนจะหยุดทำงาน

                Form2 f2 = new Form2();//กำหนด form1 ตัวแปรเป็น f1
                f2.Show();// นำตัวแปร ที่กำหนดมาโชว์
                timer.Dispose();//กำหนด ใช้คำสั่งให้ กำจัดตัวของ timer
                this.Hide();//คำสั่งลบ form


            }
            else
            {
                label2.Text = countdown.ToString();//การกำหนดให้ label2 นับถอยหลัง โดยคำสั่งตัว coundown
                countdown--;//ให้ countdown นับถอยหลังไปเลยๆ


            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            this.Text += " : " + setting.title;//การใช้คำสั่ง method ให้ทำงานในหน้านี้
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;//คำสั่งการกำหนดรูปให้ทำงานในคำสั่งค่าที่เรากำหนด ให้รูปมันเท่าๆกัน
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;//คำสั่งการกำหนดรูปให้ทำงานในคำสั่งค่าที่เรากำหนด ให้รูปมันเท่าๆกัน
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;//คำสั่งการกำหนดรูปให้ทำงานในคำสั่งค่าที่เรากำหนด ให้รูปมันเท่าๆกัน
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;//คำสั่งการกำหนดรูปให้ทำงานในคำสั่งค่าที่เรากำหนด ให้รูปมันเท่าๆกัน
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;//คำสั่งการกำหนดรูปให้ทำงานในคำสั่งค่าที่เรากำหนด ให้รูปมันเท่าๆกัน

            button1.Enabled = false;//การปิดใช้งาน button
            button2.Enabled = false;//การปิดใช้งาน button
            button3.Enabled = false;//การปิดใช้งาน button
            button4.Enabled = false;//การปิดใช้งาน button
            button5.Enabled = false;//การปิดใช้งาน button
            button6.Enabled = false;//การปิดใช้งาน button
            button7.Enabled = false;//การปิดใช้งาน button
            button8.Enabled = false;//การปิดใช้งาน button
            button9.Enabled = false;//การปิดใช้งาน button
            button10.Enabled = false;//การปิดใช้งาน button

            pictureBox1.Visible = false;//การปิดใช้งาน pictureBox
            pictureBox2.Visible = false;//การปิดใช้งาน pictureBox
            pictureBox3.Visible = false;//การปิดใช้งาน pictureBox
            pictureBox4.Visible = false;//การปิดใช้งาน pictureBox
            pictureBox5.Visible = false;//การปิดใช้งาน pictureBox

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string p = textBox1.Text.ToString();//การกำหนดตัว string ให้เป็นตัวแปร p เท่ากับ textBox ใช้งานในค่าที่เรากำหนด
            if (p == "5")//ตัวแปรที่เรากำหนดเท่ากับ คำที่เราต้องการจะให้ใช้งานตามที่เรากำหนด
            {
                timer.Enabled = false;//ปิดการใช้งาน timer
                MessageBox.Show("การบวก (มักแทนด้วยเครื่องหมายบวก " + ") คือหนึ่งในการดำเนินการทางคณิตศาสตร์ของเลขคณิตมูลฐาน นอกจากการบวกยังมีการลบ การคูณ และการหาร การบวกจำนวนสองจำนวนคือผลรวมของปริมาณสองปริมาณรวมกัน ตัวอย่างเช่น ในภาพด้านขวาเป็นการรวมแอปเปิล 1 ผลกับแอปเปิล 1 ผลเข้าด้วยกัน หลายเป็นแอปเปิล 2 ผล ดังนั้นจึงเหมือนกับว่ามีแอปเปิล 2 ผล การกระทำเช่นนี้เทียบเท่ากับนิพจน์ทางคณิตศาสตร์ว่า '1 + 1 = 2' หมายความว่า '1 บวก 1 เท่ากับ 2");// การใช้ MessageBox โชว์ข้อความที่เรากำหนด
                Form14 f14 = new Form14();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
                f14.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
                this.Hide();//คำสั่งลบ form
            }
            else if (textBox1.Text != "")//การกำหนดค่า textBox ไม่เท่ากับ ค่าในช่องว่าง
            {
                timer.Enabled = false;//ปิดการใช้งาน timer
                MessageBox.Show("wrong!");// การใช้ MessageBox โชว์ข้อความที่เรากำหนด
                Form2 f2 = new Form2();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
                f2.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
                this.Hide();//คำสั่งลบ form
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;//ปิดการใช้งาน timer
            Form1 f1 = new Form1();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
            f1.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
            this.Hide();//คำสั่งลบ form
        }

        private void OnbuttonClick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;//การเปิดใช้งาน pictureBox
            pictureBox2.Visible = true;//การเปิดใช้งาน pictureBox
            pictureBox3.Visible = true;//การเปิดใช้งาน pictureBox
            pictureBox4.Visible = true;//การเปิดใช้งาน pictureBox
            pictureBox5.Visible = true;//การเปิดใช้งาน pictureBox


            button1.Enabled = true;//การเปิดใช้งาน button
            button2.Enabled = true;//การเปิดใช้งาน button
            button3.Enabled = true;//การเปิดใช้งาน button
            button4.Enabled = true;//การเปิดใช้งาน button
            button5.Enabled = true;//การเปิดใช้งาน button
            button6.Enabled = true;//การเปิดใช้งาน button
            button7.Enabled = true;//การเปิดใช้งาน button
            button8.Enabled = true;//การเปิดใช้งาน button
            button9.Enabled = true;//การเปิดใช้งาน button
            button10.Enabled = true;//การเปิดใช้งาน button

            timer.Start();//การกำหนดค่า timer ให้เป็นค่าเริ่มต้น
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)//คำสั่งการใช้งานของ ClosReason เท่ากับ CloseReason ให้ทำงานโดย .UserClosing
                Environment.Exit(0);//การออกจากโปรแกรม
            if (e.CloseReason == CloseReason.WindowsShutDown)//คำสั่งการใช้งานของ ClosReason เท่ากับ CloseReason ให้ทำงานโดย .WindowsShutDown
            {
                Environment.Exit(0);//การออกจากโปรแกรม
            }
        }
    }
}

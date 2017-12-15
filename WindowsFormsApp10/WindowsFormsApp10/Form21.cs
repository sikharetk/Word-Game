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
    public partial class Form21 : Form
    {
        private Timer timer;//คำสั่งเปิดใช้งาน timer
        private Random random;//คำสั่งเปิดใช้งาน random

        private int countdown = 15;//คำสั่งการ ใช้ int ให้ตัว countdown ทำงานให้แค่ 15 วิ
        private bool a = false;// การกำหนดค่า ให้ปิดใช้งาน
        public Form21()
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
                label3.Text = "0";//การกำหนดค่า label ให้ ทำงานด้วยเลข 0
                timer.Enabled = false;//การหยุดใช้คำสั่งของ timer
                MessageBox.Show("wrong!");//เมื่อ MessagBox ขึ้น คำสั่งด้านบนจะหยุดทำงาน

                Form2 f2 = new Form2();//กำหนด form1 ตัวแปรเป็น f1
                f2.Show();// นำตัวแปร ที่กำหนดมาโชว์
                timer.Dispose();//กำหนด ใช้คำสั่งให้ กำจัดตัวของ timer
                this.Hide();//คำสั่งลบ form


            }
            else
            {
                label3.Text = countdown.ToString();//การกำหนดให้ label2 นับถอยหลัง โดยคำสั่งตัว coundown
                countdown--;//ให้ countdown นับถอยหลังไปเลยๆ


            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            string p = checkBox3.Text.ToString();//การกำหนดตัว string ให้เป็นตัวแปร p เท่ากับ  checkBox ใช้งานในค่าที่เรากำหนด
            {
                timer.Enabled = false;//ปิดการใช้งาน timer
                MessageBox.Show("คือ ด่านความจำที่เล่นมา เพื่อให้น้องๆ ได้ความตื่นเต้นและสนุกมากขึ้น เพิ่มทัศษะในการจดจำและเพิ่มความยากในหน้าลุ้นมากขึ้น");// การใช้ MessageBox โชว์ข้อความที่เรากำหนด
                Form22 f22 = new Form22();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
                f22.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
                this.Hide();//คำสั่งลบ form
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Text != "")//การกำหนดค่า checkBox ไม่เท่ากับ ค่าในช่องว่าง
            {
                timer.Enabled = false;// ปิดการใช้งาน timer
                MessageBox.Show("wrong!");// การใช้ MessageBox โชว์ข้อความที่เรากำหนด
                Form2 f2 = new Form2();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
                f2.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
                this.Hide();//คำสั่งลบ form
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Text != "")//การกำหนดค่า checkBox ไม่เท่ากับ ค่าในช่องว่าง
            {
                timer.Enabled = false;// ปิดการใช้งาน timer
                MessageBox.Show("wrong!");// การใช้ MessageBox โชว์ข้อความที่เรากำหนด
                Form2 f2 = new Form2();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
                f2.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
                this.Hide();//คำสั่งลบ form
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Text != "")//การกำหนดค่า checkBox ไม่เท่ากับ ค่าในช่องว่าง
            {
                timer.Enabled = false;// ปิดการใช้งาน timer
                MessageBox.Show("wrong!");// การใช้ MessageBox โชว์ข้อความที่เรากำหนด
                Form2 f2 = new Form2();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
                f2.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
                this.Hide();//คำสั่งลบ form
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Text != "")//การกำหนดค่า checkBox ไม่เท่ากับ ค่าในช่องว่าง
            {
                timer.Enabled = false;// ปิดการใช้งาน timer
                MessageBox.Show("wrong!");// การใช้ MessageBox โชว์ข้อความที่เรากำหนด
                Form2 f2 = new Form2();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
                f2.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
                this.Hide();//คำสั่งลบ form
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Text != "")//การกำหนดค่า checkBox ไม่เท่ากับ ค่าในช่องว่าง
            {
                timer.Enabled = false;// ปิดการใช้งาน timer
                MessageBox.Show("wrong!");// การใช้ MessageBox โชว์ข้อความที่เรากำหนด
                Form2 f2 = new Form2();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
                f2.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
                this.Hide();//คำสั่งลบ form
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Text != "")//การกำหนดค่า checkBox ไม่เท่ากับ ค่าในช่องว่าง
            {
                timer.Enabled = false;// ปิดการใช้งาน timer
                MessageBox.Show("wrong!");// การใช้ MessageBox โชว์ข้อความที่เรากำหนด
                Form2 f2 = new Form2();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
                f2.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
                this.Hide();//คำสั่งลบ form
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Text != "")//การกำหนดค่า checkBox ไม่เท่ากับ ค่าในช่องว่าง
            {
                timer.Enabled = false;// ปิดการใช้งาน timer
                MessageBox.Show("wrong!");// การใช้ MessageBox โชว์ข้อความที่เรากำหนด
                Form2 f2 = new Form2();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
                f2.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
                this.Hide();//คำสั่งลบ form
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Text != "")//การกำหนดค่า checkBox ไม่เท่ากับ ค่าในช่องว่าง
            {
                timer.Enabled = false;// ปิดการใช้งาน timer
                MessageBox.Show("wrong!");// การใช้ MessageBox โชว์ข้อความที่เรากำหนด
                Form2 f2 = new Form2();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
                f2.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
                this.Hide();//คำสั่งลบ form
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;//ปิดการใช้งาน timer
            Form1 f1 = new Form1();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
            f1.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
            this.Hide();//คำสั่งลบ form
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            this.Text += " : " + setting.title;//การใช้คำสั่ง method ให้ทำงานในหน้านี้

            checkBox1.Visible = false;//การปิดใช้งาน checkBox
            checkBox2.Visible = false;//การปิดใช้งาน checkBox
            checkBox3.Visible = false;//การปิดใช้งาน checkBox
            checkBox4.Visible = false;//การปิดใช้งาน checkBox
            checkBox5.Visible = false;//การปิดใช้งาน checkBox
            checkBox6.Visible = false;//การปิดใช้งาน checkBox
            checkBox7.Visible = false;//การปิดใช้งาน checkBox
            checkBox8.Visible = false;//การปิดใช้งาน checkBox
            checkBox9.Visible = false;//การปิดใช้งาน checkBox

            label2.Visible = false;//การใช้คำสั่งซ่อนรูปภาพที่เรากำหนด
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
            f8.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
            this.Hide();//คำสั่งลบ form
        }

        private void OnbuttonClick(object sender, EventArgs e)
        {
            label2.Visible = true;//คำสั่งเปิดรูปที่ซ่อนไว้

            checkBox1.Visible = true;//การเปิดใช้งาน checkBox
            checkBox2.Visible = true;//การเปิดใช้งาน checkBox
            checkBox3.Visible = true;//การเปิดใช้งาน checkBox
            checkBox4.Visible = true;//การเปิดใช้งาน checkBox
            checkBox5.Visible = true;//การเปิดใช้งาน checkBox
            checkBox6.Visible = true;//การเปิดใช้งาน checkBox
            checkBox7.Visible = true;//การเปิดใช้งาน checkBox
            checkBox8.Visible = true;//การเปิดใช้งาน checkBox
            checkBox9.Visible = true;//การเปิดใช้งาน checkBox



            timer.Start();//การกำหนดค่า timer ให้เป็นค่าเริ่มต้น
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)//คำสั่งการใช้งานของ ClosReason เท่ากับ CloseReason ให้ทำงานโดย .UserClosing
                Environment.Exit(0);// การออกจากโปรแกรม
            if (e.CloseReason == CloseReason.WindowsShutDown)//คำสั่งการใช้งานของ ClosReason เท่ากับ CloseReason ให้ทำงานโดย .WindowsShutDown
            {
                Environment.Exit(0);// การออกจากโปรแกรม
            }
        }
    }
}

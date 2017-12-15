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
    public partial class Form15 : Form
    {
        private Timer timer;//คำสั่งเปิดใช้งาน timer
        private Random random;//คำสั่งเปิดใช้งาน random

        private int countdown = 15;//คำสั่งการ ใช้ int ให้ตัว countdown ทำงานให้แค่ 15 วิ
        private bool a = false;// การกำหนดค่า ให้ปิดใช้งาน

        public Form15()
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string p = checkBox1.Text.ToString();//การกำหนดตัว string ให้เป็นตัวแปร p เท่ากับ  checkBox ใช้งานในค่าที่เรากำหนด
            {
                timer.Enabled = false;//ปิดการใช้งาน timer
                MessageBox.Show("หมายเลข 50 ความกระตือรือร้นจะทำให้ชีวิตประสพผลสำเร็จอย่างมั่นคง สติปัญญาดี ความจำแม่นยำ จะนำพาไปสู่ความสำเร็จที่ยิ่งใหญ่ มีความสุขุมล้ำลึก ชอบไขว่คว้าค้นหาความก้าวหน้าให้กับชีวิต และยังมีสิ่งศักดิ์สิทธิ์ให้ความคุ้มครอง มีโอกาสไปเกี่ยวข้องกับต่างประเทศทุกรูปแบบเช่น ศึกษาต่างประเทศ เที่ยวต่างประเทศ อยู่ต่างประเทศ คบหากับคนต่างประเทศ สนใจธรรมมะ รักความยุติธรรม อาชีพที่เหมาะคือประชาสัมพันธ์ พบกับคนแปลกหน้าถึงจะดี ถ้าผลรวมเบอร์โทรศัพท์ออกมาได้หมายเลข 50 ไม่ต้องเปลี่ยนดีอยู่แล้ว ถือว่าดีมาก แต่ถ้ามีหมายเลข 55 อยู่ในเบอร์ด้วย จะได้ผลกับชีวิต 100 % ถ้ามีหมายเลขคู่ 64, 65 ให้คุณกับชีวิต 100 % ");// การใช้ MessageBox โชว์ข้อความที่เรากำหนด
                Form16 f16 = new Form16();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
                f16.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
                this.Hide();//คำสั่งลบ form
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
             if (checkBox2.Text != "")//การกำหนดค่า checkBox ไม่เท่ากับ ค่าในช่องว่าง
            {
                timer.Enabled = false;//ปิดการใช้งาน timer
                MessageBox.Show("wrong!");// การใช้ MessageBox โชว์ข้อความที่เรากำหนด
                Form2 f2 = new Form2();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
                f2.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
                this.Hide();//คำสั่งลบ form
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Text != "")//การกำหนดค่า checkBox ไม่เท่ากับ ค่าในช่องว่าง
            {
                timer.Enabled = false;//ปิดการใช้งาน timer
                MessageBox.Show("wrong!");// การใช้ MessageBox โชว์ข้อความที่เรากำหนด
                Form2 f2 = new Form2();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
                f2.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
                this.Hide();//คำสั่งลบ form
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Text != "")//การกำหนดค่า checkBox ไม่เท่ากับ ค่าในช่องว่าง
            {
                timer.Enabled = false;//ปิดการใช้งาน timer
                MessageBox.Show("wrong!");// การใช้ MessageBox โชว์ข้อความที่เรากำหนด
                Form2 f2 = new Form2();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
                f2.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
                this.Hide();//คำสั่งลบ form
            }
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            this.Text += " : " + setting.title;//การใช้คำสั่ง method ให้ทำงานในหน้านี้
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;//คำสั่งการกำหนดรูปให้ทำงานในคำสั่งค่าที่เรากำหนด ให้รูปมันเท่าๆกัน

            checkBox1.Visible = false;//การปิดใช้งาน checkBox
            checkBox2.Visible = false;//การปิดใช้งาน checkBox
            checkBox3.Visible = false;//การปิดใช้งาน checkBox
            checkBox4.Visible = false;//การปิดใช้งาน checkBox

            pictureBox1.Visible = false;//การใช้คำสั่งซ่อนรูปภาพที่เรากำหนด
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;//ปิดการใช้งาน timer
            Form1 f1 = new Form1();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
            f1.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
            this.Hide();//คำสั่งลบ form
        }

        private void OnbuttonClick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;//คำสั่งเปิดรูปที่ซ่อนไว้

            checkBox1.Visible = true;//การเปิดใช้งาน checkBox
            checkBox2.Visible = true;//การเปิดใช้งาน checkBox
            checkBox3.Visible = true;//การเปิดใช้งาน checkBox
            checkBox4.Visible = true;//การเปิดใช้งาน checkBox

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

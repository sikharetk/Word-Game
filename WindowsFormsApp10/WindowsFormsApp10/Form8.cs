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
    public partial class Form8 : Form
    {
        private Timer timer;//คำสั่งเปิดใช้งาน timer
        private Random random;//คำสั่งเปิดใช้งาน random

        private int countdown = 15;//คำสั่งการ ใช้ int ให้ตัว countdown ทำงานให้แค่ 15 วิ
        private bool a = false;// การกำหนดค่า ให้ปิดใช้งาน

        public Form8()
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "A";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "B";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "C";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "D";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "E";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "F";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "G";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "H";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "I";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "J";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "K";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "L";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "M";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "N";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "O";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "P";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Q";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "R";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "S";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "T";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "U";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "V";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "W";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "X";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Y";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Z";//กำหนดค่า textBox เท่ากับ textBox บวก คำที่เราต้องการให้โชว์ขึ้นในหน้า textBox ที่เรากำหนด
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string p = textBox1.Text.ToString();//การกำหนดตัว string ให้เป็นตัวแปร p เท่ากับ textBox ใช้งานในค่าที่เรากำหนด
            if (p == "HORSE")//ตัวแปรที่เรากำหนดเท่ากับ คำที่เราต้องการจะให้ใช้งานตามที่เรากำหนด
            {
                timer.Enabled = false;//ปิดการใช้งาน timer
                MessageBox.Show(" ม้า มีวิวัฒนาการมากว่า 45 ถึง 55 ล้านปีจากสิ่งมีชีวิตหลายกีบเท้าขนาดเล็กสู่สัตว์กีบคี่ขนาดใหญ่ในปัจจุบัน มนุษย์เริ่มนำม้ามาเลี้ยงเมื่อราว 4,000 ปีก่อนคริสตกาล และเชื่อว่าการเลี้ยงแพร่หลายเมื่อ 3,000 ปีก่อนคริสตกาล ม้าชนิดย่อย caballus เป็นม้าบ้านแม้ว่าจะมีประชากรม้าบ้านบางส่วนจะอาศัยอยู่ในป่า เช่น ม้าเถื่อน (feral horses) ม้าเถื่อนไม่ใช่ม้าป่าที่แท้จริง ดังเช่นม้าป่ามองโกเลียซึ่งถูกแบ่งแยกออกมาเป็นชนิดย่อยและเป็นชนิดเดียวที่เหลืออยู่ของม้าป่าที่แท้จริง คำว่าม้าเถื่อนใช้เพื่อแสดงว่าม้านี้ไม่ใช่ม้าบ้าน มีคำศัพท์เฉพาะมากมายที่ใช้อธิบายแนวคิดที่เกี่ยวข้องกับม้า ครอบคลุมจากกายวิภาคถึงช่วงชีวิต ขนาด สี สัญลักษณ์ การเพาะพันธุ์ การเคลื่อนไหว และพฤติกรรม");// การใช้ MessageBox โชว์ข้อความที่เรากำหนด
                Form9 f9 = new Form9();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
                f9.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
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

        private void button29_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;//ปิดการใช้งาน timer
            Form1 f1 = new Form1();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
            f1.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
            this.Hide();//คำสั่งลบ form
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();//กำหนดทำปุ่ม button ให้เครียข้อความ
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.Text += " : " + setting.title;//การใช้คำสั่ง method ให้ทำงานในหน้านี้
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;//คำสั่งการกำหนดรูปให้ทำงานในคำสั่งค่าที่เรากำหนด ให้รูปมันเท่าๆกัน


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
            button11.Enabled = false;//การปิดใช้งาน button
            button12.Enabled = false;//การปิดใช้งาน button
            button13.Enabled = false;//การปิดใช้งาน button
            button14.Enabled = false;//การปิดใช้งาน button
            button15.Enabled = false;//การปิดใช้งาน button
            button16.Enabled = false;//การปิดใช้งาน button
            button17.Enabled = false;//การปิดใช้งาน button
            button18.Enabled = false;//การปิดใช้งาน button
            button19.Enabled = false;//การปิดใช้งาน button
            button20.Enabled = false;//การปิดใช้งาน button
            button21.Enabled = false;//การปิดใช้งาน button
            button22.Enabled = false;//การปิดใช้งาน button
            button23.Enabled = false;//การปิดใช้งาน button
            button24.Enabled = false;//การปิดใช้งาน button
            button25.Enabled = false;//การปิดใช้งาน button
            button26.Enabled = false;//การปิดใช้งาน button
            textBox1.Enabled = false;//การปิดใช้งาน textBox

            pictureBox1.Visible = false;//การใช้คำสั่งซ่อนรูปภาพที่เรากำหนด
        }

        private void OnbuttonClick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;//คำสั่งการเปิดใช้งานรูปที่ซ่อนอยู่

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
            button11.Enabled = true;//การเปิดใช้งาน button
            button12.Enabled = true;//การเปิดใช้งาน button
            button13.Enabled = true;//การเปิดใช้งาน button
            button14.Enabled = true;//การเปิดใช้งาน button
            button15.Enabled = true;//การเปิดใช้งาน button
            button16.Enabled = true;//การเปิดใช้งาน button
            button17.Enabled = true;//การเปิดใช้งาน button
            button18.Enabled = true;//การเปิดใช้งาน button
            button19.Enabled = true;//การเปิดใช้งาน button
            button20.Enabled = true;//การเปิดใช้งาน button
            button21.Enabled = true;//การเปิดใช้งาน button
            button22.Enabled = true;//การเปิดใช้งาน button
            button23.Enabled = true;//การเปิดใช้งาน button
            button24.Enabled = true;//การเปิดใช้งาน button
            button25.Enabled = true;//การเปิดใช้งาน button
            button26.Enabled = true;//การเปิดใช้งาน button
            textBox1.Enabled = true;//การเปิดใช้งาน textBox

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

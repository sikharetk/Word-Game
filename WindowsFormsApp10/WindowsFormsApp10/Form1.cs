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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); //การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
            f2.Show();              //ตัวแปรให้โชว์ในค่าที่เรากำหนด
            this.Hide();            //คำสั่งลบ form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    //การออกจากโปรแกรม
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();   //การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
            f4.Show();         //ตัวแปรให้โชว์ในค่าที่เรากำหนด
            this.Hide();      //คำสั่งลบ form
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = setting.title; //การใช้คำสั่ง method ให้ทำงานในหน้านี้
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
            f26.Show();            //ตัวแปรให้โชว์ในค่าที่เรากำหนด
            this.Hide();          //คำสั่งลบ form
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form27 f27 = new Form27();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
            f27.Show();             //ตัวแปรให้โชว์ในค่าที่เรากำหนด
            this.Hide();            //คำสั่งลบ form
        }
    }
}

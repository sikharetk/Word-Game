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

    public partial class Form4 : Form
    {
        CheckBox[] B1, B2, B3 ,B4 , B5 , B6 , B7, B8 , B9 , B10; //การกำหนดค่า checkBox ให้ในแต่ละตัวกำหนดแถวแบ่ง checBox ให้ทำงานในรูป ตัวแปรที่เรากำหนด
        int pound, i = 0, num=0, K; //กำหนด int ให้ pound i num K ทำงานในรูปของ int
        Random pon = new Random(); // กำหนด Random ให้เป็น pon

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            num = 0; //num เท่ากับ 0 
            MessageBox.Show(num.ToString());//กำหนดค่า MessagBox ให้ Show ใน num ในคำสั่งที่เรากำหนด
            Environment.Exit(0); //การออกจากโปรแกรม
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1,checkBox2,checkBox3,checkBox4}; //ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 }; //ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 }; //ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 0; //ตัวแปรที่กำหนด เท่ากับ 0 
            i = 0;  //ตัวแปรที่กำหนด เท่ากับ 0 
            K = 0;//ตัวแปรที่กำหนด เท่ากับ 0 

            checkBox5.Enabled = false; //ปิดการใช้งานของ checkBox
            checkBox6.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox7.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox8.Enabled = false;//ปิดการใช้งานของ checkBox

            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox

            checkBox13.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox14.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox15.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox16.Enabled = false;//ปิดการใช้งานของ checkBox

            while (i < B1.Length) //กำหนด ให้ i น้อยกว่า B1 ในค่าที่เรากำหนด
            {
                B1[i].Enabled = false; //ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
                i++; // เพิ่มไปเลยๆ

            }
            i = 0; //i เท่ากับ 0
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B2[i].Enabled = true;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้เปิดในการใช้งาน
                i++;// เพิ่มไปเลยๆ
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0 

            B1[0].Enabled = false;  //ปิดการใช้งานของ B1
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)
            {
                B2[i].Enabled = false;//ปิดการใช้งานของ B2
                i++;
            }
            i = 0; //i เท่ากับ 0
            while (i < B3.Length)//กำหนด ให้ i น้อยกว่า B3 ในค่าที่เรากำหนด
            {
                B3[i].Enabled = true;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้เปิดในการใช้งาน
                i++;// เพิ่มไปเลยๆ
            }
           
        
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num
    
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B1[0].Enabled = false; //ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B2[i].Enabled = false; //ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//i เท่ากับ 0
            while (i < B3.Length)//กำหนด ให้ i น้อยกว่า B3 ในค่าที่เรากำหนด
            {
                B3[i].Enabled = true;//ปิดการใช้งานของ B3
                i++;// เพิ่มไปเลยๆ
            }
           
        }

        private void checkBox7_CheckedChanged_1(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num
                   
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while ( i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B2[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//i เท่ากับ 0
            while ( i < B3.Length)//กำหนด ให้ i น้อยกว่า B3 ในค่าที่เรากำหนด
            {
                B3[i].Enabled = true;//เปิดการใช้งานของ B3
                i++;// เพิ่มไปเลยๆ
            }
            num += 1; //num บวกหรือเท่ากับ 1 
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            K = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            checkBox5.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox6.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox7.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox8.Enabled = false;//ปิดการใช้งานของ checkBox

            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox

            checkBox13.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox14.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox15.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox16.Enabled = false;//ปิดการใช้งานของ checkBox

            while (i < B1.Length)//กำหนด ให้ i น้อยกว่า B1 ในค่าที่เรากำหนด
            {
                B1[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ

            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B1 ในค่าที่เรากำหนด
            {
                B2[i].Enabled = true;//เปิดการใช้งานของ B2
                i++;// เพิ่มไปเลยๆ
            }
          
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B2[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
            checkBox13.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox14.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox15.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox16.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B3[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B4.Length)//กำหนด ให้ i น้อยกว่า B4 ในค่าที่เรากำหนด
            {
                B4[i].Enabled = true;//เปิดการใช้งานของ B4
                i++;// เพิ่มไปเลยๆ
            }

          
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
            checkBox13.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox14.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox15.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox16.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B3[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B4.Length)//กำหนด ให้ i น้อยกว่า B4 ในค่าที่เรากำหนด
            {
                B4[i].Enabled = true;//เปิดการใช้งานของ B4
                i++;// เพิ่มไปเลยๆ
            }

            num += 1;//num บวกหรือเท่ากับ 1 
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
            checkBox13.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox14.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox15.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox16.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B3[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B4.Length)//กำหนด ให้ i น้อยกว่า B4 ในค่าที่เรากำหนด
            {
                B4[i].Enabled = true;//เปิดการใช้งานของ B4
                i++;// เพิ่มไปเลยๆ
            }

           
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num
           
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B5[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B3.Length)//กำหนด ให้ i น้อยกว่า B3 ในค่าที่เรากำหนด
            {
                B6[i].Enabled = true;//เปิดการใช้งานของ B6
                i++;// เพิ่มไปเลยๆ
            }

         
          
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num
          
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B5[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B3.Length)//กำหนด ให้ i น้อยกว่า B3 ในค่าที่เรากำหนด
            {
                B6[i].Enabled = true;//เปิดการใช้งานของ B6
                i++;// เพิ่มไปเลยๆ
            }

          
   
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B5[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B3.Length)//กำหนด ให้ i น้อยกว่า B3 ในค่าที่เรากำหนด
            {
                B6[i].Enabled = true;//เปิดการใช้งานของ B6
                i++;// เพิ่มไปเลยๆ
            }

   
            
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B6 = new CheckBox[] { checkBox21, checkBox22, checkBox23, checkBox24 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B6[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B7.Length)//กำหนด ให้ i น้อยกว่า B7 ในค่าที่เรากำหนด
            {
                B7[i].Enabled = true;//เปิดการใช้งานของ B7
                i++;// เพิ่มไปเลยๆ
            }

            num += 1;//num บวกหรือเท่ากับ 1 
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B6 = new CheckBox[] { checkBox21, checkBox22, checkBox23, checkBox24 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num
     
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B7[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B8.Length)//กำหนด ให้ i น้อยกว่า B8 ในค่าที่เรากำหนด
            {
                B8[i].Enabled = true;//เปิดการใช้งานของ B8
                i++;// เพิ่มไปเลยๆ
            }

            num += 1;//num บวกหรือเท่ากับ 1

        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B6 = new CheckBox[] { checkBox21, checkBox22, checkBox23, checkBox24 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B6[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B6.Length)//กำหนด ให้ i น้อยกว่า B6 ในค่าที่เรากำหนด
            {
                B7[i].Enabled = true;//เปิดการใช้งานของ B6
                i++;// เพิ่มไปเลยๆ
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B6 = new CheckBox[] { checkBox21, checkBox22, checkBox23, checkBox24 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num
         
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B6[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B6.Length)//กำหนด ให้ i น้อยกว่า B6 ในค่าที่เรากำหนด
            {
                B7[i].Enabled = true;//เปิดการใช้งานของ B6
                i++;// เพิ่มไปเลยๆ
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B6 = new CheckBox[] { checkBox21, checkBox22, checkBox23, checkBox24 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num
           
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B6[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B6.Length)//กำหนด ให้ i น้อยกว่า B6 ในค่าที่เรากำหนด
            {
                B7[i].Enabled = true;//เปิดการใช้งานของ B6
                i++;// เพิ่มไปเลยๆ
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B7[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B7.Length)//กำหนด ให้ i น้อยกว่า B7 ในค่าที่เรากำหนด
            {
                B8[i].Enabled = true;//เปิดการใช้งานของ B8
                i++;// เพิ่มไปเลยๆ

            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B7[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B7.Length)//กำหนด ให้ i น้อยกว่า B7 ในค่าที่เรากำหนด
            {
                B8[i].Enabled = true;//เปิดการใช้งานของ B8
                i++;// เพิ่มไปเลยๆ

            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B7[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B7.Length)//กำหนด ให้ i น้อยกว่า B7 ในค่าที่เรากำหนด
            {
                B8[i].Enabled = true;//เปิดการใช้งานของ B8
                i++;// เพิ่มไปเลยๆ

            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B6 = new CheckBox[] { checkBox21, checkBox22, checkBox23, checkBox24 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B8[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B9.Length)//กำหนด ให้ i น้อยกว่า B9 ในค่าที่เรากำหนด
            {
                B9[i].Enabled = true;//เปิดการใช้งานของ B9
                i++;// เพิ่มไปเลยๆ
            }

            num += 1;//num บวกหรือเท่ากับ 1

        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B6 = new CheckBox[] { checkBox21, checkBox22, checkBox23, checkBox24 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B9[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B10.Length)//กำหนด ให้ i น้อยกว่า B10 ในค่าที่เรากำหนด
            {
                B10[i].Enabled = true;//เปิดการใช้งานของ B10
                i++;// เพิ่มไปเลยๆ
            }

            num += 1;//num บวกหรือเท่ากับ 1

        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 
            K = num;//ตัวแปรที่กำหนด เท่ากับ num
         
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B8[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B9.Length)//กำหนด ให้ i น้อยกว่า B9 ในค่าที่เรากำหนด
            {
                B9[i].Enabled = true;//เปิดการใช้งานของ B10
                i++;// เพิ่มไปเลยๆ

            }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B8[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B9.Length)//กำหนด ให้ i น้อยกว่า B9 ในค่าที่เรากำหนด
            {
                B9[i].Enabled = true;//เปิดการใช้งานของ B10
                i++;// เพิ่มไปเลยๆ

            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B8[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B9.Length)//กำหนด ให้ i น้อยกว่า B9 ในค่าที่เรากำหนด
            {
                B9[i].Enabled = true;//เปิดการใช้งานของ B10
                i++;// เพิ่มไปเลยๆ

            }
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num
           
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox13.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox14.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox15.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox16.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B9[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B10.Length)//กำหนด ให้ i น้อยกว่า B10 ในค่าที่เรากำหนด
            {
                B10[i].Enabled = true;//เปิดการใช้งานของ B10
                i++;// เพิ่มไปเลยๆ
            }
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox13.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox14.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox15.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox16.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B9[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B10.Length)//กำหนด ให้ i น้อยกว่า B10 ในค่าที่เรากำหนด
            {
                B10[i].Enabled = true;//เปิดการใช้งานของ B10
                i++;// เพิ่มไปเลยๆ
            }
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox13.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox14.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox15.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox16.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B9[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B10.Length)//กำหนด ให้ i น้อยกว่า B10 ในค่าที่เรากำหนด
            {
                B10[i].Enabled = true;//เปิดการใช้งานของ B10
                i++;// เพิ่มไปเลยๆ
            }
        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B9[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B10.Length)//กำหนด ให้ i น้อยกว่า B10 ในค่าที่เรากำหนด
            {
                B10[i].Enabled = true;//เปิดการใช้งานของ B10
                i++;// เพิ่มไปเลยๆ
            }
            MessageBox.Show(num.ToString()); //กำหนดค่า MessageBox ให้ Show ใน num ที่กำหนด
            Form1 f1 = new Form1();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
            f1.ShowDialog();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
            this.Hide();//คำสั่งลบ form
        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B9[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B10.Length)//กำหนด ให้ i น้อยกว่า B10 ในค่าที่เรากำหนด
            {
                B10[i].Enabled = true;//เปิดการใช้งานของ B10
                i++;// เพิ่มไปเลยๆ
            }
            MessageBox.Show(num.ToString());//กำหนดค่า MessageBox ให้ Show ใน num ที่กำหนด
            Form1 f1 = new Form1();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
            f1.ShowDialog();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
            this.Hide();//คำสั่งลบ form
        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B6 = new CheckBox[] { checkBox21, checkBox22, checkBox23, checkBox24 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B9[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B10.Length)//กำหนด ให้ i น้อยกว่า B10 ในค่าที่เรากำหนด
            {
                B10[i].Enabled = true;//เปิดการใช้งานของ B10
                i++;// เพิ่มไปเลยๆ
            }

            MessageBox.Show(num.ToString());//กำหนดค่า MessageBox ให้ Show ใน num ที่กำหนด
            Form1 f1 = new Form1();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
            f1.ShowDialog();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
            this.Hide();//คำสั่งลบ form
        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B6 = new CheckBox[] { checkBox21, checkBox22, checkBox23, checkBox24 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B9[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B10.Length)//กำหนด ให้ i น้อยกว่า B10 ในค่าที่เรากำหนด
            {
                B10[i].Enabled = true;//เปิดการใช้งานของ B10
                i++;// เพิ่มไปเลยๆ
            }

            num += 1;//num บวกหรือเท่ากับ 1
            MessageBox.Show(num.ToString());//กำหนดค่า MessageBox ให้ Show ใน num ที่กำหนด
            Form1 f1 = new Form1();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
            f1.ShowDialog();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
            this.Hide();//คำสั่งลบ form

        }
        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)//คำสั่งการใช้งานของ ClosReason เท่ากับ CloseReason ให้ทำงานโดย .UserClosing
                Environment.Exit(0);//การออกจากโปรแกรม
            if (e.CloseReason == CloseReason.WindowsShutDown)//คำสั่งการใช้งานของ ClosReason เท่ากับ CloseReason ให้ทำงานโดย .WindowsShutDown
            {
                Environment.Exit(0);//การออกจากโปรแกรม
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
            f1.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
            this.Hide();//คำสั่งลบ form
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox13.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox14.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox15.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox16.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B3[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B4.Length)//กำหนด ให้ i น้อยกว่า B4 ในค่าที่เรากำหนด
            {
                B4[i].Enabled = true;//เปิดการใช้งานของ B4
                i++;// เพิ่มไปเลยๆ
            }

           
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B4[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B3.Length)//กำหนด ให้ i น้อยกว่า B3 ในค่าที่เรากำหนด
            {
                B5[i].Enabled = true;//เปิดการใช้งานของ B5
                i++;// เพิ่มไปเลยๆ
            }

            num += 1;//num บวกหรือเท่ากับ 1
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B4[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B4.Length)//กำหนด ให้ i น้อยกว่า B3 ในค่าที่เรากำหนด
            {
                B5[i].Enabled = true;//เปิดการใช้งานของ B5
                i++;// เพิ่มไปเลยๆ
            }

        
        
    }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B4[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B4.Length)//กำหนด ให้ i น้อยกว่า B3 ในค่าที่เรากำหนด
            {
                B5[i].Enabled = true;//เปิดการใช้งานของ B5
                i++;// เพิ่มไปเลยๆ
            }

            
        
    }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B4[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B4.Length)//เปิดการใช้งานของ B5
            {
                B5[i].Enabled = true;//เปิดการใช้งานของ B5
                i++;// เพิ่มไปเลยๆ
            }

         
        
    }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B5[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B3.Length)//เปิดการใช้งานของ B3
            {
                B6[i].Enabled = true;//เปิดการใช้งานของ B6
                i++;// เพิ่มไปเลยๆ
            }

            num += 1;//num บวกหรือเท่ากับ 1

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 1;//ตัวแปรที่กำหนด เท่ากับ 1
            K = num;//ตัวแปรที่กำหนด เท่ากับ num

            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            B3[0].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B2[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งานด
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B3.Length)//เปิดการใช้งานของ B3
            {
                B3[i].Enabled = true;//เปิดการใช้งานของ B3
                i++;// เพิ่มไปเลยๆ
            }

            
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B4 = new CheckBox[] { checkBox13, checkBox14, checkBox15, checkBox16 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B5 = new CheckBox[] { checkBox17, checkBox18, checkBox19, checkBox20 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B6 = new CheckBox[] { checkBox21, checkBox22, checkBox23, checkBox24 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B7 = new CheckBox[] { checkBox25, checkBox26, checkBox27, checkBox28 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B8 = new CheckBox[] { checkBox29, checkBox30, checkBox31, checkBox32 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B9 = new CheckBox[] { checkBox33, checkBox34, checkBox35, checkBox36 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B10 = new CheckBox[] { checkBox37, checkBox38, checkBox39, checkBox40 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B2[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B3.Length)//กำหนด ให้ i น้อยกว่า B3 ในค่าที่เรากำหนด
            {
                B3[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B4.Length)//กำหนด ให้ i น้อยกว่า B4 ในค่าที่เรากำหนด
            {
                B4[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B5.Length)//กำหนด ให้ i น้อยกว่า B5 ในค่าที่เรากำหนด
            {
                B5[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B6.Length)//กำหนด ให้ i น้อยกว่า B6 ในค่าที่เรากำหนด
            {
                B6[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B7.Length)//กำหนด ให้ i น้อยกว่า B7 ในค่าที่เรากำหนด
            {
                B7[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B8.Length)//กำหนด ให้ i น้อยกว่า B8 ในค่าที่เรากำหนด
            {
                B8[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B9.Length)//กำหนด ให้ i น้อยกว่า B9 ในค่าที่เรากำหนด
            {
                B9[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
                i++;// เพิ่มไปเลยๆ
            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B10.Length)//กำหนด ให้ i น้อยกว่า B10 ในค่าที่เรากำหนด
            {
                B10[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
                i++;// เพิ่มไปเลยๆ
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            K = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            checkBox5.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox6.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox7.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox8.Enabled = false;//ปิดการใช้งานของ checkBox

            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox

            checkBox13.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox14.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox15.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox16.Enabled = false;//ปิดการใช้งานของ checkBox

            while (i < B1.Length)//กำหนด ให้ i น้อยกว่า B1 ในค่าที่เรากำหนด
            {
                B1[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
                i++;// เพิ่มไปเลยๆ

            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B2[i].Enabled = true;//เปิดการใช้งานของ B2
                i++;// เพิ่มไปเลยๆ
            }
            
        }

        Random rnd = new Random(); //กำหนด ตัวแปรให้เป็น rnd
        public Form4()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            B1 = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B2 = new CheckBox[] { checkBox5, checkBox6, checkBox7, checkBox8 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            B3 = new CheckBox[] { checkBox9, checkBox10, checkBox11, checkBox12 };//ตัวแปรที่เรากำหนด เท่ากับ ค่าใน CheckBoxในช่องว่าง ให้ทำงานโดย checkBox เฉพาะ ตัวที่เรากำหนด
            pound = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            K = 0;//ตัวแปรที่กำหนด เท่ากับ 0

            checkBox5.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox6.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox7.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox8.Enabled = false;//ปิดการใช้งานของ checkBox

            checkBox9.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox10.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox11.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox12.Enabled = false;//ปิดการใช้งานของ checkBox

            checkBox13.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox14.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox15.Enabled = false;//ปิดการใช้งานของ checkBox
            checkBox16.Enabled = false;//ปิดการใช้งานของ checkBox
            while (i < B1.Length)
            {
                B1[i].Enabled = false;//ค่าที่เรากำหนด ทำงานในช่อง ที่เป็น i คือ0 ให้ปิดในการใช้งาน
                i++;// เพิ่มไปเลยๆ

            }
            i = 0;//ตัวแปรที่กำหนด เท่ากับ 0
            while (i < B2.Length)//กำหนด ให้ i น้อยกว่า B2 ในค่าที่เรากำหนด
            {
                B2[i].Enabled = true;//เปิดการใช้งานของ B2
                i++;// เพิ่มไปเลยๆ
            }
            num += 1;//num บวกหรือเท่ากับ 1

        }
    }
}

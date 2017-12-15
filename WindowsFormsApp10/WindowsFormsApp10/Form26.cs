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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void Form26_Load(object sender, EventArgs e)
        {
            this.Text += " : " + setting.title;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox23.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox24.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox25.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox26.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
            f1.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
            this.Hide();//คำสั่งลบ form
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();//การกำหนดค่า ปุ่ม ให้ทำงานโดยย้ายไปอีกหน้านึง
            f1.Show();//ตัวแปรให้โชว์ในค่าที่เรากำหนด
            this.Hide();//คำสั่งลบ form
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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 ability ความสามารถ "+"\r\n"+ " 2 about เกี่ยวกับ" + "\r\n" + " 3 above ข้างต้น" + "\r\n" + " 4 abroad ในต่างประเทศ" + "\r\n" + " 5 absence การไม่อยู่" + "\r\n" + " 6 absent ไม่อยู่" + "\r\n" + " 7 accept ยอมรับ" + "\r\n" + " 8 acceptable ยอมรับได้" + "\r\n" + " 9 accident อุบัติเหตุ" + "\r\n" + " 10 accordance ความสอดคล้อง" + "\r\n" + " 11 according to ตามที่" + "\r\n" + " 12 account บัญชี" + "\r\n" + " 13 ache ปวดเมื่อย" + "\r\n" + " 14 acid กรด" + "\r\n" + " 15 across ข้าม" + "\r\n" + " 16 act การกระทำ " + "\r\n" + "17 action การกระทำ" + "\r\n" + " 18 active กระตือรือร้น, กระฉับกระเฉง" + "\r\n" + " 19 activity กิจกรรม" + "\r\n" + " 20 actor นักแสดง" + "\r\n" + " 21 actress นักแสดงหญิง" + "\r\n" + " 22 actual ที่เกิดขึ้นจริง" + "\r\n" + " 23 add เพิ่ม" + "\r\n" + " 24 addition การบวก, การเพิ่ม" + "\r\n" + " 25 address ที่อยู่"); // การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 attempt ความพยายาม" + "\r\n" + "2 attend เข้าร่วม" + "\r\n" + "3 attendance เข้าร่วมประชุม" + "\r\n" + "4 attention ความสนใจ" + "\r\n" + "5 attract ดึงดูดความสนใจ" + "\r\n" + "6 attractive ที่น่าสนใจ" + "\r\n" + "7 aunt ป้า" + "\r\n" + "8 autumn ฤดูใบไม้ร่วง" + "\r\n" + "9 average โดยเฉลี่ย" + "\r\n" + "10 avoid หลีกเลี่ยง" + "\r\n" + "11 awake ตื่นตัว" + "\r\n" + "12 away ออกไป" + "\r\n" + "13 awkward งุ่มง่าม, เคอะเขิน, เก้งก้าง" + "\r\n" + "14 baby ทารก" + "\r\n" + "15 back กลับ, หลัง" + "\r\n" + "16 background พื้นหลัง" + "\r\n" + "17 backward ย้อนกลับ" + "\r\n" + "18 backwards ย้อนกลับ" + "\r\n" + "19 bacteria แบคทีเรีย" + "\r\n" + "20 bad ไม่ดี" + "\r\n" + "21 bag ถุง" + "\r\n" + "22 bake อบ" + "\r\n" + "23 balance สมดุล" + "\r\n" + "24 ball ลูกบอล" + "\r\n" + "25 banana กล้วย");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด


        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 cage กรง" + "\r\n" + "2 cake เค้ก" + "\r\n" + "3 calculate คำนวณ" + "\r\n" + "4 calculator เครื่องคิดเลข" + "\r\n" + "5 call โทร" + "\r\n" + "6 calm สงบ" + "\r\n" + "7 camera กล้องถ่ายภาพ" + "\r\n" + "8 camp ค่าย" + "\r\n" + "9 can สามารถ" + "\r\n" + "10 candle เทียน" + "\r\n" + "11 cap ฝาครอบ" + "\r\n" + "12 capital เมืองหลวง, เงินทุน" + "\r\n" + "13 captain กัปตัน" + "\r\n" + "14 car รถ" + "\r\n" + "15 card บัตร" + "\r\n" + "16 cardboard กระดาษแข็ง" + "\r\n" + "17 care การดูแล" + "\r\n" + "18 careful ระมัดระวัง" + "\r\n" + "19 careless ประมาท" + "\r\n" + "20 carriage การขนส่ง" + "\r\n" + "21 carry พกพา" + "\r\n" + "22 cart เกวียน" + "\r\n" + "23 case กรณี" + "\r\n" + "24 castle ปราสาท" + "\r\n" + "25 cat แมว" + "\r\n" + "26 catch จับ");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 daily ประจำวัน" + "\r\n" + "2 damage ความเสียหาย" + "\r\n" + "3 dance เต้นรำ" + "\r\n" + "4 danger อันตราย" + "\r\n" + "5 dangerous เป็นอันตราย" + "\r\n" + "6 dare กล้า" + "\r\n" + "7 daring ความกล้าหาญ" + "\r\n" + "8 dark มืด" + "\r\n" + "9 date วันที่" + "\r\n" + "10 daughter ลูกสาว" + "\r\n" + "11 day วัน" + "\r\n" + "12 dead ตาย" + "\r\n" + "13 deal ติดต่อ, เกี่ยงข้อง" + "\r\n" + "14 dear ที่รัก" + "\r\n" + "15 death ความตาย" + "\r\n" + "16 debt หนี้สิน" + "\r\n" + "17 decay ผุพัง" + "\r\n" + "18 deceit อุบายหลอกลวง" + "\r\n" + "19 deceive หลอกลวง" + "\r\n" + "20 decide ตัดสินใจ" + "\r\n" + "21 decimal ทศนิยม" + "\r\n" + "22 decision การตัดสินใจ");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 each แต่ละ" + "\r\n" + "2 eager กระตือรือร้น" + "\r\n" + "3 ear หู" + "\r\n" + "4 early แต่แรก" + "\r\n" + "5 earn ได้รับ" + "\r\n" + "6 earth โลก" + "\r\n" + "7 east ทิศตะวันออก" + "\r\n" + "8 eastern ทางทิศตะวันออก" + "\r\n" + "9 easy ง่าย" + "\r\n" + "10 eat กิน" + "\r\n" + "11 edge ขอบ, ริม" + "\r\n" + "12 educate ให้การศึกษา" + "\r\n" + "13 education การศึกษา" + "\r\n" + "14 effect ผล" + "\r\n" + "15 effective มีประสิทธิภาพ" + "\r\n" + "16 effort ความพยายาม" + "\r\n" + "17 egg ไข่" + "\r\n" + "18 eight แปด" + "\r\n" + "19 eighth ที่แปด" + "\r\n" + "20 either อย่างใดอย่างหนึ่ง" + "\r\n" + "21 elastic ซึ่งยืดหยุ่น, ยืดหดได้" + "\r\n" + "22 elbow ข้อศอก" + "\r\n" + "23 elect เลือกตั้ง" + "\r\n" + "24 election การเลือกตั้ง");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 face ใบหน้า" + "\r\n" + "2 fact ความจริง" + "\r\n" + "3 factory โรงงาน" + "\r\n" + "4 fail ล้มเหลว" + "\r\n" + "5 failure ความล้มเหลว" + "\r\n" + "6 faint เป็นลม" + "\r\n" + "7 fair ยุติธรรม" + "\r\n" + "8 fairy นางฟ้า" + "\r\n" + "9 faith ความเชื่อ" + "\r\n" + "10 faithful ซื่อสัตย์" + "\r\n" + "11 fall ตก, ฤดูใบไม้ร่วง" + "\r\n" + "12 FALSE ปลอม, เท็จ" + "\r\n" + "13 fame ชื่อเสียง" + "\r\n" + "14 familiar คุ้นเคย" + "\r\n" + "15 family ครอบครัว" + "\r\n" + "16 famous มีชื่อเสียง" + "\r\n" + "17 fancy จินตนาการ, หรูหรา" + "\r\n" + "18 far ไกล" + "\r\n" + "19 farm ฟาร์ม" + "\r\n" + "20 farmer ชาวนา" + "\r\n" + "21 farmyard บริเวณฟาร์ม" + "\r\n" + "22 fashion แฟชั่น" + "\r\n" + "23 fashionable ทันสมัย" + "\r\n" + "24 fast รวดเร็ว" + "\r\n" + "25 fasten ยึด" + "\r\n" + "26 fat ไขมัน");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 gate ประตู" + "\r\n" + "2 gather รวบรวม" + "\r\n" + "3 general ทั่วไป" + "\r\n" + "4 generous ใจกว้าง" + "\r\n" + "5 gentle อ่อนโยน" + "\r\n" + "6 gentleman สุภาพบุรุษ" + "\r\n" + "7get ได้รับ" + "\r\n" + "8 gift ของขวัญ" + "\r\n" + "9 girl เด็กหญิง" + "\r\n" + "10 give ให้" + "\r\n" + "11 glad ดีใจ" + "\r\n" + "12 glass แก้ว" + "\r\n" + "13 glory เกียรติยศ" + "\r\n" + "14 glue กาว15 go ไป" + "\r\n" + "16 goat แพะ" + "\r\n" + "17 god พระเจ้า" + "\r\n" + "18 gold ทอง" + "\r\n" + "19 golden ทำด้วยทอง" + "\r\n" + "20 good ดี" + "\r\n" + "21 good - bye ลาก่อน" + "\r\n" + "22 goods สินค้า" + "\r\n" + "23 govern ปกครอง" + "\r\n" + "24 government รัฐบาล");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 habit นิสัย" + "\r\n" + "2 habitual เป็นนิสัย" + "\r\n" + "3 hair ผม" + "\r\n" + "4 hairy มีผมมาก, มีขนมาก" + "\r\n" + "5 half ครึ่ง" + "\r\n" + "6 hall ห้องโถง" + "\r\n" + "7 hammer ค้อน" + "\r\n" + "8 hand มือ" + "\r\n" + "9 handkerchief ผ้าเช็ดหน้า" + "\r\n" + "10 handle จัดการ" + "\r\n" + "11 hang แขวน" + "\r\n" + "12 happen เกิดขึ้น" + "\r\n" + "13 happy มีความสุข" + "\r\n" + "14 hard แข็ง, ยาก" + "\r\n" + "15 harden ทำให้แข็ง" + "\r\n" + "16 hardly แทบจะไม่" + "\r\n" + "17 hardship ความยากลำบาก" + "\r\n" + "18 harm อันตราย" + "\r\n" + "19 harmful เป็นอันตราย" + "\r\n" + "20 harmless ไม่เป็นอันตราย" + "\r\n" + "21 hasty รีบร้อน" + "\r\n" + "22 hat หมวก" + "\r\n" + "23 hate เกลียดชัง" + "\r\n" + "24 hatred ความเกลียดชัง");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 if ถ้า" + "\r\n" + "2 ill ป่วย" + "\r\n" + "3 image ภาพ" + "\r\n" + "4 imaginary สมมุติขึ้น, เพ้อฝัน" + "\r\n" + "5 imagination จินตนาการ" + "\r\n" + "6 imagine จินตนาการ" + "\r\n" + "7 importance ความสำคัญ" + "\r\n" + "8 important ที่สำคัญ" + "\r\n" + "9 improve ปรับปรุง" + "\r\n" + "10 improvement การปรับปรุง" + "\r\n" + "11 in ใน" + "\r\n" + "12 include รวมถึง" + "\r\n" + "13 including รวมทั้ง" + "\r\n" + "14 income รายได้" + "\r\n" + "15 increase เพิ่มขึ้น" + "\r\n" + "16 indoor ในบ้าน adj" + "\r\n" + "17 indoors ในบ้าน adv" + "\r\n" + "18 industrial เกี่ยวกับอุตสาหกรรม" + "\r\n" + "19 industry อุตสาหกรรม" + "\r\n" + "20 infect ติดโรค, ติดเชื้อ" + "\r\n" + "21 infection การติดเชื้อ" + "\r\n" + "22 infectious ติดเชื้อ" + "\r\n" + "23 influence อิทธิพล" + "\r\n" + "24 influential มีอิทธิพล");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 jaw กราม" + "\r\n" + "2 jealous อิจฉา" + "\r\n" + "3 jealousy ความอิจฉา" + "\r\n" + "4 jelly วุ้น" + "\r\n" + "5 jewel อัญมณี" + "\r\n" + "6 jewelry เครื่องอัญมณี" + "\r\n" + "7 job งาน, อาชีพ" + "\r\n" + "8 join ร่วม" + "\r\n" + "9 joint ร่วมกัน" + "\r\n" + "10 joke เรื่องตลก" + "\r\n" + "11 journey การเดินทาง" + "\r\n" + "12 joy ปิติ" + "\r\n" + "13 judge ผู้พิพากษา" + "\r\n" + "14 judgment การตัดสิน" + "\r\n" + "15 juice น้ำผลไม้" + "\r\n" + "16 jump กระโดด" + "\r\n" + "17 just เพียงแค่" + "\r\n" + "18 justice ความยุติธรรม");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 kilo กิโล" + "\r\n" + "2 kilogram กิโลกรัม" + "\r\n" + "3 kilometer กิโลเมตร" + "\r\n" + "4 kind ชนิด" + "\r\n" + "5 king พระมหากษัตริย์" + "\r\n" + "6 kingdom ราชอาณาจักร" + "\r\n" + "7 kiss จูบ" + "\r\n" + "8 kitchen ห้องครัว" + "\r\n" + "9 knee หัวเข่า" + "\r\n" + "10 kneel คุกเข่า" + "\r\n" + "11 knife มีด" + "\r\n" + "12 knock เคาะ" + "\r\n" + "13 knot ปม, เงื่อน, กระจุก" + "\r\n" + "14 know ทราบ" + "\r\n" + "15 knowledge ความรู้");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 lamb เนื้อลูกแกะ" + "\r\n" + "2 lamp โคมไฟ" + "\r\n" + "3 land ที่ดิน" + "\r\n" + "4 language ภาษา" + "\r\n" + "5 large ขนาดใหญ่" + "\r\n" + "6 last สุดท้าย" + "\r\n" + "7 late สาย" + "\r\n" + "8 lately เมื่อเร็ว ๆ นี้" + "\r\n" + "9 laugh หัวเราะ" + "\r\n" + "10 laughter เสียงหัวเราะ" + "\r\n" + "11 law กฎหมาย" + "\r\n" + "12 lawyer ทนายความ" + "\r\n" + "13 lay วาง" + "\r\n" + "14 lazy ขี้เกียจ" + "\r\n" + "15 lead นำ" + "\r\n" + "16 lead ตะกั่ว" + "\r\n" + "17 leaf ใบไม้" + "\r\n" + "18 lean ยัน, พิง" + "\r\n" + "19 learn เรียน");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 mail ไปรษณีย์" + "\r\n" + "2 main หลัก, สำคัญที่สุด, ใหญ่ที่สุด, มากที่สุด" + "\r\n" + "3 make ทำ, ทำให้" + "\r\n" + "4 male เพศชาย" + "\r\n" + "5 man มนุษย์" + "\r\n" + "6 manage จัดการ" + "\r\n" + "7 manager ผู้จัดการ" + "\r\n" + "8 manner ลักษณะ" + "\r\n" + "9 many มากมาย" + "\r\n" + "10 map แผนที่" + "\r\n" + "11 March มีนาคม" + "\r\n" + "12 mark ทำเครื่องหมาย" + "\r\n" + "13 market ตลาด" + "\r\n" + "14 marriage การแต่งงาน" + "\r\n" + "15 marry แต่งงาน" + "\r\n" + "16 mass มวล" + "\r\n" + "17 master ต้นแบบ, เจ้านาย" + "\r\n" + "18 mat เสื่อ");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 name ชื่อ" + "\r\n" + "2 narrow แคบ" + "\r\n" + "3 nasty น่ารังเกียจ" + "\r\n" + "4 nation ประเทศชาติ" + "\r\n" + "5 national แห่งชาติ" + "\r\n" + "6 nature ธรรมชาติ" + "\r\n" + "7 naval เกี่ยวกับกองทัพเรือ" + "\r\n" + "8 navy กองทัพเรือ" + "\r\n" + "9 near ที่อยู่ใกล้" + "\r\n" + "10 nearly เกือบ" + "\r\n" + "11 neat เรียบร้อย" + "\r\n" + "12 necessary จำเป็น" + "\r\n" + "13 neck คอ" + "\r\n" + "14 need จำเป็นต้อง" + "\r\n" + "15 needle เข็ม" + "\r\n" + "16 neighbor เพื่อนบ้าน" + "\r\n" + "17 neighborhood ย่าน" + "\r\n" + "18 neither ไม่(ทั้งสอง)" + "\r\n" + "19 nerve เส้นประสาท" + "\r\n" + "20 nervous กระวนกระวาย, กังวล" + "\r\n" + "21 nest รัง");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 obedience การเชื่อฟังคำสั่ง" + "\r\n" + "2 obedient ที่เชื่อฟัง, อ่อนน้อม, ว่าง่าย, อยู่ในโอวาท" + "\r\n" + "3 obey เชื่อฟัง" + "\r\n" + "4 object วัตถุ" + "\r\n" + "5 obtain ได้รับ" + "\r\n" + "6 occasion โอกาส" + "\r\n" + "7 ocean มหาสมุทร" + "\r\n" + "8 odd คี่" + "\r\n" + "9 of จาก" + "\r\n" + "10 off ปิด" + "\r\n" + "11 offend ทำให้ขุ่นเคือง" + "\r\n" + "12 offense ความขุ่นเคือง" + "\r\n" + "13 offensive ที่ทำให้ขุ่นเคือง" + "\r\n" + "14 offer เสนอ" + "\r\n" + "15 office สำนักงาน" + "\r\n" + "16 officer เจ้าหน้าที่" + "\r\n" + "17 official เป็นทางการ, เจ้าหน้าที่" + "\r\n" + "18 often บ่อย ๆ");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 pair คู่" + "\r\n" + "2 palace พระราชวัง" + "\r\n" + "3 pale ซีด" + "\r\n" + "4 pan กระทะ" + "\r\n" + "5 paper กระดาษ" + "\r\n" + "6 parallel ขนาน" + "\r\n" + "7 parcel ห่อ" + "\r\n" + "8 parent ผู้ปกครอง" + "\r\n" + "9 park สวนสาธารณะ" + "\r\n" + "10 parliament รัฐสภา" + "\r\n" + "11 part ส่วนหนึ่ง" + "\r\n" + "12 particular โดยเฉพาะ" + "\r\n" + "13 partner หุ้นส่วน" + "\r\n" + "14 party พรรค" + "\r\n" + "15 pass ส่ง" + "\r\n" + "16 passage ทาง" + "\r\n" + "17 passenger ผู้โดยสาร");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 quality คุณภาพ" + "\r\n" + "2 quantity ปริมาณ" + "\r\n" + "3 quarrel การวิวาท" + "\r\n" + "4 quarter ไตรมาส" + "\r\n" + "5 queen พระราชินี" + "\r\n" + "6 question คำถาม" + "\r\n" + "7 quick รวดเร็ว" + "\r\n" + "8 quiet เงียบ" + "\r\n" + "9 quite ทีเดียว");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 rabbit กระต่าย" + "\r\n" + "2 race การแข่งขันด้านความเร็ว" + "\r\n" + "3 radio วิทยุ" + "\r\n" + "4 railway ทางรถไฟ" + "\r\n" + "5 rain ฝนตก" + "\r\n" + "6 raise ยก" + "\r\n" + "7 range ช่วง" + "\r\n" + "8 rank ยศ, ตำแหน่ง" + "\r\n" + "9 rapid รวดเร็ว" + "\r\n" + "10 rare หายาก" + "\r\n" + "11 rat หนู" + "\r\n" + "12 rate อัตรา" + "\r\n" + "13 rather ค่อนข้าง" + "\r\n" + "14 raw ดิบ" + "\r\n" + "15 reach ไปถึง" + "\r\n" + "16 read อ่าน" + "\r\n" + "17 ready พร้อม" + "\r\n" + "18 real จริง");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 sad เสียใจ" + "\r\n" + "2 safe ปลอดภัย" + "\r\n" + "3 safety ความปลอดภัย" + "\r\n" + "4 sail แล่นเรือ" + "\r\n" + "5 sale ขาย" + "\r\n" + "6 salt เกลื" + "\r\n" + "7 same เดียวกัน" + "\r\n" + "8 sand ทราย" + "\r\n" + "9 satisfaction ความพอใจ" + "\r\n" + "10 satisfactory น่าพอใจ" + "\r\n" + "11 satisfy ทำให้พอใจ" + "\r\n" + "12 save ช่วยให้ปลอดภัย, บันทึกข้อมูล" + "\r\n" + "13 say กล่าว" + "\r\n" + "14 scale ตราชั่ง, ขนาด" + "\r\n" + "15 scatter กระจัดกระจาย" + "\r\n" + "16 scene ฉาก/");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 tail หาง" + "\r\n" + "2 take นำมา, พาไป, ยึด, ถือ" + "\r\n" + "3 talk พูด, คุย" + "\r\n" + "4 tall สูง" + "\r\n" + "5 taste ลิ้มรส" + "\r\n" + "6 tax ภาษี" + "\r\n" + "7 taxi รถแท็กซี่" + "\r\n" + "8 tea ชา" + "\r\n" + "9 teach สอน" + "\r\n" + "10 team ทีมงาน" + "\r\n" + "11 tear ฉีก" + "\r\n" + "12 tear น้ำตา" + "\r\n" + "13 telephone โทรศัพท์" + "\r\n" + "14 television โทรทัศน์" + "\r\n" + "15 tell บอก" + "\r\n" + "16 temper อารมณ์" + "\r\n" + "17 temperature อุณหภูมิ" + "\r\n" + "18 temple วัด, โบสถ์" + "\r\n" + "19 tend มีแนวโน้ม" + "\r\n" + "20 tendency แนวโน้ม");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 uncle ลุง" + "\r\n" + "2 under ภายใต้" + "\r\n" + "3 understand เข้าใจ" + "\r\n" + "4 undo ยกเลิกสิ่งที่ได้ทำไปแล้ว" + "\r\n" + "5 uniform เครื่องแบบ" + "\r\n" + "6 union สหภาพ" + "\r\n" + "7 unit หน่วย" + "\r\n" + "8 unite รวมกัน" + "\r\n" + "9 universal สากล" + "\r\n" + "10 universe จักรวาล" + "\r\n" + "11 university มหาวิทยาลัย" + "\r\n" + "12 until จนกระทั่ง" + "\r\n" + "13 up ขึ้น");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 value ค่า" + "\r\n" + "2 variety ความหลากหลาย" + "\r\n" + "3 various ต่างๆ" + "\r\n" + "4 vary แตกต่างกันไป" + "\r\n" + "5 vegetable พืชผัก" + "\r\n" + "6 vehicle พาหนะ" + "\r\n" + "7 verb คำกริยา" + "\r\n" + "8 very มาก" + "\r\n" + "9 victory ชัยชนะ" + "\r\n" + "10 view มุมมอง" + "\r\n" + "11 village หมู่บ้าน" + "\r\n" + "12 violence ความรุนแรง" + "\r\n" + "13 violent รุนแรง" + "\r\n" + "14 visit เยี่ยมชม" + "\r\n" + "15 voice เสียง" + "\r\n" + "16 vote การลงคะแนนเสียง" + "\r\n" + "17 vowel สระ");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 waist เอว" + "\r\n" + "2 wait คอย" + "\r\n" + "3 waiter บริกร" + "\r\n" + "4 wake ปลุก" + "\r\n" + "5 walk เดิน" + "\r\n" + "6 wall ผนัง" + "\r\n" + "7 wander เดินทางไปโดยไม่มีจุดหมายที่แน่นอน, ร่อนเร่" + "\r\n" + "8 want ต้องการ" + "\r\n" + "9 war สงคราม" + "\r\n" + "10 warm อบอุ่น" + "\r\n" + "11 warmth ความอบอุ่น" + "\r\n" + "12 warn เตือน" + "\r\n" + "13 wash ล้าง" + "\r\n" + "14 waste เสีย" + "\r\n" + "15 watch ดู, ชม" + "\r\n" + "16 water น้ำ" + "\r\n" + "17 wave คลื่น" + "\r\n" + "18 way ทาง, วิธี");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button25_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 X n พยัญชนะภาษาอังกฤษตัวที่ 24" + "\r\n" + "2 x chromosome n โครโมโซมเพศ(ทางพันธุกรรม)" + "\r\n" + "3 x div abbr คำย่อของ ex - dividend" + "\r\n" + "4 x marks the spot idm ตำแหน่งที่แน่นอน" + "\r\n" + "5 x ray n รังสีเอ็กซ์" + "\r\n" + "6 x ray n ภาพถ่ายด้วยรังสีเอ็กซ์(ทางการแพทย์และวิทยาศาสตร์)" + "\r\n" + "7 x ray n รหัสของอักษร x(ทางการติดต่อทางวิทยุระหว่างประเทศ)" + "\r\n" + "8 x ray vt ถ่ายภาพด้วยรังสีเอ็กซ์" + "\r\n" + "9 x ray vt รักษาคนป่วยโดยใช้รังสีเอ็กซ์" + "\r\n" + "10 x - axis n แกนนอน" + "\r\n" + "11 X - ing n บริเวณรางรถไฟ ถนน หรือแม่น้ำ 2 สายตัดกันเป็นรูปกากบาท" + "\r\n" + "12 x - ing n บริเวณรางรถไฟ ถนน หรือแม่น้ำ 2 สายตัดกันเป็นรูปกากบาท" + "\r\n" + "13 x - radiation n การรักษาด้วยรังสีเอ็กซ์" + "\r\n" + "14 X - rated adj ซึ่งห้ามเด็กอายุต่ำกว่า 17 ปีเข้าชม" + "\r\n" + "15 x - ray n รังสีเอ็กซ์");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 yard หลา" + "\r\n" + "2 year ปี" + "\r\n" + "3 yearly รายปี" + "\r\n" + "4 yellow สีเหลือง" + "\r\n" + "5 yes ใช่" + "\r\n" + "6 yesterday เมื่อวาน" + "\r\n" + "7 yet ยัง" + "\r\n" + "8 you คุณ" + "\r\n" + "9 young หนุ่มสาว" + "\r\n" + "10 your ของคุณ" + "\r\n" + "11 yours ของคุณ" + "\r\n" + "12 yourself ด้วยตัวคุณเอง" + "\r\n" + "13 youth หนุ่ม");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }

        private void button27_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 zag vi เคลื่อนที่เป็นรูปฟันปลา" + "\r\n" + "2 zaire n สาธารณรัฐซาเอียร์ในภาคกลางของแอฟริกา" + "\r\n" + "3 zaire n หน่วยเงินตราของประเทศซาเอียร์" + "\r\n" + "4 zany n ตลกโง่ๆ" + "\r\n" + "5 zany n ตัวตลกโง่ๆ" + "\r\n" + "6 zeal n ความกระตือรือร้นจนเกินไป" + "\r\n" + "7 zealot n ผู้กระตือรือร้นเกินไป" + "\r\n" + "8 zealot enthusiast n ผู้อุทิศตัว" + "\r\n" + "9 zealous adj กระตือรือร้น" + "\r\n" + "10 zealous adj เด็ดเดี่ยว" + "\r\n" + "11 zealous adj กระตือรือร้น" + "\r\n" + "12 zealous adj คลั่งไคล้ที่สุด" + "\r\n" + "13 zealous adj ซึ่งแสดงความรู้สึกอย่างมาก" + "\r\n" + "14 zealous adj แรงกล้า");// การกำหนด MessageBox ให้แสดงคำที่เรากำหนด
        }
    }
}
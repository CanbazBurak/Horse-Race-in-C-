using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarışı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Random uret = new Random();
        int birincisoluz, ikincisoluz, ucuncusoluz;
        int bahismiktari,atsecimi,hesapdakipara;

        private void Form2_Load(object sender, EventArgs e)
        {
            bahismiktari = Convert.ToInt32(label11.Text);
            hesapdakipara = Convert.ToInt32(label9.Text);
            atsecimi = Convert.ToInt32(label10.Text);



            birincisoluz = pictureBox1.Left;
            ikincisoluz = pictureBox2.Left;
            ucuncusoluz = pictureBox3.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 baslangıc = new Form1();
            baslangıc.textBox1.Text = hesapdakipara.ToString();
            baslangıc.textBox1.Enabled = false;
            baslangıc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL ="C:\\Users\\Burak CANBAZ\\Desktop\\C# Çalışmalarım\\At Yarışı\resimler\\başlama sesi.mp3";
            timer1.Enabled = true;
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayı = Convert.ToInt32(label7.Text);
            sayı++;
            label7.Text = sayı.ToString();

           
            int birincigen, ikincigen, ucuncugen;
            int bıtısuz;
            bıtısuz = label4.Left;
            birincigen = pictureBox1.Width;
            ikincigen = pictureBox2.Width;
            ucuncugen = pictureBox3.Width;

            pictureBox1.Left=pictureBox1.Left+ uret.Next(5, 16);
            pictureBox2.Left = pictureBox2.Left + uret.Next(15, 16);
            pictureBox3.Left = pictureBox3.Left + uret.Next(5, 16);
            if (pictureBox1.Left >= pictureBox2.Left + 5 && pictureBox1.Left >= pictureBox3.Left + 5)
            {
                label6.Text = "BİRİNCİ AT YARIŞI ÖNDE GÖTÜRÜYOR";
            }
            else if (pictureBox2.Left >= pictureBox1.Left + 5 && pictureBox2.Left >= pictureBox3.Left + 5)
            {
                label6.Text = "İKİNCİ AT YARIŞI ÖNDE GÖTÜRÜYOR";
            }
            else if (pictureBox3.Left >= pictureBox2.Left + 5 && pictureBox3.Left >= pictureBox1.Left + 5)
            {
                label6.Text = "ÜÇÜNCÜ AT YARIŞI ÖNDE GÖTÜRÜYOR";
            }

            if (birincigen + pictureBox1.Left >= bıtısuz)
            {
                timer1.Enabled = false;
                label6.Text = "!!!  BİRİNCİ AT YARIŞI KAZANDI !!!";
                button1.Enabled = true;
                if (atsecimi == 1)
                {
                    MessageBox.Show("WONNNNNN!!!");
                    hesapdakipara = bahismiktari + hesapdakipara;
                }
                else hesapdakipara = hesapdakipara - bahismiktari;
                
                
            }
            else if (ikincigen + pictureBox2.Left >= bıtısuz) { 
                    timer1.Enabled = false;
                    label6.Text = "!!!  İKİNCİ AT YARIŞI KAZANDI !!!";
                button1.Enabled = true;
                if (atsecimi == 2)
                {
                    MessageBox.Show("WONNNNNN!!!");
                    hesapdakipara = bahismiktari + hesapdakipara;
                }
                else hesapdakipara = hesapdakipara - bahismiktari;
            }
            else if (ucuncugen + pictureBox3.Left >= bıtısuz)
            {
                timer1.Enabled = false;
                label6.Text = "!!!  ÜÇÜNCÜ AT YARIŞI KAZANDI !!!";
                button1.Enabled = true;
                if (atsecimi == 3)
                {
                    MessageBox.Show("WONNNNNN!!!");
                    hesapdakipara = bahismiktari + hesapdakipara;
                }
                else hesapdakipara = hesapdakipara - bahismiktari;
            }

           


        }
    }
}
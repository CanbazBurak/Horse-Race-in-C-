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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hesapdakipara, bahismiktarı, atsecimi;

        private void button3_Click(object sender, EventArgs e)
        {
            hesapdakipara = Convert.ToInt32(textBox1.Text);
            bahismiktarı = Convert.ToInt32(textBox2.Text);
            atsecimi = Convert.ToInt32(comboBox1.Text);
            


            if (bahismiktarı > hesapdakipara)
            {
                MessageBox.Show("Lütfen Hesabınızdaki Paradan Fazla Bahis Yapmayınız!!!");
                
            }
            else
            {
                button1.Enabled = true;
                button3.Enabled = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 yarıs = new Form2();
            yarıs.label9.Text = hesapdakipara.ToString();
            yarıs.label10.Text = atsecimi.ToString();
            yarıs.label11.Text = bahismiktarı.ToString();
            yarıs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

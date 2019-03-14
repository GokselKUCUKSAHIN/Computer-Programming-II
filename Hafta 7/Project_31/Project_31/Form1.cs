using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
        }
        string KullaniciAdi = "Goksel";
        string Sifre = "1234";
        
        private void button1_Click(object sender, EventArgs e)
        {
            string kAdi = textBox1.Text.ToString();
            string kSifre = textBox2.Text.ToString();
            if((kAdi == KullaniciAdi) && (kSifre == Sifre))
            {
                Form2 frm2 = new Form2();
                frm2.Visible = true;
                label3.Visible = false;
                //frm2.Show();
                this.Visible = false;
                frm2.VeriIlet(this);
                textBox1.Clear();
                textBox2.Clear();
            }
            else if((kAdi == String.Empty) || (kSifre == String.Empty))
            {
                label3.Visible = true;
                label3.Text = "Hata:      Kullanıcı Adı veya Şifre Boş Olamaz";
            }
            else
            {
                label3.Visible = true;
                label3.Text = "Hata:           Kullanıcı Adı veya Şifre Yanlış!";
            }
        }
    }
}

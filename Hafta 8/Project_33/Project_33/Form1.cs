using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hasta hastamiz = new Hasta();
            hastamiz.TCKimlikNo = textBox1.Text;
            hastamiz.Adi = textBox2.Text;
            hastamiz.Soyadi = textBox3.Text;
            Randevu r = new Randevu();
            r.Kisi = hastamiz;
            r.bolum = comboBox1.SelectedItem.ToString();
            r.tarih = dateTimePicker1.Value.ToShortDateString();
            r.saat = comboBox2.SelectedItem.ToString();

            RandevuSistemi rs = new RandevuSistemi();
            bool varMi = rs.BTSArama(r);
            if (varMi == true)
                MessageBox.Show("Secilen Bolume, secilen tarih ve saatte randevu var");
            else
            {
                rs.RandevuEkle(r);
                MessageBox.Show("Randevu alınmıştır");
            }
        }

        Form2 frm2 = new Form2();
        private void button2_Click(object sender, EventArgs e)
        {
            frm2.Show();
        }
    }
}

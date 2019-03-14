using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ulkelerDS = DBIslemleri.UlkeleriCek();
            comboBox1.DisplayMember = "UlkeAdi";
            comboBox1.ValueMember = "UlkeID";
            comboBox1.DataSource = ulkelerDS.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ulkeID = (int)comboBox1.SelectedValue;
            DataSet sehirlerDS = DBIslemleri.SehirleriCek(ulkeID);
            comboBox2.DisplayMember = "Sehir";
            comboBox2.ValueMember = "SehirID";
            comboBox2.DataSource = sehirlerDS.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adi = textBox1.Text;
            string soyadi = textBox2.Text;
            string telefon = textBox3.Text;
            int sehirID = (int)comboBox2.SelectedValue;
            string adres = textBox4.Text;
            DBIslemleri.Ekle(adi, soyadi, telefon, sehirID, adres);
            MessageBox.Show("Eklendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            DataSet sonuclar = DBIslemleri.Arama(textBox5.Text);
            dataGridView1.DataSource = sonuclar.Tables[0];
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                textBox7.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox8.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox9.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kisiID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            string yenia = textBox7.Text;
            string yenis = textBox8.Text;
            string yenit = textBox9.Text;
            string yeniadr = textBox6.Text;
            DBIslemleri.Duzenle(kisiID, yenia, yenis, yenit, yeniadr);
            MessageBox.Show("Güncellendi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int KisiID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            DBIslemleri.Sil(KisiID);
            MessageBox.Show("Silindi!");
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Project_35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
             DialogResult basilan = MessageBox.Show("Mesaj","Başlık",MessageBoxButtons.OKCancel,MessageBoxIcon.Hand);
            if(basilan ==DialogResult.OK)
            {
                //Ok olunca
                MessageBox.Show("OK'e Bastınız!");
            }
            else
            {
                //Cancel olunca
                MessageBox.Show("Cancel'a Bastınız!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Metin Dosyaları|*.txt;*.doc;*.docx";
            DialogResult basilan = od.ShowDialog();
            if(basilan == DialogResult.OK)
            {
                string secilenDosya = od.FileName;
                StreamReader okumaNesnesi = new StreamReader(secilenDosya);
                string icerikler = okumaNesnesi.ReadToEnd();
                okumaNesnesi.Close();
                richTextBox1.Text = icerikler;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Metinler|*.txt";
            sd.DefaultExt = ".txt";
            DialogResult basilan = sd.ShowDialog();
            if(basilan == DialogResult.OK)
            {
                string kayitDosya = sd.FileName;
                StreamWriter yazmaNesnesi = new StreamWriter(kayitDosya, false);
                yazmaNesnesi.WriteLine(richTextBox1.Text);
                yazmaNesnesi.Close();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            DialogResult basilan = fd.ShowDialog();
            if(basilan == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult basilan = cd.ShowDialog();
            if (basilan == DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Resim Dosyaları|*.png;*.jpg";
            DialogResult basilan = od.ShowDialog();
            if (basilan == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(od.FileName);
            }
        }
    }
}
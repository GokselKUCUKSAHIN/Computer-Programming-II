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

namespace Project_32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                StreamReader okumaNesnesi = new StreamReader(@"randevu.txt");
                okumaNesnesi.Close();
            }
            catch
            {
                MessageBox.Show("Kayıt Defteri Bulunamadı, Yeni defter oluşturuluyor","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                StreamWriter CreateNew = new StreamWriter(@"randevu.txt",true);
                CreateNew.WriteLine("Kimlik No*Ad*Soyad*Bölüm*Tarih*Saat");
                CreateNew.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            //Değişkenler
            //
            bool Error = false;
            string kimlikNo = String.Empty;
            string adi = String.Empty;
            string soyadi = String.Empty;
            string klinik = String.Empty;
            string saat = String.Empty;
            string tarih = String.Empty;
            
            //
            //Kimlik No alma
            //
            if ((textBox1.Text != String.Empty) && (!Error))
            {
                kimlikNo = textBox1.Text.ToString();
            }
            else
            {
                Error = true;
                MessageBox.Show("Kimlik No Boş", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //
            //Ad alma
            //
            if ((textBox2.Text != String.Empty) && (!Error))
            {
                adi = textBox2.Text.ToString();
            }
            else
            {
                Error = true;
                MessageBox.Show("Ad Boş", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //
            //Soyad alma
            //
            if ((textBox3.Text != String.Empty) && (!Error))
            {
                soyadi = textBox3.Text.ToString();
            }
            else
            {
                Error = true;
                MessageBox.Show("Soyad Boş", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //
            //klinik alma
            //
            if(!Error)
            {
                try
                {
                    klinik = comboBox1.SelectedItem.ToString();
                }
                catch
                {
                    Error = true;
                    MessageBox.Show("Klinik Seçmediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //
            //Tarih Alma
            //
            tarih = dateTimePicker1.Value.ToShortDateString();

            //
            //Saat alma
            //
            if(!Error)
            {
                try
                {
                    saat = comboBox2.SelectedItem.ToString();
                }
                catch
                {
                    Error = true;
                    MessageBox.Show("Saat Seçmediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            bool Eslesme = true;
            //
            //Diske Yazma
            //
            if (!Error)
            {
                Eslesme = varMi(klinik, tarih, saat);
                if(!Eslesme)
                {
                    try
                    {
                        string satir = kimlikNo + "*" + adi + "*" + soyadi + "*" + klinik + "*" + tarih + "*" + saat;
                        StreamWriter yazmaNesnesi = new StreamWriter(@"randevu.txt", true);
                        yazmaNesnesi.WriteLine(satir);
                        MessageBox.Show("Eklendi!");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        comboBox1.SelectedIndex = -1;
                        comboBox2.SelectedIndex = -1;
                        dateTimePicker1.ResetText();
                        yazmaNesnesi.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Dosya Yazdırılamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("İstemiş olduğunuz Randevu başkası tarafından alımış duruma!", "EŞLEŞME!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetData();
        }
        void GetData()
        {
            string icerik = String.Empty;
            try
            {
                StreamReader okumaNesnesi = new StreamReader(@"randevu.txt");
                //icerik = okumaNesnesi.ReadToEnd();
                while (!okumaNesnesi.EndOfStream)
                {
                    string satir = okumaNesnesi.ReadLine();
                    icerik += satir + Environment.NewLine;
                }
                textBox4.Text = icerik;
                okumaNesnesi.Close();
            }
            catch
            {
                MessageBox.Show("HATA Dosya Okunamadı!!!");
            }
        }
        bool varMi(string bolum, string tarih, string saat)
        {
            //randevu.txt dosyasını acacak
            //her bir satırı okuyacak 
            //her bir satiri * karakterini bölecek
            //satir.Split('*')
            //bölüm tarih ve saat bilgisi satirin 3 4 5 parçaları ile aynı ise
            //randevu var demektir ve true değer dönderecek
            //dosya sonuna kadar eşleşme yok ise false dönderecek

            bool Eslesme = false;
            string dOku = String.Empty;
            try
            {
                int counter = 0;
                StreamReader Datakontrol = new StreamReader(@"randevu.txt");
                while ((!Datakontrol.EndOfStream) && (!Eslesme))
                {
                    dOku = Datakontrol.ReadLine();
                    string[] satir = dOku.Split('*');
                    if((satir[3] == bolum) &&(satir [4] == tarih) &&(satir[5] == saat))
                    {
                        Eslesme = true;
                    }
                }
                Datakontrol.Close();
            }
            catch
            {
                Eslesme = true;
                MessageBox.Show("DOSYADAN OKUMA BAŞARISIZ","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
            return Eslesme;
        }
    }
}
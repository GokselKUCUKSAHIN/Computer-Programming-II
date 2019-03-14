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
using System.Collections;
namespace Project_36
{
    public partial class FormTextEdit : Form
    {
        /*HELLO*/

        public FormTextEdit()
        {
            InitializeComponent();
            cache = durumÇubuğuToolStripMenuItem.Checked;
        }

        bool acikDosyaVarmi = false;
        bool degisiklikVarmi = false;
        string acikDosya = String.Empty;

        void dosyaAcmaIslemleri()
        {
            //OpenFD acilir, secilen dosya StreamReader ile okunur
            //İçerik RichTextBoxa atilir. artık açık dosya var açık dosyanin adi saklanır
            //henüz yeni için değişiklik yoktur

            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Dosyalar|*.txt";
            od.DefaultExt = ".txt";
            DialogResult basilan = od.ShowDialog();
            if(basilan == DialogResult.OK)
            {
                acikDosya = od.FileName;
                StreamReader okumaNesnesi = new StreamReader(acikDosya);
                string icerik = okumaNesnesi.ReadToEnd();
                okumaNesnesi.Close();
                richTextBox1.Text = icerik;
                acikDosyaVarmi = true;
                degisiklikVarmi = false;
                this.Text = acikDosya + " - Metin Düzenleme";
            }
        }
        
        void Kaydet()
        {
            StreamWriter yazmaNesnesi = new StreamWriter(acikDosya, false);
            yazmaNesnesi.WriteLine(richTextBox1.Text);
            yazmaNesnesi.Close();
            degisiklikVarmi = false;
        }

        void farkliKaydet()
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Dosyalar|*.txt";
            sd.DefaultExt = ".txt";
            DialogResult basilan = sd.ShowDialog();
            if(basilan==DialogResult.OK)
            {
                StreamWriter yazmaNesnesi = new StreamWriter(sd.FileName, false);
                yazmaNesnesi.WriteLine(richTextBox1.Text);
                yazmaNesnesi.Close();
                degisiklikVarmi = false;
            }
        }
        void Resetle()
        {
            richTextBox1.Clear();
            acikDosyaVarmi = false;
            degisiklikVarmi = false;
            acikDosya = String.Empty;
            this.Text = "Adsız - Metin Düzenleme";
        }

        //
        //MenuBar
        //
        private void AcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(acikDosyaVarmi)
            {
                if(degisiklikVarmi)
                {
                    DialogResult basilan = MessageBox.Show("Kaydedilsin mi?","Metin Düzenleme",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                    if(basilan == DialogResult.Yes)
                    {
                        Kaydet();
                        dosyaAcmaIslemleri();
                    }
                    else if(basilan == DialogResult.No)
                    {
                        dosyaAcmaIslemleri();
                    }
                }
                else //acik dosya var değişiklik yok
                {
                    dosyaAcmaIslemleri();
                }
            }
            else//açık dosya yok
            {
                if(degisiklikVarmi)
                {
                    DialogResult basilan = MessageBox.Show("Kaydedilsin mi?", "Metin Düzenleme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (basilan == DialogResult.Yes)
                    {
                        farkliKaydet();
                        dosyaAcmaIslemleri();
                    }
                    else if (basilan == DialogResult.No)
                    {
                        dosyaAcmaIslemleri();
                    }
                }
                else//acik dosya yok değişiklik yok
                {
                    dosyaAcmaIslemleri();
                }
            }
        }

        private void YeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(acikDosyaVarmi)
            {
                if (degisiklikVarmi)//açık dosya var değişiklik var
                {
                    DialogResult basilan = MessageBox.Show("Kaydedilsin mi?", "Metin Düzenleme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if(basilan == DialogResult.Yes)//açık dosya var değişiklik var ; basilan = yes
                    {
                        Kaydet();
                        Resetle();
                    }
                    else if(basilan == DialogResult.No)//açık dosya var değişiklik var ; basilan = no
                    {
                        Resetle();
                    }
                }
                else//açık dosya var, değişiklik yoksa
                {
                    Resetle();
                }
            }
            else//açık dosya yoksa
            {
                if(degisiklikVarmi)//acik dosya yok değişiklik var
                {
                    DialogResult basilan = MessageBox.Show("Kaydedilsin mi?", "Metin Düzenleme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if(basilan == DialogResult.Yes)
                    {
                        farkliKaydet();
                        Resetle();
                    }
                    else if(basilan == DialogResult.No)
                    {
                        Resetle();
                    }
                }
                else//acik dosya yok değişiklik yok
                {
                    Resetle();
                }
            }
        }

        private void kaydetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!acikDosyaVarmi)
                farkliKaydet();
            else
                Kaydet();
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farkliKaydet();
        }

        //
        //Değişiklik var mı Kontrol
        //
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            degisiklikVarmi = true;
            
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(richTextBox1.SelectedText);
            richTextBox1.SelectedText = String.Empty;
            //veya
            //richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(richTextBox1.SelectedText);
            //veya
            //richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste(DataFormats.GetFormat(DataFormats.Text));
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = String.Empty;
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void tarihVeSaatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += DateTime.Now.ToString();
        }
        bool cache;
        private void sözcükKaydırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = sözcükKaydırToolStripMenuItem.Checked;

            if(richTextBox1.WordWrap && durumÇubuğuToolStripMenuItem.Checked)
            {
                cache = durumÇubuğuToolStripMenuItem.Checked;
                statusBar.Visible = true;
                durumÇubuğuToolStripMenuItem.Enabled = true;
                durumÇubuğuToolStripMenuItem.Checked = true;
            }
            else if(richTextBox1.WordWrap && !durumÇubuğuToolStripMenuItem.Checked)
            {
                statusBar.Visible = false;
                durumÇubuğuToolStripMenuItem.Enabled = true;
                durumÇubuğuToolStripMenuItem.Checked = false;
            }
            else if(!richTextBox1.WordWrap && durumÇubuğuToolStripMenuItem.Checked)
            {
                statusBar.Visible = false;
                durumÇubuğuToolStripMenuItem.Enabled = false;
                durumÇubuğuToolStripMenuItem.Checked = cache;
            }

        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            DialogResult basilan = fd.ShowDialog();
            if(basilan == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }

        private void durumÇubuğuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.WordWrap)
            {
                statusBar.Visible = false;
            }
            else
            {
                statusBar.Visible = durumÇubuğuToolStripMenuItem.Checked;
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }

        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (richTextBox1.SelectedText == String.Empty)
            {
                kesToolStripMenuItem.Enabled = false;
                kesToolStripMenuItem1.Enabled = false;
                kopyalaToolStripMenuItem.Enabled = false;
                kopyalaToolStripMenuItem1.Enabled = false;
                silToolStripMenuItem.Enabled = false;
                gitStripMenuItem6.Enabled = false;
            }
            else
            {
                kesToolStripMenuItem.Enabled = true;
                kesToolStripMenuItem1.Enabled = true;
                kopyalaToolStripMenuItem.Enabled = true;
                kopyalaToolStripMenuItem1.Enabled = true;
                silToolStripMenuItem.Enabled = true;
                gitStripMenuItem6.Enabled = true;
            }
        }

        private void FormTextEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(degisiklikVarmi)
            {
                DialogResult basilan = MessageBox.Show("Kaydedilsin mi?", "Metin Düzenleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (basilan == DialogResult.Yes)
                {
                    farkliKaydet();
                }
            }
        }
        //
        //Veri Aktar
        //
        private void bulStripMenuItem9_Click(object sender, EventArgs e)
        {
            Bul bulForm = new Bul();
            bulForm.VeriAktar(this);
            if(!Bul.On)
                bulForm.Show();
        }
        static public string Search;
        public void AramaYap(bool Case)
        {
            if(Case == false)
            {
                int indis = richTextBox1.Text.IndexOf(Search);
                if (indis == -1)
                    MessageBox.Show(Search + " Bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    int Len = Search.Length;
                    richTextBox1.Select(indis, Len);
                    this.Activate();
                }
            }
            else
            {
                int lowerIndis = richTextBox1.Text.ToLower().IndexOf(Search.ToLower());
                if (lowerIndis == -1)
                    MessageBox.Show( Search+" Bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    int Len = Search.Length;
                    richTextBox1.Select(lowerIndis, Len);
                    this.Activate();
                }
            }
            
        }
        //
    }
}

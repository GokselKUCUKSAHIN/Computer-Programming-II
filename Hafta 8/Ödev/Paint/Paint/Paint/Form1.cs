using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //
            //StartUp Settings
            //
            comboBoxKalinlik.SelectedIndex = 2;
            comboBoxBoyut.SelectedIndex = 0;
            comboBoxGenislik.SelectedIndex = 0;
            PickColor.Color = Color.Black;
            pictureBox1.BackColor = PickColor.Color;
            comboBoxKalinlik.Enabled = false;
            comboBoxBoyut.Visible = false;
            label1.Visible = false;
            radioButton1.Checked = true;
            button1.Enabled = false;
        }
        byte RIndex = 0;
        Color CurrentC = Color.White;

        //
        //Color Dialog Nesnesi
        //
        ColorDialog PickColor = new ColorDialog();
        //
        #region RadioButtons
        //
        //Kalem
        //
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxGenislik.Visible = false;
            label2.Visible = false;
            RIndex = 0;
            comboBoxKalinlik.Enabled = false;
            comboBoxBoyut.Visible = false;
            label1.Visible = false;
            button1.Enabled = false;
        }

        //
        //Çizgi
        //
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxGenislik.Visible = false;
            label2.Visible = false;
            RIndex = 1;
            comboBoxKalinlik.Enabled = true;
            comboBoxBoyut.Visible = false;
            label1.Visible = false;
            button1.Enabled = false;
        }

        //
        //Kare
        //
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxGenislik.Visible = false;
            label2.Visible = false;
            RIndex = 2;
            comboBoxKalinlik.Enabled = true;
            comboBoxBoyut.Visible = true;
            label1.Text = "Boyut";
            label1.Visible = true;
            button1.Enabled = false;
        }

        //
        //Dikdörtgen
        //
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxGenislik.Visible = true;
            label2.Visible = true;
            RIndex = 3;
            comboBoxKalinlik.Enabled = true;
            comboBoxBoyut.Visible = true;
            label1.Text = "Yükseklik";
            label1.Visible = true;
            button1.Enabled = false;
        }

        //
        //Daire
        //
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxGenislik.Visible = false;
            label2.Visible = false;
            RIndex = 4;
            comboBoxKalinlik.Enabled = true;
            comboBoxBoyut.Visible = true;
            label1.Text = "Boyut";
            label1.Visible = true;
            button1.Enabled = false;
        }

        //
        //Elips
        //
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxGenislik.Visible = true;
            label2.Visible = true;
            RIndex = 5;
            comboBoxKalinlik.Enabled = true;
            comboBoxBoyut.Visible = true;
            label1.Text = "Yükseklik";
            label1.Visible = true;
            button1.Enabled = false;
        }

        //
        //Silgi
        //
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxGenislik.Visible = false;
            label2.Visible = false;
            RIndex = 6;
            comboBoxKalinlik.Enabled = false;
            comboBoxBoyut.Visible = true;
            label1.Text = "Boyut";
            label1.Visible = true;
            button1.Enabled = false;
        }

        //
        //Serbest Dörtgen
        //
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            RIndex = 7;
            comboBoxGenislik.Visible = false;
            label2.Visible = false;
            comboBoxKalinlik.Enabled = true;
            comboBoxBoyut.Visible = false;
            label1.Text = "Boyut";
            label1.Visible = false;
            button1.Enabled = false;
        }

        //
        //Spiral
        //
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            RIndex = 8;
            comboBoxGenislik.Visible = false;
            label2.Visible = false;
            comboBoxKalinlik.Enabled = true;
            comboBoxBoyut.Visible = false;
            label1.Visible = false;
            button1.Enabled = true;
        }
        #endregion

        bool Drawable = false;
        Point ilkKonum;
        Point sonKonum;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if(RainBow)
            {
                if(RenkCount == 0)
                {
                    PickColor.Color = Color.FromArgb(255, 148, 0, 211);//Violet
                    RenkCount++;
                }
                else if(RenkCount == 1)
                {
                    PickColor.Color = Color.FromArgb(255, 75, 0, 130);//Indigo
                    RenkCount++;
                }
                else if(RenkCount == 2)
                {
                    PickColor.Color = Color.FromArgb(255, 0, 0, 255);//Blue
                    RenkCount++;
                }
                else if(RenkCount == 3)
                {
                    PickColor.Color = Color.FromArgb(255,0,255,0);//Green
                    RenkCount++;
                }
                else if (RenkCount == 4)
                {
                    PickColor.Color = Color.FromArgb(255,255,255,0);//Yellow
                    RenkCount++;
                }
                else if (RenkCount == 5)
                {
                    PickColor.Color = Color.FromArgb(255,255,127,0);//Orange
                    RenkCount++;
                }
                else if (RenkCount == 6)
                {
                    PickColor.Color = Color.FromArgb(255,255,0,0);//Red
                    RenkCount = 0;
                }
                pictureBox1.BackColor = PickColor.Color;
            }
            Drawable = true;
            if (RIndex == 0) // Kalem
            {
                Pen Kalem = new Pen(PickColor.Color, 3f);
                Graphics cizimAlani = panel1.CreateGraphics();
                cizimAlani.DrawEllipse(Kalem, e.X - 2 , e.Y - 2 , 3,3);
            }
            else if (RIndex == 1) //Çizgi
            {
                ilkKonum.X = e.X;
                ilkKonum.Y = e.Y;
            }
            else if(RIndex == 2) //Kare
            {
                Pen Kalem = new Pen(PickColor.Color, float.Parse(comboBoxKalinlik.SelectedItem.ToString()));
                Graphics cizimAlani = panel1.CreateGraphics();
                int H = int.Parse(comboBoxBoyut.SelectedItem.ToString());
                cizimAlani.DrawRectangle(Kalem, e.X, e.Y, H,H);
            }
            else if(RIndex == 3)//Dikdörtgen
            {
                Pen Kalem = new Pen(PickColor.Color, float.Parse(comboBoxKalinlik.SelectedItem.ToString()));
                Graphics cizimAlani = panel1.CreateGraphics();
                int H = int.Parse(comboBoxBoyut.SelectedItem.ToString());
                int W = int.Parse(comboBoxGenislik.SelectedItem.ToString());
                if(H == W)
                {
                    MessageBox.Show("Madem İkisini de aynı Seçecektin neden Dikdörtgeni Seçtin ?","Neden ???",MessageBoxButtons.OK,MessageBoxIcon.Question);
                }
                else
                {
                    cizimAlani.DrawRectangle(Kalem, e.X, e.Y, W, H);
                }
            }
            else if(RIndex == 4)//Daire
            {
                Pen Kalem = new Pen(PickColor.Color, float.Parse(comboBoxKalinlik.SelectedItem.ToString()));
                Graphics cizimAlani = panel1.CreateGraphics();
                int H = int.Parse(comboBoxBoyut.SelectedItem.ToString());
                cizimAlani.DrawEllipse(Kalem, e.X-(H/2), e.Y-(H/2), H, H);
            }
            else if(RIndex == 5)//Elips
            {
                Pen Kalem = new Pen(PickColor.Color, float.Parse(comboBoxKalinlik.SelectedItem.ToString()));
                Graphics cizimAlani = panel1.CreateGraphics();
                int H = int.Parse(comboBoxBoyut.SelectedItem.ToString());
                int W = int.Parse(comboBoxGenislik.SelectedItem.ToString());
                if (H == W)
                {
                    MessageBox.Show("Madem İkisini de aynı Seçecektin neden Elipsi Seçtin ?", "Neden ???", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    cizimAlani.DrawEllipse(Kalem, e.X - (W / 2), e.Y - (H / 2), W, H);
                }
            }
            else if(RIndex == 6)//Silgi
            {
                int Cvalue = Int32.Parse(comboBoxBoyut.SelectedItem.ToString()) / 5;
                Pen Silgi = new Pen(CurrentC, Cvalue);
                Graphics cizimAlani = panel1.CreateGraphics();
                cizimAlani.DrawRectangle(Silgi, e.X - Cvalue / 2, e.Y - Cvalue / 2, Cvalue, Cvalue);
            }
            else if(RIndex == 7)
            {
                ilkKonum.X = e.X;
                ilkKonum.Y = e.Y;
            }
            else if(RIndex ==8)
            {
                if(!Reset)
                {
                    ilkKonum.X = e.X;
                    ilkKonum.Y = e.Y;
                    Reset = true;
                }
                else
                {
                    sonKonum.X = e.X;
                    sonKonum.Y = e.Y;
                    Pen Kalem = new Pen(PickColor.Color, float.Parse(comboBoxKalinlik.SelectedItem.ToString()));
                    Graphics cizimAlani = panel1.CreateGraphics();
                    cizimAlani.DrawLine(Kalem, ilkKonum, sonKonum);
                }
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Drawable = false;
            sonKonum.X = e.X;
            sonKonum.Y = e.Y;
            if (RIndex == 1) //Çizgi
            {
                Pen Kalem = new Pen(PickColor.Color, float.Parse(comboBoxKalinlik.SelectedItem.ToString()));
                Graphics cizimAlani = panel1.CreateGraphics();
                cizimAlani.DrawLine(Kalem, ilkKonum, sonKonum);
            }
            else if(RIndex == 7)
            {
                Pen Kalem = new Pen(PickColor.Color, float.Parse(comboBoxKalinlik.SelectedItem.ToString()));
                Graphics cizimAlani = panel1.CreateGraphics();
                int fX = ilkKonum.X;
                int fY = ilkKonum.Y;
                int sX = sonKonum.X;
                int sY = sonKonum.Y;
                int H;
                int W;
                if ((fX < sX) && (fY < sY))
                {
                    W = sX - fX;
                    H = sY - fY;
                    cizimAlani.DrawRectangle(Kalem, fX, fY, W, H);
                }
                else if ((fX > sX) && (fY < sY))
                {
                    W = fX - sX;
                    H = sY - fY;
                    cizimAlani.DrawRectangle(Kalem, fX - W, fY, W, H);
                }
                else if ((sX < fX) && (sY < fY)) 
                {
                    W = fX - sX;
                    H = fY - sY;
                    cizimAlani.DrawRectangle(Kalem, sX, sY, W, H);
                }
                else if ((sY < fY) && (fX < sX)) 
                {
                    W = sX - fX;
                    H = fY - sY;
                    cizimAlani.DrawRectangle(Kalem,fX,fY-H,W,H);
                }
            }
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drawable == true)
            {
                if (RIndex == 0) //Kalem
                {
                    Pen Kalem = new Pen(PickColor.Color, 3f);
                    Graphics cizimAlani = panel1.CreateGraphics();
                    cizimAlani.DrawEllipse(Kalem, e.X-2, e.Y-2, 3, 3);
                }
                else if(RIndex == 6) //Silgi
                {
                    //
                    //Converter
                    //
                    int Cvalue = Int32.Parse(comboBoxBoyut.SelectedItem.ToString()) / 5;
                    Pen Silgi = new Pen(CurrentC, Cvalue);
                    Graphics cizimAlani = panel1.CreateGraphics();
                    cizimAlani.DrawRectangle(Silgi, e.X - Cvalue / 2, e.Y - Cvalue / 2, Cvalue, Cvalue);
                }
            }
        }
        private void Temizle_Click(object sender, EventArgs e)
        {
            Reset = false;
            DialogResult Soru = MessageBox.Show("Yapılan Tüm Çizimler Silinmek üzere."+Environment.NewLine+"Devam Etmek İstiyor musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(Soru == DialogResult.Yes)
            {
                DialogResult renkSoru = MessageBox.Show("Arka plan için renk seçmek ister miniz? ", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (renkSoru == DialogResult.No) 
                {
                    Graphics cizimAlani = panel1.CreateGraphics();
                    cizimAlani.Clear(Color.White);
                    CurrentC = Color.White;
                }
                else
                {
                    ColorDialog arkaPlan = new ColorDialog();
                    arkaPlan.Color = Color.Red; //default
                    arkaPlan.ShowDialog();
                    Graphics cizimAlani = panel1.CreateGraphics();
                    cizimAlani.Clear(arkaPlan.Color);
                    CurrentC = arkaPlan.Color;
                }
            }   
        }
        private void ButtonRenkSec_Click(object sender, EventArgs e)
        {
            DialogResult SecilenRenk = PickColor.ShowDialog();
            pictureBox1.BackColor = PickColor.Color;
        }

        //
        //RainBowColor Settings
        //
        int RenkCount = 0;
        bool RainBow = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!RainBow)
            {
                RainBow = true;
                RenkCount = 0;
                ButtonRenkSec.Enabled = false;
            }
            else
            {
                RainBow = false;
                RenkCount = 0;
                ButtonRenkSec.Enabled = true;
                PickColor.Color = Color.Black;
                pictureBox1.BackColor = PickColor.Color;
            }
        }

        //Konum sıfırlama
        bool Reset = false;
        private void button1_Click(object sender, EventArgs e)
        {
            Reset = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
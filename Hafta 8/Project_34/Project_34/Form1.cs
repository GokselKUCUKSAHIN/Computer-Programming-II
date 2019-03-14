using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics cizimAlani = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.DarkBlue, 0.5f);
            cizimAlani.DrawLine(kalem, 50, 60, 100, 145);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics cizimAlani = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.Coral, 5f);
            cizimAlani.DrawEllipse(kalem, 50, 60, 50, 50);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics cizimAlani = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.Cyan, 4f);
            cizimAlani.DrawRectangle(kalem, 100, 170, 90, 60);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString() + "," + e.Y.ToString();
            Graphics cizimAlani = panel2.CreateGraphics();
            Pen kalem = new Pen(Color.Cyan, 4f);
            cizimAlani.DrawRectangle(kalem, e.X, e.Y, 90, 60);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = e.X.ToString() + "," + e.Y.ToString();
            Graphics cizimAlani = panel2.CreateGraphics();
            Pen kalem = new Pen(Color.Coral, 10f);
            cizimAlani.DrawEllipse(kalem, e.X, e.Y, 5, 5);
        }

        Point[] Ucgen = new Point[3];
        Random sayiGen = new Random();
        Color[] renkKutusu = new Color[] { Color.Pink, Color.Coral, Color.Crimson, Color.Magenta, Color.Lime, Color.Cyan, Color.DarkViolet, Color.Beige };

        int counter = 0;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Point nokta = new Point();
            nokta.X = e.X;
            nokta.Y = e.Y;
            Ucgen[counter] = nokta;
            counter++;
            if(counter>2)
            {
                int sec = sayiGen.Next(0, renkKutusu.Length);
                counter = 0;
                Graphics cizimAlani = panel1.CreateGraphics();
                Pen kalem = new Pen (renkKutusu[sec], 3f);
                cizimAlani.DrawLine(kalem, Ucgen[0], Ucgen[1]);
                cizimAlani.DrawLine(kalem, Ucgen[1], Ucgen[2]);
                cizimAlani.DrawLine(kalem, Ucgen[2], Ucgen[0]);
            }
        }

        Point[] Cizgi = new Point[2];
        int sayac = 0;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            Point nokta = new Point();
            nokta.X = e.X;
            nokta.Y = e.Y;
            Cizgi[sayac] = nokta;
            sayac++;
            if (sayac > 1)
            {
                sayac = 0;
                Graphics cizimAlani = panel3.CreateGraphics();
                Pen kalem = new Pen(Color.Crimson, 5f);
                cizimAlani.DrawLine(kalem, Cizgi[0], Cizgi[1]);
            }
        }
    }
}
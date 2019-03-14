using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //SECİLEN TARİHİ AL
            DateTime SecilenTarih = dateTimePicker1.Value;
            int SecilenYil = SecilenTarih.Year;
            DateTime BugununTarihi = DateTime.Now;
            int BuYil = BugununTarihi.Year;
            int yas = BuYil - SecilenYil;
            label1.Text = "YAŞ: " + yas.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_36
{
    public partial class Bul : Form
    {
        public Bul()
        {
            InitializeComponent();
        }
        FormTextEdit frm1 = new FormTextEdit();

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                FormTextEdit.Search = textBox1.Text;
                frm1.Activate();
                frm1.AramaYap(checkBox1.Checked);
            }
            else
                MessageBox.Show("Boş değer!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        public static bool On = false; 
        public void VeriAktar(FormTextEdit frm)
        {
            frm1 = frm;
        }

        private void Bul_FormClosing(object sender, FormClosingEventArgs e)
        {
            On = false;
        }

        private void Bul_Load(object sender, EventArgs e)
        {
            On = true;
        }
    }
}

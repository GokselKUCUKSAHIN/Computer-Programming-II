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
    public partial class Form2 : Form
    {
        Form1 frm1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Odev nasil geri açarız
            frm1.Show();
        }

        public void VeriIlet(Form1 frm)
        {
            frm1 = frm;
        }
    }
}

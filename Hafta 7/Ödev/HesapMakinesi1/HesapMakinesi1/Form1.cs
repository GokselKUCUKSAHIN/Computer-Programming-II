using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi1
{
    public partial class MainForm : Form
    {
        int speed = 50;
        public MainForm()
        {
            InitializeComponent();
            Result.Text = Environment.NewLine + "0";
            TempResult.Text = String.Empty;
            #region Unusedthings
            timer1.Interval = speed;  //RED
            timer2.Interval = speed;  //GREEN
            timer3.Interval = speed;  //BLUE
            timer4.Interval = speed;  //REFRESH
            Std = BackColor;
            #endregion
        }
        //
        //Variables
        //
        double value = 0;
        double tempValue = 0;
        string Operator = String.Empty;
        bool IsOperatorUsed = false;
        bool Done = true;
        bool Koma = true;

        private void PrintNumber(string label)
        {
            if (Result.Text == Environment.NewLine + "0")
            {
                Result.Clear();
                Result.Text = Environment.NewLine;
            }
            if(Done != true)
            {
                ClearResult();
                Result.Text = Environment.NewLine;
                Done = true;
            }
            Result.Text += label;

        }
        private void ClearResult()
        {
            Result.Text = Environment.NewLine + "0";
        }
        private string GetString(string Results) => Double.Parse(Results).ToString();

        #region Number Button Methods
        private void B0_Click(object sender, EventArgs e)
        {
            PrintNumber(B0.Text);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            PrintNumber(B1.Text);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            PrintNumber(B2.Text);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            PrintNumber(B3.Text);
        }

        private void B4_Click(object sender, EventArgs e)
        {
            PrintNumber(B4.Text);
        }

        private void B5_Click(object sender, EventArgs e)
        {
            PrintNumber(B5.Text);
        }

        private void B6_Click(object sender, EventArgs e)
        {
            PrintNumber(B6.Text);
        }

        private void B7_Click(object sender, EventArgs e)
        {
            PrintNumber(B7.Text);
        }

        private void B8_Click(object sender, EventArgs e)
        {
            PrintNumber(B8.Text);
        }

        private void B9_Click(object sender, EventArgs e)
        {
            PrintNumber(B9.Text);
        }
        #endregion

        #region Operator Buttons
        private void BClearEverything_Click(object sender, EventArgs e)
        {
            ClearDel();
        }
        private void BClear_Click(object sender, EventArgs e)
        {
            ClearLine();
        }
        private void BdevidedByOne_Click(object sender, EventArgs e)
        {
            if (Double.Parse(Result.Text) != 0)
            {
                Done = false;
                string temp = (1 / Double.Parse(Result.Text)).ToString();
                TempResult.Text = "1 / " + GetString(Result.Text);
                ClearResult();
                Result.Text = Environment.NewLine;
                Result.Text += temp;
            }
            else
            {
                MessageBox.Show("Geçersiz İşlem" + Environment.NewLine + "Sayı Bölü Sıfır Hatası", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BPlusMinus_Click(object sender, EventArgs e)
        {
            string temp = (Double.Parse(Result.Text) * (-1)).ToString();
            ClearResult();
            Result.Text = Environment.NewLine;
            Result.Text += temp;
        }
        private void BDevide_Click(object sender, EventArgs e)
        {
            Devide();
        }
        private void BTimes_Click(object sender, EventArgs e)
        {
            Times();
        }
        private void BMinus_Click(object sender, EventArgs e)
        {
            Minus();
        }
        private void BPlus_Click(object sender, EventArgs e)
        {
            Plus();
        }
        private void BEquals_Click(object sender, EventArgs e)
        {
            Equals();
        }
        private void Bsqrt_Click(object sender, EventArgs e)
        {
            if (Double.Parse(Result.Text) >= 0)
            {
                Done = false;
                string temp = (Math.Sqrt(Double.Parse(Result.Text))).ToString();
                TempResult.Text = " √( " + GetString(Result.Text) + " ) ";
                ClearResult();
                Result.Text = Environment.NewLine;
                Result.Text += temp;
            }
            else
            {
                MessageBox.Show("Geçersiz İşlem" + Environment.NewLine + "Kök içi Sıfırdan Küçük Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BpowerTwo_Click(object sender, EventArgs e)
        {
            Done = false;
            string temp = (Double.Parse(Result.Text) * Double.Parse(Result.Text)).ToString();
            TempResult.Text = GetString(Result.Text) + " × " + GetString(Result.Text);
            ClearResult();
            Result.Text = Environment.NewLine;
            Result.Text += temp;
        }
        private void Bpercent_Click(object sender, EventArgs e)
        {
            Done = false;
            string temp = (Math.Abs(Double.Parse(Result.Text))).ToString();
            TempResult.Text = " |" + GetString(Result.Text)+ "| ";
            ClearResult();
            Result.Text = Environment.NewLine;
            Result.Text += temp;
        }
        private void BKoma_Click(object sender, EventArgs e)
        {
            KomaChar();
        }
        #endregion

        #region Operator Methods
        private void Equals()
        {
            //TempResult.Text = Double.Parse(Result.Text).ToString();
            if (IsOperatorUsed == true)
            {
                value = Convert.ToDouble(Result.Text);
                ClearResult();
                Result.Text = Environment.NewLine;
                TempResult.Text = String.Empty;
                Done = false;
                Koma = true;
                try
                {
                    switch (Operator)
                    {
                        case "÷":
                            if (value == 0)
                            {
                                MessageBox.Show("Geçersiz İşlem" + Environment.NewLine + "Sayı Bölü Sıfır Hatası", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                value = tempValue / value;
                                Result.Text += value.ToString();
                            }
                            IsOperatorUsed = false;
                            break;
                        case "×":
                            value = tempValue * value;
                            Result.Text += value.ToString();
                            IsOperatorUsed = false;
                            break;
                        case "+":
                            value = tempValue + value;
                            Result.Text += value.ToString();
                            IsOperatorUsed = false;
                            break;
                        case "-":
                            value = tempValue - value;
                            Result.Text += value.ToString();
                            IsOperatorUsed = false;
                            break;
                        default:
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Geçersiz İşlem", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("İşlem yapmadınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #region private void test();
            if (value == 1030522874)
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
                timer3.Enabled = true;
                timer4.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                BackColor = Std;
            }
            #endregion
        }
        private void Plus()
        {
            if (IsOperatorUsed == false)
            {
                Operator = BPlus.Text;
                TempResult.Text = GetString(Result.Text) + " " + Operator + " ";
                tempValue = Double.Parse(Result.Text);
                ClearResult();
                IsOperatorUsed = true;
                Koma = true;
            }
            else if (TempResult.Text != String.Empty)
            {
                Operator = BPlus.Text;
                TempResult.Text = GetString(Result.Text) + " " + Operator + " ";
                tempValue = Double.Parse(Result.Text);
                ClearResult();
                Koma = true;
            }
            else
            {
                MessageBox.Show("İşlem üzerine İşlem yapılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Minus()
        {
            if (IsOperatorUsed == false)
            {
                Operator = BMinus.Text;
                TempResult.Text = GetString(Result.Text) + " " + Operator + " ";
                tempValue = Double.Parse(Result.Text);
                ClearResult();
                IsOperatorUsed = true;
                Koma = true;
            }
            else if (TempResult.Text != String.Empty)
            {
                Operator = BMinus.Text;
                TempResult.Text = GetString(Result.Text) + " " + Operator + " ";
                tempValue = Double.Parse(Result.Text);
                ClearResult();
                Koma = true;
            }
            else
            {
                MessageBox.Show("İşlem üzerine İşlem yapılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void KomaChar()
        {
            if (Koma && Done)
            {
                Result.Text += ",";
                Koma = false;
            }
        }
        private void Times()
        {
            if (IsOperatorUsed == false)
            {
                Operator = BTimes.Text;
                TempResult.Text = GetString(Result.Text) + " " + Operator + " ";
                tempValue = Double.Parse(Result.Text);
                ClearResult();
                IsOperatorUsed = true;
                Koma = true;
            }
            else if (TempResult.Text != String.Empty)
            {
                Operator = BTimes.Text;
                TempResult.Text = GetString(Result.Text) + " " + Operator + " ";
                tempValue = Double.Parse(Result.Text);
                ClearResult();
                Koma = true;
            }
            else
            {
                MessageBox.Show("İşlem üzerine İşlem yapılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Devide()
        {
            if (IsOperatorUsed == false)
            {
                Operator = BDevide.Text;
                TempResult.Text = GetString(Result.Text) + " " + Operator + " ";
                tempValue = Double.Parse(Result.Text);
                ClearResult();
                IsOperatorUsed = true;
                Koma = true;
            }
            else if (TempResult.Text != String.Empty)
            {
                Operator = BDevide.Text;
                TempResult.Text = GetString(Result.Text) + " " + Operator + " ";
                tempValue = Double.Parse(Result.Text);
                ClearResult();
                Koma = true;
            }
            else
            {
                MessageBox.Show("İşlem üzerine İşlem yapılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ClearDel()
        {
            ClearResult();
            TempResult.Text = String.Empty;
            value = 0;
            tempValue = 0;
            Operator = String.Empty;
            IsOperatorUsed = false;
            Koma = true;
        }
        private void ClearLine()
        {
            ClearResult();
            value = 0;
            Koma = true;
        }

        #endregion

        #region April Fools
        int red = 255;
        int green = 255;
        int blue = 0;
        int flag = 0;
        Color Std;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //RED
            if (flag == 2)
            {
                red -= 5;
                if (red <= 0)
                {
                    red = 0;
                    flag = 3;
                }
            }
            else if (flag == 5)
            {
                red += 5;
                if (red >= 255)
                {
                    red = 255;
                    flag = 0;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //GREEN
            if (flag == 0)
            {
                green -= 5;
                if (green <= 0)
                {
                    green = 0;
                    flag = 1;
                }

            }
            else if (flag == 3)
            {
                green += 5;
                if (green >= 255)
                {
                    green = 255;
                    flag = 4;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //BLUE
            if (flag == 1)
            {
                blue += 5;
                if (blue >= 255)
                {
                    blue = 255;
                    flag = 2;
                }
            }
            else if (flag == 4)
            {
                blue -= 5;
                if (blue <= 0)
                {
                    blue = 0;
                    flag = 5;
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //Refresh
            this.BackColor = Color.FromArgb(255, red, green, blue);
        }
        #endregion

        #region Numpad Keys
        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
            {
                PrintNumber(B0.Text);
            }
            else if (e.KeyChar == '1')
            {
                PrintNumber(B1.Text);
            }
            else if (e.KeyChar == '2')
            {
                PrintNumber(B2.Text);
            }
            else if (e.KeyChar == '3')
            {
                PrintNumber(B3.Text);
            }
            else if (e.KeyChar == '4')
            {
                PrintNumber(B4.Text);
            }
            else if (e.KeyChar == '5')
            {
                PrintNumber(B5.Text);
            }
            else if (e.KeyChar == '6')
            {
                PrintNumber(B6.Text);
            }
            else if (e.KeyChar == '7')
            {
                PrintNumber(B7.Text);
            }
            else if (e.KeyChar == '8')
            {
                PrintNumber(B8.Text);
            }
            else if (e.KeyChar == '9')
            {
                PrintNumber(B9.Text);
            }
            else if (e.KeyChar == 13) //Enter
            {
                Equals();
            }
            else if (e.KeyChar == '+')
            {
                Plus();
            }
            else if (e.KeyChar == '-') 
            {
                Minus();
            }
            else if (e.KeyChar == '*')
            {
                Times();
            }
            else if(e.KeyChar == '/')
            {
                Devide();
            }
            else if(e.KeyChar == ',')
            {
                KomaChar();
            }
            else if(e.KeyChar == 8)
            {
                ClearLine();
            }
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ClearDel();
            }
        }
        #endregion
    }
}

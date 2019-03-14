namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonRenkSec = new System.Windows.Forms.Button();
            this.comboBoxKalinlik = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.comboBoxBoyut = new System.Windows.Forms.ComboBox();
            this.comboBoxGenislik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Temizle = new System.Windows.Forms.Button();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(139, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 554);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // ButtonRenkSec
            // 
            this.ButtonRenkSec.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonRenkSec.Location = new System.Drawing.Point(12, 433);
            this.ButtonRenkSec.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.ButtonRenkSec.Name = "ButtonRenkSec";
            this.ButtonRenkSec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonRenkSec.Size = new System.Drawing.Size(78, 34);
            this.ButtonRenkSec.TabIndex = 1;
            this.ButtonRenkSec.TabStop = false;
            this.ButtonRenkSec.Text = "Renk Seç";
            this.ButtonRenkSec.UseVisualStyleBackColor = true;
            this.ButtonRenkSec.Click += new System.EventHandler(this.ButtonRenkSec_Click);
            // 
            // comboBoxKalinlik
            // 
            this.comboBoxKalinlik.FormattingEnabled = true;
            this.comboBoxKalinlik.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "15",
            "20",
            "35",
            "50",
            "1000"});
            this.comboBoxKalinlik.Location = new System.Drawing.Point(12, 499);
            this.comboBoxKalinlik.Name = "comboBoxKalinlik";
            this.comboBoxKalinlik.Size = new System.Drawing.Size(109, 21);
            this.comboBoxKalinlik.TabIndex = 3;
            this.comboBoxKalinlik.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Boyut";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(12, 12);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton1.Size = new System.Drawing.Size(67, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "Kalem";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(12, 45);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton2.Size = new System.Drawing.Size(58, 21);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Çizgi";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(12, 78);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton3.Size = new System.Drawing.Size(55, 21);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "Kare";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(12, 111);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton4.Size = new System.Drawing.Size(98, 21);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.Text = "Dikdörtgen";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(12, 144);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton5.Size = new System.Drawing.Size(60, 21);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.Text = "Daire";
            this.radioButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // comboBoxBoyut
            // 
            this.comboBoxBoyut.FormattingEnabled = true;
            this.comboBoxBoyut.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150"});
            this.comboBoxBoyut.Location = new System.Drawing.Point(12, 330);
            this.comboBoxBoyut.Name = "comboBoxBoyut";
            this.comboBoxBoyut.Size = new System.Drawing.Size(108, 21);
            this.comboBoxBoyut.TabIndex = 6;
            this.comboBoxBoyut.TabStop = false;
            // 
            // comboBoxGenislik
            // 
            this.comboBoxGenislik.FormattingEnabled = true;
            this.comboBoxGenislik.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150"});
            this.comboBoxGenislik.Location = new System.Drawing.Point(12, 379);
            this.comboBoxGenislik.Name = "comboBoxGenislik";
            this.comboBoxGenislik.Size = new System.Drawing.Size(108, 21);
            this.comboBoxGenislik.TabIndex = 6;
            this.comboBoxGenislik.TabStop = false;
            this.comboBoxGenislik.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Genişlik";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kalınlık";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(12, 177);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton6.Size = new System.Drawing.Size(53, 21);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.Text = "Elips";
            this.radioButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(99, 437);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Temizle
            // 
            this.Temizle.BackColor = System.Drawing.Color.Firebrick;
            this.Temizle.FlatAppearance.BorderSize = 0;
            this.Temizle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Temizle.ForeColor = System.Drawing.SystemColors.Control;
            this.Temizle.Location = new System.Drawing.Point(12, 532);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(109, 31);
            this.Temizle.TabIndex = 8;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = false;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(12, 210);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton7.Size = new System.Drawing.Size(50, 21);
            this.radioButton7.TabIndex = 5;
            this.radioButton7.Text = "Silgi";
            this.radioButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(12, 243);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton8.Size = new System.Drawing.Size(121, 21);
            this.radioButton8.TabIndex = 9;
            this.radioButton8.Text = "Özgür Dörtgen";
            this.radioButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 409);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Gök Kuşağı";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton9.Location = new System.Drawing.Point(12, 276);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton9.Size = new System.Drawing.Size(60, 21);
            this.radioButton9.TabIndex = 11;
            this.radioButton9.Text = "Spiral";
            this.radioButton9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 578);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.Temizle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxGenislik);
            this.Controls.Add(this.comboBoxBoyut);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKalinlik);
            this.Controls.Add(this.ButtonRenkSec);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonRenkSec;
        private System.Windows.Forms.ComboBox comboBoxKalinlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.ComboBox comboBoxBoyut;
        private System.Windows.Forms.ComboBox comboBoxGenislik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.Button button1;
    }
}


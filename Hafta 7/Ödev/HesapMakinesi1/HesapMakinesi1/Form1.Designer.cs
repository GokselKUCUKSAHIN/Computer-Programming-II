namespace HesapMakinesi1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.Result = new System.Windows.Forms.TextBox();
            this.BpowerTwo = new System.Windows.Forms.Button();
            this.BdevidedByOne = new System.Windows.Forms.Button();
            this.Bsqrt = new System.Windows.Forms.Button();
            this.Bpercent = new System.Windows.Forms.Button();
            this.TopBar = new System.Windows.Forms.MenuStrip();
            this.BarView = new System.Windows.Forms.ToolStripMenuItem();
            this.BarEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.BarHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BMinus = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.BTimes = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.BDevide = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.BClearEverything = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.BPlus = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.BPlusMinus = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.BKoma = new System.Windows.Forms.Button();
            this.BEquals = new System.Windows.Forms.Button();
            this.TempResult = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.TopBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Result.Location = new System.Drawing.Point(16, 50);
            this.Result.Margin = new System.Windows.Forms.Padding(10);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(312, 94);
            this.Result.TabIndex = 1;
            this.Result.TabStop = false;
            this.Result.Text = "0";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BpowerTwo
            // 
            this.BpowerTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BpowerTwo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BpowerTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BpowerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BpowerTwo.Location = new System.Drawing.Point(172, 6);
            this.BpowerTwo.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.BpowerTwo.Name = "BpowerTwo";
            this.BpowerTwo.Size = new System.Drawing.Size(56, 48);
            this.BpowerTwo.TabIndex = 2;
            this.BpowerTwo.TabStop = false;
            this.BpowerTwo.Text = "x²";
            this.BpowerTwo.UseVisualStyleBackColor = true;
            this.BpowerTwo.Click += new System.EventHandler(this.BpowerTwo_Click);
            // 
            // BdevidedByOne
            // 
            this.BdevidedByOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BdevidedByOne.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BdevidedByOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BdevidedByOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BdevidedByOne.Location = new System.Drawing.Point(252, 6);
            this.BdevidedByOne.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.BdevidedByOne.Name = "BdevidedByOne";
            this.BdevidedByOne.Size = new System.Drawing.Size(56, 48);
            this.BdevidedByOne.TabIndex = 2;
            this.BdevidedByOne.TabStop = false;
            this.BdevidedByOne.Text = "1/x";
            this.BdevidedByOne.UseVisualStyleBackColor = true;
            this.BdevidedByOne.Click += new System.EventHandler(this.BdevidedByOne_Click);
            // 
            // Bsqrt
            // 
            this.Bsqrt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bsqrt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bsqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bsqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bsqrt.Location = new System.Drawing.Point(92, 6);
            this.Bsqrt.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.Bsqrt.Name = "Bsqrt";
            this.Bsqrt.Size = new System.Drawing.Size(56, 48);
            this.Bsqrt.TabIndex = 2;
            this.Bsqrt.TabStop = false;
            this.Bsqrt.Text = "√";
            this.Bsqrt.UseVisualStyleBackColor = true;
            this.Bsqrt.Click += new System.EventHandler(this.Bsqrt_Click);
            // 
            // Bpercent
            // 
            this.Bpercent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bpercent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bpercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bpercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bpercent.Location = new System.Drawing.Point(12, 6);
            this.Bpercent.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.Bpercent.Name = "Bpercent";
            this.Bpercent.Size = new System.Drawing.Size(56, 48);
            this.Bpercent.TabIndex = 2;
            this.Bpercent.TabStop = false;
            this.Bpercent.Text = "Abs";
            this.Bpercent.UseVisualStyleBackColor = true;
            this.Bpercent.Click += new System.EventHandler(this.Bpercent_Click);
            // 
            // TopBar
            // 
            this.TopBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BarView,
            this.BarEdit,
            this.BarHelp});
            this.TopBar.Location = new System.Drawing.Point(6, 6);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(332, 24);
            this.TopBar.TabIndex = 8;
            this.TopBar.Text = "menuStrip1";
            // 
            // BarView
            // 
            this.BarView.Name = "BarView";
            this.BarView.Size = new System.Drawing.Size(44, 20);
            this.BarView.Text = "&View";
            // 
            // BarEdit
            // 
            this.BarEdit.Name = "BarEdit";
            this.BarEdit.Size = new System.Drawing.Size(39, 20);
            this.BarEdit.Text = "&Edit";
            // 
            // BarHelp
            // 
            this.BarHelp.Name = "BarHelp";
            this.BarHelp.Size = new System.Drawing.Size(44, 20);
            this.BarHelp.Text = "&Help";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.BMinus, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.B6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.B5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.B4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BTimes, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.B9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.B8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.B7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BDevide, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Delete, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BClear, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Bsqrt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BdevidedByOne, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BpowerTwo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Bpercent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BClearEverything, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.B1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BPlus, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.B3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.B2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BPlusMinus, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.B0, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.BKoma, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.BEquals, 3, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 154);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 355);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // BMinus
            // 
            this.BMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMinus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BMinus.Location = new System.Drawing.Point(252, 186);
            this.BMinus.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.BMinus.Name = "BMinus";
            this.BMinus.Size = new System.Drawing.Size(56, 48);
            this.BMinus.TabIndex = 14;
            this.BMinus.TabStop = false;
            this.BMinus.Text = "-";
            this.BMinus.UseVisualStyleBackColor = true;
            this.BMinus.Click += new System.EventHandler(this.BMinus_Click);
            // 
            // B6
            // 
            this.B6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B6.Location = new System.Drawing.Point(172, 186);
            this.B6.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(56, 48);
            this.B6.TabIndex = 13;
            this.B6.TabStop = false;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.B6_Click);
            // 
            // B5
            // 
            this.B5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B5.Location = new System.Drawing.Point(92, 186);
            this.B5.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(56, 48);
            this.B5.TabIndex = 12;
            this.B5.TabStop = false;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Click += new System.EventHandler(this.B5_Click);
            // 
            // B4
            // 
            this.B4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B4.Location = new System.Drawing.Point(12, 186);
            this.B4.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(56, 48);
            this.B4.TabIndex = 11;
            this.B4.TabStop = false;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // BTimes
            // 
            this.BTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTimes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTimes.Location = new System.Drawing.Point(252, 126);
            this.BTimes.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.BTimes.Name = "BTimes";
            this.BTimes.Size = new System.Drawing.Size(56, 48);
            this.BTimes.TabIndex = 10;
            this.BTimes.TabStop = false;
            this.BTimes.Text = "×";
            this.BTimes.UseVisualStyleBackColor = true;
            this.BTimes.Click += new System.EventHandler(this.BTimes_Click);
            // 
            // B9
            // 
            this.B9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B9.Location = new System.Drawing.Point(172, 126);
            this.B9.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(56, 48);
            this.B9.TabIndex = 9;
            this.B9.TabStop = false;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Click += new System.EventHandler(this.B9_Click);
            // 
            // B8
            // 
            this.B8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B8.Location = new System.Drawing.Point(92, 126);
            this.B8.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(56, 48);
            this.B8.TabIndex = 8;
            this.B8.TabStop = false;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Click += new System.EventHandler(this.B8_Click);
            // 
            // B7
            // 
            this.B7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B7.Location = new System.Drawing.Point(12, 126);
            this.B7.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(56, 48);
            this.B7.TabIndex = 7;
            this.B7.TabStop = false;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Click += new System.EventHandler(this.B7_Click);
            // 
            // BDevide
            // 
            this.BDevide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BDevide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BDevide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BDevide.Location = new System.Drawing.Point(252, 66);
            this.BDevide.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.BDevide.Name = "BDevide";
            this.BDevide.Size = new System.Drawing.Size(56, 48);
            this.BDevide.TabIndex = 6;
            this.BDevide.TabStop = false;
            this.BDevide.Text = "÷";
            this.BDevide.UseVisualStyleBackColor = true;
            this.BDevide.Click += new System.EventHandler(this.BDevide_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Delete.Enabled = false;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Delete.Location = new System.Drawing.Point(172, 66);
            this.Delete.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(56, 48);
            this.Delete.TabIndex = 5;
            this.Delete.TabStop = false;
            this.Delete.Text = "«";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // BClear
            // 
            this.BClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BClear.Location = new System.Drawing.Point(92, 66);
            this.BClear.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(56, 48);
            this.BClear.TabIndex = 4;
            this.BClear.TabStop = false;
            this.BClear.Text = "C";
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // BClearEverything
            // 
            this.BClearEverything.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BClearEverything.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BClearEverything.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClearEverything.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BClearEverything.Location = new System.Drawing.Point(12, 66);
            this.BClearEverything.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.BClearEverything.Name = "BClearEverything";
            this.BClearEverything.Size = new System.Drawing.Size(56, 48);
            this.BClearEverything.TabIndex = 3;
            this.BClearEverything.TabStop = false;
            this.BClearEverything.Text = "CE";
            this.BClearEverything.UseVisualStyleBackColor = true;
            this.BClearEverything.Click += new System.EventHandler(this.BClearEverything_Click);
            // 
            // B1
            // 
            this.B1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B1.Location = new System.Drawing.Point(12, 246);
            this.B1.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(56, 48);
            this.B1.TabIndex = 16;
            this.B1.TabStop = false;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // BPlus
            // 
            this.BPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BPlus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BPlus.Location = new System.Drawing.Point(252, 246);
            this.BPlus.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.BPlus.Name = "BPlus";
            this.BPlus.Size = new System.Drawing.Size(56, 48);
            this.BPlus.TabIndex = 15;
            this.BPlus.TabStop = false;
            this.BPlus.Text = "+";
            this.BPlus.UseVisualStyleBackColor = true;
            this.BPlus.Click += new System.EventHandler(this.BPlus_Click);
            // 
            // B3
            // 
            this.B3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B3.Location = new System.Drawing.Point(172, 246);
            this.B3.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(56, 48);
            this.B3.TabIndex = 15;
            this.B3.TabStop = false;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // B2
            // 
            this.B2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B2.Location = new System.Drawing.Point(92, 246);
            this.B2.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(56, 48);
            this.B2.TabIndex = 15;
            this.B2.TabStop = false;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // BPlusMinus
            // 
            this.BPlusMinus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BPlusMinus.Location = new System.Drawing.Point(12, 306);
            this.BPlusMinus.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.BPlusMinus.Name = "BPlusMinus";
            this.BPlusMinus.Size = new System.Drawing.Size(56, 48);
            this.BPlusMinus.TabIndex = 15;
            this.BPlusMinus.TabStop = false;
            this.BPlusMinus.Text = "±";
            this.BPlusMinus.UseVisualStyleBackColor = true;
            this.BPlusMinus.Click += new System.EventHandler(this.BPlusMinus_Click);
            // 
            // B0
            // 
            this.B0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B0.Location = new System.Drawing.Point(92, 306);
            this.B0.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(56, 48);
            this.B0.TabIndex = 15;
            this.B0.TabStop = false;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = true;
            this.B0.Click += new System.EventHandler(this.B0_Click);
            // 
            // BKoma
            // 
            this.BKoma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BKoma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BKoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BKoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BKoma.Location = new System.Drawing.Point(172, 306);
            this.BKoma.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.BKoma.Name = "BKoma";
            this.BKoma.Size = new System.Drawing.Size(56, 48);
            this.BKoma.TabIndex = 15;
            this.BKoma.TabStop = false;
            this.BKoma.Text = ",";
            this.BKoma.UseVisualStyleBackColor = true;
            this.BKoma.Click += new System.EventHandler(this.BKoma_Click);
            // 
            // BEquals
            // 
            this.BEquals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BEquals.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BEquals.Location = new System.Drawing.Point(252, 306);
            this.BEquals.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.BEquals.Name = "BEquals";
            this.BEquals.Size = new System.Drawing.Size(56, 48);
            this.BEquals.TabIndex = 15;
            this.BEquals.TabStop = false;
            this.BEquals.Text = "=";
            this.BEquals.UseVisualStyleBackColor = true;
            this.BEquals.Click += new System.EventHandler(this.BEquals_Click);
            // 
            // TempResult
            // 
            this.TempResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TempResult.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TempResult.Location = new System.Drawing.Point(21, 54);
            this.TempResult.Name = "TempResult";
            this.TempResult.Size = new System.Drawing.Size(303, 23);
            this.TempResult.TabIndex = 10;
            this.TempResult.Text = "1234 +";
            this.TempResult.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 521);
            this.Controls.Add(this.TempResult);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.TopBar;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 840);
            this.MinimumSize = new System.Drawing.Size(360, 560);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button BpowerTwo;
        private System.Windows.Forms.Button BdevidedByOne;
        private System.Windows.Forms.Button Bsqrt;
        private System.Windows.Forms.Button Bpercent;
        private System.Windows.Forms.MenuStrip TopBar;
        private System.Windows.Forms.ToolStripMenuItem BarView;
        private System.Windows.Forms.ToolStripMenuItem BarEdit;
        private System.Windows.Forms.ToolStripMenuItem BarHelp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BMinus;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button BTimes;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button BDevide;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.Button BClearEverything;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button BPlus;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button BPlusMinus;
        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Button BKoma;
        private System.Windows.Forms.Button BEquals;
        private System.Windows.Forms.Label TempResult;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}


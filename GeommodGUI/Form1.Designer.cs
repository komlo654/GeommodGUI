namespace GeommodGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.coltrollPointsToDefaultButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bSplineRadioButton = new System.Windows.Forms.RadioButton();
            this.bezierRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.controllPointsShowHandlerButton = new System.Windows.Forms.Button();
            this.gridShowHandlerButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // coltrollPointsToDefaultButton
            // 
            this.coltrollPointsToDefaultButton.Location = new System.Drawing.Point(12, 452);
            this.coltrollPointsToDefaultButton.Name = "coltrollPointsToDefaultButton";
            this.coltrollPointsToDefaultButton.Size = new System.Drawing.Size(131, 23);
            this.coltrollPointsToDefaultButton.TabIndex = 0;
            this.coltrollPointsToDefaultButton.Text = "Alaphelyzet";
            this.coltrollPointsToDefaultButton.UseVisualStyleBackColor = true;
            this.coltrollPointsToDefaultButton.Click += new System.EventHandler(this.coltrollPointsToDefaultButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bSplineRadioButton);
            this.groupBox1.Controls.Add(this.bezierRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Felület kiválasztása";
            // 
            // bSplineRadioButton
            // 
            this.bSplineRadioButton.AutoSize = true;
            this.bSplineRadioButton.Location = new System.Drawing.Point(6, 47);
            this.bSplineRadioButton.Name = "bSplineRadioButton";
            this.bSplineRadioButton.Size = new System.Drawing.Size(68, 19);
            this.bSplineRadioButton.TabIndex = 1;
            this.bSplineRadioButton.TabStop = true;
            this.bSplineRadioButton.Text = "B-spline";
            this.bSplineRadioButton.UseVisualStyleBackColor = true;
            this.bSplineRadioButton.CheckedChanged += new System.EventHandler(this.bSplineRadioButton_CheckedChanged);
            // 
            // bezierRadioButton
            // 
            this.bezierRadioButton.AutoSize = true;
            this.bezierRadioButton.Location = new System.Drawing.Point(6, 22);
            this.bezierRadioButton.Name = "bezierRadioButton";
            this.bezierRadioButton.Size = new System.Drawing.Size(56, 19);
            this.bezierRadioButton.TabIndex = 0;
            this.bezierRadioButton.TabStop = true;
            this.bezierRadioButton.Text = "Bezier";
            this.bezierRadioButton.UseVisualStyleBackColor = true;
            this.bezierRadioButton.CheckedChanged += new System.EventHandler(this.bezierRadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 129);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kontrollpontok megadása";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(142, 67);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(142, 35);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "A Z tengely mentén: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Az X tengely mentén: ";
            // 
            // controllPointsShowHandlerButton
            // 
            this.controllPointsShowHandlerButton.Location = new System.Drawing.Point(149, 452);
            this.controllPointsShowHandlerButton.Name = "controllPointsShowHandlerButton";
            this.controllPointsShowHandlerButton.Size = new System.Drawing.Size(136, 23);
            this.controllPointsShowHandlerButton.TabIndex = 3;
            this.controllPointsShowHandlerButton.Text = "Kontrollpontok: KI";
            this.controllPointsShowHandlerButton.UseVisualStyleBackColor = true;
            this.controllPointsShowHandlerButton.Click += new System.EventHandler(this.controllPointsShowHandlerButton_Click);
            // 
            // gridShowHandlerButton
            // 
            this.gridShowHandlerButton.Location = new System.Drawing.Point(149, 423);
            this.gridShowHandlerButton.Name = "gridShowHandlerButton";
            this.gridShowHandlerButton.Size = new System.Drawing.Size(136, 23);
            this.gridShowHandlerButton.TabIndex = 4;
            this.gridShowHandlerButton.Text = "Kontrollpontháló: KI";
            this.gridShowHandlerButton.UseVisualStyleBackColor = true;
            this.gridShowHandlerButton.Click += new System.EventHandler(this.gridShowHandlerButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(16, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 151);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Funkciók";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "- F: kiválasztott pont mozgatása felfele";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "- L: kiválasztott pont mozgatása lefele";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "- W: kamera mozgatása felfele";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "- S: kamera mozgatása lefele";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "- Fel-le nyilakkal közelítés, távolodás";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "- Jobbra-balra nyilakkal forgatás";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "- Bal egérgomb: pont kiválasztása";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 487);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gridShowHandlerButton);
            this.Controls.Add(this.controllPointsShowHandlerButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.coltrollPointsToDefaultButton);
            this.Name = "Form1";
            this.Text = "Geometriai modellezés";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button coltrollPointsToDefaultButton;
        private GroupBox groupBox1;
        private RadioButton bSplineRadioButton;
        private RadioButton bezierRadioButton;
        private GroupBox groupBox2;
        private Label label1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Button controllPointsShowHandlerButton;
        private Button gridShowHandlerButton;
        private GroupBox groupBox3;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label9;
    }
}
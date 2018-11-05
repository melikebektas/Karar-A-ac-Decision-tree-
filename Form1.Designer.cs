namespace karar_agaci
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbHava = new System.Windows.Forms.ComboBox();
            this.cmbIsi = new System.Windows.Forms.ComboBox();
            this.cmbNem = new System.Windows.Forms.ComboBox();
            this.cmbRüzgar = new System.Windows.Forms.ComboBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.btnEntropi = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAgc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hava:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Isı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rüzgar:";
            // 
            // cmbHava
            // 
            this.cmbHava.FormattingEnabled = true;
            this.cmbHava.Items.AddRange(new object[] {
            "Güneşli",
            "Yağmurlu",
            "Bulutlu"});
            this.cmbHava.Location = new System.Drawing.Point(71, 391);
            this.cmbHava.Name = "cmbHava";
            this.cmbHava.Size = new System.Drawing.Size(121, 21);
            this.cmbHava.TabIndex = 5;
            // 
            // cmbIsi
            // 
            this.cmbIsi.FormattingEnabled = true;
            this.cmbIsi.Items.AddRange(new object[] {
            "Sıcak",
            "Ilık",
            "Soğuk"});
            this.cmbIsi.Location = new System.Drawing.Point(71, 419);
            this.cmbIsi.Name = "cmbIsi";
            this.cmbIsi.Size = new System.Drawing.Size(121, 21);
            this.cmbIsi.TabIndex = 6;
            // 
            // cmbNem
            // 
            this.cmbNem.FormattingEnabled = true;
            this.cmbNem.Items.AddRange(new object[] {
            "Yüksek",
            "Normal"});
            this.cmbNem.Location = new System.Drawing.Point(71, 446);
            this.cmbNem.Name = "cmbNem";
            this.cmbNem.Size = new System.Drawing.Size(121, 21);
            this.cmbNem.TabIndex = 7;
            // 
            // cmbRüzgar
            // 
            this.cmbRüzgar.FormattingEnabled = true;
            this.cmbRüzgar.Items.AddRange(new object[] {
            "Hafif",
            "Kuvvetli"});
            this.cmbRüzgar.Location = new System.Drawing.Point(71, 476);
            this.cmbRüzgar.Name = "cmbRüzgar";
            this.cmbRüzgar.Size = new System.Drawing.Size(121, 21);
            this.cmbRüzgar.TabIndex = 8;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(6, 511);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(197, 41);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Test Et";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 574);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Oyun Sonucu:";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(84, 571);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(119, 20);
            this.txtSonuc.TabIndex = 11;
            // 
            // btnEntropi
            // 
            this.btnEntropi.Location = new System.Drawing.Point(300, 356);
            this.btnEntropi.Name = "btnEntropi";
            this.btnEntropi.Size = new System.Drawing.Size(196, 47);
            this.btnEntropi.TabIndex = 12;
            this.btnEntropi.Text = "Entropi Hesapla";
            this.btnEntropi.UseVisualStyleBackColor = true;
            this.btnEntropi.Click += new System.EventHandler(this.btnEntropi_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(241, 409);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(318, 160);
            this.listBox1.TabIndex = 13;
            // 
            // btnAgc
            // 
            this.btnAgc.Location = new System.Drawing.Point(300, 571);
            this.btnAgc.Name = "btnAgc";
            this.btnAgc.Size = new System.Drawing.Size(196, 42);
            this.btnAgc.TabIndex = 14;
            this.btnAgc.Text = "Karar Ağacı Çiz";
            this.btnAgc.UseVisualStyleBackColor = true;
            this.btnAgc.Click += new System.EventHandler(this.btnAgc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(581, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(681, 647);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 733);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAgc);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEntropi);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.cmbRüzgar);
            this.Controls.Add(this.cmbNem);
            this.Controls.Add(this.cmbIsi);
            this.Controls.Add(this.cmbHava);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbHava;
        private System.Windows.Forms.ComboBox cmbIsi;
        private System.Windows.Forms.ComboBox cmbNem;
        private System.Windows.Forms.ComboBox cmbRüzgar;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button btnEntropi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAgc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


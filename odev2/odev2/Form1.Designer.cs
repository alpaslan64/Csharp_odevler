namespace odev2
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
            this.getir = new System.Windows.Forms.Button();
            this.meslekk = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.burcc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.yass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.postaa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tcc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.soyadd = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ad1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyad1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eposta1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yas1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.burc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meslek1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // getir
            // 
            this.getir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getir.Location = new System.Drawing.Point(105, 436);
            this.getir.Name = "getir";
            this.getir.Size = new System.Drawing.Size(120, 41);
            this.getir.TabIndex = 35;
            this.getir.Text = "Getir";
            this.getir.UseVisualStyleBackColor = false;
            this.getir.Click += new System.EventHandler(this.getir_Click);
            // 
            // meslekk
            // 
            this.meslekk.Location = new System.Drawing.Point(252, 374);
            this.meslekk.Multiline = true;
            this.meslekk.Name = "meslekk";
            this.meslekk.Size = new System.Drawing.Size(151, 32);
            this.meslekk.TabIndex = 34;
            this.meslekk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.meslekk_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(98, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 24);
            this.label10.TabIndex = 33;
            this.label10.Text = "E-Posta";
            // 
            // burcc
            // 
            this.burcc.Location = new System.Drawing.Point(252, 324);
            this.burcc.Multiline = true;
            this.burcc.Name = "burcc";
            this.burcc.Size = new System.Drawing.Size(151, 32);
            this.burcc.TabIndex = 32;
            this.burcc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.burcc_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(98, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "Burç";
            // 
            // yass
            // 
            this.yass.Location = new System.Drawing.Point(252, 271);
            this.yass.Multiline = true;
            this.yass.Name = "yass";
            this.yass.Size = new System.Drawing.Size(151, 32);
            this.yass.TabIndex = 30;
            this.yass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yass_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(98, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "Yaş";
            // 
            // postaa
            // 
            this.postaa.Location = new System.Drawing.Point(252, 211);
            this.postaa.Multiline = true;
            this.postaa.Name = "postaa";
            this.postaa.Size = new System.Drawing.Size(151, 32);
            this.postaa.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(98, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "Meslek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(249, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "ornek@ornek.com";
            // 
            // tcc
            // 
            this.tcc.Location = new System.Drawing.Point(252, 149);
            this.tcc.Multiline = true;
            this.tcc.Name = "tcc";
            this.tcc.Size = new System.Drawing.Size(151, 32);
            this.tcc.TabIndex = 25;
            this.tcc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcc_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(98, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "T.C.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(418, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(252, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ad";
            // 
            // soyadd
            // 
            this.soyadd.Location = new System.Drawing.Point(421, 81);
            this.soyadd.Multiline = true;
            this.soyadd.Name = "soyadd";
            this.soyadd.Size = new System.Drawing.Size(151, 32);
            this.soyadd.TabIndex = 21;
            this.soyadd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyadd_KeyPress);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(252, 81);
            this.add.Multiline = true;
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(151, 32);
            this.add.TabIndex = 20;
            this.add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(101, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kimlik Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Arama Sayfası";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ad1,
            this.soyad1,
            this.tc1,
            this.eposta1,
            this.yas1,
            this.burc1,
            this.meslek1});
            this.dataGridView1.Location = new System.Drawing.Point(231, 421);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(734, 257);
            this.dataGridView1.TabIndex = 36;
            // 
            // ad1
            // 
            this.ad1.HeaderText = "Ad";
            this.ad1.Name = "ad1";
            this.ad1.ReadOnly = true;
            // 
            // soyad1
            // 
            this.soyad1.HeaderText = "Soyad";
            this.soyad1.Name = "soyad1";
            this.soyad1.ReadOnly = true;
            // 
            // tc1
            // 
            this.tc1.HeaderText = "TC";
            this.tc1.Name = "tc1";
            this.tc1.ReadOnly = true;
            // 
            // eposta1
            // 
            this.eposta1.HeaderText = "E-Posta";
            this.eposta1.Name = "eposta1";
            this.eposta1.ReadOnly = true;
            // 
            // yas1
            // 
            this.yas1.HeaderText = "Yaş";
            this.yas1.Name = "yas1";
            this.yas1.ReadOnly = true;
            // 
            // burc1
            // 
            this.burc1.HeaderText = "Burç";
            this.burc1.Name = "burc1";
            this.burc1.ReadOnly = true;
            // 
            // meslek1
            // 
            this.meslek1.HeaderText = "Meslek";
            this.meslek1.Name = "meslek1";
            this.meslek1.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(105, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 49);
            this.button1.TabIndex = 37;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 711);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.getir);
            this.Controls.Add(this.meslekk);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.burcc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.yass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.postaa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tcc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soyadd);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getir;
        private System.Windows.Forms.TextBox meslekk;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox burcc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox yass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox postaa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tcc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soyadd;
        private System.Windows.Forms.TextBox add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyad1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eposta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yas1;
        private System.Windows.Forms.DataGridViewTextBoxColumn burc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn meslek1;
        private System.Windows.Forms.Button button1;
    }
}


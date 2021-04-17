
namespace WinFormsApp11
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
            this.anayemek = new System.Windows.Forms.ComboBox();
            this.anayemekliste = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.yemekadet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.icecekadet = new System.Windows.Forms.TextBox();
            this.corbaadet = new System.Windows.Forms.TextBox();
            this.siparis = new System.Windows.Forms.Button();
            this.tutar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // anayemek
            // 
            this.anayemek.FormattingEnabled = true;
            this.anayemek.Items.AddRange(new object[] {
            "Pizza",
            "Hamburger",
            "Dürüm"});
            this.anayemek.Location = new System.Drawing.Point(126, 12);
            this.anayemek.Name = "anayemek";
            this.anayemek.Size = new System.Drawing.Size(121, 23);
            this.anayemek.TabIndex = 0;
            this.anayemek.SelectedIndexChanged += new System.EventHandler(this.anayemek_SelectedIndexChanged);
            // 
            // anayemekliste
            // 
            this.anayemekliste.FormattingEnabled = true;
            this.anayemekliste.ItemHeight = 15;
            this.anayemekliste.Location = new System.Drawing.Point(279, 12);
            this.anayemekliste.Name = "anayemekliste";
            this.anayemekliste.Size = new System.Drawing.Size(191, 94);
            this.anayemekliste.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ana yemek seçimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "İçecek seçimi";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kola- 4 tl",
            "Ayran- 3 tl",
            "Light Kola- 4 tl",
            "Soda - 2 tl",
            "Su- 1 tl",
            "Meyve Suyu- 4 tl"});
            this.comboBox1.Location = new System.Drawing.Point(127, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Çorba seçimi";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Mercimek - 4 tl",
            "Tarhana- 3 tl",
            "Yoğurt- 4 tl",
            "Tavuk Suyu- 4 tl"});
            this.listBox1.Location = new System.Drawing.Point(127, 223);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 7;
            // 
            // yemekadet
            // 
            this.yemekadet.Location = new System.Drawing.Point(216, 41);
            this.yemekadet.Name = "yemekadet";
            this.yemekadet.Size = new System.Drawing.Size(31, 23);
            this.yemekadet.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adet";
            // 
            // icecekadet
            // 
            this.icecekadet.Location = new System.Drawing.Point(216, 168);
            this.icecekadet.Name = "icecekadet";
            this.icecekadet.Size = new System.Drawing.Size(31, 23);
            this.icecekadet.TabIndex = 12;
            // 
            // corbaadet
            // 
            this.corbaadet.Location = new System.Drawing.Point(216, 325);
            this.corbaadet.Name = "corbaadet";
            this.corbaadet.Size = new System.Drawing.Size(31, 23);
            this.corbaadet.TabIndex = 13;
            // 
            // siparis
            // 
            this.siparis.Location = new System.Drawing.Point(330, 389);
            this.siparis.Name = "siparis";
            this.siparis.Size = new System.Drawing.Size(75, 23);
            this.siparis.TabIndex = 14;
            this.siparis.Text = "Sipariş Ver";
            this.siparis.UseVisualStyleBackColor = true;
            this.siparis.Click += new System.EventHandler(this.siparis_Click);
            // 
            // tutar
            // 
            this.tutar.AutoSize = true;
            this.tutar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tutar.ForeColor = System.Drawing.Color.Red;
            this.tutar.Location = new System.Drawing.Point(519, 394);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(43, 15);
            this.tutar.TabIndex = 15;
            this.tutar.Text = "Tutar : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fiyat : 8 TL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Fiyat : 4 TL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fiyat : 3 TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tutar);
            this.Controls.Add(this.siparis);
            this.Controls.Add(this.corbaadet);
            this.Controls.Add(this.icecekadet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yemekadet);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anayemekliste);
            this.Controls.Add(this.anayemek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox anayemek;
        private System.Windows.Forms.ListBox anayemekliste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox yemekadet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox icecekadet;
        private System.Windows.Forms.TextBox corbaadet;
        private System.Windows.Forms.Button siparis;
        private System.Windows.Forms.Label tutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}


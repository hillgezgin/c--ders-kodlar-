
namespace WinFormsApp18
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
            this.ad = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.vize1 = new System.Windows.Forms.TextBox();
            this.vize2 = new System.Windows.Forms.TextBox();
            this.final = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Adı = new System.Windows.Forms.ColumnHeader();
            this.Soyadı = new System.Windows.Forms.ColumnHeader();
            this.Ders = new System.Windows.Forms.ColumnHeader();
            this.Ortalama = new System.Windows.Forms.ColumnHeader();
            this.hesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(115, 45);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(100, 23);
            this.ad.TabIndex = 0;
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(115, 91);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(100, 23);
            this.soyad.TabIndex = 1;
            // 
            // vize1
            // 
            this.vize1.Location = new System.Drawing.Point(115, 180);
            this.vize1.Name = "vize1";
            this.vize1.Size = new System.Drawing.Size(100, 23);
            this.vize1.TabIndex = 2;
            // 
            // vize2
            // 
            this.vize2.Location = new System.Drawing.Point(115, 224);
            this.vize2.Name = "vize2";
            this.vize2.Size = new System.Drawing.Size(100, 23);
            this.vize2.TabIndex = 3;
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(115, 274);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(100, 23);
            this.final.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fizik",
            "Matematik",
            "Veritabanı",
            "Web Tasarım",
            "Mobil Programlama",
            "Veri Analizi",
            "Türkçe"});
            this.comboBox1.Location = new System.Drawing.Point(115, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adınız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyadınız:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ders Seçimi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vize1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vize2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Final:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Adı,
            this.Soyadı,
            this.Ders,
            this.Ortalama});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(274, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(404, 252);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Adı
            // 
            this.Adı.Text = "ADI";
            this.Adı.Width = 100;
            // 
            // Soyadı
            // 
            this.Soyadı.Text = "SOYADI";
            this.Soyadı.Width = 100;
            // 
            // Ders
            // 
            this.Ders.Text = "DERS";
            this.Ders.Width = 100;
            // 
            // Ortalama
            // 
            this.Ortalama.Text = "ORTALAMA";
            this.Ortalama.Width = 100;
            // 
            // hesapla
            // 
            this.hesapla.Location = new System.Drawing.Point(115, 330);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(100, 23);
            this.hesapla.TabIndex = 13;
            this.hesapla.Text = "Hesapla/Ekle";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 442);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.final);
            this.Controls.Add(this.vize2);
            this.Controls.Add(this.vize1);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox vize1;
        private System.Windows.Forms.TextBox vize2;
        private System.Windows.Forms.TextBox final;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Adı;
        private System.Windows.Forms.ColumnHeader Soyadı;
        private System.Windows.Forms.ColumnHeader Ders;
        private System.Windows.Forms.ColumnHeader Ortalama;
        private System.Windows.Forms.Button hesapla;
    }
}


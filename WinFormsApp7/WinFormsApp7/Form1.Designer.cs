
namespace WinFormsApp7
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
            this.giris = new System.Windows.Forms.Button();
            this.eposta = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.isim = new System.Windows.Forms.Label();
            this.yas = new System.Windows.Forms.Label();
            this.adtext = new System.Windows.Forms.TextBox();
            this.yastext = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.Label();
            this.yas2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.giris.Location = new System.Drawing.Point(169, 181);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(81, 23);
            this.giris.TabIndex = 1;
            this.giris.Text = "Oturum Aç";
            this.giris.UseVisualStyleBackColor = false;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // eposta
            // 
            this.eposta.Location = new System.Drawing.Point(137, 90);
            this.eposta.Name = "eposta";
            this.eposta.Size = new System.Drawing.Size(156, 23);
            this.eposta.TabIndex = 2;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(137, 134);
            this.sifre.MaxLength = 6;
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(156, 23);
            this.sifre.TabIndex = 3;
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isim.ForeColor = System.Drawing.Color.Gray;
            this.isim.Location = new System.Drawing.Point(73, 91);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(63, 17);
            this.isim.TabIndex = 4;
            this.isim.Text = "e-Posta : ";
            // 
            // yas
            // 
            this.yas.AutoSize = true;
            this.yas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yas.ForeColor = System.Drawing.Color.Gray;
            this.yas.Location = new System.Drawing.Point(91, 136);
            this.yas.Name = "yas";
            this.yas.Size = new System.Drawing.Size(41, 17);
            this.yas.TabIndex = 5;
            this.yas.Text = "Şifre :";
            // 
            // adtext
            // 
            this.adtext.Location = new System.Drawing.Point(593, 91);
            this.adtext.Name = "adtext";
            this.adtext.Size = new System.Drawing.Size(151, 23);
            this.adtext.TabIndex = 6;
            // 
            // yastext
            // 
            this.yastext.Location = new System.Drawing.Point(593, 136);
            this.yastext.Name = "yastext";
            this.yastext.Size = new System.Drawing.Size(152, 23);
            this.yastext.TabIndex = 7;
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ad.ForeColor = System.Drawing.Color.Gray;
            this.ad.Location = new System.Drawing.Point(540, 97);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(38, 17);
            this.ad.TabIndex = 8;
            this.ad.Text = "İsim :";
            // 
            // yas2
            // 
            this.yas2.AutoSize = true;
            this.yas2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yas2.ForeColor = System.Drawing.Color.Gray;
            this.yas2.Location = new System.Drawing.Point(540, 143);
            this.yas2.Name = "yas2";
            this.yas2.Size = new System.Drawing.Size(34, 17);
            this.yas2.TabIndex = 9;
            this.yas2.Text = "Yaş :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(639, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // kayit
            // 
            this.kayit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.kayit.Location = new System.Drawing.Point(630, 181);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(75, 23);
            this.kayit.TabIndex = 11;
            this.kayit.Text = "Kayıt Ol";
            this.kayit.UseVisualStyleBackColor = false;
            this.kayit.Click += new System.EventHandler(this.kayit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yas2);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.yastext);
            this.Controls.Add(this.adtext);
            this.Controls.Add(this.yas);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.eposta);
            this.Controls.Add(this.giris);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.TextBox eposta;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.Label yas;
        private System.Windows.Forms.TextBox adtext;
        private System.Windows.Forms.TextBox yastext;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label yas2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kayit;
    }
}


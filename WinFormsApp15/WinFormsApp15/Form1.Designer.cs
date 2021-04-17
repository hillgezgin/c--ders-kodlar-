
namespace WinFormsApp15
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
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sonuctoplam = new System.Windows.Forms.Label();
            this.sonucortalama = new System.Windows.Forms.Label();
            this.islem = new System.Windows.Forms.Button();
            this.temizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(244, 37);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(100, 23);
            this.textbox1.TabIndex = 0;
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(244, 79);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(100, 23);
            this.textbox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sayı 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayı 2:";
            // 
            // sonuctoplam
            // 
            this.sonuctoplam.AutoSize = true;
            this.sonuctoplam.Location = new System.Drawing.Point(150, 188);
            this.sonuctoplam.Name = "sonuctoplam";
            this.sonuctoplam.Size = new System.Drawing.Size(38, 15);
            this.sonuctoplam.TabIndex = 4;
            this.sonuctoplam.Text = "label3";
            // 
            // sonucortalama
            // 
            this.sonucortalama.AutoSize = true;
            this.sonucortalama.Location = new System.Drawing.Point(150, 233);
            this.sonucortalama.Name = "sonucortalama";
            this.sonucortalama.Size = new System.Drawing.Size(38, 15);
            this.sonucortalama.TabIndex = 5;
            this.sonucortalama.Text = "label4";
            // 
            // islem
            // 
            this.islem.Location = new System.Drawing.Point(432, 35);
            this.islem.Name = "islem";
            this.islem.Size = new System.Drawing.Size(75, 23);
            this.islem.TabIndex = 6;
            this.islem.Text = "İşlem";
            this.islem.UseVisualStyleBackColor = true;
            this.islem.Click += new System.EventHandler(this.islem_Click);
            // 
            // temizle
            // 
            this.temizle.Location = new System.Drawing.Point(432, 86);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(75, 23);
            this.temizle.TabIndex = 7;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.temizle);
            this.Controls.Add(this.islem);
            this.Controls.Add(this.sonucortalama);
            this.Controls.Add(this.sonuctoplam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sonuctoplam;
        private System.Windows.Forms.Label sonucortalama;
        private System.Windows.Forms.Button islem;
        private System.Windows.Forms.Button temizle;
    }
}


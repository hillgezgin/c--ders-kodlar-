namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.kydtbtn = new System.Windows.Forms.Button();
            this.kapat = new System.Windows.Forms.Button();
            this.eposta = new System.Windows.Forms.TextBox();
            this.goster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmb = new System.Windows.Forms.TextBox();
            this.eklebtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.saybtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(644, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mesaj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kydtbtn
            // 
            this.kydtbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kydtbtn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kydtbtn.Location = new System.Drawing.Point(644, 287);
            this.kydtbtn.Name = "kydtbtn";
            this.kydtbtn.Size = new System.Drawing.Size(127, 38);
            this.kydtbtn.TabIndex = 0;
            this.kydtbtn.Text = "Kaydet";
            this.kydtbtn.UseVisualStyleBackColor = false;
            this.kydtbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // kapat
            // 
            this.kapat.Location = new System.Drawing.Point(656, 218);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(75, 23);
            this.kapat.TabIndex = 1;
            this.kapat.Text = "Kapat";
            this.kapat.UseVisualStyleBackColor = true;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // eposta
            // 
            this.eposta.Location = new System.Drawing.Point(656, 57);
            this.eposta.Multiline = true;
            this.eposta.Name = "eposta";
            this.eposta.Size = new System.Drawing.Size(120, 20);
            this.eposta.TabIndex = 2;
            // 
            // goster
            // 
            this.goster.Location = new System.Drawing.Point(701, 96);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(75, 23);
            this.goster.TabIndex = 3;
            this.goster.Text = "Kayıt Ol";
            this.goster.UseVisualStyleBackColor = true;
            this.goster.Click += new System.EventHandler(this.goster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(622, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yaş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // cmb
            // 
            this.cmb.Location = new System.Drawing.Point(38, 39);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(100, 20);
            this.cmb.TabIndex = 7;
            // 
            // eklebtn
            // 
            this.eklebtn.Location = new System.Drawing.Point(144, 39);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(62, 23);
            this.eklebtn.TabIndex = 8;
            this.eklebtn.Text = "Ekle";
            this.eklebtn.UseVisualStyleBackColor = true;
            this.eklebtn.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.Location = new System.Drawing.Point(212, 39);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(67, 23);
            this.silbtn.TabIndex = 9;
            this.silbtn.Text = "Sil";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // saybtn
            // 
            this.saybtn.Location = new System.Drawing.Point(212, 91);
            this.saybtn.Name = "saybtn";
            this.saybtn.Size = new System.Drawing.Size(67, 23);
            this.saybtn.TabIndex = 10;
            this.saybtn.Text = "Say";
            this.saybtn.UseVisualStyleBackColor = true;
            this.saybtn.Click += new System.EventHandler(this.saybtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(302, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(443, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.saybtn);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.eklebtn);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goster);
            this.Controls.Add(this.eposta);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.kydtbtn);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button kydtbtn;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.TextBox eposta;
        private System.Windows.Forms.Button goster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox cmb;
        private System.Windows.Forms.Button eklebtn;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.Button saybtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
    }
}


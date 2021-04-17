
namespace WinFormsApp4
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
            this.tikla = new System.Windows.Forms.Button();
            this.degistir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tikla
            // 
            this.tikla.BackColor = System.Drawing.Color.DarkGray;
            this.tikla.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tikla.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tikla.Location = new System.Drawing.Point(95, 73);
            this.tikla.Name = "tikla";
            this.tikla.Size = new System.Drawing.Size(120, 49);
            this.tikla.TabIndex = 0;
            this.tikla.Text = "Tıkla";
            this.tikla.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tikla.UseVisualStyleBackColor = false;
            this.tikla.Click += new System.EventHandler(this.tikla_Click);
            // 
            // degistir
            // 
            this.degistir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.degistir.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.degistir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.degistir.Location = new System.Drawing.Point(262, 73);
            this.degistir.Name = "degistir";
            this.degistir.Size = new System.Drawing.Size(120, 49);
            this.degistir.TabIndex = 1;
            this.degistir.Text = "Değiştir";
            this.degistir.UseVisualStyleBackColor = false;
            this.degistir.Click += new System.EventHandler(this.degistir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.degistir);
            this.Controls.Add(this.tikla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tikla;
        private System.Windows.Forms.Button degistir;
    }
}


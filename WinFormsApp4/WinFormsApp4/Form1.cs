using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tikla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaydetmek istiyor musunuz?","Uyarı",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
        }

        private void degistir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Değiştir butonuna tıkladın!","Bilgi",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
        }
    }
}

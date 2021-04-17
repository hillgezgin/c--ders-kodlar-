using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int sonuc,s1,s2= 0;
            s1 = Convert.ToInt32(textBox1.Text);
            s2= Convert.ToInt32(textBox2.Text);
            sonuc = s1 + s2;
            label2.Text = sonuc.ToString();
        }
    }
}

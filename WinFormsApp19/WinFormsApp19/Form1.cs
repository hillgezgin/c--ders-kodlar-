using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sepet alisveris = new sepet();
            gida zeytinyagi = new gida("Tariş", 100, "doğal zeytinyağı", 1000);  
            elektronik ceptelefonu = new elektronik("galaxy", 3000, "samsung");
            tekstil elbise = new tekstil("elbise", 120, 38, "LCW");

            alisveris.Ekle(zeytinyagi);
            alisveris.Ekle(ceptelefonu);
            alisveris.Ekle(elbise);
            MessageBox.Show(alisveris.ToplamTutar().ToString());
        }
    }
}

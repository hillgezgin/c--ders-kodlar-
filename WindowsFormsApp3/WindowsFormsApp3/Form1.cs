using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Bursa");
            comboBox1.Items.Add("Erzurum");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // comboBox1.Items.Clear();
           
            comboBox1.Items.RemoveAt(0);
            string a = comboBox1.Items.Count.ToString();
            MessageBox.Show(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem.ToString();
        }

        private void listeyeekle_Click(object sender, EventArgs e)
        {
            // listBox1.Items.Add("Hilal");
            string isim = listBox1.SelectedItem.ToString();
            MessageBox.Show(isim);
        }
    }
}

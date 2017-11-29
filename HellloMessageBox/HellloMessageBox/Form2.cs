using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HellloMessageBox
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 f)
        {
            InitializeComponent();
            this.label1.Text += f.TextBox1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Hi");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            //f1.Show();
            //this.Hide();
            Form1 f2 = new Form1(this);
            f2.Show();
            this.Hide();
        }

        public string BackText
        {
            get => textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

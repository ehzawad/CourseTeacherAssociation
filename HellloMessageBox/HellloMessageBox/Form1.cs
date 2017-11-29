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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Form2 f2)
        {
            InitializeComponent();
            this.label1.Text += f2.BackText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Disagree_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
            this.Hide();
        }

        public string TextBox1
        {
            
            get => textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

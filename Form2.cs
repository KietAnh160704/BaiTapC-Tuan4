using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBTTuan4
{
    public partial class Form2 : Form
    {
        public string MSNV {  get; set; }
        public string Ten {  get; set; }
        public string Luong { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = MSNV;
            textBox2.Text = Ten;
            textBox3.Text = Luong;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             MSNV = textBox1.Text;
             Ten = textBox2.Text;
             Luong = textBox3.Text;
             this.DialogResult = DialogResult.OK;
             this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

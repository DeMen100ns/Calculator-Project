using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ope2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Number1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Number2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ope3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Number1.Text == "")
            {
                MessageBox.Show("Hãy nhập số thứ nhất", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Number1.Focus();
                return;
            }
            if (Number2.Text == "")
            {
                MessageBox.Show("Hãy nhập số thứ hai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Number2.Focus();
                return;
            }
            double a = double.Parse(Number1.Text);
            double b = double.Parse(Number2.Text);
            double c = a * b;
            Result.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Number1.Text == "")
            {
                MessageBox.Show("Hãy nhập số thứ nhất", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Number1.Focus();
                return;
            }
            if (Number2.Text == "")
            {
                MessageBox.Show("Hãy nhập số thứ hai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Number2.Focus();
                return;
            }
            double a = double.Parse(Number1.Text);
            double b = double.Parse(Number2.Text);
            if (b == 0)
            {
                MessageBox.Show("Mẫu số phải khác 0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Number2.Focus();
            } else
            {
                double c = a / b;
                Result.Text = c.ToString();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (Number1.Text == "")
            {
                MessageBox.Show("Hãy nhập số thứ nhất", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Number1.Focus();
                return;
            }
            if (Number2.Text == "")
            {
                MessageBox.Show("Hãy nhập số thứ hai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Number2.Focus();
                return;
            }
            double a = double.Parse(Number1.Text);
            double b = double.Parse(Number2.Text);
            double c = a - b;
            Result.Text = c.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Number1.Text == "")
            {
                MessageBox.Show("Hãy nhập số thứ nhất", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Number1.Focus();
                return;
            }
            if (Number2.Text == "")
            {
                MessageBox.Show("Hãy nhập số thứ hai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Number2.Focus();
                return;
            }
            double a = double.Parse(Number1.Text);
            double b = double.Parse(Number2.Text);
            double c = a + b;
            Result.Text = c.ToString();
        }

        private void Number1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = Number1.Text;
            bool f = true;
            foreach (char i in s)
            {
                if (i == '.') f = false;
            }
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == '.' && f) || e.KeyChar == 'e' || e.KeyChar == 'E')
            {
                e.Handled = false;
            }
            else e.Handled = true; 
        }

        private void Number2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = Number2.Text;
            bool f = true;
            foreach (char i in s)
            {
                if (i == '.') f = false;
            }
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == '.' && f) || e.KeyChar == 'e' || e.KeyChar == 'E')
            {
                e.Handled = false;
            }
            else e.Handled = true;
            if (e.Handled) MessageBox.Show("true");
            else MessageBox.Show("false");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

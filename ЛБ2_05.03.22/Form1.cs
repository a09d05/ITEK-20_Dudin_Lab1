using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛБ2_05._03._22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // сложение
        {
            int a, b;
            a = Int32.Parse(textBox1.Text);
            b = Int32.Parse(textBox2.Text);

            int c = a + b;
            textBox3.Text = c.ToString();
            label5.Text = "Сложение";
        }

        private void button2_Click(object sender, EventArgs e) // вычитание
        {
            int a, b;
            a = Int32.Parse(textBox1.Text);
            b = Int32.Parse(textBox2.Text);

            int c = a - b;
            textBox3.Text = c.ToString();
            label5.Text = "Вычитание";
        }

        private void button3_Click(object sender, EventArgs e) // умножение 
        {
            int a, b;
            a = Int32.Parse(textBox1.Text);
            b = Int32.Parse(textBox2.Text);

            int c = a * b;
            textBox3.Text = c.ToString();
            label5.Text = "Умножение";
        }

        private void button4_Click(object sender, EventArgs e) // деление
        {
            int a, b;
            a = Int32.Parse(textBox1.Text);
            b = Int32.Parse(textBox2.Text);

            if(b != 0)
            {
                int c = a / b;
                textBox3.Text = c.ToString();
                label5.Text = "Деление";
            }
            else 
            {
                textBox3.Text = " ";
                label5.Text = "Делить на 0 нельзя!";
            }
        }
    }
}

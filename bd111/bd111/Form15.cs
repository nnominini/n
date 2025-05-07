using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bd111
{
    public partial class Form15 : Form
    {
        public Form15(string totalAmount)
        {
            InitializeComponent();
            textBox4.Text = totalAmount;  // textBox4-д үнэ оноох
        }

        public Form15()  // default constructor хэрэгтэй бол
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }




        private void tuluh2_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox11.Text) || string.IsNullOrWhiteSpace(textBox12.Text) ||
                string.IsNullOrWhiteSpace(textBox13.Text) || string.IsNullOrWhiteSpace(textBox14.Text) ||
                string.IsNullOrWhiteSpace(textBox16.Text) || string.IsNullOrWhiteSpace(textBox17.Text))
            {
                
                MessageBox.Show("Бүх талбарыг бөглөнө үү!", "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               

                DialogResult dialog = MessageBox.Show("Таны захиалга амжилттай баталгаажлаа!", "Амжилттай", MessageBoxButtons.OK);

                if (dialog == DialogResult.OK)
                {
                  
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
            }
        }

        private void butsah8_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();   // Form2-ийг дуудаж байна
            form6.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }
    }
}



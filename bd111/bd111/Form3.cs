using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd111
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void zuult3_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();   // Form2-ийг дуудаж байна
            form2.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();                 // Хуучин form-ыг нууж байна (хүсвэл)
        }

        private void buguivch3_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();   // Form2-ийг дуудаж байна
            form2.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void bugj3_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4();   // Form2-ийг дуудаж байна
            form4.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void eemeg3_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();   // Form2-ийг дуудаж байна
            form2.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void aboutus3_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();   // Form2-ийг дуудаж байна
            form3.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void zuult3_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buguivch3_Click_1(object sender, EventArgs e)
        {

        }

        private void bugj3_Click_1(object sender, EventArgs e)
        {

        }

        private void eemeg3_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide();
        }
    }
}

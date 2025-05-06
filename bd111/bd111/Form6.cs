using System.Windows.Forms;
using System;

namespace bd111
{
    public partial class Form6 : Form
    {
        private decimal basePrice = 110.00m; // Үндсэн үнэ

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Анх label52-д үндсэн үнийг харуулах
            label52.Text = $"{basePrice:0.00}$";
            numericUpDown1.Value = 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal quantity = numericUpDown1.Value;           // сонгосон тоо
            decimal totalPrice = basePrice * quantity;         // нийт үнэ = үндсэн үнэ * тоо
            label52.Text = $"{totalPrice:0.00}$";              // label52 дээр шинэ үнэ харуулах
        }
   

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void zuult_Click(object sender, EventArgs e)
        {

        }

        private void eemeg6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();   // Form2-ийг дуудаж байна
            form2.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void bugj6_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4();   // Form2-ийг дуудаж байна
            form4.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void butsah6_Click(object sender, EventArgs e)
        {
            FormManager.GoBack(this);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void acc6_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide();
        }

       
    }
}

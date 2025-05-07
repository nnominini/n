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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void zuult_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();   // Form2-ийг дуудаж байна
            form2.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();                 // Хуучин form-ыг нууж байна (хүсвэл)
        }

        private void buguivch_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();   // Form2-ийг дуудаж байна
            form2.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void bugj_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void eemeg_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();   // Form2-ийг дуудаж байна
            form2.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void aboutus_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();   // Form2-ийг дуудаж байна
            form3.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }
        private void panel20_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            FormManager.OpenForm(this, form6);
        }

        private void panel19_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            FormManager.OpenForm(this, form6);
        }

        private void ehleh_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            FormManager.OpenForm(this, form7);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void acc1_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            FormManager.OpenForm(this, form11);
        }

        private void fav10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Амжилттай хадгалагдлаа!");
        }


        private void fav3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Амжилттай хадгалагдлаа!");
        }

        private void fav4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Амжилттай хадгалагдлаа!");
        }

        private void fav5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Амжилттай хадгалагдлаа!");
        }

        private void fav6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Амжилттай хадгалагдлаа!");
        }

        private void fav7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Амжилттай хадгалагдлаа!");
        }

        private void fav8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Амжилттай хадгалагдлаа!");
        }

        private void fav9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Амжилттай хадгалагдлаа!");
        }

        private void fav1_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
            this.Hide();
        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

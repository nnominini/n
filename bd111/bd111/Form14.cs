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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void zuult10_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();   // Form2-ийг дуудаж байна
            form2.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void buguivch10_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();   // Form2-ийг дуудаж байна
            form2.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void bugj10_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();   // Form2-ийг дуудаж байна
            form2.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void eemeg10_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();   // Form2-ийг дуудаж байна
            form2.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();   // Form2-ийг дуудаж байна
            form1.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            FormManager.OpenForm(this, form11);
        }
    }
}

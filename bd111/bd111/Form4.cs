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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void zuult2_Click(object sender, EventArgs e)
        {

        }

        private void aboutus4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();   // Form2-ийг дуудаж байна
            form3.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void eemeg4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();   // Form2-ийг дуудаж байна
            form2.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void acc4_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide();
        }
    }
}

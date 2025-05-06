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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            FormManager.OpenForm(this, form9);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            FormManager.OpenForm(this, form9);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            FormManager.OpenForm(this, form9);
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

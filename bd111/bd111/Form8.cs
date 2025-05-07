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
            FormSelectionTracker.Selection8 = "B1";
            Form9 form9 = new Form9();
            FormManager.OpenForm(this, form9);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSelectionTracker.Selection8 = "B2";
            Form9 form9 = new Form9();
            FormManager.OpenForm(this, form9);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSelectionTracker.Selection8 = "B2";
            Form9 form9 = new Form9();
            FormManager.OpenForm(this, form9); ;
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
            FormManager.OpenForm(this, form11);
        }

        private void zuult8_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();   
            form4.Show();               
            this.Hide();
        }

        private void buguivch6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); 
            form2.Show();             
            this.Hide();
        }

        private void bugj6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();   
            form2.Show();               
            this.Hide();
        }

        private void eemeg6_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormSelectionTracker.Selection8 = "B2";
            Form9 form9 = new Form9();
            FormManager.OpenForm(this, form9);
        }

        private void fav6_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
            this.Hide();
        }
    }
}

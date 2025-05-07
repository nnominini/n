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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void butsah7_Click(object sender, EventArgs e)
        {
            FormManager.GoBack(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSelectionTracker.Selection7 = "B1";
            Form8 form8 = new Form8();
            FormManager.OpenForm(this, form8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSelectionTracker.Selection7 = "B2";
            Form8 form8 = new Form8();
            FormManager.OpenForm(this, form8);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            FormSelectionTracker.Selection7 = "B2";
            Form8 form8 = new Form8();
            FormManager.OpenForm(this, form8);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormSelectionTracker.Selection7 = "B2";
            Form8 form8 = new Form8();
            FormManager.OpenForm(this, form8);
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

        private void zuult6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  
            form2.Show();               
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
            Form2 form2 = new Form2();  
            form2.Show();                
            this.Hide();
        }

        private void fav6_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
            this.Hide();
        }
    }
}

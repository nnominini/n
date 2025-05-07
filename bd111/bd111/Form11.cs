using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd111
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void acc6_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            FormManager.OpenForm(this, form11);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            FormManager.OpenForm(this, form1); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string text1 = textBox1.Text;
            string text3 = textBox3.Text;
            string text4 = textBox4.Text;
            string text5 = textBox5.Text;
            string text6 = textBox6.Text;
            string text7 = textBox7.Text;

     
            string savedText = $"Textbox1: {text1}\nTextbox3: {text3}\nTextbox4: {text4}\nTextbox5: {text5}\nTextbox6: {text6}\nTextbox7: {text7}";

         
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\example_output.txt";
            File.WriteAllText(filePath, savedText);

            MessageBox.Show("Мэдээлэл амжилттай хадгалагдлаа!", "Амжилттай", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void textBox4_TextChanged(object sender, EventArgs e) { }

        private void textBox5_TextChanged(object sender, EventArgs e) { }

        private void textBox6_TextChanged(object sender, EventArgs e) { }

        private void textBox7_TextChanged(object sender, EventArgs e) { }

        private void butsah6_Click(object sender, EventArgs e)
        {
            FormManager.GoBack(this);
        }

        private void zuult6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();   // Form2-ийг дуудаж байна
            form2.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void buguivch6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();   // Form2-ийг дуудаж байна
            form2.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void bugj6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();   // Form2-ийг дуудаж байна
            form2.Show();                // Шинэ цонх (form) нээж байна
            this.Hide();
        }

        private void eemeg6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();   // Form2-ийг дуудаж байна
            form2.Show();                // Шинэ цонх (form) нээж байна
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

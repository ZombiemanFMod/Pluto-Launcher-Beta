using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pluto_Login_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormClosed += (s, args) => this.Show(); // Show Form1 again when Form2 is closed
            this.Hide(); // Hide Form1
            form2.Show(); // Show Form2
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.FormClosed += (s, args) => this.Show(); // Show Form1 when Form3 is closed
            this.Hide(); // Hide Form1
            form3.Show(); // Show Form3
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string text1 = textBox1.Text.Trim();
                string text2 = textBox2.Text.Trim();

                if (!string.IsNullOrEmpty(text1) && !string.IsNullOrEmpty(text2))
                {
                    string filePath = "output.txt";
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine($"Text from textBox1: {text1}");
                        writer.WriteLine($"Text from textBox2: {text2}");
                    }
                    MessageBox.Show("Daten wurden gespeichert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bitte füllen Sie beide Textfelder aus.", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    checkBox1.Checked = false; // Uncheck the checkbox
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text.Trim();
            string text2 = textBox2.Text.Trim();

            if (!string.IsNullOrEmpty(text1) && !string.IsNullOrEmpty(text2))
            {
                string filePath = "output.txt";
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"Text from textBox1: {text1}");
                    writer.WriteLine($"Text from textBox2: {text2}");
                }
                MessageBox.Show("Daten wurden gespeichert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bitte füllen Sie beide Textfelder aus.", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBox1.Checked = false; // Uncheck the checkbox
            }
    }
}
}


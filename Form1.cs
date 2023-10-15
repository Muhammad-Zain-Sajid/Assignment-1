using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bcsf20a039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] subjects = { "data structures", "operating system", "economics", "compiler construction" };
            comboBox1.Items.AddRange(subjects);
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string selectedSubject =comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "";
            bool prerequisiteClear = checkBox1.Checked;

            firstName = Regex.Replace(firstName, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);
            lastName = Regex.Replace(lastName, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);


            string result =firstName+" " + lastName +
                            " is successfully enrolled in " + selectedSubject + Environment.NewLine +
                            "Prerequisite Clear: " + prerequisiteClear;


            label3.Text = result;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

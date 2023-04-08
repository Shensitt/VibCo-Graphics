using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        public static int form_height;
        public static int form_width;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            if (textBox2.Text == "" && textBox3.Text == "")
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            if (textBox3.Text == "" && textBox2.Text == "")
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                form_height = 240;
                form_width = 320;
            }
            if (checkBox2.Checked)
            {
                form_height = 480;
                form_width = 640;
            }
            if (checkBox3.Checked)
            {
                form_height = 600;
                form_width = 800;
            }
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                form_height = Convert.ToInt32(textBox3.Text);
                form_width = Convert.ToInt32(textBox2.Text);
            }
            Form1.form_height = form_height;
            Form1.form_width = form_width;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
            }
        }
    }
}

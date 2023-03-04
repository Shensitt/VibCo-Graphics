using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            //checkBox1.Checked = Form2.IsFill;
            InitializeComponent();
        }
        public static int figure_selected = 0;
        public int selected;
        public static bool IsFill = false;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = listBox1.SelectedIndex;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                IsFill = true;
            }
            else
            {
                IsFill = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            figure_selected = selected;
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

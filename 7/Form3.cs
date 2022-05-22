using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }





        public int pen_width;
        public void button1_Click(object sender, EventArgs e)
        {

            string selectedItem = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            pen_width = Convert.ToInt32(selectedItem);
            Form2.pen_wid = pen_width;
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}

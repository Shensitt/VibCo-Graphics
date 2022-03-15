using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //public class Posit
//        {
//            public int CursorX;
//            public int CursorY;

//        }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
      

        public void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.MdiParent = this;
            f.Text = "Picture " + this.MdiChildren.Length.ToString();
            f.Show();

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
               
                int CursorX1 = e.X;
               int   CursorY1 = e.Y;

                string s = CursorX1.ToString();
                string s1 = CursorY1.ToString();

                string ss = "x= " + s + ", y= " + s1;
                g.DrawString(ss, new Font("Times New Roman", 8), new SolidBrush(Color.Black), new Point(CursorX1, CursorY1));

            }

            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Cleaning...", "Right mouse button is down");
                g.Clear(Color.White);
            }

        }
    } 
}


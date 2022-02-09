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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)     //cursor pos and clean func(lab 1)
        {
            Graphics g = CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                int CursorX = Cursor.Position.X;
                int CursorY = Cursor.Position.Y;

                string s = CursorX.ToString();
                string s1 = CursorY.ToString();

                string ss = s + "," + s1;
                g.DrawString(ss, new Font("Times New Roman", 8), new SolidBrush(Color.Black), new Point(CursorX, CursorY));

            }

            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Cleaning...","Right mouse button is down");
                g.Clear(Color.White);
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.MdiParent = this;
            f.Text = "Рисунок " + this.MdiChildren.Length.ToString();
            f.Show();
        }

        // MenuStrip MainMenu = new MenuStrip();


    } 
}


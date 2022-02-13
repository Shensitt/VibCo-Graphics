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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_MouseDown(object sender, MouseEventArgs e)     //cursor pos and clean func(lab 1)
        {
            Var d = new Var();
            Graphics g = CreateGraphics();

            if (e.Button == MouseButtons.Left)
            {
                d.picture = true;
                d.begin_x = e.X;
                d.begin_y = e.Y;
                d.location_x = e.X;
                d.location_y = e.Y;
                Rectangle r = Rectangle.FromLTRB(d.begin_x, d.begin_y, d.location_x, d.location_y);
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)    
        {
            Graphics g = CreateGraphics();
            Var d = new Var();
            if (d.clear == true)
            {
                Rectangle r = Rectangle.FromLTRB(d.left_x, d.left_y, d.right_x, d.right_y);
                g.DrawRectangle(new Pen(Color.White, 1), r);
                d.clear = false;
            }
            if (d.picture == true)
            {
                d.location_x = e.X;
                d.location_y = e.Y;
                if (d.begin_x < d.location_x && d.begin_y < d.location_y)
                {
                    d.begin_x = d.left_x;
                    d.begin_y = d.left_y;
                    d.right_x = d.location_x;
                    d.right_y = d.location_y;
                }
                else if (d.begin_x > d.location_x && d.begin_y > d.location_y)
                {
                    d.begin_x = d.location_x;
                    d.begin_y = d.location_y;
                    d.right_x = d.left_x;
                    d.right_y = d.left_y;
                }
                Pen pen = new Pen(Color.Black, 1);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                Rectangle rect = Rectangle.FromLTRB(d.left_x, d.left_y, d.right_x, d.right_y);
                g.DrawRectangle(pen, rect);
            }
        }
        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            Var d = new Var();
            if (d.picture == true)
            {

                Pen pen = new Pen(Color.White, 1);
                Rectangle r = Rectangle.FromLTRB(d.left_x, d.left_y, d.right_x, d.right_y);
                g.DrawRectangle(new Pen(Color.Black, 1), r);
                d.picture = false;
                d.clear = true;
                pen.Dispose();

            }
        }
        public class Var
        {
            public int begin_x;
            public int begin_y;
            public int left_x;
            public int left_y;
            public int location_x;
            public int location_y;
            public int right_x;
            public int right_y;
            public bool picture;    // Флаг рисования
            public bool clear;
        }
    }
    
}

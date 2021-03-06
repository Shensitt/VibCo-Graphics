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
        bool draw_frag;
        int CursorX0;
        int CursorY0;
        int CursorX1;
        int CursorY1;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                draw_frag = true;
                int cycle_begin_num_off = 0;
                if (cycle_begin_num_off == 0)
                {
                    CursorX0 = e.X;
                    CursorY0 = e.Y;
                }
             //  CursorX1 =e.X;
              //  CursorY1 = e.Y ;

                //string s = CursorX1.ToString();
                //string s1 = CursorY1.ToString();

                //string ss = "x= "+s + ", y= " + s1;
                //g.DrawString(ss, new Font("Times New Roman", 8), new SolidBrush(Color.Black), new Point(CursorX1, CursorY1));

            }

            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Cleaning...","Right mouse button is down");
                g.Clear(Color.White);
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           CursorX1 =e.X-CursorX0;
          CursorY1 = e.Y-CursorY0;
            if (draw_frag == true)
            {
                Graphics g = CreateGraphics();

                Pen Rect_penw = new Pen(Color.White, 1);
                g.DrawRectangle(Rect_penw, CursorX0, CursorY0, CursorX1 - 1, CursorY1 - 1 );
               // g.DrawRectangle(Rect_penw, CursorX0, CursorY0, CursorX1, CursorY1);


                Pen Rect_pen = new Pen(Color.Black, 1);
                Rect_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                

                g.DrawRectangle(Rect_pen, CursorX0, CursorY0, CursorX1 , CursorY1 );


            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (draw_frag == true)
            {
                Graphics g = CreateGraphics();
                
                Pen Rect_pen1 = new Pen(Color.White, 1);
                g.DrawRectangle(Rect_pen1, CursorX0, CursorY0, CursorX1 - 1 , CursorY1 - 1);
              //  g.DrawRectangle(Rect_pen1, CursorX0, CursorY0, CursorX1 , CursorY1) ;




                Pen Rect_pen = new Pen(Color.Black, 1);
               

                g.DrawRectangle(Rect_pen, CursorX0, CursorY0, CursorX1, CursorY1 );


            }
            draw_frag = false;
        }
    } 
}


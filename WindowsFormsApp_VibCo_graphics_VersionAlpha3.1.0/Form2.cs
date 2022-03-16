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

        bool draw_frag;
        int X0;
        int Y0;
        int X1;
        int Y1;
        public int[,] mas = new int[100, 4];
        public int figure_count=0 ;
        public void Form2_MouseDown(object sender, MouseEventArgs e)
        {
           
            Graphics g = CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                draw_frag = true;

                X0 = e.X;
                Y0 = e.Y;

                var rect = new Rectangl();
                rect.DrawFigureCordPoint1(X0, Y0);

            }

            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Cleaning...", "Right mouse button is down");
                g.Clear(Color.White);

                for (int xx = 0; xx <= figure_count; xx++)
                {
                     mas[xx, 0]=0;
                     mas[xx, 2]=0;
                     mas[xx, 1]=0;
                     mas[xx, 3]=0;
                }
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            X1 = e.X - X0;
            Y1 = e.Y - Y0;

            if (draw_frag == true)
            {
                Graphics g = CreateGraphics();
                var rect = new Rectangl();
                rect.DrawFigureCordPoint1(X0, Y0);
                rect.DrawFigureCordPoint2(X1, Y1);
                rect.DrawDash(g);

            }
        }


        public void Form2_MouseUp(object sender, MouseEventArgs e)
        { 
            var rect = new Rectangl();
            Graphics g = CreateGraphics();

            if (draw_frag == true)
            {
                rect.DrawFigureCordPoint1(X0, Y0);
                rect.DrawFigureCordPoint2(X1, Y1);
                rect.Draw(g);
            }
            draw_frag = false;

                mas[figure_count, 0] = X0;
                mas[figure_count, 1] = Y0;
                mas[figure_count, 2] = X1;
                mas[figure_count, 3] = Y1;
           
            figure_count++;

            rect.Hide(g);
            repaint();

           ;
        }


        public void repaint()
        {
            Graphics g = CreateGraphics();

            for (int xx = 0; xx <= figure_count; xx++)
            {
                int x0 = mas[xx, 0];
                int x1 = mas[xx, 2];
                int y0 = mas[xx, 1];
                int y1 = mas[xx, 3];

                var rect = new Rectangl();

                rect.DrawFigureCordPoint1(x0, y0);
                rect.DrawFigureCordPoint2(x1, y1);
                rect.Draw(g);
            }
        }
    }
}

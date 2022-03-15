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

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            if (draw_frag == true)
            {
                Graphics g = CreateGraphics();

                var rect = new Rectangl();

                rect.DrawFigureCordPoint1(X0, Y0);
                rect.DrawFigureCordPoint2(X1, Y1);
                rect.Draw(g);

            }
            draw_frag = false;
        }
      

    }
}

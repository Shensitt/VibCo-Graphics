using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsApp1
{
    class Rectangl: AbstractFigure
    {
        public  int x_beg ;public int y_beg ;
        public int x_beg1; public int y_beg1;

        public override void DrawFigureCordPoint1(int x0, int y0) 
        {
              x_beg = x0;   y_beg = y0;
        }
        public override void DrawFigureCordPoint2(int x1, int y1) 
        {
             x_beg1 = x1;   y_beg1 =y1;
        }


        public override void DrawDash(Graphics g)
        {
            Pen Rect_pen = new Pen(Color.Black, 1);
            Rect_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            g.DrawRectangle(Rect_pen, x_beg, y_beg, x_beg1, y_beg1);
            g.FillRectangle(Brushes.White, x_beg + 1, y_beg + 1, x_beg1 - 1, y_beg1 - 1);
        }
        public override void Draw(Graphics g)
        {
            Pen Rect_pen = new Pen(Color.Black, 1);
            g.DrawRectangle(Rect_pen, x_beg, y_beg, x_beg1, y_beg1);
            g.FillRectangle(Brushes.White, x_beg + 1, y_beg + 1, x_beg1 - 1, y_beg1 - 1);
        }


        public override void Hide(Graphics g) 
        {
            g.Clear(Color.White);
        }

    }
}

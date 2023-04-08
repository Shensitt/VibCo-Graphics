using System.Drawing;

namespace WindowsFormsApp1
{
    class Curveline : AbstractFigure
    {
        public int x_beg; public int y_beg;
        public int x_beg1; public int y_beg1;


        public static Color pen_clr = Color.Black;
        public static int pen_wid = 1;
        public static Color pen_bg = Color.White;

        Brush brush = new SolidBrush(pen_bg);
        public override void GetPenSet(Color c, int i, Color b, bool fill)
        {
            pen_clr = c;
            pen_wid = i;
            pen_bg = b;

        }


        public override void DrawFigureCordPoint1(int x0, int y0)
        {
            x_beg = x0; y_beg = y0;
        }
        public override void DrawFigureCordPoint2(int x1, int y1)
        {
            x_beg1 = x1; y_beg1 = y1;
        }


        public override void DrawDash(Graphics g)
        {
            Pen Rect_pen = new Pen(pen_clr, pen_wid);
            Rect_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawCurve(Rect_pen, Form2.draw_point);

        }
        public override void Draw(Graphics g)
        {
            Pen Rect_pen = new Pen(pen_clr, pen_wid);
            g.DrawCurve(Rect_pen, Form2.draw_point);

        }


        public override void Hide(Graphics g)
        {
            g.FillRectangle(Brushes.White, 0, 0, Form2.form_width, Form2.form_height);
        }

    }
}

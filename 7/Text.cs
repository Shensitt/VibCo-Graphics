using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
     class Text : AbstractFigure
    {
        public static Color pen_clr = Color.Black;
       // public static int pen_wid = 1;
        // public static Color pen_bg = Color.White;
        public static Font font = SystemFonts.DefaultFont;
        public static FontStyle fontStyle = FontStyle.Regular;
        int x,y,x1,y1;
        public static string s;
        public override void Draw(Graphics g)
        {
            throw new NotImplementedException();
        }

        public override void DrawDash(Graphics g)
        {
            Pen Rect_pen = new Pen(pen_clr, font.Size);
            Rect_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            g.DrawRectangle(Rect_pen, x, y, x1, y1);
        }

        public override void DrawFigureCordPoint1(int x0, int y0)
        {
            x = x0;
            y = y0;
        }

        public override void DrawFigureCordPoint2(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }

        public override void GetPenSet(Color c, int i, Color b, bool fill)
        {
            pen_clr = c;
        }
        public void GetFont(Font fonts)
        {
            font = fonts;
        }
        public override void Hide(Graphics g)
        {
            g.FillRectangle(Brushes.White, 0, 0, Form2.form_width, Form2.form_height);

        }
    }
}

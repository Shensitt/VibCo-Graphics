using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
     abstract class AbstractFigure
    {
       
        public abstract void DrawFigureCordPoint1(int x0,int y0);
        public abstract void DrawFigureCordPoint2(int x1, int y1);

        public abstract void Draw(Graphics g);

        public abstract void DrawDash(Graphics g);

        public abstract void Hide(Graphics g);

    }
}

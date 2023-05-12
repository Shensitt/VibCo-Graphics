using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            DoubleBuffered = true;
            InitializeComponent();
            textBox1.Visible = false;
        }
        bool draw_frag;
        Graphics g;
        int X0;
        int Y0;
        public int X1;
        public int Y1;
        public static int figure_count = 0;
        public static int[,] mas = new int[100, 11];

        public string[] stringTextArr = new string[100];//новый массив для сохзранения
        public string[] jsonSave = new string[100];

        public static PointF[,] point_mas = new PointF[100, 1000];
        public static PointF[] draw_point;
        int aa = 1;

        public static bool IsChanged = true;
        public static int form_width;
        public static int form_height;

        public static Color pen_clr = Color.Black;
        public static int pen_wid = 1;
        public static Color pen_bg = Color.White;
        public static int figure_selected;
        public static int prev_figure_selected;
        public static bool IsFill;
        public static Font font = SystemFonts.DefaultFont;
        public static string textString;

        public static List<int> selected_figures=new List<int>();//для выделения фигур  //перенести его в класс дата и сохранять\обнулять
        public static int selected_figure_number;
        public static bool IsSelectMode = false;
        Rectangle Selected_rect=new Rectangle();//прямоугольник выделения

        PictureBox pic = new PictureBox();

        public void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            repaint();
            g = CreateGraphics();

            if (e.Button == MouseButtons.Left)
            {
                draw_frag = true;

                X0 = e.X;
                Y0 = e.Y;
                figure_selected = Form5.figure_selected;
                IsFill = Form5.IsFill;

                switch (figure_selected)
                {
                    case 0:
                        {
                            var rect = new Rectangl();
                            rect.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill);
                            rect.DrawFigureCordPoint1(X0, Y0);

                        }
                        break;
                    case 1:
                        {
                            var eli = new Ellipse();
                            eli.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill);

                            eli.DrawFigureCordPoint1(X0, Y0);

                        }
                        break;
                    case 2:
                        {
                            var str = new straightline();
                            str.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill);

                            str.DrawFigureCordPoint1(X0, Y0);
                        }
                        break;
                    case 3:
                        {
                            X1 = e.X;
                            Y1 = e.Y;
                            point_mas[figure_count, aa - 1] = new PointF(X1, Y1);
                            aa++;
                            draw_point = new PointF[aa];

                            PointF a = new PointF(0, 0);
                            int x = 0;
                            while (x < aa)
                            {
                                if (point_mas[figure_count, x] != a)
                                {
                                    draw_point[x] = point_mas[figure_count, x];

                                }
                                else
                                {
                                    if (x > 0)
                                    {
                                        draw_point[x] = point_mas[figure_count, x - 1];
                                    }

                                }

                                x++;
                            }

                            var str = new Curveline();

                            str.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill);

                            str.Draw(g);
                        }
                        break;
                    case 4:
                        {
                            var text = new Text();
                            text.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill);
                            text.DrawFigureCordPoint1(X0, Y0);

                        }
                        break;
                    case 5:
                        {
                            
                        }
                        break;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Cleaning...", "Right mouse button is down");
                g.Clear(Color.White);

                for (int xx = 0; xx <= figure_count; xx++)
                {
                    jsonSave[xx] = null;

                    mas[xx, 0] = 0;
                    mas[xx, 2] = 0;
                    mas[xx, 1] = 0;
                    mas[xx, 3] = 0;
                    mas[xx, 4] = 0;
                    mas[xx, 5] = 0;
                    mas[xx, 6] = 0;
                    mas[xx, 7] = 0;
                    mas[xx, 8] = 0;
                    mas[xx, 9] = 0;
                    mas[xx, 10] = 0;

                    draw_point = null;
                }
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            //IsMouseMoving = true;
          //  selected_figures = null;
            Graphics gg = this.pic.CreateGraphics();
            pic.Width = this.Width;
            pic.Height = this.Height;
            this.DoubleBuffered = true;

            X1 = e.X - X0;
            Y1 = e.Y - Y0;


            if (draw_frag == true)
            {
                repaint(); //selected_figures = null;
                Graphics g = CreateGraphics();

                figure_selected = Form5.figure_selected;
                IsFill = Form5.IsFill;
                switch (figure_selected)
                {
                    case 0:
                        {
                            var rect = new Rectangl();
                            rect.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill);
                            rect.DrawFigureCordPoint1(X0, Y0);
                            rect.DrawFigureCordPoint2(X1, Y1);
                            rect.DrawDash(g);
                        }
                        break;
                    case 1:
                        {
                            var eli = new Ellipse();
                            eli.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill);
                            eli.DrawFigureCordPoint1(X0, Y0);
                            eli.DrawFigureCordPoint2(X1, Y1);
                            eli.DrawDash(g);
                        }
                        break;
                    case 2:
                        {
                            var str = new straightline();
                            str.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill);
                            str.DrawFigureCordPoint1(X0, Y0);
                            X1 = e.X;
                            Y1 = e.Y;
                            str.DrawFigureCordPoint2(X1, Y1);
                            str.DrawDash(g);
                        }
                        break;
                    case 3:
                        {
                            X1 = e.X;
                            Y1 = e.Y;
                            point_mas[figure_count, aa - 1] = new PointF(X1, Y1);
                            aa++;
                            draw_point = new PointF[aa];
                            PointF a = new PointF(0, 0);
                            int x = 0;
                            while (x < aa)
                            {
                                if (point_mas[figure_count, x] != a)
                                {
                                    draw_point[x] = point_mas[figure_count, x];
                                }
                                else
                                {
                                    if (x > 0)
                                    {
                                        draw_point[x] = point_mas[figure_count, x - 1];
                                    }
                                }
                                x++;
                            }
                            var str = new Curveline();
                            str.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill);
                            str.Draw(g);
                        }
                        break;
                    case 4:
                        {
                            var text = new Text();
                            text.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill);
                            text.DrawFigureCordPoint1(X0, Y0);
                            text.DrawFigureCordPoint2(X1, Y1);
                            text.DrawDash(g);
                        }
                        break;
                    case 5:
                        {
                            selected_figures.Clear();//? неудачное место мб
                            var rect = new Rectangl();
                            rect.GetPenSet(Color.Black, 1, Color.Black, false);
                            rect.DrawFigureCordPoint1(X0, Y0);
                            rect.DrawFigureCordPoint2(X1, Y1);
                            rect.DrawDash(g);
                            
                        }
                        break;
                }
            }
        }

        public void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            repaint();
            Graphics gg = this.pic.CreateGraphics();
            pic.Width = this.Width;
            pic.Height = this.Height;
            this.DoubleBuffered = true;
            g = CreateGraphics();

            if (X1 > form_width - X0) { X0 = 0; X1 = 0; Y0 = 0; Y1 = 0; }
            if (Y1 > form_height - Y0) { Y0 = 0; Y1 = 0; X0 = 0; X1 = 0; }
            if (draw_frag == true)
            {
                X0 -= AutoScrollPosition.X;
                Y0 -= AutoScrollPosition.Y;
                figure_selected = Form5.figure_selected;
                IsFill = Form5.IsFill;
                switch (figure_selected)
                {
                    case 0:
                        {
                            var rect = new Rectangl();
                            rect.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill);
                            rect.DrawFigureCordPoint1(X0, Y0);
                            rect.DrawFigureCordPoint2(X1, Y1);
                            rect.Draw(g);
                           // selected_figures = null;
                        }
                        break;
                    case 1:
                        {
                            var eli = new Ellipse();
                            eli.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill);
                            eli.DrawFigureCordPoint1(X0, Y0);
                            eli.DrawFigureCordPoint2(X1, Y1);
                            eli.Draw(g);
                            //selected_figures = null;

                        }
                        break;
                    case 2:
                        {
                            var str = new straightline();
                            str.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill);
                            str.DrawFigureCordPoint1(X0, Y0);
                            str.DrawFigureCordPoint2(X1, Y1);
                            str.Draw(g);
                        //    selected_figures = null;

                        }
                        break;
                    case 3:
                        {
                            X1 = e.X;
                            Y1 = e.Y;
                            point_mas[figure_count, aa - 1] = new PointF(X1, Y1);
                            aa++;
                            draw_point = new PointF[aa];
                            PointF a = new PointF(0, 0);
                            int x = 0;
                            while (x < aa)
                            {
                                if (point_mas[figure_count, x] != a)
                                {
                                    draw_point[x] = point_mas[figure_count, x];
                                }
                                else
                                {
                                    if (x > 0)
                                    {
                                        draw_point[x] = point_mas[figure_count, x - 1];
                                    }
                                }
                                x++;
                            }

                            var str = new Curveline();
                            str.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill);
                            str.Draw(g);
                            for (int xe = 0; xe < aa; xe++)
                            {
                                point_mas[figure_count, xe] = draw_point[xe];
                            }
                          ///  selected_figures = null;

                        }
                        break;
                    case 4:
                        {
                            var text = new Text();
                            text.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill);

                            X0 += AutoScrollPosition.X;
                            Y0 += AutoScrollPosition.Y;
                            X1 = e.X;
                            Y1 = e.Y;
                            text.DrawFigureCordPoint1(X0, Y0);
                            text.DrawFigureCordPoint2(X1, Y1);

                            textString = null;
                            textBox1.Text = null;
                            textBox1.Visible = true;
                            textBox1.Font = font;
                            textBox1.Multiline = true;
                            textBox1.Location = new Point(text.x_beg, text.y_beg);
                            textBox1.Size = new Size(text.x_beg1 - text.x_beg, text.y_beg1 - text.y_beg);
                            repaint();
                        }
                        break;
                    case 5:
                        {
                            
                            var rect = new Rectangl();
                            rect.GetPenSet(Color.Gray, 1, Color.Black, false);
                            rect.DrawFigureCordPoint1(X0,Y0);
                            rect.DrawFigureCordPoint2(X1,Y1);
                            // rect.DrawDash(g);
                            Selected_rect = new Rectangle(X0, Y0, e.X - X0, e.Y - Y0);
                            var rectint=new System.Drawing.Rectangle(X0,Y0,e.X-X0,e.Y-Y0);

                            for (int x = 90; x >= 0; x--)//figures change
                            {
                              
                                var rectangle=new System.Drawing.Rectangle(mas[x, 0], mas[x, 1], mas[x, 2], mas[x,3]);
                                if (rectint.IntersectsWith(rectangle))
                                {
                                    selected_figures.Add(x);
                                    if (selected_figures != null)                     //log
                                    {                                                 //log
                                        foreach (var s in selected_figures)           //log
                                        {                                             //log
                                            Console.WriteLine(s.ToString());          //log
                                                                                      //log
                                        }                                             //log
                                    }                                                 //log
                                    Console.WriteLine("\n");                          //log

                                    rect.DrawFigureCordPoint1(mas[x, 0], mas[x, 1]);
                                    rect.DrawFigureCordPoint2(mas[x, 2], mas[x, 3]);
                                    rect.DrawDash(g);
                                }
                            }
                       // rect.Hide(g);
                        }
                        break;
                }
            }
            draw_frag = false;

            if (figure_selected != 5)
            {
                mas[figure_count, 0] = X0;
                mas[figure_count, 1] = Y0;
                mas[figure_count, 2] = X1;
                mas[figure_count, 3] = Y1;
                mas[figure_count, 6] = pen_wid;
                mas[figure_count, 4] = pen_clr.ToArgb();
                mas[figure_count, 5] = pen_bg.ToArgb();
                mas[figure_count, 7] = form_height;
                mas[figure_count, 8] = form_width;
                mas[figure_count, 9] = figure_selected;
                if (IsFill == true)
                {
                    mas[figure_count, 10] = 1;
                }
                else
                {
                    mas[figure_count, 10] = 0;
                }
                draw_point = null;
                data.point_mas = point_mas;
                data.mas = mas;

                var dataToSave = new
                {
                    X0 = X0,
                    Y0 = Y0,
                    X1 = X1,
                    Y1 = Y1,
                    pen_wid = pen_wid,
                    pen_clr = pen_clr.ToArgb(),
                    pen_bg = pen_bg.ToArgb(),
                    form_height = form_height,
                    form_width = form_width,
                    figure_selected = figure_selected,
                    fill = mas[figure_selected, 10],
                    textString = textString,
                    fontName = font.Name,
                    fontSize = font.Size,
                    fontStyle = font.Style
                };

                string jsonData = JsonConvert.SerializeObject(dataToSave);
                jsonSave[figure_count] = jsonData;
                data.jsonSave = jsonSave;
                // Console.WriteLine(dataToSave);
                aa = 1;
                figure_count++;
            }
            //repaint();
            IsChanged = true;
        }


        public void repaint()
        {
            g = CreateGraphics();
            var rect = new Rectangl();
            rect.Hide(g);
            g.Clear(Color.White);
            for (int xx = 0; xx <= figure_count; xx++)
            {
                int x0 = mas[xx, 0] + AutoScrollPosition.X;
                int x1 = mas[xx, 2];
                int y0 = mas[xx, 1] + AutoScrollPosition.Y;
                int y1 = mas[xx, 3];
                bool fill;
                if (mas[xx, 10] == 1)
                {
                    fill = true;
                }
                else
                {
                    fill = false;
                }
                Color pen_col = Color.FromArgb(mas[xx, 4]);
                int pen_width = mas[xx, 6];
                Color fillcol = Color.FromArgb(mas[xx, 5]);

                switch (mas[xx, 9])
                {
                    case 0:
                        {
                            rect.GetPenSet(pen_col, pen_width, fillcol, fill);
                            rect.DrawFigureCordPoint1(x0, y0);
                            rect.DrawFigureCordPoint2(x1, y1);
                            rect.Draw(g);
                            if(selected_figures!=null)
                            foreach(var selected in selected_figures)
                            {
                                if (selected == xx)
                                {
                                    rect.DrawDash(g);
                                }
                            }
                        }
                        break;
                    case 1:
                        {
                            var eli = new Ellipse();
                            eli.GetPenSet(pen_col, pen_width, fillcol, fill);
                            eli.DrawFigureCordPoint1(x0, y0);
                            eli.DrawFigureCordPoint2(x1, y1);
                            eli.Draw(g);
                            if (selected_figures != null)

                                foreach (var selected in selected_figures)
                            {
                                if (selected == xx)
                                {
                                    eli.DrawDash(g);
                                }
                            }
                        }
                        break;
                    case 2:
                        {
                            var str = new straightline();
                            str.GetPenSet(pen_col, pen_width, fillcol, fill);
                            str.DrawFigureCordPoint1(x0, y0);
                            str.DrawFigureCordPoint2(x1, y1);
                            str.Draw(g);
                            if (selected_figures != null)

                                foreach (var selected in selected_figures)
                            {
                                if (selected == xx)
                                {
                                    str.DrawDash(g);
                                }
                            }
                        }
                        break;
                    case 3:
                        {
                            PointF a = new PointF(0, 0);
                            for (int xe = 0; xe < 1000; xe++)
                            {
                                if (data.point_mas[xx, xe] == a)
                                {
                                    aa = xe;
                                    break;
                                }
                                point_mas[xx, xe] = data.point_mas[xx, xe];
                            }
                            draw_point = new PointF[aa];
                            for (int ab = 0; ab < aa; ab++)
                            {
                                PointF temp = point_mas[xx, ab];
                                temp.X += AutoScrollPosition.X;
                                temp.Y += AutoScrollPosition.Y;
                                draw_point[ab] = temp;
                            }

                            aa = 1;
                            var str = new Curveline();
                            str.GetPenSet(pen_col, pen_width, fillcol, fill);
                            str.Draw(g);
                            if (selected_figures != null)

                                foreach (var selected in selected_figures)
                            {
                                if (selected == xx)
                                {
                                    str.DrawDash(g);
                                }
                            }
                        }
                        break;
                    case 4:
                        {
                            JObject jsonObject = JObject.Parse(jsonSave[xx]);
                            Int32 argb = Convert.ToInt32((string)jsonObject["pen_clr"]);
                            g.DrawString(
                                stringTextArr[xx + 1],
                                new Font(familyName: (string)jsonObject["fontName"], emSize: (float)jsonObject["fontSize"], style: (FontStyle)Enum.Parse(typeof(FontStyle), (string)jsonObject["fontStyle"])),
                                new SolidBrush(Color.FromArgb(argb)),
                                new Rectangle(x0, y0, x1 - x0, y1 - y0)
                            );
                            if (selected_figures != null)

                                foreach (var selected in selected_figures)
                            {
                                if (selected == xx)
                                {
                                    var r = new Rectangl();
                                    r.DrawFigureCordPoint1(x0, y0);
                                    r.DrawFigureCordPoint2(x1 - x0, y1 - y0);
                                    r.DrawDash(g);

                                }
                            }
                        }
                        break;
                }
            }
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            repaint();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.form2_close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            form_height = this.Height;
            form_width = this.Width;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(form_width, form_height);
        }

        private void Form2_Scroll(object sender, ScrollEventArgs e)
        {
            repaint();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            textString = textBox1.Text;
            repaint();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            textString = textBox1.Text;
            if (e.KeyCode == Keys.Enter)
            {
                stringTextArr[figure_count] = textString;
                data.stringTextArr = stringTextArr;

                var dataToSave = new
                {
                    X0 = X0,
                    Y0 = Y0,
                    X1 = X1,
                    Y1 = Y1,
                    pen_wid = pen_wid,
                    pen_clr = pen_clr.ToArgb(),
                    pen_bg = pen_bg.ToArgb(),
                    form_height = form_height,
                    form_width = form_width,
                    figure_selected = figure_selected,
                    fill = mas[figure_selected, 10],
                    textString = textString,
                    fontName = font.Name,
                    fontSize = font.Size,
                    fontStyle = font.Style
                };
                string jsonData = JsonConvert.SerializeObject(dataToSave);
                jsonSave[figure_count] = jsonData;

                data.jsonSave = jsonSave;
                //Console.WriteLine(dataToSave);

                textBox1.Visible = false;
                textBox1.Size = new Size(0, 0);
                repaint();
            }
            repaint();
        }

        private void Form2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}

﻿using System.Drawing;
using System.Threading;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            //Form1 form1= ;
            DoubleBuffered = true;
            InitializeComponent();
            
        }

        bool draw_frag;
        
        int X0;
        int Y0;
        public int X1;
        public int Y1;
        public static int figure_count = 0;
        public int[,] mas = new int[100, 11];
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
        public static bool IsFill;
        public static Font font=SystemFonts.DefaultFont;
        public static string textString;
        private bool enterDetected=false;

        PictureBox pic = new PictureBox();

        public void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            
            g = CreateGraphics();

            if (e.Button == MouseButtons.Left)
            {
                draw_frag = true;

                X0 = e.X/* - AutoScrollPosition.X*/;
                Y0 = e.Y/* - AutoScrollPosition.Y*/;
                figure_selected = Form5.figure_selected;
                IsFill = Form5.IsFill;
                switch (figure_selected)
                {
                    case 0:
                        {
                            var rect = new Rectangl();
                            rect.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*,form_width,form_height*/);
                            rect.DrawFigureCordPoint1(X0, Y0);

                        }
                        break;
                    case 1:
                        {
                            var eli = new Ellipse();
                            eli.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*,form_width,form_height*/);

                            eli.DrawFigureCordPoint1(X0, Y0);

                        }
                        break;
                    case 2:
                        {
                            var str = new straightline();
                            str.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);

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
                                    draw_point[x] = point_mas[figure_count, x]; //aa++;

                                }
                                else
                                {
                                    if (x > 0)
                                    {
                                        draw_point[x] = point_mas[figure_count, x - 1]; //aa++;
                                    }

                                }

                                x++;                                        
                            }

                            var str = new Curveline();

                            str.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);

                            str.Draw(g);
                        }
                        break;
                    case 4:
                        {
                            Text txt=new Text();
                            txt.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);
                            txt.GetFont(font);
                            txt.DrawFigureCordPoint1(X0, Y0);
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

        private  void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics gg = this.pic.CreateGraphics();
            pic.Width = this.Width;
            pic.Height = this.Height;
            this.DoubleBuffered = true;

            X1 = e.X - X0/*-AutoScrollPosition.X*/;
            Y1 = e.Y - Y0/*-AutoScrollPosition.Y*/;
           // Form1 form1= new Form1();
            //form1.GetMousePosition(X1, Y1);

            if (draw_frag == true)
            {
                Graphics g = CreateGraphics();

                figure_selected = Form5.figure_selected;
                IsFill = Form5.IsFill;
                switch (figure_selected)
                {
                    case 0:
                        {
                            var rect = new Rectangl();
                            rect.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);
                            rect.DrawFigureCordPoint1(X0, Y0);
                            rect.DrawFigureCordPoint2(X1, Y1);

                            rect.DrawDash(g);

                        }
                        break;
                    case 1:
                        {
                            var eli = new Ellipse();
                            eli.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);
                            eli.DrawFigureCordPoint1(X0, Y0);
                            eli.DrawFigureCordPoint2(X1, Y1);

                            eli.DrawDash(g);


                        }
                        break;
                    case 2:
                        {
                            var str = new straightline();
                            str.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);

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
                                    draw_point[x] = point_mas[figure_count, x]; //aa++;
                                }
                                else
                                {
                                    if (x > 0)
                                    {
                                        draw_point[x] = point_mas[figure_count, x - 1]; //aa++;
                                    }

                                }

                                x++;                                        
                            }

                            var str = new Curveline();

                            str.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);
                            str.Draw(g);
                        }
                        break;
                    case 4:
                        {
                            Text txt = new Text();
                            txt.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);
                            txt.GetFont(font);
                            txt.DrawFigureCordPoint1(X0, Y0);
                            txt.DrawFigureCordPoint2(X1, Y1);
                            txt.DrawDash(g);
                           
                        }
                        break;
                }
            }
        }

        public void Form2_MouseUp(object sender, MouseEventArgs e)
        {
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

                            rect.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);

                            rect.DrawFigureCordPoint1(X0, Y0);
                            rect.DrawFigureCordPoint2(X1, Y1);
                            rect.Draw(g);
                        }
                        break;
                    case 1:
                        {
                            var eli = new Ellipse();
                            eli.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);

                            eli.DrawFigureCordPoint1(X0, Y0);
                            eli.DrawFigureCordPoint2(X1, Y1);
                            eli.Draw(g);
                        }
                        break;
                    case 2:
                        {
                            var str = new straightline();
                            str.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);

                            str.DrawFigureCordPoint1(X0, Y0);
                            str.DrawFigureCordPoint2(X1, Y1);
                            str.Draw(g);
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
                                    draw_point[x] = point_mas[figure_count, x]; //aa++;

                                }
                                else
                                {
                                    if (x > 0)
                                    {
                                        draw_point[x] = point_mas[figure_count, x - 1]; //aa++;
                                    }
                                }
                                x++;                                      
                            }

                            var str = new Curveline();

                            str.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);

                            str.Draw(g);

                            for (int xe = 0; xe < aa; xe++)

                            {
                                point_mas[figure_count, xe] = draw_point[xe];
                            }

                        }
                        break;
                    case 4:
                        { 
                            Text txt = new Text();
                            txt.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);
                            //txt.GetFont(font);
                            txt.DrawFigureCordPoint1(X0, Y0);
                            txt.DrawFigureCordPoint2(X1, Y1);
                            // txt.Draw(g);
                            textString = null;
                            //font=txt.fo
                            TextBox txt2 = new TextBox()
                            {
                                Parent = this,
                                Location = new Point(X0, Y0),
                                Size = new Size(X1 - X0, Y1 - Y0),
                                Multiline = true,
                                Font = font,
                                ForeColor = Color.Black
                            };
                                                                      // доделать ввод текста 9 лаба
                            //while (enterDetected == false)          // доделать ввод текста 9 лаба
                            //{                                       // доделать ввод текста 9 лаба
                            //    txt2.Text = textString;             // доделать ввод текста 9 лаба
                            //    //textString=txt2.Text;             // доделать ввод текста 9 лаба
                            //    //                                  // доделать ввод текста 9 лаба
                            //}                                       // доделать ввод текста 9 лаба
                            //txt2.Hide();                            // доделать ввод текста 9 лаба
                            ////else { Thread.Sleep(1); }             // доделать ввод текста 9 лаба
                            //enterDetected = false;                  // доделать ввод текста 9 лаба
                            ////txt2.Dispose();                       // доделать ввод текста 9 лаба
                        }                                             // доделать ввод текста 9 лаба
                        break;
                }
            }
            draw_frag = false;

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

            aa = 1;
            figure_count++;

            repaint();

            IsChanged = true;
        }


        public void repaint()
        {
            g = CreateGraphics();

            var rect = new Rectangl();
            rect.Hide(g);

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
                            rect.GetPenSet(pen_col, pen_width, fillcol, fill/*, form_width, form_height*/);
                            rect.DrawFigureCordPoint1(x0, y0);
                            rect.DrawFigureCordPoint2(x1, y1);

                            rect.Draw(g);
                        }
                        break;
                    case 1:
                        {
                            var eli = new Ellipse();
                            eli.GetPenSet(pen_col, pen_width, fillcol, fill/*, form_width, form_height*/);

                            eli.DrawFigureCordPoint1(x0, y0);
                            eli.DrawFigureCordPoint2(x1, y1);
                            eli.Draw(g);
                        }
                        break;
                    case 2:
                        {
                            var str = new straightline();
                            str.GetPenSet(pen_col, pen_width, fillcol, fill/*, form_width, form_height*/);

                            str.DrawFigureCordPoint1(x0, y0);
                            str.DrawFigureCordPoint2(x1, y1);
                            str.Draw(g);
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
                            str.GetPenSet(pen_col, pen_width, fillcol, fill/*, form_width, form_height*/);
                            str.Draw(g);
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

        Graphics g;

        private void Form2_Load(object sender, System.EventArgs e)
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

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter)
            //{
            //    enterDetected = true;
            //}

            //if (e.KeyCode != 0)
            //{
            //    textString += e.KeyCode.ToString();
            //}

        }
    }

}
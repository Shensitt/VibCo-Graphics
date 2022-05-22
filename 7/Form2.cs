using System.Drawing;
using System.Windows.Forms;



namespace WindowsFormsApp1
{



    public partial class Form2 : Form
    {


        public Form2()
        {
            // this.DoubleBuffered = true;
            DoubleBuffered = true;
            
            // this.pictureBox1.Size.Width =form_width;
            //    this.pictureBox1.Size.Width = this.Height;
            InitializeComponent();


        }

        bool draw_frag;
        /*static*/ int X0;
        /*static*/ int Y0;
        /*static*/ int X1;
        /*static*/ int Y1;
        public static int figure_count = 0;
        //public static int curve_count = 0;
      //  static int point_count = 0;

        public int[,] mas = new int[100, 11];
        //public  int[][] mas = new int[100][];
        // public Point[] point_mas = new Point[1000];
         public static PointF[,] point_mas = new PointF[100, 1000];
        // public static PointF[] temp_point=new PointF[1000];
         public static PointF[] draw_point ;
 int aa = 1;

        public static bool IsChanged = true;
        public static int form_width;
        public static int form_height;

        public static Color pen_clr = Color.Black;
        public static int pen_wid = 1;
        public static Color pen_bg = Color.White;
        static int figure_selected;
        public static bool IsFill;

        PictureBox pic = new PictureBox();

        

        public void Form2_MouseDown(object sender, MouseEventArgs e)
        {//pic=this.
            Graphics gg = this.pic.CreateGraphics();
            pic.Width = this.Width;
            pic.Height = this.Height;
            this.DoubleBuffered = true;
            g = CreateGraphics();
           // BufferedGraphics.ReferenceEquals(g, null);
            if (e.Button == MouseButtons.Left)
            {
                draw_frag = true;

                X0 = e.X/* - AutoScrollPosition.X*/;
                Y0 = e.Y/* - AutoScrollPosition.Y*/;
                figure_selected = Form5.figure_selected;
                IsFill = Form5.IsFill ;
                switch (figure_selected)
                {
                    case 0:
                        {
                            var rect = new Rectangl();
                            rect.GetPenSet(pen_clr, pen_wid, pen_bg,IsFill/*,form_width,form_height*/);
                            rect.DrawFigureCordPoint1(X0, Y0);
                            
                        } break;
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
                            // for (int x = 0; x < 1000; x++)
                            //  {
                            PointF a = new PointF(0, 0);
                            int x = 0;
                            while (x < aa)
                            {
                                if (point_mas[figure_count, x] != a)
                                {
                                    draw_point[x] = point_mas[figure_count, x]; //aa++;
                                                                                //if (draw_point[x] == a)
                                                                                //{

                                }
                                else
                                {
                                    if (x > 0)
                                    {
                                        draw_point[x] = point_mas[figure_count, x - 1]; //aa++;
                                    }
                                    //else { }

                                }
                                // PointF a = new PointF(0, 0);
                                //    draw_point[x] = draw_point[x + 1];
                                x++;                                          //}
                            }
                            //if (draw_point[x] == a)
                            //{
                            //    draw_point[x] = draw_point[x + 1];
                            //}
                            // }
                            var str = new Curveline();
                            // //// str.DrawFigureCordPoint1(X0, Y0);
                            // //// str.DrawFigureCordPoint2(X1, Y1);
                            // //draw_point = new PointF[1000];
                            // //point_mas[figure_count, aa] = new PointF(X1, Y1 );
                            // //aa++;
                            // //for (int x = 0; x < 1000; x++)
                            // //{
                            // //    //PointF a = new PointF(0, 0);
                            // //    draw_point[x] = point_mas[figure_count, x];
                            // //    //if (draw_point[x] == a)
                            // //    //{
                            // //    //    draw_point[x] = draw_point[x +1];
                            // //    //}
                            // //}
                            //str.GetPenSet(pen_col, pen_width, fillcol/*, form_width, form_height*/);
                            str.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);

                            str.Draw(g);
                            //str.Draw(g2);
                        }
                        break;
                }



            }

            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Cleaning...", "Right mouse button is down");
                g.Clear(Color.White);
               // g2.Clear(Color.White);

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
                    //mas[xx][ 0] = 0;
                    //mas[xx][ 2] = 0;
                    //mas[xx][ 1] = 0;
                    //mas[xx][ 3] = 0;
                    //mas[xx][ 4] = 0;
                    //mas[xx][ 5] = 0;
                    //mas[xx][ 6] = 0;
                    //mas[xx][ 7] = 0;
                    //mas[xx][ 8] = 0;
                    //mas[xx][ 9] = 0;

                    //for(int x = 0; x < 1000; x++)
                    //     {
                    //     point_mas[xx, x] = new Point(0, 0); //=new Point(0,0);
                    draw_point = null;
               //     }
                }
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics gg = this.pic.CreateGraphics();
            pic.Width = this.Width;
            pic.Height = this.Height;
            this.DoubleBuffered = true;

            X1 = e.X - X0/*-AutoScrollPosition.X*/;
            Y1 = e.Y - Y0/*-AutoScrollPosition.Y*/;

            if (draw_frag == true)
            {
                Graphics g = CreateGraphics();
               // BufferedGraphics.ReferenceEquals(g, null);
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
                         //   rect.DrawDash(g2);
                        }
                        break;
                    case 1:
                        {
                            var eli = new Ellipse();
                            eli.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);
                            eli.DrawFigureCordPoint1(X0, Y0);
                            eli.DrawFigureCordPoint2(X1, Y1);
                            
                            eli.DrawDash(g);
                          //  eli.DrawDash(g2);

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
                           // str.DrawDash(g2);

                        }
                        break;
                    case 3:
                        {
                            X1 =e.X;
                            Y1=e.Y;
                            point_mas[figure_count, aa-1] = new PointF(X1, Y1);
                             aa++;
                            draw_point = new PointF[aa];
                            // for (int x = 0; x < 1000; x++)
                            //  {
                            PointF a = new PointF(0, 0);
                            int x = 0;
                            while ( x < aa)
                            {
                                if(point_mas[figure_count, x] != a)
                                {
 draw_point[x] = point_mas[figure_count, x]; //aa++;
                                             //if (draw_point[x] == a)
                                             //{

                                }
                                else
                                {
                                    if (x > 0)
                                    {
                                        draw_point[x] = point_mas[figure_count, x - 1]; //aa++;
                                    }
                                    //else { }

                                }
                                // PointF a = new PointF(0, 0);
                                //    draw_point[x] = draw_point[x + 1];
                                x++;                                          //}
                            }
                            //if (draw_point[x] == a)
                            //{
                            //    draw_point[x] = draw_point[x + 1];
                            //}
                            // }
                            var str = new Curveline();
                            // //// str.DrawFigureCordPoint1(X0, Y0);
                            // //// str.DrawFigureCordPoint2(X1, Y1);
                            // //draw_point = new PointF[1000];
                            // //point_mas[figure_count, aa] = new PointF(X1, Y1 );
                            // //aa++;
                            // //for (int x = 0; x < 1000; x++)
                            // //{
                            // //    //PointF a = new PointF(0, 0);
                            // //    draw_point[x] = point_mas[figure_count, x];
                            // //    //if (draw_point[x] == a)
                            // //    //{
                            // //    //    draw_point[x] = draw_point[x +1];
                            // //    //}
                            // //}
                             //str.GetPenSet(pen_col, pen_width, fillcol/*, form_width, form_height*/);
                            str.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);
                          //  str.Draw(g2);

                            str.Draw(g);
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
           // BufferedGraphics.ReferenceEquals(g, null);
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
                         //   rect.Draw(g2);
                        }
                            break;
                        case 1:
                            {
                                var eli = new Ellipse();
                            eli.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);

                            eli.DrawFigureCordPoint1(X0, Y0);
                                eli.DrawFigureCordPoint2(X1, Y1);
                                eli.Draw(g);
                        //    eli.Draw(g2);
                            //  mas[figure_count] = new int[10];

                        }
                            break;
                        case 2:
                            {
                                var str = new straightline();
                            str.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);

                            str.DrawFigureCordPoint1(X0, Y0);
                                str.DrawFigureCordPoint2(X1, Y1);
                                str.Draw(g);
                           // str.Draw(g2);
                            //mas[figure_count] = new int[10];
                        }
                            break;
                        case 3:
                            {
                            X1 = e.X;
                            Y1 = e.Y;
                            point_mas[figure_count, aa - 1] = new PointF(X1, Y1);
                            aa++;
                            draw_point = new PointF[aa];
                            // for (int x = 0; x < 1000; x++)
                            //  {
                            PointF a = new PointF(0, 0);
                            int x = 0;
                            while (x < aa)
                            {
                                if (point_mas[figure_count, x] != a)
                                {
                                    draw_point[x] = point_mas[figure_count, x]; //aa++;
                                                                                //if (draw_point[x] == a)
                                                                                //{

                                }
                                else
                                {
                                    if (x > 0)
                                    {
                                        draw_point[x] = point_mas[figure_count, x - 1]; //aa++;
                                    }
                                    //else { }

                                }
                                // PointF a = new PointF(0, 0);
                                //    draw_point[x] = draw_point[x + 1];
                                x++;                                          //}
                            }
                            //if (draw_point[x] == a)
                            //{
                            //    draw_point[x] = draw_point[x + 1];
                            //}
                            // }
                            var str = new Curveline();
                            // //// str.DrawFigureCordPoint1(X0, Y0);
                            // //// str.DrawFigureCordPoint2(X1, Y1);
                            // //draw_point = new PointF[1000];
                            // //point_mas[figure_count, aa] = new PointF(X1, Y1 );
                            // //aa++;
                            // //for (int x = 0; x < 1000; x++)
                            // //{
                            // //    //PointF a = new PointF(0, 0);
                            // //    draw_point[x] = point_mas[figure_count, x];
                            // //    //if (draw_point[x] == a)
                            // //    //{
                            // //    //    draw_point[x] = draw_point[x +1];
                            // //    //}
                            // //}
                            //str.GetPenSet(pen_col, pen_width, fillcol/*, form_width, form_height*/);
                            str.GetPenSet(pen_clr, pen_wid, pen_bg, IsFill/*, form_width, form_height*/);

                            str.Draw(g);
                         //   str.Draw(g2);
                            for (int xe = 0; xe < aa; xe++)
                            //////                           {if(point_mas[figure_count, x] == a)
                            {
                                point_mas[figure_count, xe] = draw_point[xe];
                            }

                            //  draw_point = null;
                            ////                           }
                            //                           // str.GetPenSet(pen_col, pen_width, fillcol/*, form_width, form_height*/);
                            //str.GetPenSet(pen_clr, pen_wid, pen_bg/*, form_width, form_height*/);

                            //   str.Draw(g);
                        }
                            break;
                    }




                }
                draw_frag = false;
                //  mas[figure_count] = new int[10];

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
            //mas[figure_count][ 0] = X0;
            //mas[figure_count][ 1] = Y0;
            //mas[figure_count][ 2] = X1;
            //mas[figure_count][ 3] = Y1;
            //mas[figure_count][ 6] = pen_wid;
            //mas[figure_count][ 4] = pen_clr.ToArgb();
            //mas[figure_count][ 5] = pen_bg.ToArgb();
            //mas[figure_count][ 7] = form_height;
            //mas[figure_count][ 8] = form_width;
            //mas[figure_count][ 9] = figure_selected;
            //if (figure_selected == 3)
            //{
            //    point_mas[figure_count, point_count] = new Point(X1,Y1);
            //    data.point_mas = point_mas;
            //    point_count++;

            draw_point = null;
            //}
            //else { 
            data.point_mas = point_mas;
            
                data.mas = mas;
          //  data.point_mas = point_mas;
               aa = 1; 
           // var rect = new Rectangl();
             figure_count++;
            // }
         //    bm = new Bitmap(form_width, form_height);
         //   g2 = Graphics.FromImage(bm);

            //using (Graphics gg = Graphics.FromImage(btm))
            //{
            //    repaint();
            //}
            repaint();
                
                IsChanged = true;
            }


        public void repaint()
        {
            Graphics gg = this.pic.CreateGraphics();
           // pic.Width = this.Width;
          //  pic.Height = this.Height;
           this.DoubleBuffered = true;
            //this.DoubleBuffered = true;
            g = CreateGraphics();
          //  g.DrawImage(bm, 0, 0);

            // BufferedGraphics.ReferenceEquals(g, null);
            var rect = new Rectangl();
            rect.Hide(g);
           // rect.Hide(g2);
            for (int xx = 0; xx <= figure_count; xx++)
            { //mas[xx] = new int[10];

                int x0 = mas[xx, 0] + AutoScrollPosition.X;
                int x1 = mas[xx, 2];
                int y0 = mas[xx, 1] + AutoScrollPosition.Y;
                int y1 = mas[xx, 3];
                //int x0 = mas[xx][ 0] + AutoScrollPosition.X;
                //int x1 = mas[xx][ 2];
                //int y0 = mas[xx][ 1] + AutoScrollPosition.Y;
                //int y1 = mas[xx][ 3];
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
                ////Color pen_col = Color.FromArgb(mas[xx][ 4]);
                ////int pen_width = mas[xx][ 6];
                ////Color fillcol = Color.FromArgb(mas[xx][ 5]);

                //switch (mas[xx][ 9])


                {
                    case 0:
                        {
                            rect.GetPenSet(pen_col, pen_width, fillcol, fill/*, form_width, form_height*/);
                            rect.DrawFigureCordPoint1(x0, y0);
                            rect.DrawFigureCordPoint2(x1, y1);

                            rect.Draw(g);
                           // rect.Draw(g2);
                        }
                        break;
                    case 1:
                        {
                            var eli = new Ellipse();
                            eli.GetPenSet(pen_col, pen_width, fillcol, fill/*, form_width, form_height*/);

                            eli.DrawFigureCordPoint1(x0, y0);
                            eli.DrawFigureCordPoint2(x1, y1);
                            eli.Draw(g);
                           // eli.Draw(g2);
                        }
                        break;
                    case 2:
                        {
                            var str = new straightline();
                            str.GetPenSet(pen_col, pen_width, fillcol, fill/*, form_width, form_height*/);

                            str.DrawFigureCordPoint1(x0, y0);
                            str.DrawFigureCordPoint2(x1, y1);
                           str.Draw(g);
                          //  str.Draw(g2);
                        }
                        break;
                    case 3:
                        {
                            //int x;
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
                            // aa++;

                            // for (int x = 0; x < 1000; x++)
                            //  {

                            //int x = 0;
                            //while (x < 1000)
                            //{
                            //    draw_point = new PointF[aa];


                            //    if (point_mas[xx, x] != a)
                            //    {
                            //        draw_point[aa-1] = point_mas[xx, x]; aa++;
                            //        //aa++;                                         //if (draw_point[x] == a)
                            //                                                    //{

                            //    }
                            //    else
                            //    {
                            //        if (x > 0)
                            //        {
                            //            draw_point[aa-1] = point_mas[xx, x - 1]; //aa++;
                            //        }
                            //        //else { }

                            //    }
                            //    // PointF a = new PointF(0, 0);
                            //    //    draw_point[x] = draw_point[x + 1];
                            //    x++;                                          //}
                            //}
                            aa = 1;
                            var str = new Curveline();
                            ////// str.DrawFigureCordPoint1(X0, Y0);
                            ////// str.DrawFigureCordPoint2(X1, Y1);
                            //for (int x = 0; x < 1000; x++)
                            //{
                            //    draw_point = new PointF[aa];
                            //    //for (int i = 0; i <= aa; aa++)
                            //    PointF a = new PointF(0, 0);
                            //    //{
                            //    if (data.point_mas[xx, x] == a) { break; }
                            //    // draw_point = new PointF[x + 1];

                            //   draw_point[aa-1] = data.point_mas[xx, x];
                            //    aa++;
                            //}


                            //////}
                            str.GetPenSet(pen_col, pen_width, fillcol, fill/*, form_width, form_height*/);
                           str.Draw(g);
                           // str.Draw(g2);
                        }
                        break;
                }


            }
        }



            private void Form2_Paint(object sender, PaintEventArgs e)
            {
            //Bitmap btm = new Bitmap(form_width, form_height);
            //using (Graphics gg = Graphics.FromImage(btm))
            //{
            //repaint();
            // g.DrawImage(bm, 0, 0);
            // }
            // g=CreateGraphics();
            // g.DrawImage(bm, 0, 0);
            this.DoubleBuffered = true;
            Graphics gg = this.pic.CreateGraphics();
        }

            private void Form2_FormClosed(object sender, FormClosedEventArgs e)
            {
                Form1 f1 = new Form1();
                f1.form2_close();
            }




        Graphics g;
        //Graphics g2;
      //  Bitmap bm;
            private void Form2_Load(object sender, System.EventArgs e)
            {
                form_height = this.Height;
                form_width = this.Width;
                this.AutoScroll = true;
                this.AutoScrollMinSize = new System.Drawing.Size(form_width, form_height);

           // bm=new Bitmap(this.Width, this.Height);
            }
       
            private void Form2_Scroll(object sender, ScrollEventArgs e)
            {
                repaint();
            }
        }

    } 

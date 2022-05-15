using System.Drawing;
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
        static int X0;
        static int Y0;
        static int X1;
        static int Y1;
        public static int figure_count = 0;
        public int[,] mas = new int[100, 9];
        public static bool IsChanged = true;
        public static int form_width;
        public static int form_height;

        public static Color pen_clr = Color.Black;
        public static int pen_wid = 1;
        public static Color pen_bg = Color.White;
       

        public void Form2_MouseDown(object sender, MouseEventArgs e)
        {

            Graphics g = CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                draw_frag = true;
                         
                X0 = e.X/* - AutoScrollPosition.X*/;
                Y0 = e.Y/* - AutoScrollPosition.Y*/;
               // if (X0 > form_width) { X0 = 0; }
                //if (Y0 > form_height) { Y0 = 0; }
                var rect = new Rectangl();
               
                rect.DrawFigureCordPoint1(X0, Y0);
 rect.GetPenSet(pen_clr, pen_wid, pen_bg/*,form_width,form_height*/);
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
                }
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            X1 = e.X - X0/*-AutoScrollPosition.X*/;
            Y1 = e.Y - Y0/*-AutoScrollPosition.Y*/;
            
            if (draw_frag == true)
            {
                Graphics g = CreateGraphics();
                var rect = new Rectangl();

                rect.DrawFigureCordPoint1(X0, Y0);
                rect.DrawFigureCordPoint2(X1, Y1);
                rect.GetPenSet(pen_clr, pen_wid, pen_bg/*, form_width, form_height*/);

                rect.DrawDash(g);

            }
        }

        public void Form2_MouseUp(object sender, MouseEventArgs e)
        {

            var rect = new Rectangl();
            Graphics g = CreateGraphics();
            if (X1 > form_width - X0) { X0 = 0; X1 = 0; Y0 = 0; Y1 = 0; }
            if (Y1 > form_height - Y0) { Y0 = 0; Y1 = 0; X0 = 0; X1 = 0; }
            if (draw_frag == true)
            {
                X0-=     AutoScrollPosition.X      ;
                   // X1 -= AutoScrollPosition.X     ;
                    Y0 -=   AutoScrollPosition.Y   ;
              //  Y1 -= AutoScrollPosition.Y;
                rect.DrawFigureCordPoint1(X0, Y0);
                rect.DrawFigureCordPoint2(X1, Y1);
                rect.GetPenSet(pen_clr, pen_wid, pen_bg/*, form_width, form_height*/);

                rect.Draw(g);
                
                

            }
            draw_frag = false;
           
            mas[figure_count, 0] = X0;
            mas[figure_count, 1] = Y0;
            mas[figure_count, 2] = X1;
            mas[figure_count, 3] = Y1;

            mas[figure_count, 6] = pen_wid;
           
                //mas[figure_count, 4] = pen_clr.ToArgb();

                //mas[figure_count, 5] = pen_bg.ToArgb();
           
            mas[figure_count, 4] = pen_clr.ToArgb();
            
            mas[figure_count, 5] = pen_bg.ToArgb();
            
            mas[figure_count, 7] = form_height;
            mas[figure_count, 8] = form_width;


            //data.mas = mas;
            //if (mas[figure_count, 2] > mas[0, 8] || mas[figure_count, 3] > mas[0, 7])
            //{

            //    mas[figure_count, 0] = 0;
            //    mas[figure_count, 1] = 0;
            //    mas[figure_count, 2] = 0;
            //    mas[figure_count, 3] = 0;

            //    mas[figure_count, 6] = 0;

            //    //mas[figure_count, 4]0;

            //    //mas[figure_count, 5]0;

            //    mas[figure_count, 4] = 0;

            //    mas[figure_count, 5] = 0;

            //   mas[figure_count, 7] = 0;
            //   mas[figure_count, 8] = 0;


            //   data.mas[figure_count, 0] = 0;
            //   data.mas[figure_count, 1] = 0;
            //   data.mas[figure_count, 2] = 0;
            //   data.mas[figure_count, 3] = 0;
             
            //   data.mas[figure_count, 6] = 0;
              
            //   //mas[figure_count, 4]0;
               
               
            //   data.mas[figure_count, 4] = 0;
            //   data.mas[figure_count, 5] = 0;
            //   data.mas[figure_count, 7] = 0;
            //   data.mas[figure_count, 8] = 0;
            //}

            data.mas = mas;
figure_count++;
            rect.Hide(g);
            repaint();
            IsChanged = true;
 
        }

                                        
        public void repaint()
        {
            Graphics g = CreateGraphics();
            var rect = new Rectangl();
            rect.Hide(g);
            for (int xx = 0; xx <= figure_count; xx++)
            {

                int x0 = mas[xx, 0] + AutoScrollPosition.X;
                int x1 = mas[xx, 2] ;
                int y0 = mas[xx, 1] + AutoScrollPosition.Y;
                int y1 = mas[xx, 3];

                Color pen_col = Color.FromArgb(mas[xx, 4]);
                int pen_width = mas[xx, 6];
                Color fillcol = Color.FromArgb(mas[xx, 5]);



                rect.DrawFigureCordPoint1(x0, y0);
                rect.DrawFigureCordPoint2(x1, y1);  
                rect.GetPenSet(pen_clr, pen_wid, pen_bg/*, form_width, form_height*/);

                rect.Draw(g);
            }
        }



        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            var rect = new Rectangl();
            rect.Hide(g);
            for (int xx = 0; xx <= figure_count; xx++)
            {


                int x0 = mas[xx, 0]+ AutoScrollPosition.X;
                int x1 = mas[xx, 2];
                int y0 = mas[xx, 1] + AutoScrollPosition.Y;
                int y1 = mas[xx, 3];

                Color pen_col = Color.FromArgb(mas[xx, 4]);
                int pen_width = mas[xx, 6];
                Color fillcol = Color.FromArgb(mas[xx, 5]);

                //  var rect = new Rectangl();

                rect.DrawFigureCordPoint1(x0, y0);
                rect.DrawFigureCordPoint2(x1, y1);
                rect.GetPenSet(pen_clr, pen_wid, pen_bg/*, form_width, form_height*/);
                rect.Draw(g);



            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.form2_close();


        }






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
    }
    
}

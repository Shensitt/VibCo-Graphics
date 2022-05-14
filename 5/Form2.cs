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
        int X0;
        int Y0;
        int X1;
        int Y1;
        public static int figure_count = 0;
        public int[,] mas = new int[100,7];
        public static bool IsChanged = true;

        public static Color pen_clr = Color.Black;
        public static int pen_wid = 1;
        public static Color pen_bg = Color.White;

        //public int[] Pen_Width_array = new int[100];
       // public Color[,] Pen_fill_color_arr = new Color[100, 2];
        public void Form2_MouseDown(object sender, MouseEventArgs e)
        {

            Graphics g = CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                draw_frag = true;

                X0 = e.X;
                Y0 = e.Y;

                var rect = new Rectangl();
                rect.GetPenSet(pen_clr, pen_wid, pen_bg);
                rect.DrawFigureCordPoint1(X0, Y0);

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
                rect.GetPenSet(pen_clr, pen_wid, pen_bg);
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
                rect.GetPenSet(pen_clr, pen_wid, pen_bg);
                rect.DrawFigureCordPoint1(X0, Y0);
                rect.DrawFigureCordPoint2(X1, Y1);
                rect.Draw(g);

            }
            draw_frag = false;

            mas[figure_count, 0] = X0;
            mas[figure_count, 1] = Y0;
            mas[figure_count, 2] = X1;
            mas[figure_count, 3] = Y1;

            mas[figure_count,6] = pen_wid;

            mas[figure_count, 4] = pen_clr.ToArgb();
            //mas[figure_count, 5] = pen_clr.R;
            //mas[figure_count, 6] = pen_clr.G;
            //mas[figure_count, 7] = pen_clr.B;
            
            
            mas[figure_count, 5] = pen_bg.ToArgb();
            //mas[figure_count, 9] = pen_bg.R;
            //mas[figure_count, 10] = pen_bg.G;
            //mas[figure_count, 11] = pen_bg.B;
            //Pen_fill_color_arr[figure_count, 1] = pen_bg;


            // data.string_for_form2_save = data.string_for_form2_save + X0.ToString() + " " + Y0.ToString() + " " + X1.ToString() + " " + Y1.ToString() + " ";
            // data.Pen_Width_array=
            figure_count++;

            data.mas = mas;
           // data.Pen_Width_array = Pen_Width_array;
            //data.Pen_fill_color_arr = Pen_fill_color_arr;

            rect.Hide(g);
            repaint();
            IsChanged = true;

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

                Color pen_col = Color.FromArgb(mas[xx,4]);
                int pen_width = mas[xx, 6];
                Color fillcol = Color.FromArgb(mas[xx, 5]);

                var rect = new Rectangl();
                rect.GetPenSet(pen_col, pen_width, fillcol);
                rect.DrawFigureCordPoint1(x0, y0);
                rect.DrawFigureCordPoint2(x1, y1);
                rect.Draw(g);
            }
        }



        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();

            for (int xx = 0; xx <= figure_count; xx++)
            {


                int x0 = mas[xx, 0];
                int x1 = mas[xx, 2];
                int y0 = mas[xx, 1];
                int y1 = mas[xx, 3];

                Color pen_col = Color.FromArgb(mas[xx, 4]);
                int pen_width = mas[xx, 6];
                Color fillcol = Color.FromArgb(mas[xx, 5]);

                var rect = new Rectangl();

                rect.GetPenSet(pen_col, pen_width, fillcol);
                rect.DrawFigureCordPoint1(x0, y0);
                rect.DrawFigureCordPoint2(x1, y1);
                rect.Draw(g);



            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.form2_close();


        }
    }
}

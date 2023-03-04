using System;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    [Serializable]
    public partial class data : Form
    {
        public data()
        {
            InitializeComponent();
        }
        public static int[,] mas = new int[100, 11];//1-4 -> figure_cords;
                                                    //5-> pen color argb;
                                                    //6-> fill color argb;
                                                    //7->pen width
                                                    //8->form_heigh
                                                    //9-form width
                                                    //10->selected figure
                                                    //11-fill
                                                    //12-
                                                    // public static int[][] mas = new int[100][];
        public int form_h = mas[0, 7];
        public int form_w = mas[0, 8];
        
        public static PointF[,] point_mas = new PointF[100, 1000];
    }
}

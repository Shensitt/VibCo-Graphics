using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class data : Form
    {
        public data()
        {
            InitializeComponent();
        }
        public static int[,] mas = new int[100, 7];//1-4 -> figure_cords; 5-> pen color argb;6-> fill color argb;7->pen width
       // public static string string_for_form2_save;
        //public static int[] Pen_Width_array = new int[100];
        //public static Color[,] Pen_fill_color_arr = new Color[100, 2];
    }
}

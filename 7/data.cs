﻿using System;
using System.Drawing;


namespace WindowsFormsApp1
{
    [Serializable]
    public partial class data
    {
        public data()
        {
        }
        public static int[,] mas = new int[100, 11];//0-3 -> figure_cords;
                                                    //4-> pen color argb;
                                                    //5-> fill color argb;
                                                    //6->pen width
                                                    //7->form_heigh
                                                    //8-form width
                                                    //9->selected figure
                                                    //10-fill
                                                    //11-
                                                    // public static int[][] mas = new int[100][];

        public static string[] stringTextArr = new string[100];//новый массив для сохзранения

        public static string[] jsonSave = new string[100];


        public int form_h = mas[0, 7];
        public int form_w = mas[0, 8];

        public static PointF[,] point_mas = new PointF[100, 1000];
    }
}

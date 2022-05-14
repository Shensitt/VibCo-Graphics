using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;






namespace WindowsFormsApp1
{


    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }

        private delegate void form1_del_call(string s, Form1 f1);

        public void new_form2_creation(String s, Form1 f1)
        {
            Form2 f22 = new Form2();
            f22.Text = s;

            f22.MdiParent = f1;
            f22.Show();
            saveAsToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
        }
        form1_del_call f1dc;

        private void newToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string s = "Picture " + this.MdiChildren.Length.ToString();
            f1dc = new form1_del_call(new_form2_creation);

            f1dc(s, this);

        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f22 = new Form2();

            f22.MdiParent = this;



            Thread t = new Thread((ThreadStart)(() =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.Filter = "txt files|*.txt|All files|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream(
                        openFileDialog.FileName,
                        FileMode.Open,
                        FileAccess.Read,
                        FileShare.Read
                        );

                    data.mas = (int[,])formatter.Deserialize(stream);
                    stream.Close();
                    f22.Text = openFileDialog.FileName;
                }
            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            



                int fig_cnt_chk = 0;
                for (int x = 0; x < 100; x++)
                {
                    if (data.mas[x, 0] != 0)
                    {
                        fig_cnt_chk++;
                    }
                }
                Form2.figure_count = fig_cnt_chk;
                f22.mas = data.mas;







            Form2.IsChanged = false;
            f22.Show();
            saveAsToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;

        }

        public void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form2.IsChanged == true)
            {
                Thread t = new Thread((ThreadStart)(() =>
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
                    saveFileDialog.Filter = "txt files|*.txt|All files|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;



                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        BinaryFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream(
                               saveFileDialog.FileName,
                               FileMode.Create,
                               FileAccess.Write,
                               FileShare.None
                           );

                        formatter.Serialize(stream, data.mas);



                        Text = saveFileDialog.FileName;
                        //stream.Close();
                    }
                }));
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                t.Join();
                
            }
        }

        public void form2_close()
        {
            switch (MessageBox.Show("Save before closing?", "Exiting window", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes:
                    {

                        Thread t = new Thread((ThreadStart)(() =>
                            {

                                SaveFileDialog saveFileDialog = new SaveFileDialog();
                                saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
                                saveFileDialog.Filter = "txt files|*.txt|All files|*.*";
                                saveFileDialog.FilterIndex = 1;
                                saveFileDialog.RestoreDirectory = true;



                                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                {

                                    BinaryFormatter formatter = new BinaryFormatter();
                                    Stream stream = new FileStream(
                                           saveFileDialog.FileName,
                                           FileMode.Create,
                                           FileAccess.Write,
                                           FileShare.None
                                       );

                                    formatter.Serialize(stream, data.mas);



                                    Text = saveFileDialog.FileName;
                                    //stream.Close();
                                }
                            }));
                        t.SetApartmentState(ApartmentState.STA);
                        t.Start();
                        t.Join();
                        

                    }
                    break;
                case DialogResult.No:
                    {
                        return;
                    }

                case DialogResult.Cancel:
                    {

                        return;
                    }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Thread t = new Thread((ThreadStart)(() =>
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
                saveFileDialog.Filter = "txt files|*.txt|All files|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;



                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    BinaryFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream(
                           saveFileDialog.FileName,
                           FileMode.Create,
                           FileAccess.Write,
                           FileShare.None
                       );

                    formatter.Serialize(stream, data.mas);



                    Text = saveFileDialog.FileName;
                    //stream.Close();
                }
            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
           

        }


        // public Color clr = Color.Black;


        public void lineColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color_diag = new ColorDialog();
            switch (color_diag.ShowDialog())
            {
                case DialogResult.OK:
                    {

                        Form2.pen_clr = color_diag.Color;

                    }
                    break;
                case DialogResult.Cancel:
                    {

                        return;
                    }
            }


        }

        private void lineThicknessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 myDialog = new Form3();
            myDialog.ShowDialog(this);




        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color_diag = new ColorDialog();
            switch (color_diag.ShowDialog())
            {
                case DialogResult.OK:
                    {

                        Form2.pen_bg = color_diag.Color;
                       // color_diag.Color.
                    }
                    break;
                case DialogResult.Cancel:
                    {

                        return;
                    }
            }
        }
    }
}



namespace WindowsFormsApp1
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseFileSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineThicknessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxPenSize = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxPenColor = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxFillcolor = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxPictureSize = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBoxMousePosition = new System.Windows.Forms.TextBox();
            this.textBoxFont = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.parametersToolStripMenuItem,
            this.figureToolStripMenuItem,
            this.textToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem2,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem2
            // 
            this.newToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseFileSizeToolStripMenuItem});
            this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
            this.newToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.newToolStripMenuItem2.Text = "New";
            this.newToolStripMenuItem2.Click += new System.EventHandler(this.newToolStripMenuItem2_Click);
            // 
            // chooseFileSizeToolStripMenuItem
            // 
            this.chooseFileSizeToolStripMenuItem.Name = "chooseFileSizeToolStripMenuItem";
            this.chooseFileSizeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.chooseFileSizeToolStripMenuItem.Text = "Choose File Size";
            this.chooseFileSizeToolStripMenuItem.Click += new System.EventHandler(this.chooseFileSizeToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineColorToolStripMenuItem,
            this.lineThicknessToolStripMenuItem,
            this.backgroundColorToolStripMenuItem});
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.parametersToolStripMenuItem.Text = "Parameters";
            // 
            // lineColorToolStripMenuItem
            // 
            this.lineColorToolStripMenuItem.Name = "lineColorToolStripMenuItem";
            this.lineColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.lineColorToolStripMenuItem.Text = "Line color";
            this.lineColorToolStripMenuItem.Click += new System.EventHandler(this.lineColorToolStripMenuItem_Click);
            // 
            // lineThicknessToolStripMenuItem
            // 
            this.lineThicknessToolStripMenuItem.Name = "lineThicknessToolStripMenuItem";
            this.lineThicknessToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.lineThicknessToolStripMenuItem.Text = "Line thickness";
            this.lineThicknessToolStripMenuItem.Click += new System.EventHandler(this.lineThicknessToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // figureToolStripMenuItem
            // 
            this.figureToolStripMenuItem.Name = "figureToolStripMenuItem";
            this.figureToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.figureToolStripMenuItem.Text = "Figure";
            this.figureToolStripMenuItem.Click += new System.EventHandler(this.figureToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 24);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(0, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Pen size:";
            // 
            // textBoxPenSize
            // 
            this.textBoxPenSize.Enabled = false;
            this.textBoxPenSize.Location = new System.Drawing.Point(46, 22);
            this.textBoxPenSize.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPenSize.Name = "textBoxPenSize";
            this.textBoxPenSize.Size = new System.Drawing.Size(25, 20);
            this.textBoxPenSize.TabIndex = 8;
            this.textBoxPenSize.Text = "1";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(74, 22);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(53, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Pen color";
            // 
            // textBoxPenColor
            // 
            this.textBoxPenColor.BackColor = System.Drawing.Color.Black;
            this.textBoxPenColor.Enabled = false;
            this.textBoxPenColor.Location = new System.Drawing.Point(130, 22);
            this.textBoxPenColor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPenColor.Name = "textBoxPenColor";
            this.textBoxPenColor.Size = new System.Drawing.Size(18, 20);
            this.textBoxPenColor.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(152, 22);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(49, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "Fill color";
            // 
            // textBoxFillcolor
            // 
            this.textBoxFillcolor.BackColor = System.Drawing.Color.Black;
            this.textBoxFillcolor.Enabled = false;
            this.textBoxFillcolor.Location = new System.Drawing.Point(205, 22);
            this.textBoxFillcolor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFillcolor.Name = "textBoxFillcolor";
            this.textBoxFillcolor.Size = new System.Drawing.Size(19, 20);
            this.textBoxFillcolor.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(228, 22);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(61, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Picture size:";
            // 
            // textBoxPictureSize
            // 
            this.textBoxPictureSize.Enabled = false;
            this.textBoxPictureSize.Location = new System.Drawing.Point(293, 22);
            this.textBoxPictureSize.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPictureSize.Name = "textBoxPictureSize";
            this.textBoxPictureSize.Size = new System.Drawing.Size(62, 20);
            this.textBoxPictureSize.TabIndex = 14;
            this.textBoxPictureSize.Text = "500x500";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(360, 22);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(76, 20);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "Mouse position";
            this.textBox5.Visible = false;
            // 
            // textBoxMousePosition
            // 
            this.textBoxMousePosition.Enabled = false;
            this.textBoxMousePosition.Location = new System.Drawing.Point(440, 22);
            this.textBoxMousePosition.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMousePosition.Name = "textBoxMousePosition";
            this.textBoxMousePosition.ReadOnly = true;
            this.textBoxMousePosition.Size = new System.Drawing.Size(67, 20);
            this.textBoxMousePosition.TabIndex = 16;
            this.textBoxMousePosition.Text = "1x1";
            this.textBoxMousePosition.Visible = false;
            // 
            // textBoxFont
            // 
            this.textBoxFont.Enabled = false;
            this.textBoxFont.Location = new System.Drawing.Point(511, 22);
            this.textBoxFont.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFont.Name = "textBoxFont";
            this.textBoxFont.Size = new System.Drawing.Size(479, 20);
            this.textBoxFont.TabIndex = 19;
            this.textBoxFont.Text = "Default Font";
            this.textBoxFont.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(280, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 21;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxFont);
            this.Controls.Add(this.textBoxMousePosition);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBoxPictureSize);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxFillcolor);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBoxPenColor);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxPenSize);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.White;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "VibCo Graphics";
            this.TransparencyKey = System.Drawing.Color.White;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineThicknessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseFileSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figureToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.TextBox textBoxPenSize;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBoxPenColor;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxFillcolor;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBoxPictureSize;
        private System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.TextBox textBoxMousePosition;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        public System.Windows.Forms.TextBox textBoxFont;
        private System.Windows.Forms.Button button1;
    }
}


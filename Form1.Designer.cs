namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.headBar = new System.Windows.Forms.MenuStrip();
            this.Files = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gradientPanel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.purpleColorPanel = new System.Windows.Forms.Panel();
            this.orangeColorPanel = new System.Windows.Forms.Panel();
            this.blueColorPanel = new System.Windows.Forms.Panel();
            this.darkOrangeColorPanel = new System.Windows.Forms.Panel();
            this.navyColorPanel = new System.Windows.Forms.Panel();
            this.pinkColorPanel = new System.Windows.Forms.Panel();
            this.greenColorPanel = new System.Windows.Forms.Panel();
            this.silverColorPanel = new System.Windows.Forms.Panel();
            this.darkPintColorPanel = new System.Windows.Forms.Panel();
            this.redColorPanel = new System.Windows.Forms.Panel();
            this.cyanColorPanel = new System.Windows.Forms.Panel();
            this.maroonColorPanel = new System.Windows.Forms.Panel();
            this.limeColorPanel = new System.Windows.Forms.Panel();
            this.whiteColorPanel = new System.Windows.Forms.Panel();
            this.springColorPanel = new System.Windows.Forms.Panel();
            this.grayColorPanel = new System.Windows.Forms.Panel();
            this.yellowColorPanel = new System.Windows.Forms.Panel();
            this.blackColorPanel = new System.Windows.Forms.Panel();
            this.pen = new System.Windows.Forms.Panel();
            this.filling = new System.Windows.Forms.Panel();
            this.fatBrush = new System.Windows.Forms.Panel();
            this.brush = new System.Windows.Forms.Panel();
            this.desk = new System.Windows.Forms.PictureBox();
            this.activeColorPanel = new System.Windows.Forms.Panel();
            this.headBar.SuspendLayout();
            this.headPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desk)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(807, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "made by Ignat";
            // 
            // headBar
            // 
            this.headBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Files,
            this.about});
            this.headBar.Location = new System.Drawing.Point(0, 0);
            this.headBar.Name = "headBar";
            this.headBar.Size = new System.Drawing.Size(932, 24);
            this.headBar.TabIndex = 9;
            // 
            // Files
            // 
            this.Files.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveDefault,
            this.SaveAs});
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(42, 20);
            this.Files.Text = "Files";
            // 
            // SaveDefault
            // 
            this.SaveDefault.Name = "SaveDefault";
            this.SaveDefault.Size = new System.Drawing.Size(112, 22);
            this.SaveDefault.Text = "Save";
            // 
            // SaveAs
            // 
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(112, 22);
            this.SaveAs.Text = "Save as";
            // 
            // about
            // 
            this.about.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(52, 20);
            this.about.Text = "About";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.headPanel.Controls.Add(this.panel3);
            this.headPanel.Controls.Add(this.panel2);
            this.headPanel.Controls.Add(this.panel1);
            this.headPanel.Location = new System.Drawing.Point(1, 25);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(930, 92);
            this.headPanel.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.activeColorPanel);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(446, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 84);
            this.panel3.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "active";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.gradientPanel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(697, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 84);
            this.panel2.TabIndex = 29;
            // 
            // gradientPanel
            // 
            this.gradientPanel.BackgroundImage = global::Paint.Properties.Resources.gradient;
            this.gradientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanel.Location = new System.Drawing.Point(10, 2);
            this.gradientPanel.Name = "gradientPanel";
            this.gradientPanel.Size = new System.Drawing.Size(53, 50);
            this.gradientPanel.TabIndex = 1;
            this.gradientPanel.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "colors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "another";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.purpleColorPanel);
            this.panel1.Controls.Add(this.orangeColorPanel);
            this.panel1.Controls.Add(this.blueColorPanel);
            this.panel1.Controls.Add(this.darkOrangeColorPanel);
            this.panel1.Controls.Add(this.navyColorPanel);
            this.panel1.Controls.Add(this.pinkColorPanel);
            this.panel1.Controls.Add(this.greenColorPanel);
            this.panel1.Controls.Add(this.silverColorPanel);
            this.panel1.Controls.Add(this.darkPintColorPanel);
            this.panel1.Controls.Add(this.redColorPanel);
            this.panel1.Controls.Add(this.cyanColorPanel);
            this.panel1.Controls.Add(this.maroonColorPanel);
            this.panel1.Controls.Add(this.limeColorPanel);
            this.panel1.Controls.Add(this.whiteColorPanel);
            this.panel1.Controls.Add(this.springColorPanel);
            this.panel1.Controls.Add(this.grayColorPanel);
            this.panel1.Controls.Add(this.yellowColorPanel);
            this.panel1.Controls.Add(this.blackColorPanel);
            this.panel1.Location = new System.Drawing.Point(524, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 80);
            this.panel1.TabIndex = 0;
            // 
            // purpleColorPanel
            // 
            this.purpleColorPanel.BackColor = System.Drawing.Color.Purple;
            this.purpleColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purpleColorPanel.Location = new System.Drawing.Point(139, 55);
            this.purpleColorPanel.Name = "purpleColorPanel";
            this.purpleColorPanel.Size = new System.Drawing.Size(20, 20);
            this.purpleColorPanel.TabIndex = 28;
            // 
            // orangeColorPanel
            // 
            this.orangeColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orangeColorPanel.Location = new System.Drawing.Point(61, 55);
            this.orangeColorPanel.Name = "orangeColorPanel";
            this.orangeColorPanel.Size = new System.Drawing.Size(20, 20);
            this.orangeColorPanel.TabIndex = 19;
            // 
            // blueColorPanel
            // 
            this.blueColorPanel.BackColor = System.Drawing.Color.Blue;
            this.blueColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blueColorPanel.Location = new System.Drawing.Point(113, 55);
            this.blueColorPanel.Name = "blueColorPanel";
            this.blueColorPanel.Size = new System.Drawing.Size(20, 20);
            this.blueColorPanel.TabIndex = 25;
            // 
            // darkOrangeColorPanel
            // 
            this.darkOrangeColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.darkOrangeColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkOrangeColorPanel.Location = new System.Drawing.Point(35, 55);
            this.darkOrangeColorPanel.Name = "darkOrangeColorPanel";
            this.darkOrangeColorPanel.Size = new System.Drawing.Size(20, 20);
            this.darkOrangeColorPanel.TabIndex = 16;
            // 
            // navyColorPanel
            // 
            this.navyColorPanel.BackColor = System.Drawing.Color.Navy;
            this.navyColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navyColorPanel.Location = new System.Drawing.Point(139, 29);
            this.navyColorPanel.Name = "navyColorPanel";
            this.navyColorPanel.Size = new System.Drawing.Size(20, 20);
            this.navyColorPanel.TabIndex = 27;
            // 
            // pinkColorPanel
            // 
            this.pinkColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pinkColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pinkColorPanel.Location = new System.Drawing.Point(61, 29);
            this.pinkColorPanel.Name = "pinkColorPanel";
            this.pinkColorPanel.Size = new System.Drawing.Size(20, 20);
            this.pinkColorPanel.TabIndex = 18;
            // 
            // greenColorPanel
            // 
            this.greenColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greenColorPanel.Location = new System.Drawing.Point(87, 55);
            this.greenColorPanel.Name = "greenColorPanel";
            this.greenColorPanel.Size = new System.Drawing.Size(20, 20);
            this.greenColorPanel.TabIndex = 22;
            // 
            // silverColorPanel
            // 
            this.silverColorPanel.BackColor = System.Drawing.Color.Silver;
            this.silverColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.silverColorPanel.Location = new System.Drawing.Point(9, 55);
            this.silverColorPanel.Name = "silverColorPanel";
            this.silverColorPanel.Size = new System.Drawing.Size(20, 20);
            this.silverColorPanel.TabIndex = 13;
            this.silverColorPanel.Click += new System.EventHandler(this.silverColorPanel_Click);
            this.silverColorPanel.MouseEnter += new System.EventHandler(this.silverColorPanel_MouseEnter);
            this.silverColorPanel.MouseLeave += new System.EventHandler(this.silverColorPanel_MouseLeave);
            // 
            // darkPintColorPanel
            // 
            this.darkPintColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.darkPintColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkPintColorPanel.Location = new System.Drawing.Point(139, 3);
            this.darkPintColorPanel.Name = "darkPintColorPanel";
            this.darkPintColorPanel.Size = new System.Drawing.Size(20, 20);
            this.darkPintColorPanel.TabIndex = 26;
            // 
            // redColorPanel
            // 
            this.redColorPanel.BackColor = System.Drawing.Color.Red;
            this.redColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redColorPanel.Location = new System.Drawing.Point(61, 3);
            this.redColorPanel.Name = "redColorPanel";
            this.redColorPanel.Size = new System.Drawing.Size(20, 20);
            this.redColorPanel.TabIndex = 17;
            // 
            // cyanColorPanel
            // 
            this.cyanColorPanel.BackColor = System.Drawing.Color.Cyan;
            this.cyanColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cyanColorPanel.Location = new System.Drawing.Point(113, 29);
            this.cyanColorPanel.Name = "cyanColorPanel";
            this.cyanColorPanel.Size = new System.Drawing.Size(20, 20);
            this.cyanColorPanel.TabIndex = 24;
            // 
            // maroonColorPanel
            // 
            this.maroonColorPanel.BackColor = System.Drawing.Color.Maroon;
            this.maroonColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maroonColorPanel.Location = new System.Drawing.Point(35, 29);
            this.maroonColorPanel.Name = "maroonColorPanel";
            this.maroonColorPanel.Size = new System.Drawing.Size(20, 20);
            this.maroonColorPanel.TabIndex = 15;
            // 
            // limeColorPanel
            // 
            this.limeColorPanel.BackColor = System.Drawing.Color.Lime;
            this.limeColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.limeColorPanel.Location = new System.Drawing.Point(87, 29);
            this.limeColorPanel.Name = "limeColorPanel";
            this.limeColorPanel.Size = new System.Drawing.Size(20, 20);
            this.limeColorPanel.TabIndex = 21;
            // 
            // whiteColorPanel
            // 
            this.whiteColorPanel.BackColor = System.Drawing.Color.White;
            this.whiteColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.whiteColorPanel.Location = new System.Drawing.Point(9, 29);
            this.whiteColorPanel.Name = "whiteColorPanel";
            this.whiteColorPanel.Size = new System.Drawing.Size(20, 20);
            this.whiteColorPanel.TabIndex = 12;
            this.whiteColorPanel.Click += new System.EventHandler(this.whiteColorPanel_Click);
            this.whiteColorPanel.MouseEnter += new System.EventHandler(this.whiteColorPanel_MouseEnter);
            this.whiteColorPanel.MouseLeave += new System.EventHandler(this.whiteColorPanel_MouseLeave);
            // 
            // springColorPanel
            // 
            this.springColorPanel.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.springColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.springColorPanel.Location = new System.Drawing.Point(113, 3);
            this.springColorPanel.Name = "springColorPanel";
            this.springColorPanel.Size = new System.Drawing.Size(20, 20);
            this.springColorPanel.TabIndex = 23;
            // 
            // grayColorPanel
            // 
            this.grayColorPanel.BackColor = System.Drawing.Color.Gray;
            this.grayColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grayColorPanel.Location = new System.Drawing.Point(35, 3);
            this.grayColorPanel.Name = "grayColorPanel";
            this.grayColorPanel.Size = new System.Drawing.Size(20, 20);
            this.grayColorPanel.TabIndex = 14;
            this.grayColorPanel.Click += new System.EventHandler(this.grayColorPanel_Click);
            this.grayColorPanel.MouseEnter += new System.EventHandler(this.grayColorPanel_MouseEnter);
            this.grayColorPanel.MouseLeave += new System.EventHandler(this.grayColorPanel_MouseLeave);
            // 
            // yellowColorPanel
            // 
            this.yellowColorPanel.BackColor = System.Drawing.Color.Yellow;
            this.yellowColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yellowColorPanel.Location = new System.Drawing.Point(87, 3);
            this.yellowColorPanel.Name = "yellowColorPanel";
            this.yellowColorPanel.Size = new System.Drawing.Size(20, 20);
            this.yellowColorPanel.TabIndex = 20;
            // 
            // blackColorPanel
            // 
            this.blackColorPanel.BackColor = System.Drawing.Color.Black;
            this.blackColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blackColorPanel.Location = new System.Drawing.Point(9, 3);
            this.blackColorPanel.Name = "blackColorPanel";
            this.blackColorPanel.Size = new System.Drawing.Size(20, 20);
            this.blackColorPanel.TabIndex = 11;
            this.blackColorPanel.Click += new System.EventHandler(this.blackColorPanel_Click);
            this.blackColorPanel.MouseEnter += new System.EventHandler(this.blackColorPanel_MouseEnter);
            this.blackColorPanel.MouseLeave += new System.EventHandler(this.blackColorPanel_MouseLeave);
            // 
            // pen
            // 
            this.pen.BackgroundImage = global::Paint.Properties.Resources.pen_img;
            this.pen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pen.Location = new System.Drawing.Point(534, 134);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(83, 87);
            this.pen.TabIndex = 1;
            this.pen.Click += new System.EventHandler(this.pen_Click);
            this.pen.MouseEnter += new System.EventHandler(this.pen_MouseEnter);
            this.pen.MouseLeave += new System.EventHandler(this.pen_MouseLeave);
            // 
            // filling
            // 
            this.filling.BackgroundImage = global::Paint.Properties.Resources.fill_img;
            this.filling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filling.Location = new System.Drawing.Point(623, 227);
            this.filling.Name = "filling";
            this.filling.Size = new System.Drawing.Size(83, 87);
            this.filling.TabIndex = 4;
            this.filling.Click += new System.EventHandler(this.filling_Click);
            this.filling.MouseEnter += new System.EventHandler(this.filling_MouseEnter);
            this.filling.MouseLeave += new System.EventHandler(this.filling_MouseLeave);
            // 
            // fatBrush
            // 
            this.fatBrush.BackgroundImage = global::Paint.Properties.Resources.widthBrush_img;
            this.fatBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fatBrush.Location = new System.Drawing.Point(534, 227);
            this.fatBrush.Name = "fatBrush";
            this.fatBrush.Size = new System.Drawing.Size(83, 87);
            this.fatBrush.TabIndex = 3;
            this.fatBrush.Click += new System.EventHandler(this.fatBrush_Click);
            this.fatBrush.MouseEnter += new System.EventHandler(this.fatBrush_MouseEnter);
            this.fatBrush.MouseLeave += new System.EventHandler(this.fatBrush_MouseLeave);
            // 
            // brush
            // 
            this.brush.BackgroundImage = global::Paint.Properties.Resources.brush_img;
            this.brush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brush.Location = new System.Drawing.Point(623, 134);
            this.brush.Name = "brush";
            this.brush.Size = new System.Drawing.Size(83, 87);
            this.brush.TabIndex = 2;
            this.brush.Click += new System.EventHandler(this.brush_Click);
            this.brush.MouseEnter += new System.EventHandler(this.brush_MouseEnter);
            this.brush.MouseLeave += new System.EventHandler(this.brush_MouseLeave);
            // 
            // desk
            // 
            this.desk.BackColor = System.Drawing.Color.White;
            this.desk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.desk.Location = new System.Drawing.Point(12, 134);
            this.desk.Name = "desk";
            this.desk.Size = new System.Drawing.Size(516, 474);
            this.desk.TabIndex = 0;
            this.desk.TabStop = false;
            this.desk.MouseDown += new System.Windows.Forms.MouseEventHandler(this.desk_MouseDown);
            this.desk.MouseEnter += new System.EventHandler(this.desk_MouseEnter);
            this.desk.MouseLeave += new System.EventHandler(this.desk_MouseLeave);
            this.desk.MouseMove += new System.Windows.Forms.MouseEventHandler(this.desk_MouseMove);
            this.desk.MouseUp += new System.Windows.Forms.MouseEventHandler(this.desk_MouseUp);
            // 
            // activeColorPanel
            // 
            this.activeColorPanel.BackColor = System.Drawing.Color.Black;
            this.activeColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activeColorPanel.Location = new System.Drawing.Point(12, 5);
            this.activeColorPanel.Name = "activeColorPanel";
            this.activeColorPanel.Size = new System.Drawing.Size(50, 50);
            this.activeColorPanel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(932, 620);
            this.Controls.Add(this.pen);
            this.Controls.Add(this.headPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filling);
            this.Controls.Add(this.fatBrush);
            this.Controls.Add(this.brush);
            this.Controls.Add(this.desk);
            this.Controls.Add(this.headBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.headBar;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.headBar.ResumeLayout(false);
            this.headBar.PerformLayout();
            this.headPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.desk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox desk;
        private System.Windows.Forms.Panel pen;
        private System.Windows.Forms.Panel brush;
        private System.Windows.Forms.Panel fatBrush;
        private System.Windows.Forms.Panel filling;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip headBar;
        private System.Windows.Forms.ToolStripMenuItem Files;
        private System.Windows.Forms.ToolStripMenuItem SaveDefault;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel silverColorPanel;
        private System.Windows.Forms.Panel whiteColorPanel;
        private System.Windows.Forms.Panel blackColorPanel;
        private System.Windows.Forms.PictureBox gradientPanel;
        private System.Windows.Forms.Panel purpleColorPanel;
        private System.Windows.Forms.Panel orangeColorPanel;
        private System.Windows.Forms.Panel blueColorPanel;
        private System.Windows.Forms.Panel darkOrangeColorPanel;
        private System.Windows.Forms.Panel navyColorPanel;
        private System.Windows.Forms.Panel pinkColorPanel;
        private System.Windows.Forms.Panel greenColorPanel;
        private System.Windows.Forms.Panel darkPintColorPanel;
        private System.Windows.Forms.Panel redColorPanel;
        private System.Windows.Forms.Panel cyanColorPanel;
        private System.Windows.Forms.Panel maroonColorPanel;
        private System.Windows.Forms.Panel limeColorPanel;
        private System.Windows.Forms.Panel springColorPanel;
        private System.Windows.Forms.Panel grayColorPanel;
        private System.Windows.Forms.Panel yellowColorPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel activeColorPanel;
    }
}


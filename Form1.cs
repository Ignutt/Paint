using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool paint = false,
             brushDrawing = false,
             penDrawing = true,
             fillingDrawing = false,
             fatBrushDrawing = false;

        Color colorOfInstrument = Color.Black;

        int defaultSizeBrush = 10,
            defaultSizePen = 5,
            defaultSizeFatBrushWidth = 10,
            defaultSizeFatBrushHeight = 30;

        // Paint
        private void desk_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            Graphics g = desk.CreateGraphics();
            SolidBrush brushes = new SolidBrush(colorOfInstrument);

            if (penDrawing == true)
            {
                g.FillRectangle(brushes, e.X, e.Y, defaultSizePen, defaultSizePen);

            }
            else if (brushDrawing == true)
            {
                g.FillEllipse(brushes, e.X, e.Y, defaultSizeBrush, defaultSizeBrush);
            }
            else if (fatBrushDrawing == true)
            {
                g.FillEllipse(brushes, e.X, e.Y, defaultSizeFatBrushWidth, defaultSizeFatBrushHeight);
            }
            else if (fillingDrawing == true)
            {
                desk.BackColor = Color.White;
            }
        }    

        private void desk_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                Graphics g = desk.CreateGraphics();
                SolidBrush brushes = new SolidBrush(colorOfInstrument);

                if (penDrawing == true)
                {
                    g.FillRectangle(brushes, e.X, e.Y, defaultSizePen, defaultSizePen);
                }
                else if (brushDrawing == true)
                {
                    g.FillEllipse(brushes, e.X, e.Y, defaultSizeBrush, defaultSizeBrush);
                }
                else if (fatBrushDrawing == true)
                {
                    g.FillEllipse(brushes, e.X, e.Y , defaultSizeFatBrushWidth, defaultSizeFatBrushHeight);
                }
                else if (fillingDrawing == true)
                {
                    desk.BackColor = Color.Yellow;
                }
            }
        }

        private void desk_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }


        // Курсор
        private void desk_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }

        private void desk_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        // Make Buttons
        private void pen_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pen_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void brush_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void brush_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void fatBrush_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void fatBrush_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void filling_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void filling_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        // Change Brush
        private void pen_Click(object sender, EventArgs e)
        {
            penDrawing = true;
            brushDrawing = false;
            fatBrushDrawing = false;
            fillingDrawing = false;

            pen.BorderStyle = BorderStyle.FixedSingle;
            brush.BorderStyle = BorderStyle.None;
            fatBrush.BorderStyle = BorderStyle.None;
            filling.BorderStyle = BorderStyle.None;
        }

        private void brush_Click(object sender, EventArgs e)
        {
            penDrawing = false;
            brushDrawing = true;
            fatBrushDrawing = false;
            fillingDrawing = false;

            pen.BorderStyle = BorderStyle.None;
            brush.BorderStyle = BorderStyle.FixedSingle;
            fatBrush.BorderStyle = BorderStyle.None;
            filling.BorderStyle = BorderStyle.None;
        }

        private void fatBrush_Click(object sender, EventArgs e)
        {
            penDrawing = false;
            brushDrawing = false;
            fatBrushDrawing = true;
            fillingDrawing = false;

            pen.BorderStyle = BorderStyle.None;
            brush.BorderStyle = BorderStyle.None;
            fatBrush.BorderStyle = BorderStyle.FixedSingle;
            filling.BorderStyle = BorderStyle.None;
        }
        private void filling_Click(object sender, EventArgs e)
        {
            penDrawing = false;
            brushDrawing = false;
            fatBrushDrawing = false;
            fillingDrawing = true;

            pen.BorderStyle = BorderStyle.None;
            brush.BorderStyle = BorderStyle.None;
            fatBrush.BorderStyle = BorderStyle.None;
            filling.BorderStyle = BorderStyle.FixedSingle;
        }

        // Make Pallet

        // black
        private void blackColorPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void blackColorPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void blackColorPanel_Click(object sender, EventArgs e)
        {
            colorOfInstrument = Color.Black;
            activeColorPanel.BackColor = Color.Black;
        }

        // white
        private void whiteColorPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void whiteColorPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void whiteColorPanel_Click(object sender, EventArgs e)
        {
            colorOfInstrument = Color.White;
            activeColorPanel.BackColor = Color.White;
        }

        // silver
        private void silverColorPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void silverColorPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void silverColorPanel_Click(object sender, EventArgs e)
        {
            colorOfInstrument = Color.Silver;
            activeColorPanel.BackColor = Color.Silver;
        }

        // gray
        private void grayColorPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void grayColorPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void grayColorPanel_Click(object sender, EventArgs e)
        {
            colorOfInstrument = Color.Gray;
            activeColorPanel.BackColor = Color.Gray;
        }

        // maroon
        private void maroonColorPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void maroonColorPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void maroonColorPanel_Click(object sender, EventArgs e)
        {
            colorOfInstrument = Color.Maroon;
            activeColorPanel.BackColor = Color.Maroon;
        }

        // darkOrange
        private void darkOrangeColorPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void darkOrangeColorPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void darkOrangeColorPanel_Click(object sender, EventArgs e)
        {
            colorOfInstrument = Color.FromArgb(192, 64, 0);
            activeColorPanel.BackColor = Color.FromArgb(192, 64, 0);
        }

        // red
        private void redColorPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void redColorPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void redColorPanel_Click(object sender, EventArgs e)
        {
            colorOfInstrument = Color.Red;
            activeColorPanel.BackColor = Color.Red;
        }

        // pink
        private void pinkColorPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pinkColorPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pinkColorPanel_Click(object sender, EventArgs e)
        {
            colorOfInstrument = Color.FromArgb(255, 192, 255);
            activeColorPanel.BackColor = Color.FromArgb(255, 192, 255);
        }

        // orange
        private void orangeColorPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void orangeColorPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void orangeColorPanel_Click(object sender, EventArgs e)
        {
            colorOfInstrument = Color.FromArgb(255, 128, 0);
            activeColorPanel.BackColor = Color.FromArgb(255, 128, 0);
        }

        // yellow
        private void yellowColorPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void yellowColorPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void yellowColorPanel_Click(object sender, EventArgs e)
        {
            colorOfInstrument = Color.Yellow;
            activeColorPanel.BackColor = Color.Yellow;
        }

        // lime
        private void limeColorPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void limeColorPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void limeColorPanel_Click(object sender, EventArgs e)
        {
            colorOfInstrument = Color.Lime;
            activeColorPanel.BackColor = Color.Lime;
        }

        // Green
        private void greenColorPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void greenColorPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void greenColorPanel_Click(object sender, EventArgs e)
        {
            colorOfInstrument = Color.FromArgb(0, 192, 0);
            activeColorPanel.BackColor = Color.FromArgb(0, 192, 0);
        }

        // spring
        private void springColorPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void springColorPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void springColorPanel_Click(object sender, EventArgs e)
        {
            colorOfInstrument = Color.MediumSpringGreen;
            activeColorPanel.BackColor = Color.MediumSpringGreen;
        }

        // cyan
        private void cyanColorPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void cyanColorPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void cyanColorPanel_Click(object sender, EventArgs e)
        {
            colorOfInstrument = Color.Cyan;
            activeColorPanel.BackColor = Color.Cyan;
        }

        //blue
        private void blueColorPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void blueColorPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void blueColorPanel_Click(object sender, EventArgs e)
        {
            colorOfInstrument = Color.Blue;
            activeColorPanel.BackColor = Color.Blue;
        }

        // darkPint
        private void darkPinkColorPanel_MouseEnter_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void darkPinkColorPanel_MouseLeave_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void darkPinkColorPanel_Click_1(object sender, EventArgs e)
        {
            colorOfInstrument = Color.FromArgb(192, 0, 192);
            activeColorPanel.BackColor = Color.FromArgb(192, 0, 192);
        }

        // navy
        private void navyColorPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void navyColorPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void navyColorPanel_Click(object sender, EventArgs e)
        {
            colorOfInstrument = Color.Navy;
            activeColorPanel.BackColor = Color.Navy;
        }

        // purple
        private void purpleColorPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void purpleColorPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void purpleColorPanel_Click(object sender, EventArgs e)
        {
            colorOfInstrument = Color.Purple;
            activeColorPanel.BackColor = Color.Purple;
        }


        // Make another color
        private void gradientPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void gradientPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void gradientPanel_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            colorOfInstrument = dialog.Color;
            activeColorPanel.BackColor = dialog.Color;
        }

    }
}

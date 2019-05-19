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


        //Colors
        private void choiceColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            colorOfInstrument = dialog.Color;
            //colorPanel.BackColor = dialog.Color;
        }

    }
}

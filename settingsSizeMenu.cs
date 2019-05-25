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
    public partial class settingsSizeMenu : Form
    {
        public settingsSizeMenu()
        {
            InitializeComponent();

            changeEraserBar.Value = Form1.defaultSizeEraser;
            resultEraserPanel.Height = Form1.defaultSizeEraser;
            resultEraserPanel.Width = Form1.defaultSizeEraser;
            resultEraserPanel.Top = (60 - Form1.defaultSizeEraser) / 2;
            resultEraserPanel.Left = (60 - Form1.defaultSizeEraser) / 2;
            infoValueLabelEraser.Text = Form1.defaultSizeEraser.ToString() + " px";

            infoValueLabelPen.Text = Form1.defaultSizePen.ToString() + " px";
            resultPenPanel.Height = Form1.defaultSizePen;
            resultPenPanel.Width = Form1.defaultSizePen;
            resultPenPanel.Top = (60 - Form1.defaultSizePen) / 2;
            resultPenPanel.Left = (60 - Form1.defaultSizePen) / 2;
            changePenBar.Value = Form1.defaultSizePen;

            changeBrushBar.Value = Form1.defaultSizeBrush;
            infoValueLabelBrush.Text = Form1.defaultSizeBrush.ToString() + " px";
            backgroundBrushPanel.Invalidate();
        }

        private void changeEraserBar_Scroll(object sender, EventArgs e)
        {
            Form1.defaultSizeEraser = changeEraserBar.Value;
            infoValueLabelEraser.Text = Form1.defaultSizeEraser.ToString() + " px";
            resultEraserPanel.Height = Form1.defaultSizeEraser;
            resultEraserPanel.Width = Form1.defaultSizeEraser;
            resultEraserPanel.Top = (60 - Form1.defaultSizeEraser) / 2;
            resultEraserPanel.Left = (60 - Form1.defaultSizeEraser) / 2;
        }

        private void changePenBar_Scroll(object sender, EventArgs e)
        {
            Form1.defaultSizePen = changePenBar.Value;
            infoValueLabelPen.Text = Form1.defaultSizePen.ToString() + " px";
            resultPenPanel.Height = Form1.defaultSizePen;
            resultPenPanel.Width = Form1.defaultSizePen;
            resultPenPanel.Top = (60 - Form1.defaultSizePen) / 2;
            resultPenPanel.Left = (60 - Form1.defaultSizePen) / 2;
        }

        private void backgroundBrushPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.White);
            g.FillEllipse(brush, (60 - Form1.defaultSizeBrush) / 2, (60 - Form1.defaultSizeBrush) / 2, Form1.defaultSizeBrush, Form1.defaultSizeBrush);
        }

        private void changeBrushBar_Scroll(object sender, EventArgs e)
        {
            Form1.defaultSizeBrush = changeBrushBar.Value;
            infoValueLabelBrush.Text = Form1.defaultSizeBrush.ToString() + " px";
            backgroundBrushPanel.Invalidate();
        }

        private void backgroundWideBrushPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.White);
            g.FillEllipse(brush, (60 - Form1.defaultSizeFatBrushWidth) / 2, (60 - Form1.defaultSizeFatBrushHeight) / 2, Form1.defaultSizeFatBrushWidth, Form1.defaultSizeFatBrushHeight);
        }

        private void changeWideBrushBarHeight_Scroll(object sender, EventArgs e)
        {
            Form1.defaultSizeFatBrushHeight = changeWideBrushBarHeight.Value;
            infoValueLabelWideBrushHeight.Text = Form1.defaultSizeFatBrushHeight.ToString() + " px";
            backgroundWideBrushPanel.Invalidate();
        }

        private void changeWideBrushBarWidth_Scroll(object sender, EventArgs e)
        {
            Form1.defaultSizeFatBrushWidth = changeWideBrushBarWidth.Value;
            infoValueLabelWideBrushWidth.Text = Form1.defaultSizeFatBrushWidth.ToString() + " px";
            backgroundWideBrushPanel.Invalidate();
        }
    }
}

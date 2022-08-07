﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace The_Compiler
{
    public partial class MyPanel:Panel
    {
        public MyPanel()
        {
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.UserPaint, true);
            this.BackColor = Color.Transparent;
        }

        Color glassColor = Color.CadetBlue;
        [DefaultValue(typeof(Color), "0x5f9ea0")]
        public Color GlassColor
        {
            get { return glassColor; }
            set
            {
                glassColor = value;
                this.Invalidate();
            }
        }
        public GraphicsPath DrawRoundRect(float x, float y, float width, float height, float radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(x + radius, y, x + width - (radius * 2), y); // Line
            gp.AddArc(x + width - (radius * 2), y, radius * 2, radius * 2, 270, 90); // Corner
            gp.AddLine(x + width, y + radius, x + width, y + height - (radius * 2)); // Line
            gp.AddArc(x + width - (radius * 2), y + height - (radius * 2), radius * 2, radius * 2, 0, 90); // Corner
            gp.AddLine(x + width - (radius * 2), y + height, x + radius, y + height); // Line
            gp.AddArc(x, y + height - (radius * 2), radius * 2, radius * 2, 90, 90); // Corner
            gp.AddLine(x, y + height - (radius * 2), x, y + radius); // Line
            gp.AddArc(x, y, radius * 2, radius * 2, 180, 90); // Corner
            gp.CloseFigure();
            return gp;
        }

        bool _border = true;

        bool _BoxShadow = false;

        public bool Border
        {
            set { _border = value; }
            get { return _border; }
        
        }

        public bool BoxShadow
        {
            set { _BoxShadow = value; }
            get { return _BoxShadow; }

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            if (Width < 20 || Height < 20)
            {
                return;
            }
            Graphics gr = e.Graphics;
            GraphicsPath gp = new GraphicsPath();
            LinearGradientBrush br;
            if (Border)
            {
                //draw shadow(black glow)
                for (int i = 0; i < 10; i++)
                {
                    gp = DrawRoundRect(i, i, Width - i * 2 - 1, Height - i * 2 - 1, 7);
                    br = new LinearGradientBrush(Bounds, Color.FromArgb(i * 3, Color.Black), Color.FromArgb(i * 3, Color.Black), LinearGradientMode.Vertical);
                    gr.DrawPath(new Pen(br, 4), gp);
                }
            }

            if (BoxShadow)
            {
                //fill white 50
                gp = DrawRoundRect(9, 9, Width - 19, Height - 19, 7);
                br = new LinearGradientBrush(Bounds, Color.FromArgb(30, Color.White), Color.FromArgb(30, Color.White), LinearGradientMode.Vertical);
                gr.FillPath(br, gp);

                //fill glassColor 70
                gp = DrawRoundRect(9, 9, Width - 19, Height - 19, 7);
                br = new LinearGradientBrush(Bounds, Color.FromArgb(70, glassColor), Color.FromArgb(70, glassColor), LinearGradientMode.Vertical);
                gr.FillPath(br, gp);
            }

            if (Border)
            {
                //white border inner
                gp = DrawRoundRect(9, 9, Width - 19, Height - 19, 7);
                br = new LinearGradientBrush(Bounds, Color.FromArgb(250, Color.White), Color.FromArgb(250, Color.WhiteSmoke), LinearGradientMode.Vertical);
                gr.DrawPath(new Pen(br), gp);

                //black border outer
                gp = DrawRoundRect(8, 8, Width - 17, Height - 17, 7);
                br = new LinearGradientBrush(Bounds, Color.FromArgb(250, Color.Black), Color.FromArgb(250, Color.Black), LinearGradientMode.Vertical);
                gr.DrawPath(new Pen(br), gp);
            }
                //corner glow
                gp = DrawRoundRect(9, 9, Width - 19, Height - 19, 7);
                PathGradientBrush br2 = new PathGradientBrush(gp);
                br2.CenterPoint = new PointF(0f, 0f);
                br2.CenterColor = Color.FromArgb(50, Color.White);
                br2.SurroundColors = new Color[1] { Color.Transparent };
                gr.FillPath(br2, gp);

               br2.CenterPoint = new PointF(Convert.ToSingle(Width), 0f);
               gr.FillPath(br2, gp);
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Tobii.EyeTracking.IO;

namespace eyetracking
{
    public partial class GazePointsForm : Form
    {
        private Point2D _gazePoints;
        private Color _PointColor;
        private static int PixelRadius = 22;
        public GazePointsForm()
        {
            InitializeComponent();
        }
        public void DrawPoint(Point2D point, Color color)
        {
            _gazePoints = point;
            _PointColor = color;
            Invalidate();
        }

        public void ClearPoint()
        {
            _PointColor = Color.Transparent;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw calibration circle
            Size monitorSize = Screen.PrimaryScreen.Bounds.Size;
            Rectangle circleBounds = new Rectangle();
            circleBounds.X = (int)(monitorSize.Width * _gazePoints.X - PixelRadius);
            circleBounds.Y = (int)(monitorSize.Height * _gazePoints.Y - PixelRadius);
            circleBounds.Width = 2 * PixelRadius;
            circleBounds.Height = 2 * PixelRadius;

            Rectangle smallCircleBounds = new Rectangle();
            smallCircleBounds.X = (int)(monitorSize.Width * _gazePoints.X - 1);
            smallCircleBounds.Y = (int)(monitorSize.Height * _gazePoints.Y - 1);
            smallCircleBounds.Width = 2;
            smallCircleBounds.Height = 2;

            using (var brush = new SolidBrush(_PointColor))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillEllipse(brush, circleBounds);

                brush.Color = _PointColor == Color.Transparent ? Color.Transparent : Color.Black;
                e.Graphics.FillEllipse(brush, smallCircleBounds);
            }
        }
        public void GazePointsForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

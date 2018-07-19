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
    public partial class CalibConfirmForm : Form
    {
        public CalibConfirmForm()
        {
            InitializeComponent();
        }
        private Point2D ConfirmPoints { get; set; }
        private Color PointColor { get; set; }
        private const int PixelRadius = 22;

        public void DrawConfirmPoint(Point2D point, Color color)
        {
            ConfirmPoints = point;
            PointColor = color;
            Invalidate();
        }

        public void ClearConfirmPoint()
        {
            PointColor = Color.Transparent;
            Invalidate();
        }
        /*
                public void Form1_Click(object sender, EventArgs e)
                {

                }
        */
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw calibration circle
            Size monitorSize = Screen.PrimaryScreen.Bounds.Size;
            Rectangle circleBounds = new Rectangle();
            circleBounds.X = (int)(monitorSize.Width * ConfirmPoints.X - PixelRadius);
            circleBounds.Y = (int)(monitorSize.Height * ConfirmPoints.Y - PixelRadius);
            circleBounds.Width = 2 * PixelRadius;
            circleBounds.Height = 2 * PixelRadius;

            Rectangle smallCircleBounds = new Rectangle();
            smallCircleBounds.X = (int)(monitorSize.Width * ConfirmPoints.X - 1);
            smallCircleBounds.Y = (int)(monitorSize.Height * ConfirmPoints.Y - 1);
            smallCircleBounds.Width = 2;
            smallCircleBounds.Height = 2;

            using (var brush = new SolidBrush(PointColor))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                /*                using (StreamWriter sw = new StreamWriter("CalibConfirm.txt", true))
                                {
                                    // Add some text to the file.
                                    // Arbitrary objects can also be written to the file.
                                    sw.WriteLine("Drawing circle " + circleBounds + " color " + PointColor);
                                }

                                Console.WriteLine("Drawing circle " + circleBounds + " color " + PointColor);
                */
                e.Graphics.FillEllipse(brush, circleBounds);

                brush.Color = PointColor == Color.Transparent ? Color.Transparent : Color.Black;
                e.Graphics.FillEllipse(brush, smallCircleBounds);
            }
        }

    }
}

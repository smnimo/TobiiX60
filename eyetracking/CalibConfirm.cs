using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Tobii.EyeTracking.IO;

namespace eyetracking
{
    class CalibConfirm
    {
        private CalibConfirmForm _form1;
        private Timer _sleepTimer;
        private Timer _sleepTimer2;
        private Timer _sleepTimer3;
        public Queue<Point2D> _confirmPoints;
        private IEyeTracker _tracker;
        private Point2D _leftGaze;
        private Point2D _rightGaze;
        private Point2D _Gaze;
        private Point2D points;
        private Point2D _picpoints;
        private Point2D _error;
        private static int PixelRadius = 22;
        private gazeForm _gazeform;
        private bool _flag = false;
        private double error_sum = 0.0;
        private int count = 0;

        public CalibConfirm()
        {
            _sleepTimer = new Timer();
            _sleepTimer.Interval = 2000;
            _sleepTimer.Tick += new EventHandler(_sleepTimer_Tick);
            _sleepTimer2 = new Timer();
            _sleepTimer2.Interval = 500;
            _sleepTimer2.Tick += new EventHandler(_sleepTimer2_Tick);
            _sleepTimer3 = new Timer();
            _sleepTimer3.Interval = 1500;
            _sleepTimer3.Tick += new EventHandler(_sleepTimer3_Tick);
            _form1 = new CalibConfirmForm();
            _gazeform = new gazeForm();
            _gazeform.Width = PixelRadius * 2;
            _gazeform.Height = PixelRadius * 2;
            _gazeform.Hide();
            _form1.Load += new EventHandler(form1_Load);
        }
        public void run(IEyeTracker tracker)
        {
            _tracker = tracker;
            _tracker.ConnectionError += HandleConnectionError;
            _form1.ClearConfirmPoint();
            _sleepTimer.Start();
            Console.WriteLine("start");
            using (StreamWriter sw = new StreamWriter("CalibConfirm.txt"))
            {
                // Add some text to the file.
                // Arbitrary objects can also be written to the file.
                sw.WriteLine("start");
            }
            _tracker.StartTracking();
            _tracker.GazeDataReceived += _tracker_GazeDataReceived;
            _form1.ShowDialog();
            Console.WriteLine("end");
            using (StreamWriter sw = new StreamWriter("CalibConfirm.txt", true))
            {
                sw.WriteLine("end");
                sw.Close();
            }
            _gazeform.Close();
        }

        public void _tracker_GazeDataReceived(object sender, GazeDataEventArgs e)
        {
            /*
                log取る
            */
            _leftGaze = e.GazeDataItem.LeftGazePoint2D;
            _rightGaze = e.GazeDataItem.RightGazePoint2D;
            Size monitorSize = Screen.PrimaryScreen.Bounds.Size;

            if (_leftGaze.X != -1 && _leftGaze.Y != -1 && _rightGaze.X != -1 && _rightGaze.Y != -1)
            {

                _Gaze.X = (int)(monitorSize.Width * (_leftGaze.X + _rightGaze.X) / 2);
                _Gaze.Y = (int)(monitorSize.Height * (_leftGaze.Y + _rightGaze.Y) / 2);
                //                _gazeform.Top = (int)_Gaze.Y - PixelRadius;
                //                _gazeform.Left = (int)_Gaze.X - PixelRadius;
                //                _gazeform.Show();
                _picpoints.X = (int)(monitorSize.Width * points.X);
                _picpoints.Y = (int)(monitorSize.Height * points.Y);
                _error.X = _Gaze.X - _picpoints.X;
                _error.Y = _Gaze.Y - _picpoints.Y;
                //Console.WriteLine("{0} {1}   {2} {3}", _Gaze.X, _Gaze.Y);
                if (_flag)
                {
                    using (StreamWriter sw = new StreamWriter("CalibConfirm.txt", true))
                    {
                        sw.WriteLine("confirm" + _picpoints + ",  Gaze" + _Gaze + ",  error " + _error);
                    }
                    error_sum += Math.Sqrt((double)(_error.X * _error.X + _error.Y * _error.Y));
                    count++;
                }
            }
            /*            else
                        {
                            _gazeform.Hide();
                        }
             */
        }
        void _sleepTimer_Tick(object sender, EventArgs e)
        {
            _sleepTimer.Stop();
            NextorFinish();
        }

        void _sleepTimer2_Tick(object sender, EventArgs e)
        {
            _sleepTimer2.Stop();
            _flag = true;
        }
        void _sleepTimer3_Tick(object sender, EventArgs e)
        {
            _sleepTimer3.Stop();
            _flag = false;
        }
        public void form1_Load(object sender, EventArgs e)
        {
            CreatePointList();
        }

        private void CreatePointList()
        {
            _confirmPoints = new Queue<Point2D>();
            _confirmPoints.Enqueue(new Point2D(0.5, 0.1));
            _confirmPoints.Enqueue(new Point2D(0.1, 0.5));
            _confirmPoints.Enqueue(new Point2D(0.9, 0.5));
            _confirmPoints.Enqueue(new Point2D(0.5, 0.9));
        }

        public void NextorFinish()
        {
            if (_confirmPoints.Count > 0)
            {
                points = _confirmPoints.Dequeue();
                using (StreamWriter sw = new StreamWriter("CalibConfirm.txt", true))
                {
                    sw.WriteLine("");
                    sw.WriteLine("");
                }

                _sleepTimer.Start();
                _sleepTimer2.Start();
                _sleepTimer3.Start();
                _form1.DrawConfirmPoint(points, Color.Yellow);
            }
            else
            {
                _tracker.StopTracking();
                _tracker.GazeDataReceived -= _tracker_GazeDataReceived;
                _form1.Close();
                error_sum = error_sum / count;
                if (error_sum > 100)
                {
                    MessageBox.Show("have to callibrate", "error", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("OK", "OK", MessageBoxButtons.OK);
                }
            }
        }
        private void HandleConnectionError(object sender, ConnectionErrorEventArgs e)
        {
            AbortConfirm();
        }

        private void AbortConfirm()
        {
            _sleepTimer.Stop();
            _sleepTimer2.Stop();
            _sleepTimer3.Stop();
            _form1.Close();
        }

    }
}

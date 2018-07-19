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
using System.Diagnostics;

namespace eyetracking
{
    class DammyPoints
    {
        private GazePointsForm _gazePointsform;
        private Point2D _Gaze;
        private PictureBox[] pb;                                             //picturebox
        private Label[] lb;
        private Size monitorSize = Screen.PrimaryScreen.Bounds.Size;
        // lay out
        private const int vN = 3;
        private const int cN = 4;
        private const int N = cN * vN;
        private int[] list;
        private int seed = Environment.TickCount;
        private StreamWriter swt;
        private StreamWriter swtlist;
        private Timer _sleeptimer1;
        private Timer _sleeptimer2;
        private Timer _sleeptimer3;
        private int count;
        private Stopwatch sw;

        public DammyPoints(int picpage)
        {
            _gazePointsform = new GazePointsForm();
            pb = new PictureBox[N];
            lb = new Label[N];
            for (int i = 0; i < N; i++)
            {
                pb[i] = new PictureBox();                                             //picturebox
                lb[i] = new Label();
            }
            list = new int[N];
            string now = DateTime.Now.ToString("yyMMddhhmmss");
            string csvname = String.Format("./dammy/{0}.csv", now);
            swt = new StreamWriter(csvname);
            string listname = String.Format("./dammy/{0}.list", now);
            swtlist = new StreamWriter(listname);
            StreamWriter listwriter = new StreamWriter("./dammy/timestamp.list", true);
            listwriter.WriteLine(now);
            listwriter.Close();
            makelist(list, picpage);
            for (int i = 0; i < N; i++)
            {
                pb[i].SizeMode = PictureBoxSizeMode.StretchImage;
                string filename = String.Format("../../images/{0}.jpg", list[i]);
                pb[i].Image = new Bitmap(filename);
                pb[i].Size = new Size(monitorSize.Width / cN, monitorSize.Height / vN);
                int Ly = i / cN;
                int Lx = i - Ly * cN;
                pb[i].Location = new Point(monitorSize.Width * Lx / cN, monitorSize.Height * Ly / vN);
                //pb[i].MouseMove += new MouseEventHandler(_gazePointsform_MouseMove);
                pb[i].Click += new EventHandler(pb_Click);
                pb[i].Parent = _gazePointsform;                                      //picturebox
                pb[i].Hide();
                lb[i].Text = String.Format("{0}", i + 1);
                lb[i].Font = new Font("Arial", 30);
                lb[i].Size = new Size(monitorSize.Width / cN / 4, monitorSize.Height / vN / 4);
                lb[i].Location = new Point(10, 10);
                lb[i].Parent = pb[i];
                lb[i].Hide();
            }
            _sleeptimer1 = new Timer();
            _sleeptimer1.Interval = 50;
            _sleeptimer1.Tick += new EventHandler(_sleeptimer1_Tick);
            _sleeptimer2 = new Timer();
//            _sleeptimer2.Interval = 60000;
            _sleeptimer2.Interval = 5000;
            _sleeptimer2.Tick += new EventHandler(_sleeptimer2_Tick);
            _sleeptimer3 = new Timer();
            _sleeptimer3.Interval = 50;
            _sleeptimer3.Tick += new EventHandler(_sleeptimer3_Tick);
            sw = new Stopwatch();
        }

        public void run()
        {
            count = 0;
            _sleeptimer1.Start();
//            _gazePointsform.MouseMove += new MouseEventHandler(_gazePointsform_MouseMove);
            _gazePointsform.ClearPoint();
            _gazePointsform.ShowDialog();
        }

        void _sleeptimer1_Tick(object sender, EventArgs e)
        {
            _sleeptimer1.Stop();
            NextorFinish();
        }

        void _sleeptimer2_Tick(object sender, EventArgs e)
        {
            _sleeptimer2.Stop();
            sw.Stop();
            for (int i = 0; i < N; i++)
            {
                pb[i].MouseMove -= new MouseEventHandler(_gazePointsform_MouseMove);
                pb[i].Hide();
            }
            _gazePointsform.MouseMove -= new MouseEventHandler(_gazePointsform_MouseMove);
            _sleeptimer3.Start();
        }

        void _sleeptimer3_Tick(object sender, EventArgs e)
        {
            _sleeptimer3.Stop();
            for (int i = 0; i < N; i++)
            {
                pb[i].Show();
                lb[i].Show();
            }
        }

        void NextorFinish()
        {
            if (count == 0)
            {
                pb[count].Show();
                _sleeptimer1.Start();
            }
            else if (count == 12)
            {
                pb[count - 1].Hide();
                _sleeptimer1.Start();
            }
            else if (count == 13)
            {
                for(int i = 0; i < N; i++)
                {
                    pb[i].Show();
                    pb[i].MouseMove += new MouseEventHandler(_gazePointsform_MouseMove);
                }
                _sleeptimer2.Start();
                sw.Start();
                _gazePointsform.MouseMove += new MouseEventHandler(_gazePointsform_MouseMove);
            }
            else
            {
                pb[count - 1].Hide();
                pb[count].Show();
                _sleeptimer1.Start();
            }
            count++;
        }

        void _gazePointsform_MouseMove(object sender, MouseEventArgs e)
        {
            _Gaze.X = (double)Cursor.Position.X / (double)monitorSize.Width;
            _Gaze.Y = (double)Cursor.Position.Y / (double)monitorSize.Height;
            swt.WriteLine("{0}, {1}, {2}", sw.ElapsedMilliseconds, _Gaze.X, _Gaze.Y);
        }

        public void pb_Click(object sender, EventArgs e)
        {
            _gazePointsform.Close();
            swt.Close();
        }
        public void makelist(int[] list, int page)
        {
            Random rnd = new Random(seed++);
            int[] fulllist = new int[N];
            for (int i = 0; i < N; i++)
            {
                fulllist[i] = ((i / 3) + 1) * 100 + (i % 3) + 1 + page * 3;
            }
            List<int> numlist = new List<int>(fulllist);
            for (int i = 0; i < N; i++)
            {
                int num = rnd.Next(N - i);
                list[i] = numlist[num];
                numlist.RemoveAt(num);
                swtlist.WriteLine("{0}", list[i]);
            }
            swtlist.Close();
        }

        private void AbortConfirm()
        {
            sw.Stop();
            swt.Close();
            _gazePointsform.MouseMove -= new MouseEventHandler(_gazePointsform_MouseMove);
            Console.WriteLine("error");
            _gazePointsform.Close();
        }
    }
}
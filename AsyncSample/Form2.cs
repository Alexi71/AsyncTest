using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncSample
{
    public partial class Form2 : Form
    {

        Stopwatch stopwatch = new Stopwatch();


        public Form2()
        {
            InitializeComponent();
            ThreadPool.QueueUserWorkItem(new WaitCallback(Timer));
            gehen.Enabled = false;
        }


        private void Timer(object callback)
        {
            while (true)
            {
                var sec = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
                lock (this)
                {
                    UpdateUiTimer(sec);
                }
                Thread.Sleep(1000);
            }

        }

        private void UpdateUiTimer(string sec)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateUiTimer(sec)));
                return;
            }
            time.Text = sec.ToString();
        }

        private void kommen_Click(object sender, EventArgs e)
        {            
            ThreadPool.QueueUserWorkItem(new WaitCallback(Working));
            gehen.Enabled = true;
            kommen.Enabled = false;
            status.Text = "Anwesend";
        }

        private void gehen_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            gehen.Enabled = false;
            kommen.Enabled = true;
            status.Text = "Abwesend";
        }

        private void Working (object callback)
        {
            stopwatch.Start();
            TimeSpan ts;
            string elapsedTime;


            for (int i = 0; i <= 1000; i++)
            {
                ts = stopwatch.Elapsed;

                elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Hours, ts.Minutes, ts.Seconds);

                lock (this)
                {
                    UpdateUiTime(elapsedTime);
                }
                Thread.Sleep(100);
            }
        }

        private void UpdateUiTime(string elapsedTime)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateUiTime(elapsedTime)));
                return;
            }
            currentTime.Text = elapsedTime;
        }



    }
}

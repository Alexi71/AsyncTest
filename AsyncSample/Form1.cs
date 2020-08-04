using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncSample
{
    public partial class Form1 : Form
    {
        private BackgroundWorker _worker;
        private Thread _thread;
        public Form1()
        {
            InitializeComponent();

            _thread = new Thread(DoMe);
            _worker = new BackgroundWorker();
            _worker.DoWork += _worker_DoWork;
            _worker.WorkerReportsProgress = true;
            _worker.ProgressChanged += (sender, args) =>
            {
                var progress = args.ProgressPercentage;
                label1.Text = progress.ToString();
            };

            _worker.RunWorkerCompleted += (sender, args) =>
            {
                MessageBox.Show("Habe Fertig");
            };

            //_thread.Start();
        }

        private void _worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (var i = 0; i < 1000; i++)
            {
                _worker.ReportProgress(i);
                Thread.Sleep(100);
            }
        }

        private void DoMe()
        {
            for (int i = 0; i < 100; i++)
            {
                lock (this)
                {
                    UpdateUi(i);
                }
                Thread.Sleep(100);
            }
            //Completion....
        }

        private void UpdateUi(int i)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateUi(i)));
                return;
            }
            label1.Text = i.ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Started...";
            //await GetLoop();
            //label1.Text = "Completed...";

            //_worker.RunWorkerAsync();
            _thread.Start();
        }

        static void DoWork(int i)
        {
            Console.WriteLine(i + " ");
        }

        private async Task GetLoop()
        {
            //await Task.Run(() =>
            //{
            //    for (var i = 0; i < 1000000; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //});
            await Task.Delay(10000);

        }
    }
}

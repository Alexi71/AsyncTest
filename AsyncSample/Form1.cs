using System;
using System.Threading;
using System.Windows.Forms;

namespace AsyncSample
{
    public partial class Form1 : Form
    {
        //private BackgroundWorker _worker;
        private Thread _threadDo;
        private Thread _threadclock;

        public Form1()
        {
            InitializeComponent();

            _threadDo = new Thread(Do);
            _threadclock = new Thread(timer);

            //_worker = new BackgroundWorker();
            //_worker.WorkerReportsProgress = true;
            //_worker.ProgressChanged += (sender, args) =>
            //{
            //    var progress = args.ProgressPercentage;
            //    label1.Text = progress.ToString(); 
            //};
        }

        private void timer()
        {
            while (true)
            {
                var sec = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
                lock (this)
                {
                    UpdateUiTimer(sec);
                }
                Thread.Sleep(100);
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

        private void Do()
        {
            for (int i = 0; i <= 100; i++)
            {
                lock (this)
                {
                    UpdateUiCounter(i);
                }
                Thread.Sleep(100);
            }
            //Completion....
        }

        private void UpdateUiCounter(int i)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateUiCounter(i)));
                return;
            }
            counter.Text = i.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _threadDo.Start();
            _threadclock.Start();
        }
    }
}

using System;
using System.Threading;
using System.Windows.Forms;

namespace AsyncSample
{
    public partial class Form1 : Form
    {
        //private BackgroundWorker _worker;
        private Thread _threadDoME;

        public Form1()
        {
            InitializeComponent();

            _threadDoME = new Thread(DoMe);


            //_threadtimer = new Thread(timer);
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
            var sec = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
            time.Text = sec;
        }

        private void DoMe()
        {
            for (int i = 0; i <= 1000; i++)
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
            timer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _threadDoME.Start();
        }
    }
}

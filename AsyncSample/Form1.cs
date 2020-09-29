using System;
using System.Threading;
using System.Windows.Forms;

namespace AsyncSample
{
    public partial class Form1 : Form
    {
        //private BackgroundWorker _worker;
        private bool _counterIsRunning = false;
        int Anzahl;


        public Form1()
        {
            InitializeComponent();



            //_worker = new BackgroundWorker();
            //_worker.WorkerReportsProgress = true;
            //_worker.ProgressChanged += (sender, args) =>
            //{
            //    var progress = args.ProgressPercentage;
            //    label1.Text = progress.ToString(); 
            //};
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

        private void Count(object callback)
        {
            for (int i = 0; i <= Anzahl; i++)
            { 
                if (!_counterIsRunning)
                         break;
                lock (this)
                {
                    UpdateUiCounter(i);
                }
                Thread.Sleep(10);
                
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
            _counterIsRunning = true;
            ThreadPool.QueueUserWorkItem(new WaitCallback(Timer));
            ThreadPool.QueueUserWorkItem(new WaitCallback(Count));
            Start.Enabled = false;
            AnzahlLoops.Enabled = false;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            _counterIsRunning = false;
            Thread.Sleep(1000);
            _counterIsRunning = true;
            ThreadPool.QueueUserWorkItem(new WaitCallback(Count));            
        }

        private void AnzahlLoops_TextChanged(object sender, EventArgs e)
        {
            Anzahl = int.Parse(AnzahlLoops.Text);           
        }
    }
}

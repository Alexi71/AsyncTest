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
            _worker.WorkerReportsProgress = true;
            _worker.ProgressChanged += (sender, args) =>
            {
                var progress = args.ProgressPercentage;
                label1.Text = progress.ToString(); 
            };

            //_thread.Start();
        }

        private void DoMe()
        {
            for (int i = 0; i <= 10; i++)
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

        private void button1_Click(object sender, EventArgs e)   
        {
            _thread.Start();
        }

        

    }
}

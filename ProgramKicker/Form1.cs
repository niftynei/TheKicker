using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProgramKicker
{
    public partial class Kicker : Form
    {
        private delegate void SetTextCallback(TimeSpan time);
        private delegate void SetToggleCallback();
        private String _fileName;
        private readonly BackgroundWorker _worker = new BackgroundWorker();

        public Kicker()
        {
            InitializeComponent();
            openFileDialog1.AutoUpgradeEnabled = true;
            HourPicker.Minimum = 0;
            HourPicker.Maximum = 23;
            MinutePicker.Minimum = 0;
            MinutePicker.Maximum = 59;
            SecondPicker.Minimum = 0;
            SecondPicker.Maximum = 59;

            StopButton.Enabled = false;
            textBox1.Enabled = false;

            _worker.WorkerSupportsCancellation = true;
            _worker.RunWorkerCompleted += WorkerRunWorkerCompleted;
            _worker.DoWork += SleepTilKick;
        }

        private void FilePicker_Click(object sender, EventArgs e)
        {
            // Open file picker!
            openFileDialog1.ShowDialog();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_fileName) && File.Exists(_fileName))
            {
                try
                {
                    var timeSpan = new TimeSpan((int)HourPicker.Value, (int)MinutePicker.Value, (int)SecondPicker.Value);
                    // kick off timer
                    DateTime runAt = DateTime.Now + timeSpan;
                    StartTimer(runAt);
                }
                catch
                {

                }


                // Get value from numbers
                toggleButtons();

                // Hide
                ExeKickerNotifier.Visible = true;


            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            // Stop thread
            InterruptTimer();
            toggleButtons();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (openFileDialog1.CheckFileExists)
            {
                textBox1.Text = openFileDialog1.FileName;
                _fileName = openFileDialog1.FileName;
            }
        }

        public void StartTimer(DateTime runAt)
        {
            _worker.RunWorkerAsync(runAt);
        }

        public void InterruptTimer()
        {
            if (_worker.IsBusy)
            {
                // Stop Timer!
                _worker.CancelAsync();

                // Show UI?
            }
        }

        private void SleepTilKick(object sender, DoWorkEventArgs e)
        {
            TimeSpan timeToRing = (DateTime)e.Argument - DateTime.Now;
            while (timeToRing.TotalMilliseconds > 900 && !_worker.CancellationPending)
            {
                Thread.Sleep(500);
                updateTimer(timeToRing);
                timeToRing = (DateTime)e.Argument - DateTime.Now;
            }

            if (_worker.CancellationPending)
            {
                return;
            }

            startProgram();
        }

        private void WorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label1.Text = "00:00:00";
        }

        private void updateTimer(TimeSpan timeSpan)
        {
            if (label1.InvokeRequired)
            {
                SetTextCallback callback = updateTimer;
                Invoke(callback, new object[] { timeSpan });
            }
            else
            {
                label1.Text = timeSpan.ToString(@"hh\:mm\:ss");
                label1.Update();
            }
        }

        private void startProgram()
        {
            var process = Process.Start(_fileName);
            if (process != null)
                process.WaitForExit();

            // hide to systray
        }

        private void toggleButtons()
        {
            if (StartButton.InvokeRequired)
            {
                SetToggleCallback callback = toggleButtons;
                Invoke(callback, new object[] { });
            }
            else
            {
                StartButton.Enabled = !StartButton.Enabled;
                StopButton.Enabled = !StopButton.Enabled;
                FilePicker.Enabled = !FilePicker.Enabled;
            }
        }
    }
}

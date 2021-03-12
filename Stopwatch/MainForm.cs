using System;
using System.Drawing;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class MainForm : Form
    {
        private readonly Stopwatch stopwatch = new Stopwatch();
        private readonly Timer timer = new Timer();

        public MainForm()
        {
            InitializeComponent();

            timeLabel.Text = stopwatch.TotalDuration.ToString("mm':'ss':'ff");
            resetButton.Visible = false;

            startStopButton.Click += StartStopButtonClick;
            resetButton.Click += ResetButtonClick;
            intervalSecondRadioButton.CheckedChanged += IntervalSecondRadioButtonChecked;
            intervalTenthSecondRadioButton.CheckedChanged += IntervalTenthSecondRadioButtonChecked;
            intervalHundredthSecondRadioButton.CheckedChanged += IntervalHundredthSecondRadioButtonChecked;

            timer.Tick += UpdateElapsedTime;
            timer.Interval = 10;
        }

        private void IntervalSecondRadioButtonChecked(object sender, EventArgs e)
        {
            if (intervalSecondRadioButton.Checked)
            {
                timer.Interval = 1000;
            }
        }

        private void IntervalTenthSecondRadioButtonChecked(object sender, EventArgs e)
        {
            if (intervalTenthSecondRadioButton.Checked)
            {
                timer.Interval = 100;
            }
        }

        private void IntervalHundredthSecondRadioButtonChecked(object sender, EventArgs e)
        {
            if (intervalHundredthSecondRadioButton.Checked)
            {
                timer.Interval = 10;
            }
        }

        private void UpdateElapsedTime(object sender, EventArgs e)
        {
            timeLabel.Text = stopwatch.ElapsedTime.ToString("mm':'ss':'ff");
        }

        private void ResetButtonClick(object sender, EventArgs e)
        {
            stopwatch.Reset();
            timeLabel.Text = stopwatch.ElapsedTime.ToString("mm':'ss':'ff");
            durationsListBox.Items.Clear();
        }

        private void StartStopButtonClick(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                timeLabel.Text = stopwatch.ElapsedTime.ToString("mm':'ss':'ff");
                stopwatch.Stop();
                timer.Stop();
                startStopButton.Text = "Start";
                startStopButton.BackColor = Color.FromArgb(94, 188, 104);
                durationsListBox.Items.Insert(0, stopwatch.TotalDuration.ToString("mm':'ss':'ff"));
                resetButton.Visible = true;
            }
            else
            {
                stopwatch.Start();
                timer.Start();
                startStopButton.Text = "Stop";
                startStopButton.BackColor = Color.FromArgb(246, 48, 48);
                resetButton.Visible = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPIS
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void setRunButtonEnabled(object sender, EventArgs e)
        {
            runButton.Enabled = (threadCountTextBox.TextLength > 0) && (MatrixDimensionTextBox.TextLength > 0);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            LogString("Создается " + threadCountTextBox.Text + " потоков для вычисления матриц размерностью " + MatrixDimensionTextBox.Text + "x" + MatrixDimensionTextBox.Text + "...", true);
            MultiThread multiThread = new MultiThread(Convert.ToInt32(threadCountTextBox.Text), Convert.ToInt32(MatrixDimensionTextBox.Text));
            multiThread.CreateThreads();
            List<long> res = multiThread.ReleaseSemaphore();
            SetStartTimesTextBox(multiThread.startTimes);
            ShowGraphic(res);
        }

        private void SetStartTimesTextBox(List<DateTime> dates)
        {
            TimesTextBox.Text = "";
            int i = 0;
            foreach (DateTime item in dates)
            {
                TimesTextBox.Text += "Поток " + i + " стартовал в " + item.Hour + ":" + item.Minute + ":" + item.Second + "." + item.Millisecond + "\n";
                i++;
            }
        }

        private void ShowGraphic(List<long> durations)
        {
            int i = 1;
            durationsChart.Series[0].Points.Clear();
            foreach (long item in durations)
            {
                LogString("Время выполнения потока "+i+" - "+item+" миллисекунд", false);
                durationsChart.Series[0].Points.Add((double)item);
                i++;
            }
        }

        private void LogString(string str, bool clear)
        {
            if (clear)
                Log.Text = "";
            Log.Text += str + "\n";
            Log.SelectionStart = Log.Text.Length;
            Log.ScrollToCaret();
        }
    }
}

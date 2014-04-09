﻿using System;
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
            resultsTextBox.Text = "";
            MultiThread multiThread = new MultiThread(Convert.ToInt32(threadCountTextBox.Text), Convert.ToInt32(MatrixDimensionTextBox.Text));
            multiThread.CreateThreads();
            List<long> res = multiThread.ReleaseSemaphore();
            SetStartTimesTextBox(multiThread.startTimes);
            foreach (long item in res)
            {
                resultsTextBox.Text += item + ", ";
            }
            resultsTextBox.Text += "конец.";
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
    }
}

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
            MultiThread.InitSemaphore(0, Convert.ToInt32(threadCountTextBox.Text));
            MultiThread.CreateThreads(MultiThread.taskCount);
            List<int> res = MultiThread.ReleaseSemaphore(MultiThread.taskCount);
            foreach (int item in res)
            {
                resultsTextBox.Text += item + ", ";
            }
            resultsTextBox.Text += "конец.";
        }
    }
}

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

        private void runButton_Click(object sender, EventArgs e)
        {
            MultiThread.InitSemaphore(0, 10);
            MultiThread.CreateThreads(10);
            List<int> res = MultiThread.ReleaseSemaphore(10);
            foreach (int item in res)
            {
                resultsTextBox.Text += item + ", ";
            }
            resultsTextBox.Text += "конец.";
        }
    }
}

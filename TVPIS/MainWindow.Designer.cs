namespace TVPIS
{
    partial class MainWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.runButton = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.RichTextBox();
            this.threadCountTextBox = new System.Windows.Forms.TextBox();
            this.MatrixDimensionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimesTextBox = new System.Windows.Forms.RichTextBox();
            this.durationsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.durationsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Enabled = false;
            this.runButton.Location = new System.Drawing.Point(128, 66);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(100, 23);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Выполнить";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(12, 338);
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.Size = new System.Drawing.Size(555, 88);
            this.Log.TabIndex = 1;
            this.Log.Text = "";
            // 
            // threadCountTextBox
            // 
            this.threadCountTextBox.Location = new System.Drawing.Point(128, 14);
            this.threadCountTextBox.Name = "threadCountTextBox";
            this.threadCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.threadCountTextBox.TabIndex = 2;
            this.threadCountTextBox.TextChanged += new System.EventHandler(this.setRunButtonEnabled);
            this.threadCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // MatrixDimensionTextBox
            // 
            this.MatrixDimensionTextBox.Location = new System.Drawing.Point(128, 40);
            this.MatrixDimensionTextBox.Name = "MatrixDimensionTextBox";
            this.MatrixDimensionTextBox.Size = new System.Drawing.Size(100, 20);
            this.MatrixDimensionTextBox.TabIndex = 3;
            this.MatrixDimensionTextBox.TextChanged += new System.EventHandler(this.setRunButtonEnabled);
            this.MatrixDimensionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество потоков";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Размерность матриц";
            // 
            // TimesTextBox
            // 
            this.TimesTextBox.Location = new System.Drawing.Point(15, 95);
            this.TimesTextBox.Name = "TimesTextBox";
            this.TimesTextBox.ReadOnly = true;
            this.TimesTextBox.Size = new System.Drawing.Size(213, 237);
            this.TimesTextBox.TabIndex = 6;
            this.TimesTextBox.Text = "";
            // 
            // durationsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.durationsChart.ChartAreas.Add(chartArea1);
            this.durationsChart.Location = new System.Drawing.Point(234, 12);
            this.durationsChart.Name = "durationsChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Threads";
            this.durationsChart.Series.Add(series1);
            this.durationsChart.Size = new System.Drawing.Size(333, 320);
            this.durationsChart.TabIndex = 7;
            this.durationsChart.Text = "График продолжительностей";
            title1.Name = "diagramName";
            title1.Text = "Диаграмма продолжительностей";
            this.durationsChart.Titles.Add(title1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 438);
            this.Controls.Add(this.durationsChart);
            this.Controls.Add(this.TimesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MatrixDimensionTextBox);
            this.Controls.Add(this.threadCountTextBox);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.runButton);
            this.Name = "MainWindow";
            this.Text = "Лабораторная работа 1";
            ((System.ComponentModel.ISupportInitialize)(this.durationsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.RichTextBox Log;
        private System.Windows.Forms.TextBox threadCountTextBox;
        private System.Windows.Forms.TextBox MatrixDimensionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TimesTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart durationsChart;
    }
}


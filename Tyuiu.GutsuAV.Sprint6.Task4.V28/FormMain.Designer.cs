
namespace Tyuiu.GutsuAV.Sprint6.Task4.V28
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxStopStep_GAV = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_GAV = new System.Windows.Forms.TextBox();
            this.chartFunction_GAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxResult_GAV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GAV)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStopStep_GAV
            // 
            this.textBoxStopStep_GAV.Location = new System.Drawing.Point(390, 103);
            this.textBoxStopStep_GAV.Name = "textBoxStopStep_GAV";
            this.textBoxStopStep_GAV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_GAV.TabIndex = 0;
            // 
            // textBoxStartStep_GAV
            // 
            this.textBoxStartStep_GAV.Location = new System.Drawing.Point(163, 149);
            this.textBoxStartStep_GAV.Name = "textBoxStartStep_GAV";
            this.textBoxStartStep_GAV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_GAV.TabIndex = 1;
            // 
            // chartFunction_GAV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_GAV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_GAV.Legends.Add(legend1);
            this.chartFunction_GAV.Location = new System.Drawing.Point(414, 129);
            this.chartFunction_GAV.Name = "chartFunction_GAV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_GAV.Series.Add(series1);
            this.chartFunction_GAV.Size = new System.Drawing.Size(300, 300);
            this.chartFunction_GAV.TabIndex = 2;
            this.chartFunction_GAV.Text = "chart1";
            // 
            // textBoxResult_GAV
            // 
            this.textBoxResult_GAV.Location = new System.Drawing.Point(337, 46);
            this.textBoxResult_GAV.Name = "textBoxResult_GAV";
            this.textBoxResult_GAV.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_GAV.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResult_GAV);
            this.Controls.Add(this.chartFunction_GAV);
            this.Controls.Add(this.textBoxStartStep_GAV);
            this.Controls.Add(this.textBoxStopStep_GAV);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 28 | Гуцу А. В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GAV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStopStep_GAV;
        private System.Windows.Forms.TextBox textBoxStartStep_GAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GAV;
        private System.Windows.Forms.TextBox textBoxResult_GAV;
    }
}


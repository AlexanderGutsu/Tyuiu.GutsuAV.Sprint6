
namespace Tyuiu.GutsuAV.Sprint6.Task5.V7
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonResult_GAV = new System.Windows.Forms.Button();
            this.dataGridViewNums__GAV = new System.Windows.Forms.DataGridView();
            this.chartGraf__GAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonOpenFile_GAV = new System.Windows.Forms.Button();
            this.buttonInfo_GAV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums__GAV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf__GAV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonResult_GAV
            // 
            this.buttonResult_GAV.Location = new System.Drawing.Point(397, 207);
            this.buttonResult_GAV.Name = "buttonResult_GAV";
            this.buttonResult_GAV.Size = new System.Drawing.Size(75, 23);
            this.buttonResult_GAV.TabIndex = 1;
            this.buttonResult_GAV.Text = "button1";
            this.buttonResult_GAV.UseVisualStyleBackColor = true;
            this.buttonResult_GAV.Click += new System.EventHandler(this.buttonResult_GAV_Click);
            // 
            // dataGridViewNums__GAV
            // 
            this.dataGridViewNums__GAV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums__GAV.Location = new System.Drawing.Point(433, 57);
            this.dataGridViewNums__GAV.Name = "dataGridViewNums__GAV";
            this.dataGridViewNums__GAV.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewNums__GAV.TabIndex = 2;
            // 
            // chartGraf__GAV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraf__GAV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraf__GAV.Legends.Add(legend1);
            this.chartGraf__GAV.Location = new System.Drawing.Point(172, 156);
            this.chartGraf__GAV.Name = "chartGraf__GAV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraf__GAV.Series.Add(series1);
            this.chartGraf__GAV.Size = new System.Drawing.Size(300, 300);
            this.chartGraf__GAV.TabIndex = 3;
            this.chartGraf__GAV.Text = "chart1";
            // 
            // buttonOpenFile_GAV
            // 
            this.buttonOpenFile_GAV.Location = new System.Drawing.Point(593, 286);
            this.buttonOpenFile_GAV.Name = "buttonOpenFile_GAV";
            this.buttonOpenFile_GAV.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile_GAV.TabIndex = 4;
            this.buttonOpenFile_GAV.Text = "button1";
            this.buttonOpenFile_GAV.UseVisualStyleBackColor = true;
            this.buttonOpenFile_GAV.Click += new System.EventHandler(this.buttonOpenFile_GAV_Click);
            // 
            // buttonInfo_GAV
            // 
            this.buttonInfo_GAV.Location = new System.Drawing.Point(593, 369);
            this.buttonInfo_GAV.Name = "buttonInfo_GAV";
            this.buttonInfo_GAV.Size = new System.Drawing.Size(75, 23);
            this.buttonInfo_GAV.TabIndex = 5;
            this.buttonInfo_GAV.Text = "button1";
            this.buttonInfo_GAV.UseVisualStyleBackColor = true;
            this.buttonInfo_GAV.Click += new System.EventHandler(this.buttonInfo_GAV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInfo_GAV);
            this.Controls.Add(this.buttonOpenFile_GAV);
            this.Controls.Add(this.chartGraf__GAV);
            this.Controls.Add(this.dataGridViewNums__GAV);
            this.Controls.Add(this.buttonResult_GAV);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 7 | Гуцу А. В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums__GAV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf__GAV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonResult_GAV;
        private System.Windows.Forms.DataGridView dataGridViewNums__GAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraf__GAV;
        private System.Windows.Forms.Button buttonOpenFile_GAV;
        private System.Windows.Forms.Button buttonInfo_GAV;
    }
}


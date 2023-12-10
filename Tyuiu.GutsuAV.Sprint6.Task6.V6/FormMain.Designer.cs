
namespace Tyuiu.GutsuAV.Sprint6.Task6.V6
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
            this.buttonDane_GAV = new System.Windows.Forms.Button();
            this.textBoxResult_GAV = new System.Windows.Forms.TextBox();
            this.buttonOpenFail_GAV = new System.Windows.Forms.Button();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonHelp_GAV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDane_GAV
            // 
            this.buttonDane_GAV.Location = new System.Drawing.Point(448, 199);
            this.buttonDane_GAV.Name = "buttonDane_GAV";
            this.buttonDane_GAV.Size = new System.Drawing.Size(75, 23);
            this.buttonDane_GAV.TabIndex = 0;
            this.buttonDane_GAV.Text = "button1";
            this.buttonDane_GAV.UseVisualStyleBackColor = true;
            this.buttonDane_GAV.Click += new System.EventHandler(this.buttonDane_GAV_Click);
            // 
            // textBoxResult_GAV
            // 
            this.textBoxResult_GAV.Location = new System.Drawing.Point(426, 75);
            this.textBoxResult_GAV.Name = "textBoxResult_GAV";
            this.textBoxResult_GAV.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_GAV.TabIndex = 1;
            // 
            // buttonOpenFail_GAV
            // 
            this.buttonOpenFail_GAV.Location = new System.Drawing.Point(272, 159);
            this.buttonOpenFail_GAV.Name = "buttonOpenFail_GAV";
            this.buttonOpenFail_GAV.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFail_GAV.TabIndex = 2;
            this.buttonOpenFail_GAV.Text = "button1";
            this.buttonOpenFail_GAV.UseVisualStyleBackColor = true;
            this.buttonOpenFail_GAV.Click += new System.EventHandler(this.buttonOpenFail_GAV_Click);
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog1";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(246, 102);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput.TabIndex = 3;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Location = new System.Drawing.Point(30, 20);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(200, 102);
            this.groupBoxInput.TabIndex = 4;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonHelp_GAV
            // 
            this.buttonHelp_GAV.Location = new System.Drawing.Point(284, -1);
            this.buttonHelp_GAV.Name = "buttonHelp_GAV";
            this.buttonHelp_GAV.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp_GAV.TabIndex = 6;
            this.buttonHelp_GAV.Text = "button2";
            this.buttonHelp_GAV.UseVisualStyleBackColor = true;
            this.buttonHelp_GAV.Click += new System.EventHandler(this.buttonHelp_GAV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_GAV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonOpenFail_GAV);
            this.Controls.Add(this.textBoxResult_GAV);
            this.Controls.Add(this.buttonDane_GAV);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Вариант 6 | Таск 6 | Гуцу А. В.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDane_GAV;
        private System.Windows.Forms.TextBox textBoxResult_GAV;
        private System.Windows.Forms.Button buttonOpenFail_GAV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonHelp_GAV;
    }
}



namespace Tyuiu.GutsuAV.Sprint6.Task1.V29
{
    partial class Form1
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
            this.textBoxStart_GAV = new System.Windows.Forms.TextBox();
            this.textBoxStop_GAV = new System.Windows.Forms.TextBox();
            this.textBoxResult_GAV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxStart_GAV
            // 
            this.textBoxStart_GAV.Location = new System.Drawing.Point(398, 144);
            this.textBoxStart_GAV.Name = "textBoxStart_GAV";
            this.textBoxStart_GAV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_GAV.TabIndex = 0;
            // 
            // textBoxStop_GAV
            // 
            this.textBoxStop_GAV.Location = new System.Drawing.Point(398, 198);
            this.textBoxStop_GAV.Name = "textBoxStop_GAV";
            this.textBoxStop_GAV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_GAV.TabIndex = 0;
            // 
            // textBoxResult_GAV
            // 
            this.textBoxResult_GAV.Location = new System.Drawing.Point(398, 255);
            this.textBoxResult_GAV.Name = "textBoxResult_GAV";
            this.textBoxResult_GAV.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_GAV.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResult_GAV);
            this.Controls.Add(this.textBoxStop_GAV);
            this.Controls.Add(this.textBoxStart_GAV);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Спринт 6 | Таск 1 | Вариант 29 | Гуцу А. В.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStart_GAV;
        private System.Windows.Forms.TextBox textBoxStop_GAV;
        private System.Windows.Forms.TextBox textBoxResult_GAV;
    }
}


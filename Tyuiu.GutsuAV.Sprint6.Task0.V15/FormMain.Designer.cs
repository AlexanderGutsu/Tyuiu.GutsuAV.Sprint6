
namespace Tyuiu.GutsuAV.Sprint6.Task0.V15
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
            this.textBoxOutputResult_GAV = new System.Windows.Forms.TextBox();
            this.textBoxInputVarX_GAV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxOutputResult_GAV
            // 
            this.textBoxOutputResult_GAV.Location = new System.Drawing.Point(464, 217);
            this.textBoxOutputResult_GAV.Name = "textBoxOutputResult_GAV";
            this.textBoxOutputResult_GAV.Size = new System.Drawing.Size(100, 20);
            this.textBoxOutputResult_GAV.TabIndex = 0;
            // 
            // textBoxInputVarX_GAV
            // 
            this.textBoxInputVarX_GAV.Location = new System.Drawing.Point(475, 279);
            this.textBoxInputVarX_GAV.Name = "textBoxInputVarX_GAV";
            this.textBoxInputVarX_GAV.Size = new System.Drawing.Size(100, 20);
            this.textBoxInputVarX_GAV.TabIndex = 0;
           // this.textBoxInputVarX_GAV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxInputVarX_GAV);
            this.Controls.Add(this.textBoxOutputResult_GAV);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 0 | Вариант 15 | Гуцу А. В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOutputResult_GAV;
        private System.Windows.Forms.TextBox textBoxInputVarX_GAV;
    }
}


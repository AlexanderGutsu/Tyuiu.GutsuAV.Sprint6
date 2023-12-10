using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GutsuAV.Sprint6.Task6.V6.Lib;
using System.IO;
namespace Tyuiu.GutsuAV.Sprint6.Task6.V6
{
    public partial class FormMain : Form
    {
       
        public FormMain()
        {
            InitializeComponent();
        }
        DataService service1 = new DataService();
        string openFilePath;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonDane_GAV_Click(object sender, EventArgs e)
        {
    
           
        }

        private void buttonOpenFail_GAV_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxInput.Text = File.ReadAllText(openFilePath);
            groupBoxInput.Text += " " + openFilePath;
        }

        private void buttonHelp_GAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы ИИПб 23-1 Гуцу А.В.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

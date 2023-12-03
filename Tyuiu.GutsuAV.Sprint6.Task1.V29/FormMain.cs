using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GutsuAV.Sprint6.Task1.V29.Lib;
namespace Tyuiu.GutsuAV.Sprint6.Task1.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_GAV_Click(object sender, EventArgs e)
        {

            try
            {
                int startValue = Convert.ToInt32(textBoxStart_GAV.Text);
                int stopValue = Convert.ToInt32(textBoxStop_GAV.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_GAV.Text = "";
                textBoxResult_GAV.AppendText("---------+--------------" + Environment.NewLine);
                textBoxResult_GAV.AppendText("|     X  |     f(x)    |" + Environment.NewLine);
                textBoxResult_GAV.AppendText("---------+--------------" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}   |    {1,6:f2}   |", startValue, valueArray[i]);
                    textBoxResult_GAV.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_GAV.AppendText("---------+--------------" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_GAV_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Таск 1 выполнил студент группы ИИПБ-23-1 Гуцу Александр Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

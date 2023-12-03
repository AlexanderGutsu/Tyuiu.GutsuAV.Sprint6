using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GutsuAV.Sprint6.Task2.V30.Lib;
namespace Tyuiu.GutsuAV.Sprint6.Task2.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_GAV_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox textBoxStartStep_GAV = new TextBox();
                TextBox textBoxStopStep_GAV = new TextBox();
                TextBox textBoxResult_GAV = new TextBox();
                int startStep = Convert.ToInt32(textBoxStartStep_GAV.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_GAV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);



                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewNamedTAB_GAV.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chart1.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы Гуцу Александр Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridViewNamedТаб_GAV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}

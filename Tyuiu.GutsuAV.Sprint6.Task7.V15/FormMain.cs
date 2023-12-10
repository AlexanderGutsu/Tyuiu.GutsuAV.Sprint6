using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GutsuAV.Sprint6.Task7.V15.Lib;
using System.IO;
namespace Tyuiu.GutsuAV.Sprint6.Task7.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_GAV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogMatrix_GAV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_GAV_Click(object sender, EventArgs e)
        {

            openFileDialogTask_GAV.ShowDialog();
            openFile = openFileDialogTask_GAV.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewInput_GAV.RowCount = rows;
            dataGridViewInput_GAV.ColumnCount = columns;
            dataGridViewOutPut_GAV.RowCount = rows;
            dataGridViewOutPut_GAV.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_GAV.Columns[i].Width = 50;
                dataGridViewOutPut_GAV.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInput_GAV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonDone_GAV.Enabled = true;
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void buttonSave_GAV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_GAV.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_GAV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_GAV.ShowDialog();

            string path = saveFileDialogMatrix_GAV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_GAV.RowCount;
            int columns = dataGridViewOutPut_GAV.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOutPut_GAV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewInput_GAV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonDone_GAV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_GAV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_GAV.Enabled = true;
        }
        private void buttonOpenFile_PKR_MouseEnter(object sender, EventArgs e)
        {

        }
        private void buttonDone_PKR_MouseEnter(object sender, EventArgs e)
        {

        }
        private void buttonSave_PKR_MouseEnter(object sender, EventArgs e)
        {

        }
        private void buttonInfo_PKR_MouseEnter(object sender, EventArgs e)
        {

        }
        private void buttonInfo_PKR_Click(object sender, EventArgs e)
        {

        }
        private void buttonOpenFile_PKR_MouseMove(object sender, MouseEventArgs e)
        {
            buttonOpenFile_GAV.Cursor = System.Windows.Forms.Cursors.Hand;

        }
        private void buttonDone_PKR_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDone_GAV.Cursor = System.Windows.Forms.Cursors.Hand;

        }
        private void buttonSave_PKR_MouseMove(object sender, MouseEventArgs e)
        {
            buttonSave_GAV.Cursor = System.Windows.Forms.Cursors.Hand;

        }
        private void buttonInfo_PKR_MouseMove(object sender, MouseEventArgs e)
        {
            buttonInfo_GAV.Cursor = System.Windows.Forms.Cursors.Hand;

        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {
            dataGridViewInput_GAV.RowCount = 50;
            dataGridViewOutPut_GAV.RowCount = 50;

            dataGridViewInput_GAV.ColumnCount = 50;
            dataGridViewOutPut_GAV.ColumnCount = 50;

            panelLoadFromFile_GAV.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput_GAV.Columns[i].Width = 25;
                dataGridViewOutPut_GAV.Columns[i].Width = 25;
            }
        }
    }
}

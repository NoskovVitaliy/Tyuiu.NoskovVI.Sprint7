using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V8
{
    public partial class FormStatistics : Form
    {
        private static DataGridView mainFormDataGrid;
        public FormStatistics(DataGridView dataGrid)
        {
            mainFormDataGrid = dataGrid;
            InitializeComponent();
        }
        //Считывание ячеек с таблицы
        private static int[] GetIntCellsFromColumn(int column)
        {
            int[] columnArray = new int[mainFormDataGrid.RowCount];
            for (int i = 0; i < columnArray.Length; i++)
            {
                columnArray[i] = Convert.ToInt32(mainFormDataGrid.Rows[i].Cells[column].Value);
            }
            return columnArray;
        }

        private static string[] GetStringCellsFromColumn(int column)
        {
            string[] columnArray = new string[mainFormDataGrid.RowCount];
            for (int i = 0; i < columnArray.Length; i++)
            {
                columnArray[i] = Convert.ToString(mainFormDataGrid.Rows[i].Cells[column].Value);
            }
            return columnArray;
        }
        //Нахождение самых повторяющихся элементов
        private static string GetMostRepeatedString(int column)
        {
            var query = GetStringCellsFromColumn(column).GroupBy(x => x)
                                                             .Where(item => item.Count() > 1)
                                                             .Select(item => new {Number = item.Count(), Name = item.Key})
                                                             .ToArray();
            if (query.Length == 0) return "-";
            string repetition = "Error";
            foreach(var item in query)
            {
                if (item.Number == query.Max(x => x.Number))
                {
                    repetition = item.Name;
                }
            }
            return repetition;
        }
        private static int RowsCount(Color color)
        {
            int count = 0;
            for (int i = 0; i  < mainFormDataGrid.RowCount; i++)
            {
                if (mainFormDataGrid.Rows[i].Cells[0].Style.BackColor == color) count++;
            }
            return count;
        }

        public static double GetAverageStatFromColumn(int column) => Math.Round(GetIntCellsFromColumn(column).Average(),3);
        public static int GetMaxStatFromColumn(int column) => GetIntCellsFromColumn(column).Max();
        public static int GetMinStatFromColumn(int column) => GetIntCellsFromColumn(column).Min();
        public static int GetCountStatFromColumn(int column) => GetIntCellsFromColumn(column).Count();
        private void FormStatistics_Load(object sender, EventArgs e)
        {
            labelDriverCount_NVI.Text += " " + GetIntCellsFromColumn(0).Distinct().Count().ToString();
            labelMaxSpeed_NVI.Text += " " + GetMaxStatFromColumn(5).ToString();
            labelMinSpeed_NVI.Text += " " + GetMinStatFromColumn(5).ToString();
            labelAvgSpeed_NVI.Text += " " + GetAverageStatFromColumn(5).ToString();
            labelMaxLoad_NVI.Text += " " + GetMaxStatFromColumn(6).ToString();
            labelMinLoad_NVI.Text += " " + GetMinStatFromColumn(6).ToString();
            labelAvgLoad_NVI.Text += " " + GetAverageStatFromColumn(6).ToString();
            labelMaxFuel_NVI.Text += " " + GetMaxStatFromColumn(7).ToString();
            labelMinFuel_NVI.Text += " " + GetMinStatFromColumn(7).ToString();
            labelAvgFuel_NVI.Text += " " + GetAverageStatFromColumn(7).ToString();
            labelAutoCount_NVI.Text += " " + GetCountStatFromColumn(0).ToString();
            labelPopularMark_NVI.Text += " " + GetMostRepeatedString(2);
            labelPopularLocation_NVI.Text += " " + GetMostRepeatedString(4);
            labelAutoCondition_NVI.Text += " " + GetMostRepeatedString(3);
            labelRichDriver_NVI.Text += " " + "№" + GetMostRepeatedString(0);
            labelAquaRowCount_NVI.Text += " " + RowsCount(Color.Aqua).ToString();
            labelRedRowsCount_NVI.Text += " " + RowsCount(Color.OrangeRed).ToString();
            this.chartMarkToSpeed_NVI.ChartAreas[0].AxisX.Title = "Скорость";
            this.chartMarkToSpeed_NVI.ChartAreas[0].AxisY.Title = "Расход топлива";
            this.chartMarkToSpeed_NVI.Series[0].Points.Clear();
            Array.Sort(GetIntCellsFromColumn(5));
            Array.Sort(GetIntCellsFromColumn(7));
            for (int i = 0; i < mainFormDataGrid.Rows.Count; i++)
            {
                this.chartMarkToSpeed_NVI.Series[0].Points.AddXY(GetIntCellsFromColumn(5)[i], GetIntCellsFromColumn(7)[i]);
            }
        }
    }
}

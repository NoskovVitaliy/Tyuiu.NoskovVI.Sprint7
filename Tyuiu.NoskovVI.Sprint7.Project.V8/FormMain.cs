using System.Buffers;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Tyuiu.NoskovVI.Sprint7.Project.V8;
using Tyuiu.NoskovVI.Sprint7.Project.V8.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Project.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogProject_NVI.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogInfo_NVI.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

        }
        //Общая функция поиска
        public void Search(DataGridView dataGrid, string searchValue, int searchableValue)
        {
            dataGrid.ClearSelection();
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[searchableValue].Value.ToString().ToUpper() == searchValue)
                {
                    dataGrid.FirstDisplayedScrollingRowIndex = row.Index;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Selected = true;
                    }
                }
            }
        }
        //Общее сокрытие рядов
        public void InvisibleRowsByColors(DataGridView dataGrid, Color color, bool rowVisibility)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[0].Style.BackColor == color)
                {
                    row.Visible = rowVisibility;
                }
            }
        }
        DataService ds = new DataService();
        public string? openFilePath;
        public bool fileOpened = false;
        AutoCompleteStringCollection driverNumComplete = new AutoCompleteStringCollection();
        AutoCompleteStringCollection autoNumComplete = new AutoCompleteStringCollection();

        //Содержит прошлые значения ячеек(до редактирования)
        public int cellInt = 0;
        public string? cellString = String.Empty;
        private void infoToolStripMenuItem_NVI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void exitToolStripMenuItem_NVI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statsToolStripMenuItem_NVI_Click(object sender, EventArgs e)
        {
            FormStatistics formStatistics = new FormStatistics(dataGridViewChanged_NVI);
            formStatistics.ShowDialog();
        }

        private void guideToolStripMenuItem_NVI_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        //Загрузка файла в таблицы, активация кнопок
        private void buttonLoad_NVI_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialogProject_NVI.ShowDialog();
                openFilePath = openFileDialogProject_NVI.FileName;
                List<string[]> gridInfo = ds.LoadDataFromFile(openFilePath);
                this.dataGridViewAuto_NVI.Rows.Clear();
                this.dataGridViewAuto_NVI.RowCount = gridInfo.Count;
                this.dataGridViewChanged_NVI.Rows.Clear();
                this.dataGridViewChanged_NVI.RowCount = gridInfo.Count;
                this.dataGridViewAuto_NVI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridViewChanged_NVI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                for (int i = 0; i < gridInfo.Count; i++)
                {
                    for (int j = 0; j < gridInfo[0].Length; j++)
                    {
                        if (j == 0 || j > 4)
                        {
                            this.dataGridViewAuto_NVI.Rows[i].Cells[j].Value = Convert.ToInt32(gridInfo[i][j]);
                            this.dataGridViewChanged_NVI.Rows[i].Cells[j].Value = Convert.ToInt32(gridInfo[i][j]);
                            //Для забивания типов данных столбцов(Понадобится больше)
                            this.dataGridViewAuto_NVI.Columns[j].ValueType = typeof(int);
                            this.dataGridViewChanged_NVI.Columns[j].ValueType = typeof(int);

                        }
                        else
                        {
                            this.dataGridViewAuto_NVI.Rows[i].Cells[j].Value = gridInfo[i][j].ToString().ToUpper();
                            this.dataGridViewChanged_NVI.Rows[i].Cells[j].Value = gridInfo[i][j].ToString().ToUpper();
                            this.dataGridViewAuto_NVI.Columns[j].ValueType = typeof(string);
                            this.dataGridViewChanged_NVI.Columns[j].ValueType = typeof(string);
                        }
                    }
                }
                
                for (int i = 0; i < dataGridViewAuto_NVI.RowCount; i++)
                {
                    driverNumComplete.Add(this.dataGridViewAuto_NVI.Rows[i].Cells[0].Value.ToString());
                    autoNumComplete.Add(this.dataGridViewAuto_NVI.Rows[i].Cells[1].Value.ToString());
                }
                this.textBoxSearchDriverNum_NVI.AutoCompleteCustomSource = driverNumComplete;
                this.textBoxSearchDriverNum_NVI.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.textBoxSearchDriverNum_NVI.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.textBoxAutoNumSearch_NVI.AutoCompleteCustomSource = autoNumComplete;
                this.textBoxAutoNumSearch_NVI.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.textBoxAutoNumSearch_NVI.AutoCompleteSource = AutoCompleteSource.CustomSource;
                fileOpened = true;
                this.buttonSave_NVI.Enabled = true;
                this.statsToolStripMenuItem_NVI.Enabled = true;
                this.tabControlSearch_NVI.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Выберите файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Поиск в зависимости от выбранной таблицы
        private void buttonSearchDriverNum_NVI_Click(object sender, EventArgs e)
        {
            //if (this.dataGridViewChanged_NVI.Rows[0].Cells[1].ValueType == typeof(string))
            //{
            //    MessageBox.Show("Это ???");
            //}
            this.textBoxAutoNumSearch_NVI.AutoCompleteMode = AutoCompleteMode.Suggest;
            string searchValue = this.textBoxSearchDriverNum_NVI.Text;
            switch (this.tabControlData_NVI
                .SelectedIndex)
            {
                case 0:
                    Search(this.dataGridViewAuto_NVI, searchValue, 0);
                    break;
                case 1:
                    Search(this.dataGridViewChanged_NVI, searchValue, 0);
                    break;
            }
        }

        private void buttonSearchAutoNum_NVI_Click(object sender, EventArgs e)
        {
            string searchValue = this.textBoxAutoNumSearch_NVI.Text;
            switch (this.tabControlData_NVI
                .SelectedIndex)
            {
                case 0:
                    Search(this.dataGridViewAuto_NVI, searchValue, 1);
                    break;
                case 1:
                    Search(this.dataGridViewChanged_NVI, searchValue, 1);
                    break;
            }
        }
        //Логика галочек у некоторых кнопок
        private void EnableEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.disableEditToolStripMenuItem_NVI.Checked = false;
            this.enableEditToolStripMenuItem_NVI.Checked = true;
            this.dataGridViewChanged_NVI.ReadOnly = false;
        }

        private void disableEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.enableEditToolStripMenuItem_NVI.Checked = false;
            this.disableEditToolStripMenuItem_NVI.Checked = true;
            this.dataGridViewChanged_NVI.ReadOnly = true;
        }
        //Сохранение файла(без помеченных строк)
        private void buttonSave_NVI_Click(object sender, EventArgs e)
        {
            this.saveFileDialogInfo_NVI.FileName = "OutPutAuto.csv";
            this.saveFileDialogInfo_NVI.InitialDirectory = Directory.GetCurrentDirectory();

            string path = "C:\\DataSprint7\\OutPutAuto.csv";
            if (File.Exists(path)) { File.Delete(path); }

            int row = this.dataGridViewChanged_NVI.RowCount;
            int column = this.dataGridViewChanged_NVI.ColumnCount;
            string str = "";
            if (this.saveFileDialogInfo_NVI.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (this.dataGridViewChanged_NVI.Rows[i].Cells[j].Style.BackColor == Color.OrangeRed) break;

                        if (j == column - 1)
                        {
                            str += this.dataGridViewChanged_NVI.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            str += this.dataGridViewChanged_NVI.Rows[i].Cells[j].Value.ToString() + ";";
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Задание максимальной длины элементов в столбцах
            ((DataGridViewTextBoxColumn)dataGridViewChanged_NVI.Columns[1]).MaxInputLength = 6;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_NVI.Columns[2]).MaxInputLength = 20;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_NVI.Columns[3]).MaxInputLength = 30;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_NVI.Columns[4]).MaxInputLength = 30;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_NVI.Columns[5]).MaxInputLength = 3;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_NVI.Columns[6]).MaxInputLength = 4;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_NVI.Columns[7]).MaxInputLength = 5;
            


            this.BeginInvoke(new Action(() =>
            {
                buttonLoad_NVI.Focus();
            }));
        }
        //Проверяет значение с тем, что было раньше и не отмечает ячейку если они сходятся
        //Также проверяет, чтобы ячейки не были пустыми
        private void dataGridViewChanged_NVI_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool isInt = cellInt != 0;
            bool isString = !isInt;
            try
            {
                if (!String.IsNullOrEmpty(this.dataGridViewChanged_NVI.CurrentCell.Value.ToString()) && !Convert.IsDBNull(this.dataGridViewChanged_NVI.CurrentCell.Value) && this.dataGridViewChanged_NVI.CurrentCell.Style.BackColor != Color.Aqua)
                {
                    if ((isInt && Convert.ToInt32(this.dataGridViewChanged_NVI.CurrentCell.Value) != cellInt) || (isString && this.dataGridViewChanged_NVI.CurrentCell.Value.ToString() != cellString))
                    {
                        this.dataGridViewChanged_NVI.CurrentCell.Style.BackColor = Color.Green;
                        if (e.ColumnIndex == 0)
                        {
                            driverNumComplete.Remove(cellInt.ToString());
                            driverNumComplete.Add(this.dataGridViewChanged_NVI.CurrentCell.Value.ToString());
                        }
                        if (e.ColumnIndex == 1)
                        {
                            autoNumComplete.Remove(cellString);
                            autoNumComplete.Add(this.dataGridViewChanged_NVI.CurrentCell.Value.ToString());
                        }
                    }
                }

            }
            catch (NullReferenceException)
            {
                this.dataGridViewChanged_NVI.CurrentCell.Value = cellString;
                cellString = string.Empty;
            }
            finally
            {
                if (Convert.IsDBNull(this.dataGridViewChanged_NVI.CurrentCell.Value))
                {
                    if (cellInt != 0)
                    {
                        this.dataGridViewChanged_NVI.CurrentCell.Value = cellInt;
                        cellInt = 0;
                    }
                }
            }

        }



        private void NumInput(object? sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '-' || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void StringInput(object? sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '-' || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        //Ограничение на ввод некоторых символов в зависимости от типа ячейки
        private void dataGridViewChanged_NVI_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            bool isCellString = (this.dataGridViewChanged_NVI.CurrentCell.ValueType == typeof(string));
            bool isAutoNum = (this.dataGridViewChanged_NVI.CurrentCell.ColumnIndex == 1);
            if (e.Control is DataGridViewTextBoxEditingControl textBoxEditingControl)
            {
                textBoxEditingControl.KeyPress -= NumInput;
                textBoxEditingControl.KeyPress -= StringInput;
                if (isCellString && !isAutoNum)
                {
                    textBoxEditingControl.KeyPress += StringInput;
                }
                else if (!isCellString && !isAutoNum)
                {
                    textBoxEditingControl.KeyPress += NumInput;
                }

            }
        }
        //Выключение кнопок при переходе на первую таблмцу
        private void tabControlData_NVI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlData_NVI.SelectedIndex == 1 && fileOpened)
            {
                this.buttonAdd_NVI.Enabled = true;
                this.buttonRemove_NVI.Enabled = true;

            }
            else
            {
                this.buttonAdd_NVI.Enabled = false;
                this.buttonRemove_NVI.Enabled = false;
                this.buttonMarkDelete_NVI.Enabled = false;
                this.buttonMarkDelete_NVI.Visible = false;
                this.buttonUnMarkDelete_NVI.Enabled = false;
                this.buttonUnMarkDelete_NVI.Visible = false;
                this.buttonTrueDelete_NVI.Enabled = false;
                this.buttonTrueDelete_NVI.Visible = false;
                this.dataGridViewChanged_NVI.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }
        #region ToolTipChange
        private void buttonTrueDelete_NVI_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_NVI.ToolTipTitle = "Удалить";
            toolTipInfo_NVI.ToolTipIcon = ToolTipIcon.Info;
        }
        private void buttonAdd_NVI_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_NVI.ToolTipTitle = "Добавить";
            toolTipInfo_NVI.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonSave_NVI_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_NVI.ToolTipTitle = "Сохранить";
            toolTipInfo_NVI.ToolTipIcon = ToolTipIcon.Info;
        }
        private void buttonLoad_NVI_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_NVI.ToolTipTitle = "Загрузить";
            toolTipInfo_NVI.ToolTipIcon = ToolTipIcon.Info;

        }
        private void buttonRemove_NVI_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_NVI.ToolTipTitle = "Удалить";
            toolTipInfo_NVI.ToolTipIcon = ToolTipIcon.Info;
        }
        private void buttonSearchDriverNum_NVI_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_NVI.ToolTipTitle = "Поиск";
            toolTipInfo_NVI.ToolTipIcon = ToolTipIcon.Info;
        }
        private void buttonSearchAutoNum_NVI_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_NVI.ToolTipTitle = "Поиск";
            toolTipInfo_NVI.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonMarkDelete_NVI_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_NVI.ToolTipTitle = "Удалить";
            toolTipInfo_NVI.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonUnMarkDelete_NVI_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_NVI.ToolTipTitle = "Убрать из удаленных";
            toolTipInfo_NVI.ToolTipIcon = ToolTipIcon.Info;
        }
        #endregion


        private void buttonRemove_NVI_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewChanged_NVI.SelectionMode == DataGridViewSelectionMode.FullRowSelect)
            {
                this.dataGridViewChanged_NVI.SelectionMode = DataGridViewSelectionMode.CellSelect;
                this.buttonMarkDelete_NVI.Enabled = false;
                this.buttonMarkDelete_NVI.Visible = false;
                this.buttonUnMarkDelete_NVI.Enabled = false;
                this.buttonUnMarkDelete_NVI.Visible = false;
                this.buttonTrueDelete_NVI.Enabled = false;
                this.buttonTrueDelete_NVI.Visible = false;
            }
            else
            {
                this.dataGridViewChanged_NVI.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                this.buttonMarkDelete_NVI.Enabled = true;
                this.buttonMarkDelete_NVI.Visible = true;
                this.buttonUnMarkDelete_NVI.Enabled = true;
                this.buttonUnMarkDelete_NVI.Visible = true;
                this.buttonTrueDelete_NVI.Enabled = true;
                this.buttonTrueDelete_NVI.Visible = true;
            }


        }
        //Покраска выделенных ячеек на удаление
        private void buttonMarkDelete_NVI_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewChanged_NVI.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.OrangeRed;
                }
            }
        }
        //Убирание покраски удаления
        private void buttonUnMarkDelete_NVI_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewChanged_NVI.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Style.BackColor == Color.OrangeRed)
                    {
                        cell.Style.BackColor = Color.FromKnownColor(KnownColor.ControlLightLight);
                    }
                }
            }
        }
        //Сохраняет предыдущие значения
        private void dataGridViewChanged_NVI_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cellInt = this.dataGridViewChanged_NVI.CurrentCell.ValueType == typeof(int) ? Convert.ToInt32(this.dataGridViewChanged_NVI.CurrentCell.Value) : 0;
            cellString = this.dataGridViewChanged_NVI.CurrentCell.ValueType == typeof(string) ? this.dataGridViewChanged_NVI.CurrentCell.Value.ToString() : String.Empty;
        }
        //Покраска новых строк
        private void buttonAdd_NVI_Click(object sender, EventArgs e)
        {
            this.dataGridViewChanged_NVI.Rows.Add(0, "######", "НЕИЗВЕСТНО", "НЕИЗВЕСТНО", "НЕИЗВЕСТНО", 0, 0, 0);
            foreach (DataGridViewCell cell in this.dataGridViewChanged_NVI.Rows[^1].Cells)
            {
                cell.Style.BackColor = Color.Aqua;
            }
        }
        //Фильтры
        private void redRowsToolStripMenuItem_NVI_Click(object sender, EventArgs e)
        {

            if (!this.redRowsToolStripMenuItem_NVI.Checked)
            {
                this.redRowsToolStripMenuItem_NVI.Checked = true;
                InvisibleRowsByColors(this.dataGridViewChanged_NVI, Color.OrangeRed, true);
            }
            else
            {
                this.redRowsToolStripMenuItem_NVI.Checked = false;
                InvisibleRowsByColors(this.dataGridViewChanged_NVI, Color.OrangeRed, false);
            }
        }

        private void aquaRowsToolStripMenuItem_NVI_Click(object sender, EventArgs e)
        {
            if (!this.aquaRowsToolStripMenuItem_NVI.Checked)
            {
                this.aquaRowsToolStripMenuItem_NVI.Checked = true;
                InvisibleRowsByColors(this.dataGridViewChanged_NVI, Color.Aqua, true);
            }
            else
            {
                this.aquaRowsToolStripMenuItem_NVI.Checked = false;
                InvisibleRowsByColors(this.dataGridViewChanged_NVI, Color.Aqua, false);
            }
        }

        private void filterToolStripMenuItem_NVI_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewChanged_NVI.Rows)
            {
                if (row.Cells[0].Style.BackColor == Color.OrangeRed)
                {
                    this.redRowsToolStripMenuItem_NVI.Enabled = true;
                }
                if (row.Cells[0].Style.BackColor == Color.Aqua)
                {
                    this.aquaRowsToolStripMenuItem_NVI.Enabled = true;
                }
            }
        }
        //Окончательное удаление строк(и)
        private void buttonTrueDelete_NVI_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы ДЕЙСТВИТЕЛЬНО уверены, что хотите удалить данный ряд? Это действие необратимо.", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridViewChanged_NVI.SelectedRows)
                {
                    this.dataGridViewChanged_NVI.Rows.RemoveAt(row.Index);
                }
            }
        }


    }
}

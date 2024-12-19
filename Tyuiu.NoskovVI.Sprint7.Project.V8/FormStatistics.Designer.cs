namespace Project.V8
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chartMarkToSpeed_NVI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitContainer_NVI = new SplitContainer();
            groupBoxGrid_NVI = new GroupBox();
            labelAquaRowCount_NVI = new Label();
            labelRedRowsCount_NVI = new Label();
            groupBoxAuto_NVI = new GroupBox();
            labelPopularMark_NVI = new Label();
            labelPopularLocation_NVI = new Label();
            labelAutoCondition_NVI = new Label();
            labelAutoCount_NVI = new Label();
            groupBoxAutoStats_NVI = new GroupBox();
            labelMaxFuel_NVI = new Label();
            labelMinLoad_NVI = new Label();
            labelAvgLoad_NVI = new Label();
            labelMinFuel_NVI = new Label();
            labelAvgSpeed_NVI = new Label();
            labelMinSpeed_NVI = new Label();
            labelAvgFuel_NVI = new Label();
            labelMaxLoad_NVI = new Label();
            labelMaxSpeed_NVI = new Label();
            groupBoxDrivers_NVI = new GroupBox();
            labelRichDriver_NVI = new Label();
            labelDriverCount_NVI = new Label();
            ((System.ComponentModel.ISupportInitialize)chartMarkToSpeed_NVI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer_NVI).BeginInit();
            splitContainer_NVI.Panel1.SuspendLayout();
            splitContainer_NVI.Panel2.SuspendLayout();
            splitContainer_NVI.SuspendLayout();
            groupBoxGrid_NVI.SuspendLayout();
            groupBoxAuto_NVI.SuspendLayout();
            groupBoxAutoStats_NVI.SuspendLayout();
            groupBoxDrivers_NVI.SuspendLayout();
            SuspendLayout();
            // 
            // chartMarkToSpeed_NVI
            // 
            chartArea1.Name = "ChartArea1";
            chartMarkToSpeed_NVI.ChartAreas.Add(chartArea1);
            chartMarkToSpeed_NVI.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartMarkToSpeed_NVI.Legends.Add(legend1);
            chartMarkToSpeed_NVI.Location = new Point(0, 0);
            chartMarkToSpeed_NVI.Name = "chartMarkToSpeed_NVI";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            chartMarkToSpeed_NVI.Series.Add(series1);
            chartMarkToSpeed_NVI.Size = new Size(400, 450);
            chartMarkToSpeed_NVI.TabIndex = 0;
            title1.Name = "Соотношение марок и колчиества";
            chartMarkToSpeed_NVI.Titles.Add(title1);
            // 
            // splitContainer_NVI
            // 
            splitContainer_NVI.Dock = DockStyle.Fill;
            splitContainer_NVI.Location = new Point(0, 0);
            splitContainer_NVI.Name = "splitContainer_NVI";
            // 
            // splitContainer_NVI.Panel1
            // 
            splitContainer_NVI.Panel1.Controls.Add(groupBoxGrid_NVI);
            splitContainer_NVI.Panel1.Controls.Add(groupBoxAuto_NVI);
            splitContainer_NVI.Panel1.Controls.Add(groupBoxAutoStats_NVI);
            splitContainer_NVI.Panel1.Controls.Add(groupBoxDrivers_NVI);
            // 
            // splitContainer_NVI.Panel2
            // 
            splitContainer_NVI.Panel2.Controls.Add(chartMarkToSpeed_NVI);
            splitContainer_NVI.Size = new Size(1069, 450);
            splitContainer_NVI.SplitterDistance = 665;
            splitContainer_NVI.TabIndex = 1;
            // 
            // groupBoxGrid_NVI
            // 
            groupBoxGrid_NVI.Controls.Add(labelAquaRowCount_NVI);
            groupBoxGrid_NVI.Controls.Add(labelRedRowsCount_NVI);
            groupBoxGrid_NVI.Location = new Point(364, 143);
            groupBoxGrid_NVI.Name = "groupBoxGrid_NVI";
            groupBoxGrid_NVI.Size = new Size(298, 284);
            groupBoxGrid_NVI.TabIndex = 0;
            groupBoxGrid_NVI.TabStop = false;
            groupBoxGrid_NVI.Text = "Таблица";
            // 
            // labelAquaRowCount_NVI
            // 
            labelAquaRowCount_NVI.AutoSize = true;
            labelAquaRowCount_NVI.Location = new Point(6, 201);
            labelAquaRowCount_NVI.Name = "labelAquaRowCount_NVI";
            labelAquaRowCount_NVI.Size = new Size(233, 20);
            labelAquaRowCount_NVI.TabIndex = 0;
            labelAquaRowCount_NVI.Text = "Количество добавленных строк:";
            // 
            // labelRedRowsCount_NVI
            // 
            labelRedRowsCount_NVI.AutoSize = true;
            labelRedRowsCount_NVI.Location = new Point(6, 51);
            labelRedRowsCount_NVI.Name = "labelRedRowsCount_NVI";
            labelRedRowsCount_NVI.Size = new Size(214, 20);
            labelRedRowsCount_NVI.TabIndex = 0;
            labelRedRowsCount_NVI.Text = "Количество удаленных строк:";
            // 
            // groupBoxAuto_NVI
            // 
            groupBoxAuto_NVI.Controls.Add(labelPopularMark_NVI);
            groupBoxAuto_NVI.Controls.Add(labelPopularLocation_NVI);
            groupBoxAuto_NVI.Controls.Add(labelAutoCondition_NVI);
            groupBoxAuto_NVI.Controls.Add(labelAutoCount_NVI);
            groupBoxAuto_NVI.Location = new Point(223, 12);
            groupBoxAuto_NVI.Name = "groupBoxAuto_NVI";
            groupBoxAuto_NVI.Size = new Size(439, 125);
            groupBoxAuto_NVI.TabIndex = 0;
            groupBoxAuto_NVI.TabStop = false;
            groupBoxAuto_NVI.Text = "Машины";
            // 
            // labelPopularMark_NVI
            // 
            labelPopularMark_NVI.AutoSize = true;
            labelPopularMark_NVI.Location = new Point(6, 32);
            labelPopularMark_NVI.Name = "labelPopularMark_NVI";
            labelPopularMark_NVI.Size = new Size(191, 20);
            labelPopularMark_NVI.TabIndex = 0;
            labelPopularMark_NVI.Text = "Самая популярная марка:";
            // 
            // labelPopularLocation_NVI
            // 
            labelPopularLocation_NVI.AutoSize = true;
            labelPopularLocation_NVI.Location = new Point(6, 72);
            labelPopularLocation_NVI.Name = "labelPopularLocation_NVI";
            labelPopularLocation_NVI.Size = new Size(191, 20);
            labelPopularLocation_NVI.TabIndex = 0;
            labelPopularLocation_NVI.Text = "Самое популярное место:";
            // 
            // labelAutoCondition_NVI
            // 
            labelAutoCondition_NVI.AutoSize = true;
            labelAutoCondition_NVI.Location = new Point(6, 52);
            labelAutoCondition_NVI.Name = "labelAutoCondition_NVI";
            labelAutoCondition_NVI.Size = new Size(241, 20);
            labelAutoCondition_NVI.TabIndex = 0;
            labelAutoCondition_NVI.Text = "Подавляющее состояние машин:";
            // 
            // labelAutoCount_NVI
            // 
            labelAutoCount_NVI.AutoSize = true;
            labelAutoCount_NVI.Location = new Point(6, 92);
            labelAutoCount_NVI.Name = "labelAutoCount_NVI";
            labelAutoCount_NVI.Size = new Size(146, 20);
            labelAutoCount_NVI.TabIndex = 0;
            labelAutoCount_NVI.Text = "Количество машин:";
            // 
            // groupBoxAutoStats_NVI
            // 
            groupBoxAutoStats_NVI.Controls.Add(labelMaxFuel_NVI);
            groupBoxAutoStats_NVI.Controls.Add(labelMinLoad_NVI);
            groupBoxAutoStats_NVI.Controls.Add(labelAvgLoad_NVI);
            groupBoxAutoStats_NVI.Controls.Add(labelMinFuel_NVI);
            groupBoxAutoStats_NVI.Controls.Add(labelAvgSpeed_NVI);
            groupBoxAutoStats_NVI.Controls.Add(labelMinSpeed_NVI);
            groupBoxAutoStats_NVI.Controls.Add(labelAvgFuel_NVI);
            groupBoxAutoStats_NVI.Controls.Add(labelMaxLoad_NVI);
            groupBoxAutoStats_NVI.Controls.Add(labelMaxSpeed_NVI);
            groupBoxAutoStats_NVI.Location = new Point(12, 143);
            groupBoxAutoStats_NVI.Name = "groupBoxAutoStats_NVI";
            groupBoxAutoStats_NVI.Size = new Size(346, 284);
            groupBoxAutoStats_NVI.TabIndex = 0;
            groupBoxAutoStats_NVI.TabStop = false;
            groupBoxAutoStats_NVI.Text = "Характеристики машин";
            // 
            // labelMaxFuel_NVI
            // 
            labelMaxFuel_NVI.AutoSize = true;
            labelMaxFuel_NVI.Location = new Point(6, 201);
            labelMaxFuel_NVI.Name = "labelMaxFuel_NVI";
            labelMaxFuel_NVI.Size = new Size(206, 20);
            labelMaxFuel_NVI.TabIndex = 0;
            labelMaxFuel_NVI.Text = "Максимум расхода топлива:";
            // 
            // labelMinLoad_NVI
            // 
            labelMinLoad_NVI.AutoSize = true;
            labelMinLoad_NVI.Location = new Point(6, 141);
            labelMinLoad_NVI.Name = "labelMinLoad_NVI";
            labelMinLoad_NVI.Size = new Size(185, 20);
            labelMinLoad_NVI.TabIndex = 0;
            labelMinLoad_NVI.Text = "Минимум грузоподъема:";
            // 
            // labelAvgLoad_NVI
            // 
            labelAvgLoad_NVI.AutoSize = true;
            labelAvgLoad_NVI.Location = new Point(6, 171);
            labelAvgLoad_NVI.Name = "labelAvgLoad_NVI";
            labelAvgLoad_NVI.Size = new Size(169, 20);
            labelAvgLoad_NVI.TabIndex = 0;
            labelAvgLoad_NVI.Text = "Средний грузоподъем:";
            // 
            // labelMinFuel_NVI
            // 
            labelMinFuel_NVI.AutoSize = true;
            labelMinFuel_NVI.Location = new Point(6, 231);
            labelMinFuel_NVI.Name = "labelMinFuel_NVI";
            labelMinFuel_NVI.Size = new Size(202, 20);
            labelMinFuel_NVI.TabIndex = 0;
            labelMinFuel_NVI.Text = "Минимум расхода топлива:";
            // 
            // labelAvgSpeed_NVI
            // 
            labelAvgSpeed_NVI.AutoSize = true;
            labelAvgSpeed_NVI.Location = new Point(6, 81);
            labelAvgSpeed_NVI.Name = "labelAvgSpeed_NVI";
            labelAvgSpeed_NVI.Size = new Size(137, 20);
            labelAvgSpeed_NVI.TabIndex = 0;
            labelAvgSpeed_NVI.Text = "Средняя скорость:";
            // 
            // labelMinSpeed_NVI
            // 
            labelMinSpeed_NVI.AutoSize = true;
            labelMinSpeed_NVI.Location = new Point(6, 51);
            labelMinSpeed_NVI.Name = "labelMinSpeed_NVI";
            labelMinSpeed_NVI.Size = new Size(178, 20);
            labelMinSpeed_NVI.TabIndex = 0;
            labelMinSpeed_NVI.Text = "Минимальная скорость:";
            // 
            // labelAvgFuel_NVI
            // 
            labelAvgFuel_NVI.AutoSize = true;
            labelAvgFuel_NVI.Location = new Point(6, 261);
            labelAvgFuel_NVI.Name = "labelAvgFuel_NVI";
            labelAvgFuel_NVI.Size = new Size(186, 20);
            labelAvgFuel_NVI.TabIndex = 0;
            labelAvgFuel_NVI.Text = "Средний расход топлива:";
            // 
            // labelMaxLoad_NVI
            // 
            labelMaxLoad_NVI.AutoSize = true;
            labelMaxLoad_NVI.Location = new Point(6, 111);
            labelMaxLoad_NVI.Name = "labelMaxLoad_NVI";
            labelMaxLoad_NVI.Size = new Size(189, 20);
            labelMaxLoad_NVI.TabIndex = 0;
            labelMaxLoad_NVI.Text = "Максимум грузоподъема:";
            // 
            // labelMaxSpeed_NVI
            // 
            labelMaxSpeed_NVI.AutoSize = true;
            labelMaxSpeed_NVI.Location = new Point(6, 21);
            labelMaxSpeed_NVI.Name = "labelMaxSpeed_NVI";
            labelMaxSpeed_NVI.Size = new Size(182, 20);
            labelMaxSpeed_NVI.TabIndex = 0;
            labelMaxSpeed_NVI.Text = "Максимальная скорость:";
            // 
            // groupBoxDrivers_NVI
            // 
            groupBoxDrivers_NVI.Controls.Add(labelRichDriver_NVI);
            groupBoxDrivers_NVI.Controls.Add(labelDriverCount_NVI);
            groupBoxDrivers_NVI.Location = new Point(12, 12);
            groupBoxDrivers_NVI.Name = "groupBoxDrivers_NVI";
            groupBoxDrivers_NVI.Size = new Size(205, 125);
            groupBoxDrivers_NVI.TabIndex = 0;
            groupBoxDrivers_NVI.TabStop = false;
            groupBoxDrivers_NVI.Text = "Водители";
            // 
            // labelRichDriver_NVI
            // 
            labelRichDriver_NVI.AutoSize = true;
            labelRichDriver_NVI.Location = new Point(6, 75);
            labelRichDriver_NVI.Name = "labelRichDriver_NVI";
            labelRichDriver_NVI.Size = new Size(122, 20);
            labelRichDriver_NVI.TabIndex = 0;
            labelRichDriver_NVI.Text = "Самый богатый:";
            // 
            // labelDriverCount_NVI
            // 
            labelDriverCount_NVI.AutoSize = true;
            labelDriverCount_NVI.Location = new Point(6, 35);
            labelDriverCount_NVI.Name = "labelDriverCount_NVI";
            labelDriverCount_NVI.Size = new Size(93, 20);
            labelDriverCount_NVI.TabIndex = 0;
            labelDriverCount_NVI.Text = "Количество:";
            // 
            // FormStatistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 450);
            Controls.Add(splitContainer_NVI);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormStatistics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика";
            Load += FormStatistics_Load;
            ((System.ComponentModel.ISupportInitialize)chartMarkToSpeed_NVI).EndInit();
            splitContainer_NVI.Panel1.ResumeLayout(false);
            splitContainer_NVI.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_NVI).EndInit();
            splitContainer_NVI.ResumeLayout(false);
            groupBoxGrid_NVI.ResumeLayout(false);
            groupBoxGrid_NVI.PerformLayout();
            groupBoxAuto_NVI.ResumeLayout(false);
            groupBoxAuto_NVI.PerformLayout();
            groupBoxAutoStats_NVI.ResumeLayout(false);
            groupBoxAutoStats_NVI.PerformLayout();
            groupBoxDrivers_NVI.ResumeLayout(false);
            groupBoxDrivers_NVI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMarkToSpeed_NVI;
        private SplitContainer splitContainer_NVI;
        private GroupBox groupBoxGrid_NVI;
        private GroupBox groupBoxAuto_NVI;
        private GroupBox groupBoxAutoStats_NVI;
        private GroupBox groupBoxDrivers_NVI;
        private Label labelRichDriver_NVI;
        private Label labelDriverCount_NVI;
        private Label labelPopularMark_NVI;
        private Label labelPopularLocation_NVI;
        private Label labelAutoCondition_NVI;
        private Label labelAutoCount_NVI;
        private Label labelMaxFuel_NVI;
        private Label labelMinLoad_NVI;
        private Label labelAvgLoad_NVI;
        private Label labelMinFuel_NVI;
        private Label labelAvgSpeed_NVI;
        private Label labelMinSpeed_NVI;
        private Label labelAvgFuel_NVI;
        private Label labelMaxLoad_NVI;
        private Label labelMaxSpeed_NVI;
        private Label labelAquaRowCount_NVI;
        private Label labelRedRowsCount_NVI;
    }
}
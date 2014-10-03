namespace Lab1Exam
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.currentOrientationDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.currentOrientationDataGroupLabel = new System.Windows.Forms.Label();
            this.clearDataDataGroupButton = new System.Windows.Forms.Button();
            this.saveDataDataGroupButton = new System.Windows.Forms.Button();
            this.bytesToReadDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.zQueueDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.yQueueDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.xQueueDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.zMeanDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.yMeanDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.xMeanDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.zAccelerationDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.yAccelerationDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.xAccelerationDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.rawZDataGroupListBox = new System.Windows.Forms.ListBox();
            this.rawYDataGroupListBox = new System.Windows.Forms.ListBox();
            this.rawXDataGroupListBox = new System.Windows.Forms.ListBox();
            this.rawZDataGroupLabel = new System.Windows.Forms.Label();
            this.rawYDataGroupLabel = new System.Windows.Forms.Label();
            this.rawXDataGroupLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.meanDataGroupLabel = new System.Windows.Forms.Label();
            this.xDataGroupLabel = new System.Windows.Forms.Label();
            this.yDataGroupLabel = new System.Windows.Forms.Label();
            this.accelerationDataGroupLabel = new System.Windows.Forms.Label();
            this.zDataGroupLabel = new System.Windows.Forms.Label();
            this.queueDataGroupLabel = new System.Windows.Forms.Label();
            this.calibrateButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.portSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.plotsGroupBox = new System.Windows.Forms.GroupBox();
            this.rawDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.movesGroupBox = new System.Windows.Forms.GroupBox();
            this.timeoutMovesGroupTextBox = new System.Windows.Forms.TextBox();
            this.performedMovesGroupTextBox = new System.Windows.Forms.TextBox();
            this.inputMovesGroupTextBox = new System.Windows.Forms.TextBox();
            this.clearHistoryMovesGroupButton = new System.Windows.Forms.Button();
            this.saveHistoryMovesGroupButton = new System.Windows.Forms.Button();
            this.historyMovesGroupListBox = new System.Windows.Forms.ListBox();
            this.historyMovesGroupLabel = new System.Windows.Forms.Label();
            this.timeMovesGroupLabel = new System.Windows.Forms.Label();
            this.performedMovesGroupLabel = new System.Windows.Forms.Label();
            this.inputMovesGroupLabel = new System.Windows.Forms.Label();
            this.moveListGroupBox = new System.Windows.Forms.GroupBox();
            this.newMoveNameMoveListGroupLabel = new System.Windows.Forms.Label();
            this.clearNewMoveInputsMoveListGroupButton = new System.Windows.Forms.Button();
            this.newMoveInputsMoveListGroupTextBox = new System.Windows.Forms.TextBox();
            this.newMoveNameMoveListGroupTextBox = new System.Windows.Forms.TextBox();
            this.minusZMoveListGroupButton = new System.Windows.Forms.Button();
            this.plusZMoveListGroupButton = new System.Windows.Forms.Button();
            this.minusYMoveListGroupButton = new System.Windows.Forms.Button();
            this.plusYMoveListGroupButton = new System.Windows.Forms.Button();
            this.minusXMoveListGroupButton = new System.Windows.Forms.Button();
            this.plusXMoveListGroupButton = new System.Windows.Forms.Button();
            this.deleteMoveMoveListGroupButton = new System.Windows.Forms.Button();
            this.createNewMoveMostListGroupButton = new System.Windows.Forms.Button();
            this.moveNameMoveListGroupLabel = new System.Windows.Forms.Label();
            this.inputMoveListGroupLabel = new System.Windows.Forms.Label();
            this.moveNameMoveListGroupListBox = new System.Windows.Forms.ListBox();
            this.moveInputMoveListGroupListBox = new System.Windows.Forms.ListBox();
            this.tinyStickSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.csvSaveFileDialogBox = new System.Windows.Forms.SaveFileDialog();
            this.StartGestureReadingTimer = new System.Windows.Forms.Timer(this.components);
            this.ClearGestureReadingTimer = new System.Windows.Forms.Timer(this.components);
            this.fullQueueSizeDataGroupLabel = new System.Windows.Forms.Label();
            this.fullQueueSizeDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.soundGroupBox = new System.Windows.Forms.GroupBox();
            this.backgroundSoundSoundGroupCheckBox = new System.Windows.Forms.CheckBox();
            this.newGestureSoundGroupCheckBox = new System.Windows.Forms.CheckBox();
            this.newMoveSoundGroupCheckBox = new System.Windows.Forms.CheckBox();
            this.dataGroupBox.SuspendLayout();
            this.plotsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataChart)).BeginInit();
            this.movesGroupBox.SuspendLayout();
            this.moveListGroupBox.SuspendLayout();
            this.soundGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.fullQueueSizeDataGroupTextBox);
            this.dataGroupBox.Controls.Add(this.fullQueueSizeDataGroupLabel);
            this.dataGroupBox.Controls.Add(this.currentOrientationDataGroupTextBox);
            this.dataGroupBox.Controls.Add(this.currentOrientationDataGroupLabel);
            this.dataGroupBox.Controls.Add(this.clearDataDataGroupButton);
            this.dataGroupBox.Controls.Add(this.saveDataDataGroupButton);
            this.dataGroupBox.Controls.Add(this.bytesToReadDataGroupTextBox);
            this.dataGroupBox.Controls.Add(this.zQueueDataGroupTextBox);
            this.dataGroupBox.Controls.Add(this.yQueueDataGroupTextBox);
            this.dataGroupBox.Controls.Add(this.xQueueDataGroupTextBox);
            this.dataGroupBox.Controls.Add(this.zMeanDataGroupTextBox);
            this.dataGroupBox.Controls.Add(this.yMeanDataGroupTextBox);
            this.dataGroupBox.Controls.Add(this.xMeanDataGroupTextBox);
            this.dataGroupBox.Controls.Add(this.zAccelerationDataGroupTextBox);
            this.dataGroupBox.Controls.Add(this.yAccelerationDataGroupTextBox);
            this.dataGroupBox.Controls.Add(this.xAccelerationDataGroupTextBox);
            this.dataGroupBox.Controls.Add(this.rawZDataGroupListBox);
            this.dataGroupBox.Controls.Add(this.rawYDataGroupListBox);
            this.dataGroupBox.Controls.Add(this.rawXDataGroupListBox);
            this.dataGroupBox.Controls.Add(this.rawZDataGroupLabel);
            this.dataGroupBox.Controls.Add(this.rawYDataGroupLabel);
            this.dataGroupBox.Controls.Add(this.rawXDataGroupLabel);
            this.dataGroupBox.Controls.Add(this.label7);
            this.dataGroupBox.Controls.Add(this.meanDataGroupLabel);
            this.dataGroupBox.Controls.Add(this.xDataGroupLabel);
            this.dataGroupBox.Controls.Add(this.yDataGroupLabel);
            this.dataGroupBox.Controls.Add(this.accelerationDataGroupLabel);
            this.dataGroupBox.Controls.Add(this.zDataGroupLabel);
            this.dataGroupBox.Controls.Add(this.queueDataGroupLabel);
            this.dataGroupBox.Controls.Add(this.calibrateButton);
            this.dataGroupBox.Controls.Add(this.connectButton);
            this.dataGroupBox.Controls.Add(this.portSelectionComboBox);
            this.dataGroupBox.Location = new System.Drawing.Point(17, 16);
            this.dataGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.dataGroupBox.Size = new System.Drawing.Size(548, 282);
            this.dataGroupBox.TabIndex = 0;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Data";
            // 
            // currentOrientationDataGroupTextBox
            // 
            this.currentOrientationDataGroupTextBox.Location = new System.Drawing.Point(201, 255);
            this.currentOrientationDataGroupTextBox.Name = "currentOrientationDataGroupTextBox";
            this.currentOrientationDataGroupTextBox.ReadOnly = true;
            this.currentOrientationDataGroupTextBox.Size = new System.Drawing.Size(100, 22);
            this.currentOrientationDataGroupTextBox.TabIndex = 35;
            // 
            // currentOrientationDataGroupLabel
            // 
            this.currentOrientationDataGroupLabel.AutoSize = true;
            this.currentOrientationDataGroupLabel.Location = new System.Drawing.Point(6, 258);
            this.currentOrientationDataGroupLabel.Name = "currentOrientationDataGroupLabel";
            this.currentOrientationDataGroupLabel.Size = new System.Drawing.Size(129, 17);
            this.currentOrientationDataGroupLabel.TabIndex = 34;
            this.currentOrientationDataGroupLabel.Text = "Current Orientation";
            // 
            // clearDataDataGroupButton
            // 
            this.clearDataDataGroupButton.Location = new System.Drawing.Point(443, 232);
            this.clearDataDataGroupButton.Name = "clearDataDataGroupButton";
            this.clearDataDataGroupButton.Size = new System.Drawing.Size(87, 23);
            this.clearDataDataGroupButton.TabIndex = 33;
            this.clearDataDataGroupButton.Text = "Clear Data";
            this.clearDataDataGroupButton.UseVisualStyleBackColor = true;
            this.clearDataDataGroupButton.Click += new System.EventHandler(this.clearDataDataGroupButton_Click);
            // 
            // saveDataDataGroupButton
            // 
            this.saveDataDataGroupButton.Location = new System.Drawing.Point(344, 232);
            this.saveDataDataGroupButton.Name = "saveDataDataGroupButton";
            this.saveDataDataGroupButton.Size = new System.Drawing.Size(93, 23);
            this.saveDataDataGroupButton.TabIndex = 32;
            this.saveDataDataGroupButton.Text = "Save Data";
            this.saveDataDataGroupButton.UseVisualStyleBackColor = true;
            this.saveDataDataGroupButton.Click += new System.EventHandler(this.saveDataDataGroupButton_Click);
            // 
            // bytesToReadDataGroupTextBox
            // 
            this.bytesToReadDataGroupTextBox.Location = new System.Drawing.Point(201, 227);
            this.bytesToReadDataGroupTextBox.Name = "bytesToReadDataGroupTextBox";
            this.bytesToReadDataGroupTextBox.ReadOnly = true;
            this.bytesToReadDataGroupTextBox.Size = new System.Drawing.Size(100, 22);
            this.bytesToReadDataGroupTextBox.TabIndex = 31;
            this.bytesToReadDataGroupTextBox.TextChanged += new System.EventHandler(this.bytesToReadDataGroupTextBox_TextChanged);
            // 
            // zQueueDataGroupTextBox
            // 
            this.zQueueDataGroupTextBox.Location = new System.Drawing.Point(240, 141);
            this.zQueueDataGroupTextBox.Name = "zQueueDataGroupTextBox";
            this.zQueueDataGroupTextBox.ReadOnly = true;
            this.zQueueDataGroupTextBox.Size = new System.Drawing.Size(61, 22);
            this.zQueueDataGroupTextBox.TabIndex = 30;
            // 
            // yQueueDataGroupTextBox
            // 
            this.yQueueDataGroupTextBox.Location = new System.Drawing.Point(240, 113);
            this.yQueueDataGroupTextBox.Name = "yQueueDataGroupTextBox";
            this.yQueueDataGroupTextBox.ReadOnly = true;
            this.yQueueDataGroupTextBox.Size = new System.Drawing.Size(61, 22);
            this.yQueueDataGroupTextBox.TabIndex = 29;
            // 
            // xQueueDataGroupTextBox
            // 
            this.xQueueDataGroupTextBox.Location = new System.Drawing.Point(240, 85);
            this.xQueueDataGroupTextBox.Name = "xQueueDataGroupTextBox";
            this.xQueueDataGroupTextBox.ReadOnly = true;
            this.xQueueDataGroupTextBox.Size = new System.Drawing.Size(61, 22);
            this.xQueueDataGroupTextBox.TabIndex = 28;
            // 
            // zMeanDataGroupTextBox
            // 
            this.zMeanDataGroupTextBox.Location = new System.Drawing.Point(162, 140);
            this.zMeanDataGroupTextBox.Name = "zMeanDataGroupTextBox";
            this.zMeanDataGroupTextBox.ReadOnly = true;
            this.zMeanDataGroupTextBox.Size = new System.Drawing.Size(61, 22);
            this.zMeanDataGroupTextBox.TabIndex = 27;
            // 
            // yMeanDataGroupTextBox
            // 
            this.yMeanDataGroupTextBox.Location = new System.Drawing.Point(162, 112);
            this.yMeanDataGroupTextBox.Name = "yMeanDataGroupTextBox";
            this.yMeanDataGroupTextBox.ReadOnly = true;
            this.yMeanDataGroupTextBox.Size = new System.Drawing.Size(61, 22);
            this.yMeanDataGroupTextBox.TabIndex = 26;
            // 
            // xMeanDataGroupTextBox
            // 
            this.xMeanDataGroupTextBox.Location = new System.Drawing.Point(162, 84);
            this.xMeanDataGroupTextBox.Name = "xMeanDataGroupTextBox";
            this.xMeanDataGroupTextBox.ReadOnly = true;
            this.xMeanDataGroupTextBox.Size = new System.Drawing.Size(61, 22);
            this.xMeanDataGroupTextBox.TabIndex = 25;
            // 
            // zAccelerationDataGroupTextBox
            // 
            this.zAccelerationDataGroupTextBox.Location = new System.Drawing.Point(92, 140);
            this.zAccelerationDataGroupTextBox.Name = "zAccelerationDataGroupTextBox";
            this.zAccelerationDataGroupTextBox.ReadOnly = true;
            this.zAccelerationDataGroupTextBox.Size = new System.Drawing.Size(61, 22);
            this.zAccelerationDataGroupTextBox.TabIndex = 24;
            // 
            // yAccelerationDataGroupTextBox
            // 
            this.yAccelerationDataGroupTextBox.Location = new System.Drawing.Point(92, 112);
            this.yAccelerationDataGroupTextBox.Name = "yAccelerationDataGroupTextBox";
            this.yAccelerationDataGroupTextBox.ReadOnly = true;
            this.yAccelerationDataGroupTextBox.Size = new System.Drawing.Size(61, 22);
            this.yAccelerationDataGroupTextBox.TabIndex = 23;
            // 
            // xAccelerationDataGroupTextBox
            // 
            this.xAccelerationDataGroupTextBox.Location = new System.Drawing.Point(92, 84);
            this.xAccelerationDataGroupTextBox.Name = "xAccelerationDataGroupTextBox";
            this.xAccelerationDataGroupTextBox.ReadOnly = true;
            this.xAccelerationDataGroupTextBox.Size = new System.Drawing.Size(61, 22);
            this.xAccelerationDataGroupTextBox.TabIndex = 22;
            // 
            // rawZDataGroupListBox
            // 
            this.rawZDataGroupListBox.FormattingEnabled = true;
            this.rawZDataGroupListBox.ItemHeight = 16;
            this.rawZDataGroupListBox.Location = new System.Drawing.Point(478, 64);
            this.rawZDataGroupListBox.Name = "rawZDataGroupListBox";
            this.rawZDataGroupListBox.Size = new System.Drawing.Size(52, 148);
            this.rawZDataGroupListBox.TabIndex = 15;
            // 
            // rawYDataGroupListBox
            // 
            this.rawYDataGroupListBox.FormattingEnabled = true;
            this.rawYDataGroupListBox.ItemHeight = 16;
            this.rawYDataGroupListBox.Location = new System.Drawing.Point(412, 64);
            this.rawYDataGroupListBox.Name = "rawYDataGroupListBox";
            this.rawYDataGroupListBox.Size = new System.Drawing.Size(52, 148);
            this.rawYDataGroupListBox.TabIndex = 14;
            // 
            // rawXDataGroupListBox
            // 
            this.rawXDataGroupListBox.FormattingEnabled = true;
            this.rawXDataGroupListBox.ItemHeight = 16;
            this.rawXDataGroupListBox.Location = new System.Drawing.Point(344, 64);
            this.rawXDataGroupListBox.Name = "rawXDataGroupListBox";
            this.rawXDataGroupListBox.Size = new System.Drawing.Size(52, 148);
            this.rawXDataGroupListBox.TabIndex = 13;
            // 
            // rawZDataGroupLabel
            // 
            this.rawZDataGroupLabel.AutoSize = true;
            this.rawZDataGroupLabel.Location = new System.Drawing.Point(475, 28);
            this.rawZDataGroupLabel.Name = "rawZDataGroupLabel";
            this.rawZDataGroupLabel.Size = new System.Drawing.Size(48, 17);
            this.rawZDataGroupLabel.TabIndex = 12;
            this.rawZDataGroupLabel.Text = "Raw Z";
            // 
            // rawYDataGroupLabel
            // 
            this.rawYDataGroupLabel.AutoSize = true;
            this.rawYDataGroupLabel.Location = new System.Drawing.Point(409, 28);
            this.rawYDataGroupLabel.Name = "rawYDataGroupLabel";
            this.rawYDataGroupLabel.Size = new System.Drawing.Size(52, 17);
            this.rawYDataGroupLabel.TabIndex = 11;
            this.rawYDataGroupLabel.Text = " Raw Y";
            // 
            // rawXDataGroupLabel
            // 
            this.rawXDataGroupLabel.AutoSize = true;
            this.rawXDataGroupLabel.Location = new System.Drawing.Point(341, 28);
            this.rawXDataGroupLabel.Name = "rawXDataGroupLabel";
            this.rawXDataGroupLabel.Size = new System.Drawing.Size(48, 17);
            this.rawXDataGroupLabel.TabIndex = 10;
            this.rawXDataGroupLabel.Text = "Raw X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "BytesToRead";
            // 
            // meanDataGroupLabel
            // 
            this.meanDataGroupLabel.AutoSize = true;
            this.meanDataGroupLabel.Location = new System.Drawing.Point(141, 64);
            this.meanDataGroupLabel.Name = "meanDataGroupLabel";
            this.meanDataGroupLabel.Size = new System.Drawing.Size(107, 17);
            this.meanDataGroupLabel.TabIndex = 8;
            this.meanDataGroupLabel.Text = "Mean (last 100)";
            // 
            // xDataGroupLabel
            // 
            this.xDataGroupLabel.AutoSize = true;
            this.xDataGroupLabel.Location = new System.Drawing.Point(7, 87);
            this.xDataGroupLabel.Name = "xDataGroupLabel";
            this.xDataGroupLabel.Size = new System.Drawing.Size(17, 17);
            this.xDataGroupLabel.TabIndex = 7;
            this.xDataGroupLabel.Text = "X";
            // 
            // yDataGroupLabel
            // 
            this.yDataGroupLabel.AutoSize = true;
            this.yDataGroupLabel.Location = new System.Drawing.Point(7, 115);
            this.yDataGroupLabel.Name = "yDataGroupLabel";
            this.yDataGroupLabel.Size = new System.Drawing.Size(17, 17);
            this.yDataGroupLabel.TabIndex = 6;
            this.yDataGroupLabel.Text = "Y";
            // 
            // accelerationDataGroupLabel
            // 
            this.accelerationDataGroupLabel.AutoSize = true;
            this.accelerationDataGroupLabel.Location = new System.Drawing.Point(89, 64);
            this.accelerationDataGroupLabel.Name = "accelerationDataGroupLabel";
            this.accelerationDataGroupLabel.Size = new System.Drawing.Size(42, 17);
            this.accelerationDataGroupLabel.TabIndex = 5;
            this.accelerationDataGroupLabel.Text = "Accel";
            // 
            // zDataGroupLabel
            // 
            this.zDataGroupLabel.AutoSize = true;
            this.zDataGroupLabel.Location = new System.Drawing.Point(6, 144);
            this.zDataGroupLabel.Name = "zDataGroupLabel";
            this.zDataGroupLabel.Size = new System.Drawing.Size(17, 17);
            this.zDataGroupLabel.TabIndex = 4;
            this.zDataGroupLabel.Text = "Z";
            // 
            // queueDataGroupLabel
            // 
            this.queueDataGroupLabel.AutoSize = true;
            this.queueDataGroupLabel.Location = new System.Drawing.Point(246, 64);
            this.queueDataGroupLabel.Name = "queueDataGroupLabel";
            this.queueDataGroupLabel.Size = new System.Drawing.Size(51, 17);
            this.queueDataGroupLabel.TabIndex = 3;
            this.queueDataGroupLabel.Text = "Queue";
            // 
            // calibrateButton
            // 
            this.calibrateButton.Location = new System.Drawing.Point(240, 25);
            this.calibrateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calibrateButton.Name = "calibrateButton";
            this.calibrateButton.Size = new System.Drawing.Size(83, 28);
            this.calibrateButton.TabIndex = 2;
            this.calibrateButton.Text = "Calibrate";
            this.calibrateButton.UseVisualStyleBackColor = true;
            this.calibrateButton.Click += new System.EventHandler(this.calibrateButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(144, 25);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(88, 28);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // portSelectionComboBox
            // 
            this.portSelectionComboBox.FormattingEnabled = true;
            this.portSelectionComboBox.Location = new System.Drawing.Point(9, 25);
            this.portSelectionComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.portSelectionComboBox.Name = "portSelectionComboBox";
            this.portSelectionComboBox.Size = new System.Drawing.Size(126, 24);
            this.portSelectionComboBox.TabIndex = 0;
            // 
            // plotsGroupBox
            // 
            this.plotsGroupBox.Controls.Add(this.rawDataChart);
            this.plotsGroupBox.Location = new System.Drawing.Point(17, 305);
            this.plotsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.plotsGroupBox.Name = "plotsGroupBox";
            this.plotsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.plotsGroupBox.Size = new System.Drawing.Size(1016, 281);
            this.plotsGroupBox.TabIndex = 1;
            this.plotsGroupBox.TabStop = false;
            this.plotsGroupBox.Text = "Plots";
            // 
            // rawDataChart
            // 
            chartArea1.Area3DStyle.Inclination = 20;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.Title = "Time [ms] / Interval [25ms]";
            chartArea1.AxisY.Title = "Raw Acceleration";
            chartArea1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.Name = "ChartArea1";
            this.rawDataChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend";
            this.rawDataChart.Legends.Add(legend1);
            this.rawDataChart.Location = new System.Drawing.Point(10, 22);
            this.rawDataChart.Name = "rawDataChart";
            this.rawDataChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend";
            series1.Name = "X";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend";
            series2.Name = "Y";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend";
            series3.Name = "Z";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.rawDataChart.Series.Add(series1);
            this.rawDataChart.Series.Add(series2);
            this.rawDataChart.Series.Add(series3);
            this.rawDataChart.Size = new System.Drawing.Size(987, 252);
            this.rawDataChart.TabIndex = 0;
            this.rawDataChart.Text = "Raw Data";
            this.rawDataChart.Click += new System.EventHandler(this.rawDataChart_Click);
            // 
            // movesGroupBox
            // 
            this.movesGroupBox.Controls.Add(this.timeoutMovesGroupTextBox);
            this.movesGroupBox.Controls.Add(this.performedMovesGroupTextBox);
            this.movesGroupBox.Controls.Add(this.inputMovesGroupTextBox);
            this.movesGroupBox.Controls.Add(this.clearHistoryMovesGroupButton);
            this.movesGroupBox.Controls.Add(this.saveHistoryMovesGroupButton);
            this.movesGroupBox.Controls.Add(this.historyMovesGroupListBox);
            this.movesGroupBox.Controls.Add(this.historyMovesGroupLabel);
            this.movesGroupBox.Controls.Add(this.timeMovesGroupLabel);
            this.movesGroupBox.Controls.Add(this.performedMovesGroupLabel);
            this.movesGroupBox.Controls.Add(this.inputMovesGroupLabel);
            this.movesGroupBox.Location = new System.Drawing.Point(575, 16);
            this.movesGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.movesGroupBox.Name = "movesGroupBox";
            this.movesGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.movesGroupBox.Size = new System.Drawing.Size(267, 282);
            this.movesGroupBox.TabIndex = 2;
            this.movesGroupBox.TabStop = false;
            this.movesGroupBox.Text = "Moves";
            // 
            // timeoutMovesGroupTextBox
            // 
            this.timeoutMovesGroupTextBox.Location = new System.Drawing.Point(7, 87);
            this.timeoutMovesGroupTextBox.Name = "timeoutMovesGroupTextBox";
            this.timeoutMovesGroupTextBox.ReadOnly = true;
            this.timeoutMovesGroupTextBox.Size = new System.Drawing.Size(161, 22);
            this.timeoutMovesGroupTextBox.TabIndex = 21;
            // 
            // performedMovesGroupTextBox
            // 
            this.performedMovesGroupTextBox.Location = new System.Drawing.Point(7, 55);
            this.performedMovesGroupTextBox.Name = "performedMovesGroupTextBox";
            this.performedMovesGroupTextBox.ReadOnly = true;
            this.performedMovesGroupTextBox.Size = new System.Drawing.Size(161, 22);
            this.performedMovesGroupTextBox.TabIndex = 20;
            // 
            // inputMovesGroupTextBox
            // 
            this.inputMovesGroupTextBox.Location = new System.Drawing.Point(7, 19);
            this.inputMovesGroupTextBox.Name = "inputMovesGroupTextBox";
            this.inputMovesGroupTextBox.ReadOnly = true;
            this.inputMovesGroupTextBox.Size = new System.Drawing.Size(161, 22);
            this.inputMovesGroupTextBox.TabIndex = 19;
            // 
            // clearHistoryMovesGroupButton
            // 
            this.clearHistoryMovesGroupButton.Location = new System.Drawing.Point(122, 239);
            this.clearHistoryMovesGroupButton.Name = "clearHistoryMovesGroupButton";
            this.clearHistoryMovesGroupButton.Size = new System.Drawing.Size(108, 23);
            this.clearHistoryMovesGroupButton.TabIndex = 18;
            this.clearHistoryMovesGroupButton.Text = "Clear History";
            this.clearHistoryMovesGroupButton.UseVisualStyleBackColor = true;
            this.clearHistoryMovesGroupButton.Click += new System.EventHandler(this.clearHistoryMovesGroupButton_Click);
            // 
            // saveHistoryMovesGroupButton
            // 
            this.saveHistoryMovesGroupButton.Location = new System.Drawing.Point(41, 239);
            this.saveHistoryMovesGroupButton.Name = "saveHistoryMovesGroupButton";
            this.saveHistoryMovesGroupButton.Size = new System.Drawing.Size(75, 23);
            this.saveHistoryMovesGroupButton.TabIndex = 17;
            this.saveHistoryMovesGroupButton.Text = "Save History";
            this.saveHistoryMovesGroupButton.UseVisualStyleBackColor = true;
            this.saveHistoryMovesGroupButton.Click += new System.EventHandler(this.saveHistoryMovesGroupButton_Click);
            // 
            // historyMovesGroupListBox
            // 
            this.historyMovesGroupListBox.FormattingEnabled = true;
            this.historyMovesGroupListBox.ItemHeight = 16;
            this.historyMovesGroupListBox.Location = new System.Drawing.Point(7, 144);
            this.historyMovesGroupListBox.Name = "historyMovesGroupListBox";
            this.historyMovesGroupListBox.Size = new System.Drawing.Size(253, 84);
            this.historyMovesGroupListBox.TabIndex = 16;
            // 
            // historyMovesGroupLabel
            // 
            this.historyMovesGroupLabel.AutoSize = true;
            this.historyMovesGroupLabel.Location = new System.Drawing.Point(4, 117);
            this.historyMovesGroupLabel.Name = "historyMovesGroupLabel";
            this.historyMovesGroupLabel.Size = new System.Drawing.Size(52, 17);
            this.historyMovesGroupLabel.TabIndex = 3;
            this.historyMovesGroupLabel.Text = "History";
            // 
            // timeMovesGroupLabel
            // 
            this.timeMovesGroupLabel.AutoSize = true;
            this.timeMovesGroupLabel.Location = new System.Drawing.Point(190, 87);
            this.timeMovesGroupLabel.Name = "timeMovesGroupLabel";
            this.timeMovesGroupLabel.Size = new System.Drawing.Size(59, 17);
            this.timeMovesGroupLabel.TabIndex = 2;
            this.timeMovesGroupLabel.Text = "Timeout";
            // 
            // performedMovesGroupLabel
            // 
            this.performedMovesGroupLabel.AutoSize = true;
            this.performedMovesGroupLabel.Location = new System.Drawing.Point(190, 55);
            this.performedMovesGroupLabel.Name = "performedMovesGroupLabel";
            this.performedMovesGroupLabel.Size = new System.Drawing.Size(74, 17);
            this.performedMovesGroupLabel.TabIndex = 1;
            this.performedMovesGroupLabel.Text = "Performed";
            // 
            // inputMovesGroupLabel
            // 
            this.inputMovesGroupLabel.AutoSize = true;
            this.inputMovesGroupLabel.Location = new System.Drawing.Point(190, 22);
            this.inputMovesGroupLabel.Name = "inputMovesGroupLabel";
            this.inputMovesGroupLabel.Size = new System.Drawing.Size(39, 17);
            this.inputMovesGroupLabel.TabIndex = 0;
            this.inputMovesGroupLabel.Text = "Input";
            // 
            // moveListGroupBox
            // 
            this.moveListGroupBox.Controls.Add(this.newMoveNameMoveListGroupLabel);
            this.moveListGroupBox.Controls.Add(this.clearNewMoveInputsMoveListGroupButton);
            this.moveListGroupBox.Controls.Add(this.newMoveInputsMoveListGroupTextBox);
            this.moveListGroupBox.Controls.Add(this.newMoveNameMoveListGroupTextBox);
            this.moveListGroupBox.Controls.Add(this.minusZMoveListGroupButton);
            this.moveListGroupBox.Controls.Add(this.plusZMoveListGroupButton);
            this.moveListGroupBox.Controls.Add(this.minusYMoveListGroupButton);
            this.moveListGroupBox.Controls.Add(this.plusYMoveListGroupButton);
            this.moveListGroupBox.Controls.Add(this.minusXMoveListGroupButton);
            this.moveListGroupBox.Controls.Add(this.plusXMoveListGroupButton);
            this.moveListGroupBox.Controls.Add(this.deleteMoveMoveListGroupButton);
            this.moveListGroupBox.Controls.Add(this.createNewMoveMostListGroupButton);
            this.moveListGroupBox.Controls.Add(this.moveNameMoveListGroupLabel);
            this.moveListGroupBox.Controls.Add(this.inputMoveListGroupLabel);
            this.moveListGroupBox.Controls.Add(this.moveNameMoveListGroupListBox);
            this.moveListGroupBox.Controls.Add(this.moveInputMoveListGroupListBox);
            this.moveListGroupBox.Location = new System.Drawing.Point(851, 16);
            this.moveListGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.moveListGroupBox.Name = "moveListGroupBox";
            this.moveListGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.moveListGroupBox.Size = new System.Drawing.Size(369, 282);
            this.moveListGroupBox.TabIndex = 3;
            this.moveListGroupBox.TabStop = false;
            this.moveListGroupBox.Text = "Move List";
            // 
            // newMoveNameMoveListGroupLabel
            // 
            this.newMoveNameMoveListGroupLabel.AutoSize = true;
            this.newMoveNameMoveListGroupLabel.Location = new System.Drawing.Point(188, 55);
            this.newMoveNameMoveListGroupLabel.Name = "newMoveNameMoveListGroupLabel";
            this.newMoveNameMoveListGroupLabel.Size = new System.Drawing.Size(49, 17);
            this.newMoveNameMoveListGroupLabel.TabIndex = 30;
            this.newMoveNameMoveListGroupLabel.Text = "Name:";
            // 
            // clearNewMoveInputsMoveListGroupButton
            // 
            this.clearNewMoveInputsMoveListGroupButton.Location = new System.Drawing.Point(308, 84);
            this.clearNewMoveInputsMoveListGroupButton.Name = "clearNewMoveInputsMoveListGroupButton";
            this.clearNewMoveInputsMoveListGroupButton.Size = new System.Drawing.Size(54, 23);
            this.clearNewMoveInputsMoveListGroupButton.TabIndex = 29;
            this.clearNewMoveInputsMoveListGroupButton.Text = "Clear";
            this.clearNewMoveInputsMoveListGroupButton.UseVisualStyleBackColor = true;
            this.clearNewMoveInputsMoveListGroupButton.Click += new System.EventHandler(this.clearNewMoveInputsMoveListGroupButton_Click);
            // 
            // newMoveInputsMoveListGroupTextBox
            // 
            this.newMoveInputsMoveListGroupTextBox.Location = new System.Drawing.Point(188, 84);
            this.newMoveInputsMoveListGroupTextBox.Name = "newMoveInputsMoveListGroupTextBox";
            this.newMoveInputsMoveListGroupTextBox.ReadOnly = true;
            this.newMoveInputsMoveListGroupTextBox.Size = new System.Drawing.Size(114, 22);
            this.newMoveInputsMoveListGroupTextBox.TabIndex = 28;
            // 
            // newMoveNameMoveListGroupTextBox
            // 
            this.newMoveNameMoveListGroupTextBox.Location = new System.Drawing.Point(248, 52);
            this.newMoveNameMoveListGroupTextBox.Name = "newMoveNameMoveListGroupTextBox";
            this.newMoveNameMoveListGroupTextBox.Size = new System.Drawing.Size(114, 22);
            this.newMoveNameMoveListGroupTextBox.TabIndex = 27;
            // 
            // minusZMoveListGroupButton
            // 
            this.minusZMoveListGroupButton.Location = new System.Drawing.Point(308, 140);
            this.minusZMoveListGroupButton.Name = "minusZMoveListGroupButton";
            this.minusZMoveListGroupButton.Size = new System.Drawing.Size(54, 23);
            this.minusZMoveListGroupButton.TabIndex = 26;
            this.minusZMoveListGroupButton.Text = "-Z";
            this.minusZMoveListGroupButton.UseVisualStyleBackColor = true;
            this.minusZMoveListGroupButton.Click += new System.EventHandler(this.minusZMoveListGroupButton_Click);
            // 
            // plusZMoveListGroupButton
            // 
            this.plusZMoveListGroupButton.Location = new System.Drawing.Point(308, 114);
            this.plusZMoveListGroupButton.Name = "plusZMoveListGroupButton";
            this.plusZMoveListGroupButton.Size = new System.Drawing.Size(54, 23);
            this.plusZMoveListGroupButton.TabIndex = 25;
            this.plusZMoveListGroupButton.Text = "+Z";
            this.plusZMoveListGroupButton.UseVisualStyleBackColor = true;
            this.plusZMoveListGroupButton.Click += new System.EventHandler(this.plusZMoveListGroupButton_Click);
            // 
            // minusYMoveListGroupButton
            // 
            this.minusYMoveListGroupButton.Location = new System.Drawing.Point(248, 140);
            this.minusYMoveListGroupButton.Name = "minusYMoveListGroupButton";
            this.minusYMoveListGroupButton.Size = new System.Drawing.Size(54, 23);
            this.minusYMoveListGroupButton.TabIndex = 24;
            this.minusYMoveListGroupButton.Text = "-Y";
            this.minusYMoveListGroupButton.UseVisualStyleBackColor = true;
            this.minusYMoveListGroupButton.Click += new System.EventHandler(this.minusYMoveListGroupButton_Click);
            // 
            // plusYMoveListGroupButton
            // 
            this.plusYMoveListGroupButton.Location = new System.Drawing.Point(248, 114);
            this.plusYMoveListGroupButton.Name = "plusYMoveListGroupButton";
            this.plusYMoveListGroupButton.Size = new System.Drawing.Size(54, 23);
            this.plusYMoveListGroupButton.TabIndex = 23;
            this.plusYMoveListGroupButton.Text = "+Y";
            this.plusYMoveListGroupButton.UseVisualStyleBackColor = true;
            this.plusYMoveListGroupButton.Click += new System.EventHandler(this.plusYMoveListGroupButton_Click);
            // 
            // minusXMoveListGroupButton
            // 
            this.minusXMoveListGroupButton.Location = new System.Drawing.Point(188, 140);
            this.minusXMoveListGroupButton.Name = "minusXMoveListGroupButton";
            this.minusXMoveListGroupButton.Size = new System.Drawing.Size(54, 23);
            this.minusXMoveListGroupButton.TabIndex = 21;
            this.minusXMoveListGroupButton.Text = "-X";
            this.minusXMoveListGroupButton.UseVisualStyleBackColor = true;
            this.minusXMoveListGroupButton.Click += new System.EventHandler(this.minusXMoveListGroupButton_Click);
            // 
            // plusXMoveListGroupButton
            // 
            this.plusXMoveListGroupButton.Location = new System.Drawing.Point(188, 114);
            this.plusXMoveListGroupButton.Name = "plusXMoveListGroupButton";
            this.plusXMoveListGroupButton.Size = new System.Drawing.Size(54, 23);
            this.plusXMoveListGroupButton.TabIndex = 20;
            this.plusXMoveListGroupButton.Text = "+X";
            this.plusXMoveListGroupButton.UseVisualStyleBackColor = true;
            this.plusXMoveListGroupButton.Click += new System.EventHandler(this.plusXMoveListGroupButton_Click);
            // 
            // deleteMoveMoveListGroupButton
            // 
            this.deleteMoveMoveListGroupButton.Location = new System.Drawing.Point(188, 232);
            this.deleteMoveMoveListGroupButton.Name = "deleteMoveMoveListGroupButton";
            this.deleteMoveMoveListGroupButton.Size = new System.Drawing.Size(174, 23);
            this.deleteMoveMoveListGroupButton.TabIndex = 19;
            this.deleteMoveMoveListGroupButton.Text = "Delete Move";
            this.deleteMoveMoveListGroupButton.UseVisualStyleBackColor = true;
            this.deleteMoveMoveListGroupButton.Click += new System.EventHandler(this.deleteMoveMoveListGroupButton_Click);
            // 
            // createNewMoveMostListGroupButton
            // 
            this.createNewMoveMostListGroupButton.Location = new System.Drawing.Point(188, 203);
            this.createNewMoveMostListGroupButton.Name = "createNewMoveMostListGroupButton";
            this.createNewMoveMostListGroupButton.Size = new System.Drawing.Size(174, 23);
            this.createNewMoveMostListGroupButton.TabIndex = 18;
            this.createNewMoveMostListGroupButton.Text = "Create Move";
            this.createNewMoveMostListGroupButton.UseVisualStyleBackColor = true;
            this.createNewMoveMostListGroupButton.Click += new System.EventHandler(this.createNewMoveMostListGroupButton_Click);
            // 
            // moveNameMoveListGroupLabel
            // 
            this.moveNameMoveListGroupLabel.AutoSize = true;
            this.moveNameMoveListGroupLabel.Location = new System.Drawing.Point(7, 24);
            this.moveNameMoveListGroupLabel.Name = "moveNameMoveListGroupLabel";
            this.moveNameMoveListGroupLabel.Size = new System.Drawing.Size(45, 17);
            this.moveNameMoveListGroupLabel.TabIndex = 17;
            this.moveNameMoveListGroupLabel.Text = "Name";
            // 
            // inputMoveListGroupLabel
            // 
            this.inputMoveListGroupLabel.AutoSize = true;
            this.inputMoveListGroupLabel.Location = new System.Drawing.Point(75, 25);
            this.inputMoveListGroupLabel.Name = "inputMoveListGroupLabel";
            this.inputMoveListGroupLabel.Size = new System.Drawing.Size(39, 17);
            this.inputMoveListGroupLabel.TabIndex = 16;
            this.inputMoveListGroupLabel.Text = "Input";
            // 
            // moveNameMoveListGroupListBox
            // 
            this.moveNameMoveListGroupListBox.FormattingEnabled = true;
            this.moveNameMoveListGroupListBox.ItemHeight = 16;
            this.moveNameMoveListGroupListBox.Items.AddRange(new object[] {
            "Punch",
            "Kick",
            "Uppercut"});
            this.moveNameMoveListGroupListBox.Location = new System.Drawing.Point(7, 47);
            this.moveNameMoveListGroupListBox.Name = "moveNameMoveListGroupListBox";
            this.moveNameMoveListGroupListBox.Size = new System.Drawing.Size(74, 228);
            this.moveNameMoveListGroupListBox.TabIndex = 1;
            this.moveNameMoveListGroupListBox.SelectedIndexChanged += new System.EventHandler(this.moveNameMoveListGroupListBox_SelectedIndexChanged);
            // 
            // moveInputMoveListGroupListBox
            // 
            this.moveInputMoveListGroupListBox.FormattingEnabled = true;
            this.moveInputMoveListGroupListBox.ItemHeight = 16;
            this.moveInputMoveListGroupListBox.Items.AddRange(new object[] {
            "+X",
            "+Z,+X",
            "+X,+Y,+Z"});
            this.moveInputMoveListGroupListBox.Location = new System.Drawing.Point(78, 47);
            this.moveInputMoveListGroupListBox.Name = "moveInputMoveListGroupListBox";
            this.moveInputMoveListGroupListBox.Size = new System.Drawing.Size(104, 228);
            this.moveInputMoveListGroupListBox.TabIndex = 0;
            this.moveInputMoveListGroupListBox.SelectedIndexChanged += new System.EventHandler(this.moveInputMoveListGroupListBox_SelectedIndexChanged);
            // 
            // tinyStickSerialPort
            // 
            this.tinyStickSerialPort.BaudRate = 128000;
            this.tinyStickSerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.tinyStickSerialPort_DataReceived);
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 25;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // csvSaveFileDialogBox
            // 
            this.csvSaveFileDialogBox.DefaultExt = "csv";
            this.csvSaveFileDialogBox.FileName = "RawData";
            this.csvSaveFileDialogBox.Filter = "CSV Files (*.csv)|*csv";
            this.csvSaveFileDialogBox.RestoreDirectory = true;
            this.csvSaveFileDialogBox.Title = "Save as CSV File";
            // 
            // StartGestureReadingTimer
            // 
            this.StartGestureReadingTimer.Interval = 200;
            this.StartGestureReadingTimer.Tick += new System.EventHandler(this.StartGestureReadingTimer_Tick);
            // 
            // ClearGestureReadingTimer
            // 
            this.ClearGestureReadingTimer.Interval = 101;
            this.ClearGestureReadingTimer.Tick += new System.EventHandler(this.ClearGestureReadingTimer_Tick);
            // 
            // fullQueueSizeDataGroupLabel
            // 
            this.fullQueueSizeDataGroupLabel.AutoSize = true;
            this.fullQueueSizeDataGroupLabel.Location = new System.Drawing.Point(7, 199);
            this.fullQueueSizeDataGroupLabel.Name = "fullQueueSizeDataGroupLabel";
            this.fullQueueSizeDataGroupLabel.Size = new System.Drawing.Size(108, 17);
            this.fullQueueSizeDataGroupLabel.TabIndex = 36;
            this.fullQueueSizeDataGroupLabel.Text = "Full Queue Size";
            // 
            // fullQueueSizeDataGroupTextBox
            // 
            this.fullQueueSizeDataGroupTextBox.Location = new System.Drawing.Point(201, 199);
            this.fullQueueSizeDataGroupTextBox.Name = "fullQueueSizeDataGroupTextBox";
            this.fullQueueSizeDataGroupTextBox.ReadOnly = true;
            this.fullQueueSizeDataGroupTextBox.Size = new System.Drawing.Size(100, 22);
            this.fullQueueSizeDataGroupTextBox.TabIndex = 37;
            // 
            // soundGroupBox
            // 
            this.soundGroupBox.Controls.Add(this.newMoveSoundGroupCheckBox);
            this.soundGroupBox.Controls.Add(this.newGestureSoundGroupCheckBox);
            this.soundGroupBox.Controls.Add(this.backgroundSoundSoundGroupCheckBox);
            this.soundGroupBox.Location = new System.Drawing.Point(1042, 305);
            this.soundGroupBox.Name = "soundGroupBox";
            this.soundGroupBox.Size = new System.Drawing.Size(182, 274);
            this.soundGroupBox.TabIndex = 4;
            this.soundGroupBox.TabStop = false;
            this.soundGroupBox.Text = "Sound";
            // 
            // backgroundSoundSoundGroupCheckBox
            // 
            this.backgroundSoundSoundGroupCheckBox.AutoSize = true;
            this.backgroundSoundSoundGroupCheckBox.Checked = true;
            this.backgroundSoundSoundGroupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backgroundSoundSoundGroupCheckBox.Location = new System.Drawing.Point(6, 31);
            this.backgroundSoundSoundGroupCheckBox.Name = "backgroundSoundSoundGroupCheckBox";
            this.backgroundSoundSoundGroupCheckBox.Size = new System.Drawing.Size(146, 21);
            this.backgroundSoundSoundGroupCheckBox.TabIndex = 0;
            this.backgroundSoundSoundGroupCheckBox.Text = "Background Music";
            this.backgroundSoundSoundGroupCheckBox.UseVisualStyleBackColor = true;
            this.backgroundSoundSoundGroupCheckBox.CheckedChanged += new System.EventHandler(this.backgroundSoundSoundGroupCheckBox_CheckedChanged);
            // 
            // newGestureSoundGroupCheckBox
            // 
            this.newGestureSoundGroupCheckBox.AutoSize = true;
            this.newGestureSoundGroupCheckBox.Checked = true;
            this.newGestureSoundGroupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.newGestureSoundGroupCheckBox.Location = new System.Drawing.Point(6, 58);
            this.newGestureSoundGroupCheckBox.Name = "newGestureSoundGroupCheckBox";
            this.newGestureSoundGroupCheckBox.Size = new System.Drawing.Size(132, 21);
            this.newGestureSoundGroupCheckBox.TabIndex = 1;
            this.newGestureSoundGroupCheckBox.Text = "Input Completed";
            this.newGestureSoundGroupCheckBox.UseVisualStyleBackColor = true;
            this.newGestureSoundGroupCheckBox.CheckedChanged += new System.EventHandler(this.newGestureSoundGroupCheckBox_CheckedChanged);
            // 
            // newMoveSoundGroupCheckBox
            // 
            this.newMoveSoundGroupCheckBox.AutoSize = true;
            this.newMoveSoundGroupCheckBox.Checked = true;
            this.newMoveSoundGroupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.newMoveSoundGroupCheckBox.Location = new System.Drawing.Point(6, 85);
            this.newMoveSoundGroupCheckBox.Name = "newMoveSoundGroupCheckBox";
            this.newMoveSoundGroupCheckBox.Size = new System.Drawing.Size(135, 21);
            this.newMoveSoundGroupCheckBox.TabIndex = 2;
            this.newMoveSoundGroupCheckBox.Text = "Move Completed";
            this.newMoveSoundGroupCheckBox.UseVisualStyleBackColor = true;
            this.newMoveSoundGroupCheckBox.CheckedChanged += new System.EventHandler(this.newMoveSoundGroupCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 601);
            this.Controls.Add(this.soundGroupBox);
            this.Controls.Add(this.moveListGroupBox);
            this.Controls.Add(this.movesGroupBox);
            this.Controls.Add(this.plotsGroupBox);
            this.Controls.Add(this.dataGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MECH 368 Lab 1 Exam - Kurtis Harms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            this.plotsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rawDataChart)).EndInit();
            this.movesGroupBox.ResumeLayout(false);
            this.movesGroupBox.PerformLayout();
            this.moveListGroupBox.ResumeLayout(false);
            this.moveListGroupBox.PerformLayout();
            this.soundGroupBox.ResumeLayout(false);
            this.soundGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.GroupBox plotsGroupBox;
        private System.Windows.Forms.GroupBox movesGroupBox;
        private System.Windows.Forms.GroupBox moveListGroupBox;
        private System.Windows.Forms.Button calibrateButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox portSelectionComboBox;
        private System.Windows.Forms.ListBox rawZDataGroupListBox;
        private System.Windows.Forms.ListBox rawYDataGroupListBox;
        private System.Windows.Forms.ListBox rawXDataGroupListBox;
        private System.Windows.Forms.Label rawZDataGroupLabel;
        private System.Windows.Forms.Label rawYDataGroupLabel;
        private System.Windows.Forms.Label rawXDataGroupLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label meanDataGroupLabel;
        private System.Windows.Forms.Label xDataGroupLabel;
        private System.Windows.Forms.Label yDataGroupLabel;
        private System.Windows.Forms.Label accelerationDataGroupLabel;
        private System.Windows.Forms.Label zDataGroupLabel;
        private System.Windows.Forms.Label queueDataGroupLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart rawDataChart;
        private System.Windows.Forms.TextBox timeoutMovesGroupTextBox;
        private System.Windows.Forms.TextBox performedMovesGroupTextBox;
        private System.Windows.Forms.TextBox inputMovesGroupTextBox;
        private System.Windows.Forms.Button clearHistoryMovesGroupButton;
        private System.Windows.Forms.Button saveHistoryMovesGroupButton;
        private System.Windows.Forms.ListBox historyMovesGroupListBox;
        private System.Windows.Forms.Label historyMovesGroupLabel;
        private System.Windows.Forms.Label timeMovesGroupLabel;
        private System.Windows.Forms.Label performedMovesGroupLabel;
        private System.Windows.Forms.Label inputMovesGroupLabel;
        private System.Windows.Forms.Label inputMoveListGroupLabel;
        private System.Windows.Forms.ListBox moveNameMoveListGroupListBox;
        private System.Windows.Forms.ListBox moveInputMoveListGroupListBox;
        private System.Windows.Forms.TextBox zQueueDataGroupTextBox;
        private System.Windows.Forms.TextBox yQueueDataGroupTextBox;
        private System.Windows.Forms.TextBox xQueueDataGroupTextBox;
        private System.Windows.Forms.TextBox zMeanDataGroupTextBox;
        private System.Windows.Forms.TextBox yMeanDataGroupTextBox;
        private System.Windows.Forms.TextBox xMeanDataGroupTextBox;
        private System.Windows.Forms.TextBox zAccelerationDataGroupTextBox;
        private System.Windows.Forms.TextBox yAccelerationDataGroupTextBox;
        private System.Windows.Forms.TextBox xAccelerationDataGroupTextBox;
        private System.Windows.Forms.Button clearDataDataGroupButton;
        private System.Windows.Forms.Button saveDataDataGroupButton;
        private System.Windows.Forms.TextBox bytesToReadDataGroupTextBox;
        private System.Windows.Forms.TextBox newMoveNameMoveListGroupTextBox;
        private System.Windows.Forms.Button minusZMoveListGroupButton;
        private System.Windows.Forms.Button plusZMoveListGroupButton;
        private System.Windows.Forms.Button minusYMoveListGroupButton;
        private System.Windows.Forms.Button plusYMoveListGroupButton;
        private System.Windows.Forms.Button minusXMoveListGroupButton;
        private System.Windows.Forms.Button plusXMoveListGroupButton;
        private System.Windows.Forms.Button deleteMoveMoveListGroupButton;
        private System.Windows.Forms.Button createNewMoveMostListGroupButton;
        private System.Windows.Forms.Button clearNewMoveInputsMoveListGroupButton;
        private System.Windows.Forms.TextBox newMoveInputsMoveListGroupTextBox;
        private System.Windows.Forms.Label newMoveNameMoveListGroupLabel;
        private System.Windows.Forms.Label moveNameMoveListGroupLabel;
        private System.IO.Ports.SerialPort tinyStickSerialPort;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.SaveFileDialog csvSaveFileDialogBox;
        private System.Windows.Forms.TextBox currentOrientationDataGroupTextBox;
        private System.Windows.Forms.Label currentOrientationDataGroupLabel;
        private System.Windows.Forms.Timer StartGestureReadingTimer;
        private System.Windows.Forms.Timer ClearGestureReadingTimer;
        private System.Windows.Forms.TextBox fullQueueSizeDataGroupTextBox;
        private System.Windows.Forms.Label fullQueueSizeDataGroupLabel;
        private System.Windows.Forms.GroupBox soundGroupBox;
        private System.Windows.Forms.CheckBox newMoveSoundGroupCheckBox;
        private System.Windows.Forms.CheckBox newGestureSoundGroupCheckBox;
        private System.Windows.Forms.CheckBox backgroundSoundSoundGroupCheckBox;
    }
}


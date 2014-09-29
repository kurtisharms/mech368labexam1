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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.calibrateButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.portSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.plotsGroupBox = new System.Windows.Forms.GroupBox();
            this.movesGroupBox = new System.Windows.Forms.GroupBox();
            this.moveListGroupBox = new System.Windows.Forms.GroupBox();
            this.soundGroupBox = new System.Windows.Forms.GroupBox();
            this.gaveGroupBox = new System.Windows.Forms.GroupBox();
            this.queueDataGroupLabel = new System.Windows.Forms.Label();
            this.zDataGroupLabel = new System.Windows.Forms.Label();
            this.accelerationDataGroupLabel = new System.Windows.Forms.Label();
            this.yDataGroupLabel = new System.Windows.Forms.Label();
            this.xDataGroupLabel = new System.Windows.Forms.Label();
            this.meanDataGroupLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rawXDataGroupLabel = new System.Windows.Forms.Label();
            this.rawYDataGroupLabel = new System.Windows.Forms.Label();
            this.rawZDataGroupLabel = new System.Windows.Forms.Label();
            this.rawXDataGroupListBox = new System.Windows.Forms.ListBox();
            this.rawYDataGroupListBox = new System.Windows.Forms.ListBox();
            this.rawZDataGroupListBox = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.inputMovesGroupLabel = new System.Windows.Forms.Label();
            this.performedMovesGroupLabel = new System.Windows.Forms.Label();
            this.timeMovesGroupLabel = new System.Windows.Forms.Label();
            this.historyMovesGroupLabel = new System.Windows.Forms.Label();
            this.historyMovesGroupListBox = new System.Windows.Forms.ListBox();
            this.saveHistoryMovesGroupButton = new System.Windows.Forms.Button();
            this.clearHistoryMovesGroupButton = new System.Windows.Forms.Button();
            this.inputMoveListGroupListBox = new System.Windows.Forms.ListBox();
            this.moveMoveListGroupListBox = new System.Windows.Forms.ListBox();
            this.hitsMoveListGroupListBox = new System.Windows.Forms.ListBox();
            this.inputMoveListGroupLabel = new System.Windows.Forms.Label();
            this.moveMoveListGroupLabel = new System.Windows.Forms.Label();
            this.hitsMoveListGroupLabel = new System.Windows.Forms.Label();
            this.inputMovesGroupTextBox = new System.Windows.Forms.TextBox();
            this.performedMovesGroupTextBox = new System.Windows.Forms.TextBox();
            this.timeoutMovesGroupTextBox = new System.Windows.Forms.TextBox();
            this.xAccelerationDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.yAccelerationDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.zAccelerationDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.xMeanDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.yMeanDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.zMeanDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.xQueueDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.yQueueDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.zQueueDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.bytesToReadDataGroupTextBox = new System.Windows.Forms.TextBox();
            this.saveDataDataGroupButton = new System.Windows.Forms.Button();
            this.clearDataDataGroupButton = new System.Windows.Forms.Button();
            this.dataGroupBox.SuspendLayout();
            this.plotsGroupBox.SuspendLayout();
            this.movesGroupBox.SuspendLayout();
            this.moveListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGroupBox
            // 
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
            this.dataGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGroupBox.Size = new System.Drawing.Size(548, 282);
            this.dataGroupBox.TabIndex = 0;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Data";
            // 
            // calibrateButton
            // 
            this.calibrateButton.Location = new System.Drawing.Point(240, 25);
            this.calibrateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calibrateButton.Name = "calibrateButton";
            this.calibrateButton.Size = new System.Drawing.Size(83, 28);
            this.calibrateButton.TabIndex = 2;
            this.calibrateButton.Text = "Calibrate";
            this.calibrateButton.UseVisualStyleBackColor = true;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(144, 25);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(88, 28);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            // 
            // portSelectionComboBox
            // 
            this.portSelectionComboBox.FormattingEnabled = true;
            this.portSelectionComboBox.Location = new System.Drawing.Point(9, 25);
            this.portSelectionComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.portSelectionComboBox.Name = "portSelectionComboBox";
            this.portSelectionComboBox.Size = new System.Drawing.Size(126, 24);
            this.portSelectionComboBox.TabIndex = 0;
            // 
            // plotsGroupBox
            // 
            this.plotsGroupBox.Controls.Add(this.chart1);
            this.plotsGroupBox.Location = new System.Drawing.Point(17, 305);
            this.plotsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plotsGroupBox.Name = "plotsGroupBox";
            this.plotsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plotsGroupBox.Size = new System.Drawing.Size(548, 281);
            this.plotsGroupBox.TabIndex = 1;
            this.plotsGroupBox.TabStop = false;
            this.plotsGroupBox.Text = "Plots";
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
            this.movesGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.movesGroupBox.Name = "movesGroupBox";
            this.movesGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.movesGroupBox.Size = new System.Drawing.Size(267, 282);
            this.movesGroupBox.TabIndex = 2;
            this.movesGroupBox.TabStop = false;
            this.movesGroupBox.Text = "Moves";
            // 
            // moveListGroupBox
            // 
            this.moveListGroupBox.Controls.Add(this.hitsMoveListGroupLabel);
            this.moveListGroupBox.Controls.Add(this.moveMoveListGroupLabel);
            this.moveListGroupBox.Controls.Add(this.inputMoveListGroupLabel);
            this.moveListGroupBox.Controls.Add(this.hitsMoveListGroupListBox);
            this.moveListGroupBox.Controls.Add(this.moveMoveListGroupListBox);
            this.moveListGroupBox.Controls.Add(this.inputMoveListGroupListBox);
            this.moveListGroupBox.Location = new System.Drawing.Point(851, 16);
            this.moveListGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moveListGroupBox.Name = "moveListGroupBox";
            this.moveListGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moveListGroupBox.Size = new System.Drawing.Size(236, 282);
            this.moveListGroupBox.TabIndex = 3;
            this.moveListGroupBox.TabStop = false;
            this.moveListGroupBox.Text = "Move List";
            // 
            // soundGroupBox
            // 
            this.soundGroupBox.Location = new System.Drawing.Point(1095, 16);
            this.soundGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.soundGroupBox.Name = "soundGroupBox";
            this.soundGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.soundGroupBox.Size = new System.Drawing.Size(125, 282);
            this.soundGroupBox.TabIndex = 4;
            this.soundGroupBox.TabStop = false;
            this.soundGroupBox.Text = "Sound";
            // 
            // gaveGroupBox
            // 
            this.gaveGroupBox.Location = new System.Drawing.Point(575, 306);
            this.gaveGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gaveGroupBox.Name = "gaveGroupBox";
            this.gaveGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gaveGroupBox.Size = new System.Drawing.Size(645, 279);
            this.gaveGroupBox.TabIndex = 5;
            this.gaveGroupBox.TabStop = false;
            this.gaveGroupBox.Text = "Game";
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
            // zDataGroupLabel
            // 
            this.zDataGroupLabel.AutoSize = true;
            this.zDataGroupLabel.Location = new System.Drawing.Point(4, 186);
            this.zDataGroupLabel.Name = "zDataGroupLabel";
            this.zDataGroupLabel.Size = new System.Drawing.Size(17, 17);
            this.zDataGroupLabel.TabIndex = 4;
            this.zDataGroupLabel.Text = "Z";
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
            // yDataGroupLabel
            // 
            this.yDataGroupLabel.AutoSize = true;
            this.yDataGroupLabel.Location = new System.Drawing.Point(7, 144);
            this.yDataGroupLabel.Name = "yDataGroupLabel";
            this.yDataGroupLabel.Size = new System.Drawing.Size(17, 17);
            this.yDataGroupLabel.TabIndex = 6;
            this.yDataGroupLabel.Text = "Y";
            // 
            // xDataGroupLabel
            // 
            this.xDataGroupLabel.AutoSize = true;
            this.xDataGroupLabel.Location = new System.Drawing.Point(7, 103);
            this.xDataGroupLabel.Name = "xDataGroupLabel";
            this.xDataGroupLabel.Size = new System.Drawing.Size(17, 17);
            this.xDataGroupLabel.TabIndex = 7;
            this.xDataGroupLabel.Text = "X";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "BytesToRead";
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
            // rawYDataGroupLabel
            // 
            this.rawYDataGroupLabel.AutoSize = true;
            this.rawYDataGroupLabel.Location = new System.Drawing.Point(409, 28);
            this.rawYDataGroupLabel.Name = "rawYDataGroupLabel";
            this.rawYDataGroupLabel.Size = new System.Drawing.Size(52, 17);
            this.rawYDataGroupLabel.TabIndex = 11;
            this.rawYDataGroupLabel.Text = " Raw Y";
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
            // rawXDataGroupListBox
            // 
            this.rawXDataGroupListBox.FormattingEnabled = true;
            this.rawXDataGroupListBox.ItemHeight = 16;
            this.rawXDataGroupListBox.Location = new System.Drawing.Point(344, 64);
            this.rawXDataGroupListBox.Name = "rawXDataGroupListBox";
            this.rawXDataGroupListBox.Size = new System.Drawing.Size(52, 148);
            this.rawXDataGroupListBox.TabIndex = 13;
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
            // rawZDataGroupListBox
            // 
            this.rawZDataGroupListBox.FormattingEnabled = true;
            this.rawZDataGroupListBox.ItemHeight = 16;
            this.rawZDataGroupListBox.Location = new System.Drawing.Point(478, 64);
            this.rawZDataGroupListBox.Name = "rawZDataGroupListBox";
            this.rawZDataGroupListBox.Size = new System.Drawing.Size(52, 148);
            this.rawZDataGroupListBox.TabIndex = 15;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(37, 44);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(478, 213);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
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
            // performedMovesGroupLabel
            // 
            this.performedMovesGroupLabel.AutoSize = true;
            this.performedMovesGroupLabel.Location = new System.Drawing.Point(190, 55);
            this.performedMovesGroupLabel.Name = "performedMovesGroupLabel";
            this.performedMovesGroupLabel.Size = new System.Drawing.Size(74, 17);
            this.performedMovesGroupLabel.TabIndex = 1;
            this.performedMovesGroupLabel.Text = "Performed";
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
            // historyMovesGroupLabel
            // 
            this.historyMovesGroupLabel.AutoSize = true;
            this.historyMovesGroupLabel.Location = new System.Drawing.Point(4, 117);
            this.historyMovesGroupLabel.Name = "historyMovesGroupLabel";
            this.historyMovesGroupLabel.Size = new System.Drawing.Size(52, 17);
            this.historyMovesGroupLabel.TabIndex = 3;
            this.historyMovesGroupLabel.Text = "History";
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
            // saveHistoryMovesGroupButton
            // 
            this.saveHistoryMovesGroupButton.Location = new System.Drawing.Point(41, 239);
            this.saveHistoryMovesGroupButton.Name = "saveHistoryMovesGroupButton";
            this.saveHistoryMovesGroupButton.Size = new System.Drawing.Size(75, 23);
            this.saveHistoryMovesGroupButton.TabIndex = 17;
            this.saveHistoryMovesGroupButton.Text = "Save History";
            this.saveHistoryMovesGroupButton.UseVisualStyleBackColor = true;
            // 
            // clearHistoryMovesGroupButton
            // 
            this.clearHistoryMovesGroupButton.Location = new System.Drawing.Point(122, 239);
            this.clearHistoryMovesGroupButton.Name = "clearHistoryMovesGroupButton";
            this.clearHistoryMovesGroupButton.Size = new System.Drawing.Size(108, 23);
            this.clearHistoryMovesGroupButton.TabIndex = 18;
            this.clearHistoryMovesGroupButton.Text = "Clear History";
            this.clearHistoryMovesGroupButton.UseVisualStyleBackColor = true;
            // 
            // inputMoveListGroupListBox
            // 
            this.inputMoveListGroupListBox.FormattingEnabled = true;
            this.inputMoveListGroupListBox.ItemHeight = 16;
            this.inputMoveListGroupListBox.Location = new System.Drawing.Point(7, 50);
            this.inputMoveListGroupListBox.Name = "inputMoveListGroupListBox";
            this.inputMoveListGroupListBox.Size = new System.Drawing.Size(68, 228);
            this.inputMoveListGroupListBox.TabIndex = 0;
            // 
            // moveMoveListGroupListBox
            // 
            this.moveMoveListGroupListBox.FormattingEnabled = true;
            this.moveMoveListGroupListBox.ItemHeight = 16;
            this.moveMoveListGroupListBox.Location = new System.Drawing.Point(81, 50);
            this.moveMoveListGroupListBox.Name = "moveMoveListGroupListBox";
            this.moveMoveListGroupListBox.Size = new System.Drawing.Size(68, 228);
            this.moveMoveListGroupListBox.TabIndex = 1;
            // 
            // hitsMoveListGroupListBox
            // 
            this.hitsMoveListGroupListBox.FormattingEnabled = true;
            this.hitsMoveListGroupListBox.ItemHeight = 16;
            this.hitsMoveListGroupListBox.Location = new System.Drawing.Point(155, 50);
            this.hitsMoveListGroupListBox.Name = "hitsMoveListGroupListBox";
            this.hitsMoveListGroupListBox.Size = new System.Drawing.Size(68, 228);
            this.hitsMoveListGroupListBox.TabIndex = 2;
            // 
            // inputMoveListGroupLabel
            // 
            this.inputMoveListGroupLabel.AutoSize = true;
            this.inputMoveListGroupLabel.Location = new System.Drawing.Point(7, 25);
            this.inputMoveListGroupLabel.Name = "inputMoveListGroupLabel";
            this.inputMoveListGroupLabel.Size = new System.Drawing.Size(39, 17);
            this.inputMoveListGroupLabel.TabIndex = 16;
            this.inputMoveListGroupLabel.Text = "Input";
            // 
            // moveMoveListGroupLabel
            // 
            this.moveMoveListGroupLabel.AutoSize = true;
            this.moveMoveListGroupLabel.Location = new System.Drawing.Point(78, 25);
            this.moveMoveListGroupLabel.Name = "moveMoveListGroupLabel";
            this.moveMoveListGroupLabel.Size = new System.Drawing.Size(42, 17);
            this.moveMoveListGroupLabel.TabIndex = 17;
            this.moveMoveListGroupLabel.Text = "Move";
            // 
            // hitsMoveListGroupLabel
            // 
            this.hitsMoveListGroupLabel.AutoSize = true;
            this.hitsMoveListGroupLabel.Location = new System.Drawing.Point(152, 25);
            this.hitsMoveListGroupLabel.Name = "hitsMoveListGroupLabel";
            this.hitsMoveListGroupLabel.Size = new System.Drawing.Size(32, 17);
            this.hitsMoveListGroupLabel.TabIndex = 18;
            this.hitsMoveListGroupLabel.Text = "Hits";
            // 
            // inputMovesGroupTextBox
            // 
            this.inputMovesGroupTextBox.Location = new System.Drawing.Point(7, 19);
            this.inputMovesGroupTextBox.Name = "inputMovesGroupTextBox";
            this.inputMovesGroupTextBox.Size = new System.Drawing.Size(161, 22);
            this.inputMovesGroupTextBox.TabIndex = 19;
            // 
            // performedMovesGroupTextBox
            // 
            this.performedMovesGroupTextBox.Location = new System.Drawing.Point(7, 55);
            this.performedMovesGroupTextBox.Name = "performedMovesGroupTextBox";
            this.performedMovesGroupTextBox.Size = new System.Drawing.Size(161, 22);
            this.performedMovesGroupTextBox.TabIndex = 20;
            // 
            // timeoutMovesGroupTextBox
            // 
            this.timeoutMovesGroupTextBox.Location = new System.Drawing.Point(7, 87);
            this.timeoutMovesGroupTextBox.Name = "timeoutMovesGroupTextBox";
            this.timeoutMovesGroupTextBox.Size = new System.Drawing.Size(161, 22);
            this.timeoutMovesGroupTextBox.TabIndex = 21;
            // 
            // xAccelerationDataGroupTextBox
            // 
            this.xAccelerationDataGroupTextBox.Location = new System.Drawing.Point(92, 100);
            this.xAccelerationDataGroupTextBox.Name = "xAccelerationDataGroupTextBox";
            this.xAccelerationDataGroupTextBox.ReadOnly = true;
            this.xAccelerationDataGroupTextBox.Size = new System.Drawing.Size(61, 22);
            this.xAccelerationDataGroupTextBox.TabIndex = 22;
            // 
            // yAccelerationDataGroupTextBox
            // 
            this.yAccelerationDataGroupTextBox.Location = new System.Drawing.Point(92, 141);
            this.yAccelerationDataGroupTextBox.Name = "yAccelerationDataGroupTextBox";
            this.yAccelerationDataGroupTextBox.ReadOnly = true;
            this.yAccelerationDataGroupTextBox.Size = new System.Drawing.Size(61, 22);
            this.yAccelerationDataGroupTextBox.TabIndex = 23;
            // 
            // zAccelerationDataGroupTextBox
            // 
            this.zAccelerationDataGroupTextBox.Location = new System.Drawing.Point(92, 183);
            this.zAccelerationDataGroupTextBox.Name = "zAccelerationDataGroupTextBox";
            this.zAccelerationDataGroupTextBox.ReadOnly = true;
            this.zAccelerationDataGroupTextBox.Size = new System.Drawing.Size(61, 22);
            this.zAccelerationDataGroupTextBox.TabIndex = 24;
            // 
            // xMeanDataGroupTextBox
            // 
            this.xMeanDataGroupTextBox.Location = new System.Drawing.Point(162, 100);
            this.xMeanDataGroupTextBox.Name = "xMeanDataGroupTextBox";
            this.xMeanDataGroupTextBox.ReadOnly = true;
            this.xMeanDataGroupTextBox.Size = new System.Drawing.Size(61, 22);
            this.xMeanDataGroupTextBox.TabIndex = 25;
            // 
            // yMeanDataGroupTextBox
            // 
            this.yMeanDataGroupTextBox.Location = new System.Drawing.Point(162, 141);
            this.yMeanDataGroupTextBox.Name = "yMeanDataGroupTextBox";
            this.yMeanDataGroupTextBox.ReadOnly = true;
            this.yMeanDataGroupTextBox.Size = new System.Drawing.Size(61, 22);
            this.yMeanDataGroupTextBox.TabIndex = 26;
            // 
            // zMeanDataGroupTextBox
            // 
            this.zMeanDataGroupTextBox.Location = new System.Drawing.Point(162, 183);
            this.zMeanDataGroupTextBox.Name = "zMeanDataGroupTextBox";
            this.zMeanDataGroupTextBox.ReadOnly = true;
            this.zMeanDataGroupTextBox.Size = new System.Drawing.Size(61, 22);
            this.zMeanDataGroupTextBox.TabIndex = 27;
            // 
            // xQueueDataGroupTextBox
            // 
            this.xQueueDataGroupTextBox.Location = new System.Drawing.Point(240, 100);
            this.xQueueDataGroupTextBox.Name = "xQueueDataGroupTextBox";
            this.xQueueDataGroupTextBox.ReadOnly = true;
            this.xQueueDataGroupTextBox.Size = new System.Drawing.Size(61, 22);
            this.xQueueDataGroupTextBox.TabIndex = 28;
            // 
            // yQueueDataGroupTextBox
            // 
            this.yQueueDataGroupTextBox.Location = new System.Drawing.Point(240, 144);
            this.yQueueDataGroupTextBox.Name = "yQueueDataGroupTextBox";
            this.yQueueDataGroupTextBox.ReadOnly = true;
            this.yQueueDataGroupTextBox.Size = new System.Drawing.Size(61, 22);
            this.yQueueDataGroupTextBox.TabIndex = 29;
            // 
            // zQueueDataGroupTextBox
            // 
            this.zQueueDataGroupTextBox.Location = new System.Drawing.Point(240, 183);
            this.zQueueDataGroupTextBox.Name = "zQueueDataGroupTextBox";
            this.zQueueDataGroupTextBox.ReadOnly = true;
            this.zQueueDataGroupTextBox.Size = new System.Drawing.Size(61, 22);
            this.zQueueDataGroupTextBox.TabIndex = 30;
            // 
            // bytesToReadDataGroupTextBox
            // 
            this.bytesToReadDataGroupTextBox.Location = new System.Drawing.Point(7, 236);
            this.bytesToReadDataGroupTextBox.Name = "bytesToReadDataGroupTextBox";
            this.bytesToReadDataGroupTextBox.ReadOnly = true;
            this.bytesToReadDataGroupTextBox.Size = new System.Drawing.Size(100, 22);
            this.bytesToReadDataGroupTextBox.TabIndex = 31;
            // 
            // saveDataDataGroupButton
            // 
            this.saveDataDataGroupButton.Location = new System.Drawing.Point(344, 232);
            this.saveDataDataGroupButton.Name = "saveDataDataGroupButton";
            this.saveDataDataGroupButton.Size = new System.Drawing.Size(93, 23);
            this.saveDataDataGroupButton.TabIndex = 32;
            this.saveDataDataGroupButton.Text = "Save Data";
            this.saveDataDataGroupButton.UseVisualStyleBackColor = true;
            // 
            // clearDataDataGroupButton
            // 
            this.clearDataDataGroupButton.Location = new System.Drawing.Point(443, 232);
            this.clearDataDataGroupButton.Name = "clearDataDataGroupButton";
            this.clearDataDataGroupButton.Size = new System.Drawing.Size(87, 23);
            this.clearDataDataGroupButton.TabIndex = 33;
            this.clearDataDataGroupButton.Text = "Clear Data";
            this.clearDataDataGroupButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 601);
            this.Controls.Add(this.gaveGroupBox);
            this.Controls.Add(this.soundGroupBox);
            this.Controls.Add(this.moveListGroupBox);
            this.Controls.Add(this.movesGroupBox);
            this.Controls.Add(this.plotsGroupBox);
            this.Controls.Add(this.dataGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            this.plotsGroupBox.ResumeLayout(false);
            this.movesGroupBox.ResumeLayout(false);
            this.movesGroupBox.PerformLayout();
            this.moveListGroupBox.ResumeLayout(false);
            this.moveListGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.GroupBox plotsGroupBox;
        private System.Windows.Forms.GroupBox movesGroupBox;
        private System.Windows.Forms.GroupBox moveListGroupBox;
        private System.Windows.Forms.GroupBox soundGroupBox;
        private System.Windows.Forms.GroupBox gaveGroupBox;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
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
        private System.Windows.Forms.Label hitsMoveListGroupLabel;
        private System.Windows.Forms.Label moveMoveListGroupLabel;
        private System.Windows.Forms.Label inputMoveListGroupLabel;
        private System.Windows.Forms.ListBox hitsMoveListGroupListBox;
        private System.Windows.Forms.ListBox moveMoveListGroupListBox;
        private System.Windows.Forms.ListBox inputMoveListGroupListBox;
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
    }
}


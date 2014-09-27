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
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.plotsGroupBox = new System.Windows.Forms.GroupBox();
            this.movesGroupBox = new System.Windows.Forms.GroupBox();
            this.moveListGroupBox = new System.Windows.Forms.GroupBox();
            this.soundGroupBox = new System.Windows.Forms.GroupBox();
            this.gaveGroupBox = new System.Windows.Forms.GroupBox();
            this.portSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.button1);
            this.dataGroupBox.Controls.Add(this.connectButton);
            this.dataGroupBox.Controls.Add(this.portSelectionComboBox);
            this.dataGroupBox.Location = new System.Drawing.Point(13, 13);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(411, 229);
            this.dataGroupBox.TabIndex = 0;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Data";
            // 
            // plotsGroupBox
            // 
            this.plotsGroupBox.Location = new System.Drawing.Point(13, 248);
            this.plotsGroupBox.Name = "plotsGroupBox";
            this.plotsGroupBox.Size = new System.Drawing.Size(411, 228);
            this.plotsGroupBox.TabIndex = 1;
            this.plotsGroupBox.TabStop = false;
            this.plotsGroupBox.Text = "Plots";
            // 
            // movesGroupBox
            // 
            this.movesGroupBox.Location = new System.Drawing.Point(431, 13);
            this.movesGroupBox.Name = "movesGroupBox";
            this.movesGroupBox.Size = new System.Drawing.Size(200, 229);
            this.movesGroupBox.TabIndex = 2;
            this.movesGroupBox.TabStop = false;
            this.movesGroupBox.Text = "Moves";
            // 
            // moveListGroupBox
            // 
            this.moveListGroupBox.Location = new System.Drawing.Point(638, 13);
            this.moveListGroupBox.Name = "moveListGroupBox";
            this.moveListGroupBox.Size = new System.Drawing.Size(177, 229);
            this.moveListGroupBox.TabIndex = 3;
            this.moveListGroupBox.TabStop = false;
            this.moveListGroupBox.Text = "Move List";
            // 
            // soundGroupBox
            // 
            this.soundGroupBox.Location = new System.Drawing.Point(821, 13);
            this.soundGroupBox.Name = "soundGroupBox";
            this.soundGroupBox.Size = new System.Drawing.Size(94, 229);
            this.soundGroupBox.TabIndex = 4;
            this.soundGroupBox.TabStop = false;
            this.soundGroupBox.Text = "Sound";
            // 
            // gaveGroupBox
            // 
            this.gaveGroupBox.Location = new System.Drawing.Point(431, 249);
            this.gaveGroupBox.Name = "gaveGroupBox";
            this.gaveGroupBox.Size = new System.Drawing.Size(484, 227);
            this.gaveGroupBox.TabIndex = 5;
            this.gaveGroupBox.TabStop = false;
            this.gaveGroupBox.Text = "Game";
            // 
            // portSelectionComboBox
            // 
            this.portSelectionComboBox.FormattingEnabled = true;
            this.portSelectionComboBox.Location = new System.Drawing.Point(7, 20);
            this.portSelectionComboBox.Name = "portSelectionComboBox";
            this.portSelectionComboBox.Size = new System.Drawing.Size(122, 21);
            this.portSelectionComboBox.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(135, 20);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calibrate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 488);
            this.Controls.Add(this.gaveGroupBox);
            this.Controls.Add(this.soundGroupBox);
            this.Controls.Add(this.moveListGroupBox);
            this.Controls.Add(this.movesGroupBox);
            this.Controls.Add(this.plotsGroupBox);
            this.Controls.Add(this.dataGroupBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.dataGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.GroupBox plotsGroupBox;
        private System.Windows.Forms.GroupBox movesGroupBox;
        private System.Windows.Forms.GroupBox moveListGroupBox;
        private System.Windows.Forms.GroupBox soundGroupBox;
        private System.Windows.Forms.GroupBox gaveGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox portSelectionComboBox;
    }
}


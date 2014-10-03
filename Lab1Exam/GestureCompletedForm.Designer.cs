namespace Lab1Exam
{
    partial class GestureCompletedForm
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
            this.closeTimer = new System.Windows.Forms.Timer(this.components);
            this.gestureCompletedMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeTimer
            // 
            this.closeTimer.Tick += new System.EventHandler(this.closeTimer_Tick);
            // 
            // gestureCompletedMessageLabel
            // 
            this.gestureCompletedMessageLabel.AutoSize = true;
            this.gestureCompletedMessageLabel.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestureCompletedMessageLabel.ForeColor = System.Drawing.Color.White;
            this.gestureCompletedMessageLabel.Location = new System.Drawing.Point(1, 147);
            this.gestureCompletedMessageLabel.MinimumSize = new System.Drawing.Size(600, 0);
            this.gestureCompletedMessageLabel.Name = "gestureCompletedMessageLabel";
            this.gestureCompletedMessageLabel.Size = new System.Drawing.Size(600, 73);
            this.gestureCompletedMessageLabel.TabIndex = 0;
            this.gestureCompletedMessageLabel.Text = "TEST";
            this.gestureCompletedMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GestureCompletedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.gestureCompletedMessageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestureCompletedForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestureCompletedForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GestureCompletedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer closeTimer;
        private System.Windows.Forms.Label gestureCompletedMessageLabel;
    }
}
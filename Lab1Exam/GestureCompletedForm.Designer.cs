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
            this.gestureCompletedMessageTextBox = new System.Windows.Forms.TextBox();
            this.closeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gestureCompletedMessageTextBox
            // 
            this.gestureCompletedMessageTextBox.BackColor = System.Drawing.Color.Khaki;
            this.gestureCompletedMessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestureCompletedMessageTextBox.ForeColor = System.Drawing.Color.Firebrick;
            this.gestureCompletedMessageTextBox.Location = new System.Drawing.Point(-1, 152);
            this.gestureCompletedMessageTextBox.Name = "gestureCompletedMessageTextBox";
            this.gestureCompletedMessageTextBox.ReadOnly = true;
            this.gestureCompletedMessageTextBox.Size = new System.Drawing.Size(602, 75);
            this.gestureCompletedMessageTextBox.TabIndex = 0;
            this.gestureCompletedMessageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // closeTimer
            // 
            this.closeTimer.Tick += new System.EventHandler(this.closeTimer_Tick);
            // 
            // GestureCompletedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.gestureCompletedMessageTextBox);
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

        private System.Windows.Forms.TextBox gestureCompletedMessageTextBox;
        private System.Windows.Forms.Timer closeTimer;
    }
}
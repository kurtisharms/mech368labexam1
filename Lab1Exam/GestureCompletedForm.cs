using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Exam
{
    public partial class GestureCompletedForm : Form
    {
        string message = "";
        int timeout = 0;
        public GestureCompletedForm()
        {
            InitializeComponent();
        }
        public GestureCompletedForm(string message, int timeout)
        {
            InitializeComponent();
            this.message = message;
            this.timeout = timeout;
        }

        private void GestureCompletedForm_Load(object sender, EventArgs e)
        {
            gestureCompletedMessageTextBox.Text = message;
            if (timeout != 0) {
                closeTimer.Interval = timeout;
                closeTimer.Enabled = true;
                closeTimer.Start();
            }
        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

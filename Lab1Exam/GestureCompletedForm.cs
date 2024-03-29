﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrrKlang;

namespace Lab1Exam
{
    public partial class GestureCompletedForm : Form
    {
        string message = "";
        int timeout = 0;
        bool playSound = true;
        public GestureCompletedForm()
        {
            InitializeComponent();
        }
        public GestureCompletedForm(string message, int timeout, bool playSound)
        {
            InitializeComponent();
            this.message = message;
            this.timeout = timeout;
            this.playSound = playSound;
        }

        private void GestureCompletedForm_Load(object sender, EventArgs e)
        {
            gestureCompletedMessageLabel.Text = message;
            if (timeout != 0) {
                closeTimer.Interval = timeout;
                closeTimer.Enabled = true;
                closeTimer.Start();
            }

            if (playSound)
            {
                // Play sounds now
                ISoundEngine engine = new ISoundEngine();
                engine.Play2D("./Resources/BEEP2.wav");
            }
        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

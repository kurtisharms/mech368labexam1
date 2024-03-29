﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.IO;
using IrrKlang;

namespace Lab1Exam
{
    public partial class MainForm : Form
    {
        ConcurrentQueue<int> dataQueue = new ConcurrentQueue<int>();
        ConcurrentQueue<int> xDataQueue = new ConcurrentQueue<int>();
        ConcurrentQueue<int> yDataQueue = new ConcurrentQueue<int>();
        ConcurrentQueue<int> zDataQueue = new ConcurrentQueue<int>();

        int timeInMSElapsed = 0;

        // Default values of -1 indicate that they haven't been assigned a value yet
        int xAxis = -1;
        int yAxis = -1;
        int zAxis = -1;

        bool isGestureReading = false;
        bool isInGesture = false;

        int timeToClear = 2000;

        int xAxisCalibration = -1;
        int yAxisCalibration = -1;
        int zAxisCalibration = -1;

        double xMean = -1;
        double yMean = -1;
        double zMean = -1;

        double xMax = -1;
        double yMax = -1;
        double zMax = -1;

        // Sounds
        ISound bgMusic;
        ISound explosion;

        // Current list of moves inputted
        string currentMoveInputted = "";
        string movesInputted = "";

        public MainForm()
        {
            InitializeComponent();

            portSelectionComboBox.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (portSelectionComboBox.Items.Count > 0)
                portSelectionComboBox.SelectedIndex = 0;

            rawDataChart.ChartAreas[0].AxisY.Minimum = 0;
            rawDataChart.ChartAreas[0].AxisY.Maximum = 254;

            // Play sound
            ISoundEngine engine = new ISoundEngine();
            bgMusic = engine.Play2D("./Resources/electromania118.wav", true, false, StreamMode.AutoDetect, true);
            bgMusic.Volume *= (float) 0.5;
            if (bgMusic != null)
            {
                ISoundEffectControl fx = bgMusic.SoundEffectControl;
                if (fx != null)
                {
                    fx.EnableWavesReverbSoundEffect();
                }
            }


            
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tinyStickSerialPort.IsOpen)
                {
                    tinyStickSerialPort.PortName = portSelectionComboBox.SelectedItem.ToString();
                    tinyStickSerialPort.Open();
                    //tinyStickSerialPort.DtrEnable = true;
                    connectButton.Text = "Disconnect";
                    updateTimer.Enabled = true;
                }
                else
                {
                    tinyStickSerialPort.Close();
                    dataQueue = new ConcurrentQueue<int>();
                    connectButton.Text = "Connect";
                    updateTimer.Enabled = false;
                    xAxisCalibration = -1;
                    yAxisCalibration = -1;
                    zAxisCalibration = -1;
                }
            }
            catch (NullReferenceException)
            {
                // Handles case of trying to connect to an empty COM port
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tinyStickSerialPort.IsOpen)
                tinyStickSerialPort.Close();
        }

        private void tinyStickSerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // i = -1 to indicate we haven't found a start byte!
            int i = -1;

            try
            {
                while (tinyStickSerialPort.BytesToRead > 0)
                {
                    
                    int currentByte = tinyStickSerialPort.ReadByte();

                    if (i == -1)
                    {
                        if (currentByte == 255)
                            i = 1;
                    }
                    else
                    {
                        if (i == 0)
                        {
                            i++;
                        }
                        else if (i == 1)
                        {
                            xAxis = currentByte;
                            xDataQueue.Enqueue(currentByte);
                            i++;
                        }
                        else if (i == 2)
                        {
                            yAxis = currentByte;
                            yDataQueue.Enqueue(currentByte);
                            i++;
                        }
                        else if (i == 3)
                        {
                            zAxis = currentByte;
                            zDataQueue.Enqueue(currentByte);
                            i = 0;
                        }
                    }

                    dataQueue.Enqueue(currentByte);
                }
            }
            catch (InvalidOperationException)
            {

            }
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            bytesToReadDataGroupTextBox.Text = tinyStickSerialPort.BytesToRead.ToString();
            
            // Update current accelerations
            xAccelerationDataGroupTextBox.Text = xAxis.ToString();
            yAccelerationDataGroupTextBox.Text = yAxis.ToString();
            zAccelerationDataGroupTextBox.Text = zAxis.ToString();

            // Add to list of accelerations
            rawXDataGroupListBox.Items.Add(xAxis.ToString());
            rawYDataGroupListBox.Items.Add(yAxis.ToString());
            rawZDataGroupListBox.Items.Add(zAxis.ToString());

            // Set index to bottom
            rawXDataGroupListBox.SelectedIndex = rawXDataGroupListBox.Items.Count - 1;
            rawYDataGroupListBox.SelectedIndex = rawYDataGroupListBox.Items.Count - 1;
            rawZDataGroupListBox.SelectedIndex = rawZDataGroupListBox.Items.Count - 1;

            // Update Queues
            xQueueDataGroupTextBox.Text = xDataQueue.Count.ToString();
            yQueueDataGroupTextBox.Text = yDataQueue.Count.ToString();
            zQueueDataGroupTextBox.Text = zDataQueue.Count.ToString();

            // Update last 100 mean values
            xMean = getMean(100, xDataQueue);
            yMean = getMean(100, yDataQueue);
            zMean = getMean(100, zDataQueue);
            xMeanDataGroupTextBox.Text = xMean.ToString();
            yMeanDataGroupTextBox.Text = yMean.ToString();
            zMeanDataGroupTextBox.Text = zMean.ToString();

            // Update max acceleration of last 1000 values for every axis
            xMax = getMax(1000, xDataQueue);
            yMax = getMax(1000, yDataQueue);
            zMax = getMax(1000, zDataQueue);
            xMaxAccelerationDataGroupTextBox.Text = xMax.ToString();
            yMaxAccelerationDataGroupTextBox.Text = yMax.ToString();
            zMaxAccelerationDataGroupTextBox.Text = zMax.ToString();

            // Update the full queue
            fullQueueSizeDataGroupTextBox.Text = dataQueue.Count.ToString();

            // Update list of current gestures
            inputMovesGroupTextBox.Text = currentMoveInputted;
            performedMovesGroupTextBox.Text = movesInputted;
            timeoutMovesGroupTextBox.Text = (((double)timeToClear) / 1000).ToString();

            updateCurrentOrientation();
            handleGestures();
            updateRawDataChart();
        }

        private void clearDataDataGroupButton_Click(object sender, EventArgs e)
        {
            rawXDataGroupListBox.Items.Clear();
            rawYDataGroupListBox.Items.Clear();
            rawZDataGroupListBox.Items.Clear();

            rawDataChart.Series[0].Points.Clear();
            rawDataChart.Series[1].Points.Clear();
            rawDataChart.Series[2].Points.Clear();
            timeInMSElapsed = 0;
        }

        private void saveDataDataGroupButton_Click(object sender, EventArgs e)
        {

            StreamWriter outputFile;
            csvSaveFileDialogBox.InitialDirectory = Application.StartupPath;
            csvSaveFileDialogBox.ShowDialog();
            outputFile = new StreamWriter(csvSaveFileDialogBox.FileName);
            outputFile.WriteLine("X,Y,Z");
            for (int i = 0; i < rawXDataGroupListBox.Items.Count; i++)
            {
                outputFile.WriteLine(rawXDataGroupListBox.Items[i].ToString() + ","
                    + rawYDataGroupListBox.Items[i].ToString() + ","
                    + rawZDataGroupListBox.Items[i].ToString());
                
            }

            outputFile.Close();

        }

        private void plusNewMove(object sender)
        {
            if (newMoveInputsMoveListGroupTextBox.Text != "")
            {
                newMoveInputsMoveListGroupTextBox.AppendText(",");
            }
            newMoveInputsMoveListGroupTextBox.AppendText(((Button) sender).Text);
        }

        private void updateCurrentOrientation()
        {
            string orientation = "Calibrate 1st";
            if (xAxisCalibration != -1)
            {
                int deltaX = xAxis - xAxisCalibration;
                int deltaY = yAxis - yAxisCalibration;
                int deltaZ = zAxis - yAxisCalibration;

                int diff = 25;

                if (Math.Abs(deltaX) < diff)
                {
                    if (deltaY > 20)
                        orientation = "face left";
                    else if (deltaY < -diff)
                        orientation = "face right";
                    else if (deltaZ < -diff)
                        orientation = "face down";
                    else
                        orientation = "face up";
                }
                else if (deltaX > diff)
                {
                    orientation = "face forwards";
                }
                else
                {
                    orientation = "face backwards";
                }
            }
            currentOrientationDataGroupTextBox.Text = orientation;
        }

        private void plusXMoveListGroupButton_Click(object sender, EventArgs e)
        {
            plusNewMove(sender);
        }

        private void minusXMoveListGroupButton_Click(object sender, EventArgs e)
        {
            plusNewMove(sender);
        }

        private void plusYMoveListGroupButton_Click(object sender, EventArgs e)
        {
            plusNewMove(sender);
        }

        private void handleGestures()
        {
            if (isGestureReading)
            {
                double margin = 65;

                if (yAxis > 254-margin*0.9)
                {
                    registerInputGesture("-Y");
                }
                else if (yAxis < margin*0.85)
                {
                    registerInputGesture("+Y");
                }
                else if (xAxis > 254 - margin*0.9)
                {
                    registerInputGesture("-X");
                }
                else if (xAxis < margin)
                {
                    registerInputGesture("+X");
                }
                else if (zAxis > 254-margin*0.75)
                {
                    registerInputGesture("+Z");
                }
                else if (zAxis < margin*1.1)
                {
                    registerInputGesture("-Z");
                }

            }
        }

        private void registerInputGesture(string gesture)
        {
            // First stop reading new gestures
            isGestureReading = false;
            // Start reading new gestures in 1s
            ClearGestureReadingTimer.Enabled = true;
            StartGestureReadingTimer.Enabled = true;
            StartGestureReadingTimer.Stop();
            StartGestureReadingTimer.Start();

            // Next stop the clear gesture reading timer
            ClearGestureReadingTimer.Stop();

            // Update the current move
            currentMoveInputted = gesture;

            // Reset the time left to complete the gesture move
            timeToClear = 2000;

            if (movesInputted == "")
            {
                movesInputted = gesture;
            }
            else
            {
                movesInputted += "," + gesture;
            }

            // Play sound if sound is enabled
            if (newGestureSoundGroupCheckBox.Checked)
            {
                ISoundEngine engine = new ISoundEngine();
                explosion = engine.Play2D("./Resources/explosion.wav", false, false, StreamMode.AutoDetect, true);
                if (explosion != null)
                {
                    ISoundEffectControl fx = explosion.SoundEffectControl;
                    if (fx != null)
                    {
                        fx.EnableEchoSoundEffect();
                    }
                }
            }
            
            // Have we completed a full move of gestures? If so, display the completion form!
            string gestureName = getGestureName(movesInputted);
            if (gestureName != "") {
                timeToClear = 200;
                GestureCompletedForm gcf = new GestureCompletedForm(gestureName, 1000, newMoveSoundGroupCheckBox.Checked);
                gcf.Show();
                historyMovesGroupListBox.Items.Add(gestureName + " - " + DateTime.Now.ToShortTimeString());
                historyMovesGroupListBox.SelectedIndex = historyMovesGroupListBox.Items.Count - 1;
            }
        }

        private void minusYMoveListGroupButton_Click(object sender, EventArgs e)
        {
            plusNewMove(sender);
        }

        private void plusZMoveListGroupButton_Click(object sender, EventArgs e)
        {
            plusNewMove(sender);
        }

        private void minusZMoveListGroupButton_Click(object sender, EventArgs e)
        {
            plusNewMove(sender);
        }

        private void clearNewMoveInputsMoveListGroupButton_Click(object sender, EventArgs e)
        {
            newMoveInputsMoveListGroupTextBox.Clear();
        }

        private void createNewMoveMostListGroupButton_Click(object sender, EventArgs e)
        {
            if (newMoveNameMoveListGroupTextBox.Text != "" && newMoveInputsMoveListGroupTextBox.Text != "")
            {
                moveNameMoveListGroupListBox.Items.Add(newMoveNameMoveListGroupTextBox.Text);
                moveInputMoveListGroupListBox.Items.Add(newMoveInputsMoveListGroupTextBox.Text);

                newMoveNameMoveListGroupTextBox.Clear();
                newMoveInputsMoveListGroupTextBox.Clear();
            }
            else
            {
                MessageBox.Show("You must specify a non-empty move name and list of move gestures!", "Move cannt be empty!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void moveInputMoveListGroupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            moveNameMoveListGroupListBox.SelectedIndex = ((ListBox)sender).SelectedIndex;
        }

        private void moveNameMoveListGroupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            moveInputMoveListGroupListBox.SelectedIndex = ((ListBox)sender).SelectedIndex;
        }

        private void deleteMoveMoveListGroupButton_Click(object sender, EventArgs e)
        {
            int indexToRemove = moveNameMoveListGroupListBox.SelectedIndex;
            if (indexToRemove != -1)
            {
                moveNameMoveListGroupListBox.Items.RemoveAt(indexToRemove);
                moveInputMoveListGroupListBox.Items.RemoveAt(indexToRemove);
            }
        }

        private void calibrateButton_Click(object sender, EventArgs e)
        {
            xAxisCalibration = xAxis;
            yAxisCalibration = yAxis;
            zAxisCalibration = zAxis;

            // We can now gesture read!
            isGestureReading = true;
        }

        

        private void rawDataChart_Click(object sender, EventArgs e)
        {

        }

        private void updateRawDataChart()
        {
            rawDataChart.Series[0].Points.AddXY(timeInMSElapsed, xAxis);
            rawDataChart.Series[1].Points.AddXY(timeInMSElapsed, yAxis);
            rawDataChart.Series[2].Points.AddXY(timeInMSElapsed, zAxis);

            if (rawDataChart.Series[0].Points.Count > 100) {
                rawDataChart.Series[0].Points.RemoveAt(0);
                rawDataChart.Series[1].Points.RemoveAt(0);
                rawDataChart.Series[2].Points.RemoveAt(0);
            }

            timeInMSElapsed += 50;
        }

        private int getMax(int lastCount, ConcurrentQueue<int> queue)
        {
            int result;
            int max = 0;
            if (lastCount != -1)
            {
                while (queue.Count > lastCount)
                    queue.TryDequeue(out result);
            }

            foreach (int i in queue)
            {
                if (i > max)
                    max = i;
            }
            return max;
        }

        private double getMean(int lastCount, ConcurrentQueue<int> queue) {
            int result;
            if (lastCount != -1)
            {
                while (queue.Count > lastCount)
                    queue.TryDequeue(out result);
            }
            return queue.Average();
        }

        private void ClearGestureReadingTimer_Tick(object sender, EventArgs e)
        {
            timeToClear -= ClearGestureReadingTimer.Interval;
            if (timeToClear <= 0)
            {
                currentMoveInputted = "";
                movesInputted = "";
                ClearGestureReadingTimer.Stop();
                timeToClear = 2000;
            }
        }

        private void StartGestureReadingTimer_Tick(object sender, EventArgs e)
        {
            // Reset our current move to empty
            currentMoveInputted = "";
            // We are gesture reading again!
            isGestureReading = true;
            // Reset the gestures in 2s if nothing is entered
            ClearGestureReadingTimer.Stop();
            ClearGestureReadingTimer.Start();
            // Stop this timer, since we are already reading
            StartGestureReadingTimer.Stop();
        }

        private string getGestureName(string inputs)
        {
            for (int i = 0; i < moveInputMoveListGroupListBox.Items.Count; i++)
            {
                if (inputs.Equals(moveInputMoveListGroupListBox.Items[i].ToString()))
                {
                    return moveNameMoveListGroupListBox.Items[i].ToString() ;
                }
            }
            return "";
        }

        private void clearHistoryMovesGroupButton_Click(object sender, EventArgs e)
        {
            historyMovesGroupListBox.Items.Clear();
        }

        private void saveHistoryMovesGroupButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            csvSaveFileDialogBox.InitialDirectory = Application.StartupPath;
            csvSaveFileDialogBox.ShowDialog();
            outputFile = new StreamWriter(csvSaveFileDialogBox.FileName);
            outputFile.WriteLine("move,time");
            for (int i = 0; i < historyMovesGroupListBox.Items.Count; i++)
            {
                string moveName = historyMovesGroupListBox.Items[i].ToString().Split('-')[0].Trim();
                string moveTime = historyMovesGroupListBox.Items[i].ToString().Split('-')[1].Trim();
                outputFile.WriteLine(moveName + "," + moveTime);
            }

            outputFile.Close();
        }

        private void bytesToReadDataGroupTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void backgroundSoundSoundGroupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!backgroundSoundSoundGroupCheckBox.Checked)
            {
                bgMusic.Volume = 0;
            }
            else
            {
                bgMusic.Volume = (float) 0.5;
            }
        }

        private void newGestureSoundGroupCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void newMoveSoundGroupCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

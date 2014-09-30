using System;
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

namespace Lab1Exam
{
    public partial class MainForm : Form
    {
        ConcurrentQueue<int> dataQueue = new ConcurrentQueue<int>();

        // Default values of -1 indicate that they haven't been assigned a value yet
        int xAxis = -1;
        int yAxis = -1;
        int zAxis = -1;
        public MainForm()
        {
            InitializeComponent();

            portSelectionComboBox.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (portSelectionComboBox.Items.Count > 0)
                portSelectionComboBox.SelectedIndex = 0;
        }

        private void connectButton_Click(object sender, EventArgs e)
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
                //int bytesToRead = tinyStickSerialPort.BytesToRead;
                //bytesToReadDataGroupTextBox.Text = bytesToRead.ToString();
                while (tinyStickSerialPort.BytesToRead > 0)
                {
                    //bytesToReadDataGroupTextBox.Text = bytesToRead.ToString();
                    int currentByte = tinyStickSerialPort.ReadByte();
                    //bytesToRead--;

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
                            i++;
                        }
                        else if (i == 2)
                        {
                            yAxis = currentByte;
                            i++;
                        }
                        else if (i == 3)
                        {
                            zAxis = currentByte;
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
            rawXDataGroupListBox.Items.Add(xAxis.ToString());
            rawYDataGroupListBox.Items.Add(yAxis.ToString());
            rawZDataGroupListBox.Items.Add(zAxis.ToString());

            // Set index to bottom
            rawXDataGroupListBox.SelectedIndex = rawXDataGroupListBox.Items.Count - 1;
            rawYDataGroupListBox.SelectedIndex = rawYDataGroupListBox.Items.Count - 1;
            rawZDataGroupListBox.SelectedIndex = rawZDataGroupListBox.Items.Count - 1;
        }

        private void clearDataDataGroupButton_Click(object sender, EventArgs e)
        {
            rawXDataGroupListBox.Items.Clear();
            rawYDataGroupListBox.Items.Clear();
            rawZDataGroupListBox.Items.Clear();
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
    }
}

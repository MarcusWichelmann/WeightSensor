using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightSensorViewer
{
    public partial class MainWindow : Form
    {
        private ArduinoManager arduinoManager = new ArduinoManager();

        private delegate void DisplayWeightCallback(double weight);

        public MainWindow()
        {
            InitializeComponent();
            UpdatePortList();

            arduinoManager.WeightReceived += (e) => DisplayWeight(e.Weight);
        }

        private void UpdatePortList()
        {
            portSelectionComboBox.Items.Clear();

            string[] portNames = SerialPort.GetPortNames();
            foreach(string portName in portNames)
                portSelectionComboBox.Items.Add(portName);

            if(portNames.Length > 0)
                portSelectionComboBox.SelectedIndex = 0;

            portSelectionComboBox.Enabled = (portNames.Length > 0);
        }

        private void DisplayWeight(double weight)
        {
            if(InvokeRequired)
                Invoke(new DisplayWeightCallback(DisplayWeight), weight);
            else
                valueLabel.Text = string.Format($"{weight:N2} g");
        }

        private void portSelectionScanButton_Click(object sender, EventArgs e)
        {
            UpdatePortList();
        }

        private void portSelectionConnectButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(portSelectionComboBox.Text))
                return;

            try
            {
                string portName = portSelectionComboBox.SelectedItem.ToString();
                arduinoManager.Connect(portName);
                statusLabel.Text = $"Verbunden mit {portName}";
            }
            catch(Exception ex)
            {
                statusLabel.Text = ex.Message.Replace(Environment.NewLine, " "); ;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            arduinoManager.Disconnect();
        }
    }
}

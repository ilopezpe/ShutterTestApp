using ShutterTester.devices;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace ShutterTester
{
    /// <summary>
    /// This program sends serial commands to the Shutter Controller (Numato 3.3 V GPIO).
    /// </summary>
    public partial class ShutterTest : Form
    {
        private readonly BeamFlags beamflags = new BeamFlags();

        #region Initialize Window
        public ShutterTest()
        {
            InitializeComponent();
            getPorts();            
            delaynumberBox.Text = BeamFlags.DefaultDelay.ToString();
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
        }

        private void getPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBoxPorts.Items.Add(port);
            }
        }
        #endregion

        private void PortButton_Click(object sender, EventArgs e)
        {              
            if ((serialPort1.IsOpen == false) && (comboBoxPorts.SelectedIndex != -1))
            {
                serialPort1 = new SerialPort()
                {
                    PortName = (string)comboBoxPorts.SelectedItem,
                    BaudRate = 9600,
                    DataBits = 8,
                    StopBits = StopBits.One,
                    Parity = Parity.None,
                    Handshake = Handshake.None // No flow control
                };
                
                beamflags.Delay = (int)delaynumberBox.Text; // Reset waiting time

                beamflags.CloseLaserAndProbe();
                try
                {
                    serialPort1.Open();
                    PortButton.Text = "Close Port";
                    PortButton.BackColor = SystemColors.ControlDark;

                    serialPort1.Write("gpio iodir" + BeamFlags.GpioOutputsCmd + "\r");
                    Thread.Sleep(100);
                    serialPort1.Write("gpio iomask" + BeamFlags.GpioMaskCmd + "\r");
                    Thread.Sleep(100);
                    serialPort1.Write(BeamFlags.CloseAllCmd); // close shutters!
                    Thread.Sleep(beamflags.Delay);
                    serialPort1.DiscardOutBuffer();

                    groupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                    groupBox4.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Could Not Open Port!");
                }
            }
            else
            { // if port is already open, then run a safe close procedure
                try
                {
                    PortButton.Text = "Open Port";
                    PortButton.BackColor = Color.Lime;

                    serialPort1.Write(BeamFlags.CloseAllCmd);
                    Thread.Sleep(beamflags.Delay);
                    serialPort1.DiscardOutBuffer();

                    serialPort1.Close();
                    serialPort1.Dispose();
                    delaynumberBox.Text = BeamFlags.DefaultDelay.ToString();

                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                    groupBox4.Enabled = false;
                }
                catch
                {
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                comboBoxPorts.Items.Clear();
                getPorts();
            }
        }

        private void DoToggleLaser()
        {
            if (beamflags.LaserState == ShutterPosition.Closed)
            {
                labelStatusLaser.Text = "Open";
                labelStatusLaser.BackColor = Color.Yellow;
                labelStatusLaser.Update();

                ButtonLaser.BackColor = SystemColors.ControlDark;

                serialPort1.Write(BeamFlags.OpenLaserCmd);
                Thread.Sleep(beamflags.Delay);
                serialPort1.DiscardOutBuffer();
                beamflags.OpenLaser();
            }
            else
            {
                labelStatusLaser.Text = "Closed";
                labelStatusLaser.BackColor = Color.Red;
                labelStatusLaser.Update();

                ButtonLaser.BackColor = SystemColors.Control;

                serialPort1.Write(BeamFlags.CloseLaserCmd);
                Thread.Sleep(beamflags.Delay);
                serialPort1.DiscardOutBuffer();
                beamflags.CloseLaser();
            }
        }

        private void DoToggleProbe()
        {

            if (beamflags.ProbeState == ShutterPosition.Closed)
            {
                labelStatusProbe.Text = "Open";
                labelStatusProbe.BackColor = Color.Yellow;
                labelStatusProbe.Update();

                ButtonProbe.BackColor = SystemColors.ControlDark;

                serialPort1.DiscardInBuffer();
                serialPort1.Write(BeamFlags.OpenProbeCmd);
                Thread.Sleep(beamflags.Delay);
                serialPort1.DiscardOutBuffer();
                beamflags.OpenProbe();
            }
            else
            {
                labelStatusProbe.Text = "Closed";
                labelStatusProbe.BackColor = Color.Red;
                labelStatusProbe.Update();

                ButtonProbe.BackColor = SystemColors.Control;

                serialPort1.Write(BeamFlags.CloseProbeCmd);
                Thread.Sleep(beamflags.Delay);
                serialPort1.DiscardOutBuffer();
                beamflags.CloseProbe();
            }
        }

        private void ButtonLaser_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {

                    DoToggleLaser();
                }
                catch
                {
                }
            }
        }

        private void ButtonProbe_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    DoToggleProbe();
                }
                catch
                {
                }
            }
        }

        private void ButtonOpenAll_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    labelStatusLaser.Text = "Open";
                    labelStatusLaser.BackColor = Color.Yellow;
                    labelStatusLaser.Update();

                    labelStatusProbe.Text = "Open";
                    labelStatusProbe.BackColor = Color.Yellow;
                    labelStatusProbe.Update();

                    ButtonLaser.BackColor = SystemColors.ControlDark;
                    ButtonProbe.BackColor = SystemColors.ControlDark;

                    serialPort1.Write(BeamFlags.OpenAllCmd);
                    Thread.Sleep(beamflags.Delay);
                    serialPort1.DiscardOutBuffer();

                    beamflags.OpenLaserAndProbe();
                }
                catch
                {
                }
            }
        }

        private void ButtonCloseAll_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen == false)
            {
                try
                {
                    labelStatusLaser.Text = "Closed";
                    labelStatusLaser.BackColor = Color.Red;
                    labelStatusLaser.Update();

                    labelStatusProbe.Text = "Closed";
                    labelStatusProbe.BackColor = Color.Red;
                    labelStatusProbe.Update();

                    ButtonLaser.BackColor = SystemColors.Control;
                    ButtonProbe.BackColor = SystemColors.Control;

                    serialPort1.Write(BeamFlags.CloseAllCmd);
                    Thread.Sleep(beamflags.Delay);
                    serialPort1.DiscardOutBuffer();

                    beamflags.CloseLaserAndProbe();
                }
                catch
                {
                }
            }
        }

        private void comboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetdelayButton_Click(object sender, EventArgs e)
        {
            beamflags.Delay = int.Parse(delaynumberBox.Text);
        }
    }
}

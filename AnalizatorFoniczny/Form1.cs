using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace AnalizatorFoniczny
{
    public partial class Form1 : Form
    {
        private byte[] bArray = new byte[20 * numberOfSamples + 4]; // frequencies (512 samples) and magnitudes (512 values) - each is a single precision float so 4 bytes
        private Single[] fArray = new float[2 * numberOfSamples + 1]; // float data array
        //private byte[] bBuffer = new byte[4];
        private byte[] bSterowanie = new byte[1];

        private static int counterOfRecBytes = 0;
        private static int numberOfSamples = 512;


        public Form1()
        {
            InitializeComponent();                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // UI settings
            //chart1.ChartAreas[0].AxisX.Minimum = 0;
            //schart1.ChartAreas[0].AxisX.Maximum = 30000;

            // Default transmission parameters for testing
            SerialP.PortName = "COM5";
            SerialP.BaudRate = 115200;
            SerialP.StopBits = StopBits.One;
            SerialP.DataBits = 8;
            SerialP.Parity = Parity.None;
            SerialP.Handshake = Handshake.None;
            SerialP.ReadBufferSize = 16 * numberOfSamples + 4;
            
        }

        /// <summary>
        /// SerialPort Data Recieved Event Handler
        /// </summary>
        
        private void SerialP_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;

            
            int previouse = counterOfRecBytes;

            counterOfRecBytes += sp.BytesToRead;

            sp.Read(bArray, previouse, (counterOfRecBytes - previouse));

            if (counterOfRecBytes >= 8 * numberOfSamples + 4)
            {
                decimal[] decArray = new decimal[2 * numberOfSamples + 1];
                for (uint i = 0; i < 2 * numberOfSamples + 1; i++)
                {
                    fArray[i] = Math.Abs(ByteToFloat(bArray, i));
                    //decArray[i] = (Decimal)fArray[i];
                    if (fArray[i] > (Single)decimal.MaxValue || fArray[i] < (Single)decimal.MinValue) fArray[i] = 0;

                    //if (Single.IsNaN(fArray[i]) || Single.IsInfinity(fArray[i])) fArray[i] = 0;
                }

                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(ChartData));
                }
                else
                {
                    ChartData();
                }

                // Set counterOfRecBytes to recieve new data
                counterOfRecBytes = 0;
            }



        }

        ///// <summary>
        ///// Changes my recieved bArray to single precision floats
        ///// </summary>
        private float ByteToFloat(byte[] input, UInt32 i)
        {
            byte[] array = new[] { input[4 * i], input[4 * i + 1], input[4 * i + 2], input[4 * i + 3] };
            return BitConverter.ToSingle(array, 0);
        }

        /// <summary>
        /// Setting chart data
        /// </summary>
        private void ChartData()
        {

            chart1.Series["Widmo"].Points.Clear();

            for(int i = 1; i < numberOfSamples + 1; i++)
            {
                chart1.Series["Widmo"].Points.AddXY(fArray[i], fArray[i + numberOfSamples]);
            }
                       
        }

        private void bt_do_Click(object sender, EventArgs e)
        {
            if (bt_do.Text == "Start")
            {
                bSterowanie[0] = 10;
                bt_do.Text = "Stop";
                pb_connect.Value = 100;
                Thread.SpinWait(200);
                SerialP.Open();
                SerialP.Write(bSterowanie, 0, 1); //send 'a' character to start                
            }
            else
            {
                bSterowanie[0] = 150;
                bt_do.Text = "Start";
                SerialP.Write(bSterowanie, 0, 1); //send 'z' character to stop
                pb_connect.Value = 0;
                Thread.SpinWait(100);
                SerialP.Close();

            }
        }
    }

}
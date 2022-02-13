using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQ_Sim_App_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSampling_Click(object sender, EventArgs e)
        {
            // When pressing the Sampling button it shows the Sampling Time and the Sensor Value
            txtSampling.Text = "2,3 s";
            int counter, maxSid = 4;
            string sTxt = "";
            // Create an array of 4 sensor objects
            Sensor[] sObj = new Sensor[maxSid];
            for (counter = 0; counter < maxSid; counter++)
            {
                sObj[counter] = new Sensor(counter);
            }
            // Get the object values as a string
            for (counter = 0; counter < maxSid; counter++)
            {
                sTxt = sObj[counter].GetValue().ToString("F3");

            }
            // Shows sensor value in the Sensor Value textbox
            txtSenVal.Text = sTxt;
        }

        private void txtSampling_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogging_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogging_Click(object sender, EventArgs e)
        {
            // When pressing the Logging button it shows the Logging time and makes a CSV File while sensor values
            txtLogging.Text = "58 s";
            int counter, maxSid = 4;
            string sTxt = "";   
            // Create an array of 4 sensor objects
            Sensor[] sObj = new Sensor[maxSid];
            for (counter = 0; counter < maxSid; counter++)
            {
                sObj[counter] = new Sensor(counter);
            }
            // Get the object values as a string
            for (counter = 0; counter < maxSid; counter++)
            {
                sTxt = sObj[counter].GetValue().ToString("F3");
            }
            //Uses the Logger to write sensor values and date/time to a CSV File
            Logger(sTxt, "sensor.txt");             
        }


        public static void Logger(string Value, string filepath)
        {
            //Writes given string and the date and time to a CSV File
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
            {
                file.WriteLine($"{DateTime.Now} : {Value}");
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // Makes the messagebox about information when you press the Help button
            MessageBox.Show("Press 'Sampling' to show sensor values. Press 'Logging' to start logging sensor values in CSV file",
            "Help About Information", System.Windows.Forms.MessageBoxButtons.OK);
        }
    }
    /////////////////////////////////////////////////////////
    ///Gets an input id of a sensor and assigns it a value between -1 and 1
    ///then returns the sensor ID and the its value
    class Sensor
        {
            double dVal;
            int sId;
            Random rSensorValue;
            public Sensor(int id)
            {
                sId = id;
                rSensorValue = new Random(id);
                dVal = 0.0F;
            }
            public double GetValue()
            {
                dVal += rSensorValue.NextDouble();
                dVal = (dVal * 2) - 1;
                return dVal;
            }
            public int GetSensId()
            {
                return sId;
            }
        }
        /////////////////////////////////////////////////////////

}

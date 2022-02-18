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
        int samplingseconds = 3;
        int loggingseconds = 58;
        int counterLogg = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void CreateAIsignals()
        {
            int counter, maxSid = 3;
            string sValue;
            string newLine = Environment.NewLine;

            // Create an array of 3 sensor objects
            Sensor[] sObj = new Sensor[maxSid];
            for (counter = 0; counter < maxSid; counter++)
            {
                sObj[counter] = new Sensor(counter);
            }
            // Get the object values as a string
            for (counter = 0; counter < maxSid; counter++)
            {
                sValue = sObj[counter].GetValue().ToString("F3");          
                txtSenVal.Text = txtSenVal.Text + "Analog sensor " + counter + " : " + sValue + newLine;
            }
        }

        public void CreateDigitalSensor(int number)
        {
            // Gets input about number of digital sensors
            // Creates x random int values between -1 and 1 and converts it to string
            Random rnd = new Random();
            string newLine = Environment.NewLine;
            for (int counter = 0; counter < number; counter++)
            {
                int nums = rnd.Next(0, 3) - 1;
                txtSenVal.Text = txtSenVal.Text + "Digital sensor " + counter + " : " + nums.ToString() + newLine;
            }
        }

        private void btnSampling_Click(object sender, EventArgs e)
        {
            // When pressing the Sampling button the Sensor Values are shown and the timer starts if the timer is reset (3 sec)
            if (samplingseconds == 3)
            {

                tmrSampling.Start();        //Starts the sample timing
                CreateDigitalSensor(1);     //Calling method that gives 1 Digital Signal
                CreateAIsignals();          //Calling method that gives the Analog signals  
            }
            // If timer is not reset, you need to wait and text below is shown
            else
            {
                lblNoticeS.Text = "Wait for Next sampling time";
                lblNoticeS.Show();
            }
        }

        private void txtSampling_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogging_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogging_Click(object sender, EventArgs e)
        {

            if (loggingseconds == 58)
            {
                tmrLogging.Start();
                // counts number of uses of this button and prints it to CSV File
                counterLogg += 1;
                string numbs_writ = "Number of writings: " + counterLogg.ToString();
                Logger(numbs_writ, "sensor.txt");
                // When pressing the Logging button it shows the Logging time and makes a CSV File while sensor values
                int counter, maxSid = 3;
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
                    //Uses the Logger to write sensor values and date/time to a CSV File 
                    Logger(sTxt, "sensor.txt");
                }

                Random rnd = new Random();
                string newLine = Environment.NewLine;
                for (int i = 1; i <= 1; i++)
                {
                    int nums = rnd.Next(0, 3) - 1;
                    string digsig = nums.ToString() + newLine;
                    Logger(digsig, "sensor.txt");
                }
            }
            else
            {
                lblNoticeL.Text = "Wait for Next logging time";
                lblNoticeL.Show();
            }
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

        private void tmrSampling_Tick(object sender, EventArgs e)
        {
            txtSampling.Text = samplingseconds--.ToString();
            if (samplingseconds < 0)
            {
                tmrSampling.Stop();
                samplingseconds = 3;
                lblNoticeS.Hide();
            }
        }

        private void tmrLogging_Tick(object sender, EventArgs e)
        {
            txtLogging.Text = loggingseconds--.ToString();
            if (loggingseconds < 0)
            {
                tmrLogging.Stop();
                loggingseconds = 58;
                lblNoticeL.Hide();
            }
        }

        //Creates a random integer (whole number) between -1 and 1 for the Digital signal,
        //converts it to a string and puts it in the textbox Sensor Values

    }
    /////////////////////////////////////////////////////////
    ///Gets the number of sensor id and assigns it a value between -1 and 1
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
            public double GetValue()    // attribute that returns a random decimal value between -1 and 1
            {
                dVal = rSensorValue.NextDouble() * 2 - 1;
                return dVal;
            }
            public int GetSensId()      // attribute that returns sensor ID
            {
                return sId;
            }

        }
        /////////////////////////////////////////////////////////

}

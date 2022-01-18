using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet;
using MathNet.Numerics;

namespace PWM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        #region Define Variables
        static double freqSine = 50.0;
        static double freqCarrier = 33.0 * freqSine;
        static double sine2A;
        static double carrierA;

        static double simTimeCycles = 1.0;
        static double simTimeSeconds = simTimeCycles / freqSine;
        static int numSamples = 10000;
        static int samplesPerSecond = (int)(numSamples / simTimeSeconds);

        //  Triangle carrier period in seconds
        static double carrierPeriodSeconds = 1.0 / freqCarrier;

        //  Triangle carrier period in samples
        static int carrierPeriodSamples = (int)(carrierPeriodSeconds * samplesPerSecond);

        //  Plot parameters
        static int plotCyclesFund = 1;
        static double plotTime = plotCyclesFund / freqSine;
        //static int plotSamples = plotCyclesFund;
        #endregion

        #region Define Arrays
        double [] sine = new double[numSamples];
        double [] sine2 = new double[numSamples];
        double [] carrier = new double[numSamples];
        double [] t = new double[numSamples];
        double [] pwm = new double[numSamples];
        #endregion

        public void GeneratePWM()
        {
            #region Calculate Waveform Amplitudes from Trackbar Values
            sine2A = trackBar1.Value * 0.1;
            carrierA = 1 + trackBar2.Value * 0.1;
            #endregion

            #region Generate Waveforms with Mathnet
            sine = Generate.Sinusoidal(numSamples, samplesPerSecond, freqSine, 1.0);
            sine2 = Generate.Sinusoidal(numSamples, samplesPerSecond, 2 * freqSine, sine2A);
            carrier = Generate.Triangle(numSamples, carrierPeriodSamples / 2, carrierPeriodSamples / 2, -carrierA, carrierA);
            #endregion

            #region Prepare Chart
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = plotTime;
            chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "F4";
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.LightBlue;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.LightBlue;
            #endregion

            #region Calculate PWM
            for (int i = 0; i < numSamples; i++)
            {
                sine[i] += sine2[i];
                t[i] = i / (double)samplesPerSecond;

                if (sine[i] > carrier[i])
                {
                    pwm[i] = 1.0;
                }
                else pwm[i] = 0;
            }
            #endregion


            PlotIt();

        }





        public void PlotIt()
        {
            chart1.Series["Sine"].Points.Clear();
            chart1.Series["Carrier"].Points.Clear();
            chart1.Series["PWM"].Points.Clear();

            for (int i = 0; i < numSamples; i++)
            {
                if (checkBox1.Checked == true)
                {
                    chart1.Series["Sine"].Points.AddXY(t[i], sine[i]);
                }

                if (checkBox2.Checked == true)
                {
                    chart1.Series["Carrier"].Points.AddXY(t[i], carrier[i]);
                }

                if (checkBox3.Checked == true)
                {
                    chart1.Series["PWM"].Points.AddXY(t[i], pwm[i]);
                }

            }
        }


        #region Event Handlers

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GeneratePWM();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            GeneratePWM();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            GeneratePWM();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PlotIt();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            PlotIt();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            PlotIt();
        }


        #endregion


    }
}

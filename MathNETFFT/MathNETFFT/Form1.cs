using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MathNet.Numerics;

using MathNet.Numerics.IntegralTransforms;
using System.Numerics;

using System.Windows.Forms.DataVisualization.Charting;


namespace MathNETFFT
{
    public partial class Form1 : Form
    {
        static int numSamples = 1000;
        static int sampleRate = 2000;
        static int magSecond;
        static int magThird;
        static double PHSecond;
        static double PHThird;

        Complex[] samples = new Complex[numSamples];


        public Form1()
        {
            InitializeComponent();
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            PlotWaveform(0, 0, 0, 0);
        }

        private void btnFFT_Click(object sender, EventArgs e)
        {
            PlotFFT();
        }


        public void PlotWaveform(int secondHarm, int thirdHarm, double secondPH, double thirdPH)
        {
            chart1.Series["Waveform"].Points.Clear();
            chart1.Series["Second Harmonic"].Points.Clear();
            chart1.Series["Third Harmonic"].Points.Clear();

            double[] fundamental = Generate.Sinusoidal(numSamples, sampleRate, 50, 10.0);
            

            double[] second = Generate.Sinusoidal(numSamples, sampleRate, 100, secondHarm, 0.0, secondPH);
            double[] third = Generate.Sinusoidal(numSamples, sampleRate, 150, thirdHarm, 0.0, thirdPH);

            for (int i = 0; i < numSamples; i++)
            {
                samples[i] = new Complex(fundamental[i] + second[i] + third[i], 0);
            }

            for (int i = 0; i < samples.Length / 5; i++)
            {
                double time = ((i + 1.0) / numSamples) / 2;

                chart1.Series["Waveform"].LegendText = "Waveform";
                chart1.Series["Waveform"].ChartType = SeriesChartType.Line;

                chart1.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 14.0f);
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Seconds";

                if (checkbox1.Checked)
                {
                    chart1.Series["Second Harmonic"].Points.AddXY
                    (time, second[i]);
                }

                if (checkbox2.Checked)
                {
                    chart1.Series["Third Harmonic"].Points.AddXY
                    (time, third[i]);
                }

                chart1.Series["Waveform"].Points.AddXY
                    (time, samples[i].Real);


            }

        }

        public void PlotFFT()
        {
            chart2.Series["Frequency"].Points.Clear();

            //  "Forward Fourier converts time -> frequency
            Fourier.Forward(samples, FourierOptions.NoScaling);

            for (int i = 1; i < samples.Length / 10; i++)
            {
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Hz";
                chart2.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 14.0f);
                chart2.ChartAreas["ChartArea1"].AxisX.MinorTickMark.Enabled = true;

                // Get the magnitude of each FFT sample:
                //  = abs[sqrt{r^2 + i^2)}]

                double mag = (2.0 / numSamples) * (Math.Abs(Math.Sqrt(Math.Pow(samples[i].Real, 2) +
                    Math.Pow(samples[i].Imaginary, 2))));

                //	Determine how many Hz represented by each sample
                double hzPerSample = sampleRate / numSamples;

                chart2.Series["Frequency"].Points.AddXY
                    (hzPerSample * i, mag);
            }
        }


        //  Event handlers


        private void trkThird_Scroll(object sender, EventArgs e)
        {
            //	Plot resultant waveform, then
            //	plot FFT


            trkPHThird.Enabled = true;
            magThird = trkThird.Value;
            lblMagThird.Text = magThird.ToString("F0");
            PlotWaveform(magSecond, magThird, PHSecond, PHThird);
            PlotFFT();
        }


        private void trkSecond_Scroll(object sender, EventArgs e)
        {
            trkPHSecond.Enabled = true;
            magSecond = trkSecond.Value;
            lblMagSecond.Text = magSecond.ToString("F0");
            PlotWaveform(magSecond, magThird, PHSecond, PHThird);
            PlotFFT();
        }


        private void trkPHSecond_Scroll(object sender, EventArgs e)
        {
            //	Value goes from 0 to 10, corresponding to 0 to 360 degrees, or 2*PI radians
            //	First convert value to radians, where 10 = 360 degrees or 2PI radians
            PHSecond = 2.0 * Math.PI * (trkPHSecond.Value / (double)trkPHSecond.Maximum);
            double angle = PHSecond * 360.0 / (2 * Math.PI);
            lblPHSecond.Text = angle.ToString("F1");
            PlotWaveform(magSecond, magThird, PHSecond, PHThird);
            PlotFFT();
        }

        private void trkPHThird_Scroll(object sender, EventArgs e)
        {
            PHThird = 2.0 * Math.PI * (trkPHThird.Value / (double)trkPHThird.Maximum);
            double angle = PHThird * 360.0 / (2 * Math.PI);
            lblPHThird.Text = angle.ToString("F1");
            PlotWaveform(magSecond, magThird, PHSecond, PHThird);
            PlotFFT();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}

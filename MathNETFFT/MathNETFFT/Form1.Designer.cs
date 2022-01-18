namespace MathNETFFT
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnFFT = new System.Windows.Forms.Button();
            this.checkbox1 = new System.Windows.Forms.CheckBox();
            this.checkbox2 = new System.Windows.Forms.CheckBox();
            this.lblMagSecond = new System.Windows.Forms.Label();
            this.lblMagThird = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trkSecond = new System.Windows.Forms.TrackBar();
            this.trkThird = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPHSecond = new System.Windows.Forms.Label();
            this.lblPHThird = new System.Windows.Forms.Label();
            this.trkPHSecond = new System.Windows.Forms.TrackBar();
            this.trkPHThird = new System.Windows.Forms.TrackBar();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPHSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPHThird)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Waveform";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Second Harmonic";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Third Harmonic";
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(788, 318);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(12, 347);
            this.chart2.Name = "chart2";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Frequency";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Angle";
            this.chart2.Series.Add(series9);
            this.chart2.Series.Add(series10);
            this.chart2.Size = new System.Drawing.Size(788, 324);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.Location = new System.Drawing.Point(918, 16);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 27);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnFFT
            // 
            this.btnFFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFFT.Location = new System.Drawing.Point(920, 523);
            this.btnFFT.Name = "btnFFT";
            this.btnFFT.Size = new System.Drawing.Size(75, 27);
            this.btnFFT.TabIndex = 3;
            this.btnFFT.Text = "FFT";
            this.btnFFT.UseVisualStyleBackColor = true;
            this.btnFFT.Click += new System.EventHandler(this.btnFFT_Click);
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSize = true;
            this.checkbox1.Location = new System.Drawing.Point(851, 66);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(15, 14);
            this.checkbox1.TabIndex = 4;
            this.checkbox1.UseVisualStyleBackColor = true;
            // 
            // checkbox2
            // 
            this.checkbox2.AutoSize = true;
            this.checkbox2.Location = new System.Drawing.Point(961, 66);
            this.checkbox2.Name = "checkbox2";
            this.checkbox2.Size = new System.Drawing.Size(15, 14);
            this.checkbox2.TabIndex = 5;
            this.checkbox2.UseVisualStyleBackColor = true;
            // 
            // lblMagSecond
            // 
            this.lblMagSecond.AutoSize = true;
            this.lblMagSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMagSecond.Location = new System.Drawing.Point(848, 108);
            this.lblMagSecond.Name = "lblMagSecond";
            this.lblMagSecond.Size = new System.Drawing.Size(37, 15);
            this.lblMagSecond.TabIndex = 6;
            this.lblMagSecond.Text = "label1";
            // 
            // lblMagThird
            // 
            this.lblMagThird.AutoSize = true;
            this.lblMagThird.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMagThird.Location = new System.Drawing.Point(958, 108);
            this.lblMagThird.Name = "lblMagThird";
            this.lblMagThird.Size = new System.Drawing.Size(37, 15);
            this.lblMagThird.TabIndex = 7;
            this.lblMagThird.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1049, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Magnitude";
            // 
            // trkSecond
            // 
            this.trkSecond.Location = new System.Drawing.Point(848, 147);
            this.trkSecond.Maximum = 30;
            this.trkSecond.Name = "trkSecond";
            this.trkSecond.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkSecond.Size = new System.Drawing.Size(45, 104);
            this.trkSecond.TabIndex = 9;
            this.trkSecond.Scroll += new System.EventHandler(this.trkSecond_Scroll);
            // 
            // trkThird
            // 
            this.trkThird.Location = new System.Drawing.Point(948, 147);
            this.trkThird.Maximum = 30;
            this.trkThird.Name = "trkThird";
            this.trkThird.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkThird.Size = new System.Drawing.Size(45, 104);
            this.trkThird.TabIndex = 10;
            this.trkThird.Scroll += new System.EventHandler(this.trkThird_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(845, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "120Hz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(945, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "180Hz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1049, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Phase (deegreed)";
            // 
            // lblPHSecond
            // 
            this.lblPHSecond.AutoSize = true;
            this.lblPHSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPHSecond.Location = new System.Drawing.Point(848, 317);
            this.lblPHSecond.Name = "lblPHSecond";
            this.lblPHSecond.Size = new System.Drawing.Size(37, 15);
            this.lblPHSecond.TabIndex = 14;
            this.lblPHSecond.Text = "label7";
            // 
            // lblPHThird
            // 
            this.lblPHThird.AutoSize = true;
            this.lblPHThird.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPHThird.Location = new System.Drawing.Point(948, 317);
            this.lblPHThird.Name = "lblPHThird";
            this.lblPHThird.Size = new System.Drawing.Size(37, 15);
            this.lblPHThird.TabIndex = 15;
            this.lblPHThird.Text = "label8";
            // 
            // trkPHSecond
            // 
            this.trkPHSecond.Location = new System.Drawing.Point(851, 373);
            this.trkPHSecond.Name = "trkPHSecond";
            this.trkPHSecond.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkPHSecond.Size = new System.Drawing.Size(45, 104);
            this.trkPHSecond.TabIndex = 16;
            this.trkPHSecond.Scroll += new System.EventHandler(this.trkPHSecond_Scroll);
            // 
            // trkPHThird
            // 
            this.trkPHThird.Location = new System.Drawing.Point(938, 373);
            this.trkPHThird.Name = "trkPHThird";
            this.trkPHThird.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkPHThird.Size = new System.Drawing.Size(45, 104);
            this.trkPHThird.TabIndex = 17;
            this.trkPHThird.Scroll += new System.EventHandler(this.trkPHThird_Scroll);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(1184, 523);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 683);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.trkPHThird);
            this.Controls.Add(this.trkPHSecond);
            this.Controls.Add(this.lblPHThird);
            this.Controls.Add(this.lblPHSecond);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trkThird);
            this.Controls.Add(this.trkSecond);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMagThird);
            this.Controls.Add(this.lblMagSecond);
            this.Controls.Add(this.checkbox2);
            this.Controls.Add(this.checkbox1);
            this.Controls.Add(this.btnFFT);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPHSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPHThird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnFFT;
        private System.Windows.Forms.CheckBox checkbox1;
        private System.Windows.Forms.CheckBox checkbox2;
        private System.Windows.Forms.Label lblMagSecond;
        private System.Windows.Forms.Label lblMagThird;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trkSecond;
        private System.Windows.Forms.TrackBar trkThird;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPHSecond;
        private System.Windows.Forms.Label lblPHThird;
        private System.Windows.Forms.TrackBar trkPHSecond;
        private System.Windows.Forms.TrackBar trkPHThird;
        private System.Windows.Forms.Button btnExit;
    }
}


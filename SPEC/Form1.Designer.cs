namespace SPEC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SIGNAL_CHART = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.A1 = new System.Windows.Forms.TextBox();
            this.A2 = new System.Windows.Forms.TextBox();
            this.F1 = new System.Windows.Forms.TextBox();
            this.F2 = new System.Windows.Forms.TextBox();
            this.P1 = new System.Windows.Forms.TextBox();
            this.P2 = new System.Windows.Forms.TextBox();
            this.ARR = new System.Windows.Forms.TextBox();
            this.Graph = new System.Windows.Forms.Button();
            this.NOISE = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CMESH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SHAG_SHUM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ZAVICIMOCT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SRED = new System.Windows.Forms.TextBox();
            this.Усреднение = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SIGNAL_CHART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // SIGNAL_CHART
            // 
            chartArea1.AxisX.Interval = 32D;
            chartArea1.Name = "ChartArea1";
            this.SIGNAL_CHART.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.SIGNAL_CHART.Legends.Add(legend1);
            this.SIGNAL_CHART.Location = new System.Drawing.Point(12, 30);
            this.SIGNAL_CHART.Name = "SIGNAL_CHART";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.SIGNAL_CHART.Series.Add(series1);
            this.SIGNAL_CHART.Size = new System.Drawing.Size(517, 261);
            this.SIGNAL_CHART.TabIndex = 0;
            this.SIGNAL_CHART.Text = "chart1";
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.A1.Location = new System.Drawing.Point(99, 36);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(53, 21);
            this.A1.TabIndex = 1;
            this.A1.Text = "5";
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.A2.Location = new System.Drawing.Point(158, 36);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(54, 21);
            this.A2.TabIndex = 2;
            this.A2.Text = "6";
            // 
            // F1
            // 
            this.F1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.F1.Location = new System.Drawing.Point(99, 70);
            this.F1.Name = "F1";
            this.F1.Size = new System.Drawing.Size(53, 21);
            this.F1.TabIndex = 3;
            this.F1.Text = "0,35";
            // 
            // F2
            // 
            this.F2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.F2.Location = new System.Drawing.Point(158, 70);
            this.F2.Name = "F2";
            this.F2.Size = new System.Drawing.Size(54, 21);
            this.F2.TabIndex = 4;
            this.F2.Text = "0,15";
            // 
            // P1
            // 
            this.P1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.P1.Location = new System.Drawing.Point(99, 104);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(53, 21);
            this.P1.TabIndex = 5;
            this.P1.Text = "0,1";
            // 
            // P2
            // 
            this.P2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.P2.Location = new System.Drawing.Point(158, 104);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(54, 21);
            this.P2.TabIndex = 6;
            this.P2.Text = "0,2";
            // 
            // ARR
            // 
            this.ARR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ARR.Location = new System.Drawing.Point(131, 36);
            this.ARR.Name = "ARR";
            this.ARR.Size = new System.Drawing.Size(73, 21);
            this.ARR.TabIndex = 7;
            this.ARR.Text = "256";
            // 
            // Graph
            // 
            this.Graph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Graph.Location = new System.Drawing.Point(635, 182);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(167, 44);
            this.Graph.TabIndex = 8;
            this.Graph.Text = "Сигнал и Спектр";
            this.Graph.UseVisualStyleBackColor = true;
            this.Graph.Click += new System.EventHandler(this.Graph_Click);
            // 
            // NOISE
            // 
            this.NOISE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.NOISE.Location = new System.Drawing.Point(131, 70);
            this.NOISE.Name = "NOISE";
            this.NOISE.Size = new System.Drawing.Size(73, 21);
            this.NOISE.TabIndex = 9;
            this.NOISE.Text = "10";
            // 
            // chart1
            // 
            chartArea2.AxisX.Interval = 0.05D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 322);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(517, 275);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // CMESH
            // 
            this.CMESH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CMESH.Location = new System.Drawing.Point(131, 104);
            this.CMESH.Name = "CMESH";
            this.CMESH.Size = new System.Drawing.Size(73, 21);
            this.CMESH.TabIndex = 11;
            this.CMESH.Text = "11";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.A1);
            this.groupBox1.Controls.Add(this.A2);
            this.groupBox1.Controls.Add(this.F1);
            this.groupBox1.Controls.Add(this.F2);
            this.groupBox1.Controls.Add(this.P1);
            this.groupBox1.Controls.Add(this.P2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(560, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 153);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры сигнала";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(11, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Фаза:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(11, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Частота:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Амплитуда:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Смещение АКП:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Кол-во отсчетов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(7, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "% Энергии шума";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CMESH);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NOISE);
            this.groupBox2.Controls.Add(this.ARR);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(819, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 152);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дополнительные параметры:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label7.Location = new System.Drawing.Point(184, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "График сигнала";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label8.Location = new System.Drawing.Point(184, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "График спектра";
            // 
            // chart2
            // 
            chartArea3.AxisX.Maximum = 100D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(560, 323);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(500, 273);
            this.chart2.TabIndex = 20;
            this.chart2.Text = "chart2";
            // 
            // SHAG_SHUM
            // 
            this.SHAG_SHUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SHAG_SHUM.Location = new System.Drawing.Point(853, 237);
            this.SHAG_SHUM.Name = "SHAG_SHUM";
            this.SHAG_SHUM.Size = new System.Drawing.Size(69, 21);
            this.SHAG_SHUM.TabIndex = 21;
            this.SHAG_SHUM.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(680, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Шаг по % энергии шума:";
            // 
            // ZAVICIMOCT
            // 
            this.ZAVICIMOCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ZAVICIMOCT.Location = new System.Drawing.Point(829, 182);
            this.ZAVICIMOCT.Name = "ZAVICIMOCT";
            this.ZAVICIMOCT.Size = new System.Drawing.Size(167, 44);
            this.ZAVICIMOCT.TabIndex = 23;
            this.ZAVICIMOCT.Text = "График зависимости";
            this.ZAVICIMOCT.UseVisualStyleBackColor = true;
            this.ZAVICIMOCT.Click += new System.EventHandler(this.ZAVICIMOCT_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SRED
            // 
            this.SRED.Location = new System.Drawing.Point(853, 264);
            this.SRED.Name = "SRED";
            this.SRED.Size = new System.Drawing.Size(69, 20);
            this.SRED.TabIndex = 24;
            this.SRED.Text = "10";
            // 
            // Усреднение
            // 
            this.Усреднение.AutoSize = true;
            this.Усреднение.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Усреднение.Location = new System.Drawing.Point(722, 266);
            this.Усреднение.Name = "Усреднение";
            this.Усреднение.Size = new System.Drawing.Size(77, 15);
            this.Усреднение.TabIndex = 25;
            this.Усреднение.Text = "Усреднение";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1008, 583);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "%Шума";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(545, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Оценка разрешения";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(509, 583);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "f";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "S(f)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label14.Location = new System.Drawing.Point(656, 302);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(340, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "Зависимость разрешающей способности от шума";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 611);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Усреднение);
            this.Controls.Add(this.SRED);
            this.Controls.Add(this.ZAVICIMOCT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SHAG_SHUM);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.SIGNAL_CHART);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Исследование зависимости разрешающей способности спектральной оценки ";
            this.Load += new System.EventHandler(this.Graph_Click);
            ((System.ComponentModel.ISupportInitialize)(this.SIGNAL_CHART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SIGNAL_CHART;
        private System.Windows.Forms.TextBox A1;
        private System.Windows.Forms.TextBox A2;
        private System.Windows.Forms.TextBox F1;
        private System.Windows.Forms.TextBox F2;
        private System.Windows.Forms.TextBox P1;
        private System.Windows.Forms.TextBox P2;
        private System.Windows.Forms.TextBox ARR;
        private System.Windows.Forms.Button Graph;
        private System.Windows.Forms.TextBox NOISE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox CMESH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox SHAG_SHUM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ZAVICIMOCT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox SRED;
        private System.Windows.Forms.Label Усреднение;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}


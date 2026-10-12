namespace MonitorReader
{
    partial class FrmTrends
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "", "2025-05-19 16:51:50", "28.6", "65", "88" }, -1);
            panel1 = new Panel();
            chkAirflow = new CheckBox();
            chkHumidity = new CheckBox();
            chkTemperature = new CheckBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lvDatas = new ListView();
            col01 = new ColumnHeader();
            colTime = new ColumnHeader();
            colTemperature = new ColumnHeader();
            colHumidity = new ColumnHeader();
            colAirflow = new ColumnHeader();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(chkAirflow);
            panel1.Controls.Add(chkHumidity);
            panel1.Controls.Add(chkTemperature);
            panel1.Location = new Point(26, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1343, 45);
            panel1.TabIndex = 0;
            // 
            // chkAirflow
            // 
            chkAirflow.AutoSize = true;
            chkAirflow.ForeColor = Color.Turquoise;
            chkAirflow.Location = new Point(269, 10);
            chkAirflow.Name = "chkAirflow";
            chkAirflow.Size = new Size(61, 24);
            chkAirflow.TabIndex = 0;
            chkAirflow.Tag = "Airflow";
            chkAirflow.Text = "风速";
            chkAirflow.UseVisualStyleBackColor = true;
            chkAirflow.CheckedChanged += chkTrend_CheckedChanged;
            // 
            // chkHumidity
            // 
            chkHumidity.AutoSize = true;
            chkHumidity.ForeColor = Color.FromArgb(0, 192, 0);
            chkHumidity.Location = new Point(156, 10);
            chkHumidity.Name = "chkHumidity";
            chkHumidity.Size = new Size(61, 24);
            chkHumidity.TabIndex = 0;
            chkHumidity.Tag = "Humidity";
            chkHumidity.Text = "湿度";
            chkHumidity.UseVisualStyleBackColor = true;
            chkHumidity.CheckedChanged += chkTrend_CheckedChanged;
            // 
            // chkTemperature
            // 
            chkTemperature.AutoSize = true;
            chkTemperature.ForeColor = Color.FromArgb(255, 128, 0);
            chkTemperature.Location = new Point(40, 10);
            chkTemperature.Name = "chkTemperature";
            chkTemperature.Size = new Size(61, 24);
            chkTemperature.TabIndex = 0;
            chkTemperature.Tag = "Temperature";
            chkTemperature.Text = "温度";
            chkTemperature.UseVisualStyleBackColor = true;
            chkTemperature.CheckedChanged += chkTrend_CheckedChanged;
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chart1.BorderlineColor = Color.Silver;
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.AxisX.LabelStyle.ForeColor = Color.Gray;
            chartArea2.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea2.AxisX.LabelStyle.Interval = 0D;
            chartArea2.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea2.AxisX.LineColor = Color.LightGray;
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Interval = 5D;
            chartArea2.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea2.AxisX.Title = "时间";
            chartArea2.AxisX.TitleAlignment = StringAlignment.Far;
            chartArea2.AxisX.TitleFont = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chartArea2.AxisY.LabelStyle.ForeColor = Color.Gray;
            chartArea2.AxisY.LineColor = Color.LightGray;
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.AxisY.MajorGrid.Interval = 10D;
            chartArea2.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.MajorGrid.LineWidth = 2;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.Title = "实时值";
            chartArea2.AxisY.TitleAlignment = StringAlignment.Far;
            chartArea2.AxisY.TitleFont = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chartArea2.BorderColor = Color.Silver;
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 90F;
            chartArea2.InnerPlotPosition.Width = 90F;
            chartArea2.InnerPlotPosition.X = 5F;
            chartArea2.InnerPlotPosition.Y = 4F;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 88F;
            chartArea2.Position.Width = 88F;
            chartArea2.Position.X = 3F;
            chartArea2.Position.Y = 3F;
            chart1.ChartAreas.Add(chartArea2);
            legend2.ForeColor = Color.FromArgb(64, 64, 64);
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 30F;
            legend2.Position.Width = 10F;
            legend2.Position.X = 88F;
            legend2.Position.Y = 3F;
            legend2.Title = "车间环境实时数据";
            legend2.TitleBackColor = Color.White;
            legend2.TitleFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            legend2.TitleForeColor = Color.FromArgb(0, 192, 192);
            legend2.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickGradientLine;
            legend2.TitleSeparatorColor = Color.FromArgb(0, 192, 192);
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(26, 96);
            chart1.Name = "chart1";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = Color.FromArgb(255, 128, 0);
            series4.Legend = "Legend1";
            series4.MarkerColor = Color.FromArgb(255, 128, 0);
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Series1";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = Color.Green;
            series5.Legend = "Legend1";
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "Series2";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = Color.Turquoise;
            series6.Legend = "Legend1";
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series6.Name = "Series3";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart1.Series.Add(series4);
            chart1.Series.Add(series5);
            chart1.Series.Add(series6);
            chart1.Size = new Size(1343, 321);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            // 
            // lvDatas
            // 
            lvDatas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvDatas.BorderStyle = BorderStyle.FixedSingle;
            lvDatas.Columns.AddRange(new ColumnHeader[] { col01, colTime, colTemperature, colHumidity, colAirflow });
            lvDatas.Items.AddRange(new ListViewItem[] { listViewItem2 });
            lvDatas.Location = new Point(26, 423);
            lvDatas.Name = "lvDatas";
            lvDatas.Size = new Size(1343, 305);
            lvDatas.TabIndex = 2;
            lvDatas.UseCompatibleStateImageBehavior = false;
            lvDatas.View = View.Details;
            // 
            // col01
            // 
            col01.Width = 0;
            // 
            // colTime
            // 
            colTime.Text = "采集时间";
            colTime.Width = 200;
            // 
            // colTemperature
            // 
            colTemperature.Text = "当前温度(℃)";
            colTemperature.Width = 200;
            // 
            // colHumidity
            // 
            colHumidity.Text = "当前湿度(%RH)";
            colHumidity.Width = 200;
            // 
            // colAirflow
            // 
            colAirflow.Text = "当前风速(m/s)";
            colAirflow.Width = 200;
            // 
            // FrmTrends
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1396, 749);
            Controls.Add(lvDatas);
            Controls.Add(chart1);
            Controls.Add(panel1);
            Name = "FrmTrends";
            ShowIcon = false;
            Text = "实时趋势";
            Load += FrmTrends_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox chkAirflow;
        private CheckBox chkHumidity;
        private CheckBox chkTemperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ListView lvDatas;
        private ColumnHeader col01;
        private ColumnHeader colTime;
        private ColumnHeader colTemperature;
        private ColumnHeader colHumidity;
        private ColumnHeader colAirflow;
    }
}
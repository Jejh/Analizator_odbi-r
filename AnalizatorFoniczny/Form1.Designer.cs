namespace AnalizatorFoniczny
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cb_Ports = new System.Windows.Forms.ComboBox();
            this.lb_Port = new System.Windows.Forms.Label();
            this.lb_BaudRate = new System.Windows.Forms.Label();
            this.pb_connect = new System.Windows.Forms.ProgressBar();
            this.SerialP = new System.IO.Ports.SerialPort(this.components);
            this.cb_BaudRate = new System.Windows.Forms.ComboBox();
            this.lb_Chart = new System.Windows.Forms.Label();
            this.bt_do = new System.Windows.Forms.Button();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Ports
            // 
            this.cb_Ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Ports.FormattingEnabled = true;
            this.cb_Ports.Location = new System.Drawing.Point(273, 14);
            this.cb_Ports.Name = "cb_Ports";
            this.cb_Ports.Size = new System.Drawing.Size(90, 21);
            this.cb_Ports.TabIndex = 2;
            // 
            // lb_Port
            // 
            this.lb_Port.AutoSize = true;
            this.lb_Port.Location = new System.Drawing.Point(229, 17);
            this.lb_Port.Name = "lb_Port";
            this.lb_Port.Size = new System.Drawing.Size(29, 13);
            this.lb_Port.TabIndex = 3;
            this.lb_Port.Text = "Port:";
            // 
            // lb_BaudRate
            // 
            this.lb_BaudRate.AutoSize = true;
            this.lb_BaudRate.Location = new System.Drawing.Point(408, 17);
            this.lb_BaudRate.Name = "lb_BaudRate";
            this.lb_BaudRate.Size = new System.Drawing.Size(61, 13);
            this.lb_BaudRate.TabIndex = 4;
            this.lb_BaudRate.Text = "Baud Rate:";
            // 
            // pb_connect
            // 
            this.pb_connect.Location = new System.Drawing.Point(86, 12);
            this.pb_connect.Name = "pb_connect";
            this.pb_connect.Size = new System.Drawing.Size(34, 23);
            this.pb_connect.TabIndex = 6;
            // 
            // SerialP
            // 
            this.SerialP.PortName = "COM3";
            this.SerialP.ReadBufferSize = 100000;
            this.SerialP.WriteBufferSize = 128;
            this.SerialP.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialP_DataReceived);
            // 
            // cb_BaudRate
            // 
            this.cb_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BaudRate.FormattingEnabled = true;
            this.cb_BaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200"});
            this.cb_BaudRate.Location = new System.Drawing.Point(484, 14);
            this.cb_BaudRate.Name = "cb_BaudRate";
            this.cb_BaudRate.Size = new System.Drawing.Size(90, 21);
            this.cb_BaudRate.TabIndex = 9;
            // 
            // lb_Chart
            // 
            this.lb_Chart.AutoSize = true;
            this.lb_Chart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Chart.Location = new System.Drawing.Point(716, 44);
            this.lb_Chart.Name = "lb_Chart";
            this.lb_Chart.Size = new System.Drawing.Size(276, 24);
            this.lb_Chart.TabIndex = 20;
            this.lb_Chart.Text = "Widmo próbkowanego sygnału";
            // 
            // bt_do
            // 
            this.bt_do.Location = new System.Drawing.Point(126, 12);
            this.bt_do.Name = "bt_do";
            this.bt_do.Size = new System.Drawing.Size(75, 23);
            this.bt_do.TabIndex = 21;
            this.bt_do.Text = "Start";
            this.bt_do.UseVisualStyleBackColor = true;
            this.bt_do.Click += new System.EventHandler(this.bt_do_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(45, 104);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Widmo";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1367, 422);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 848);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.bt_do);
            this.Controls.Add(this.lb_Chart);
            this.Controls.Add(this.cb_BaudRate);
            this.Controls.Add(this.pb_connect);
            this.Controls.Add(this.lb_BaudRate);
            this.Controls.Add(this.lb_Port);
            this.Controls.Add(this.cb_Ports);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
        //    ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_Ports;
        private System.Windows.Forms.Label lb_Port;
        private System.Windows.Forms.Label lb_BaudRate;
        private System.Windows.Forms.ProgressBar pb_connect;
        private System.IO.Ports.SerialPort SerialP;
        private System.Windows.Forms.ComboBox cb_BaudRate;
        private System.Windows.Forms.Label lb_Chart;
        private System.Windows.Forms.Button bt_do;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}


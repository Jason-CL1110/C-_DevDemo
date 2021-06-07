namespace OneNet_release_2._0
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DeviceID = new System.Windows.Forms.Label();
            this.lbl_ApiKey = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_AlertNum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Temperature = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_Humidity = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_SetOneNet = new System.Windows.Forms.Button();
            this.btn_ConnectOneNet = new System.Windows.Forms.Button();
            this.btn_AlertSetting = new System.Windows.Forms.Button();
            this.tbx_AlertNum = new System.Windows.Forms.TextBox();
            this.chart_temp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_humi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_AlertClear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_humi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ConnectOneNet);
            this.groupBox1.Controls.Add(this.btn_SetOneNet);
            this.groupBox1.Controls.Add(this.lbl_AlertNum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_ApiKey);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_DeviceID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "云平台设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chart_humi);
            this.groupBox2.Controls.Add(this.chart_temp);
            this.groupBox2.Controls.Add(this.lbl_Humidity);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lbl_Temperature);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 380);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " 温湿度信息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_AlertClear);
            this.groupBox3.Controls.Add(this.tbx_AlertNum);
            this.groupBox3.Controls.Add(this.btn_AlertSetting);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox3.Location = new System.Drawing.Point(538, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "设置触发阈值";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "设备ID：";
            // 
            // lbl_DeviceID
            // 
            this.lbl_DeviceID.AutoSize = true;
            this.lbl_DeviceID.Location = new System.Drawing.Point(84, 28);
            this.lbl_DeviceID.Name = "lbl_DeviceID";
            this.lbl_DeviceID.Size = new System.Drawing.Size(72, 16);
            this.lbl_DeviceID.TabIndex = 1;
            this.lbl_DeviceID.Text = "暂无信息";
            // 
            // lbl_ApiKey
            // 
            this.lbl_ApiKey.AutoSize = true;
            this.lbl_ApiKey.Location = new System.Drawing.Point(84, 66);
            this.lbl_ApiKey.Name = "lbl_ApiKey";
            this.lbl_ApiKey.Size = new System.Drawing.Size(72, 16);
            this.lbl_ApiKey.TabIndex = 3;
            this.lbl_ApiKey.Text = "暂无信息";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Api Key：";
            // 
            // lbl_AlertNum
            // 
            this.lbl_AlertNum.AutoSize = true;
            this.lbl_AlertNum.Location = new System.Drawing.Point(271, 28);
            this.lbl_AlertNum.Name = "lbl_AlertNum";
            this.lbl_AlertNum.Size = new System.Drawing.Size(72, 16);
            this.lbl_AlertNum.TabIndex = 5;
            this.lbl_AlertNum.Text = "暂无信息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "触发阈值：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "触发阈值：";
            // 
            // lbl_Temperature
            // 
            this.lbl_Temperature.AutoSize = true;
            this.lbl_Temperature.ForeColor = System.Drawing.Color.Red;
            this.lbl_Temperature.Location = new System.Drawing.Point(86, 33);
            this.lbl_Temperature.Name = "lbl_Temperature";
            this.lbl_Temperature.Size = new System.Drawing.Size(104, 16);
            this.lbl_Temperature.TabIndex = 9;
            this.lbl_Temperature.Text = "暂无温度信息";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "当前温度：";
            // 
            // lbl_Humidity
            // 
            this.lbl_Humidity.AutoSize = true;
            this.lbl_Humidity.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Humidity.Location = new System.Drawing.Point(532, 33);
            this.lbl_Humidity.Name = "lbl_Humidity";
            this.lbl_Humidity.Size = new System.Drawing.Size(104, 16);
            this.lbl_Humidity.TabIndex = 11;
            this.lbl_Humidity.Text = "暂无湿度信息";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(452, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "当前湿度：";
            // 
            // btn_SetOneNet
            // 
            this.btn_SetOneNet.Location = new System.Drawing.Point(413, 22);
            this.btn_SetOneNet.Name = "btn_SetOneNet";
            this.btn_SetOneNet.Size = new System.Drawing.Size(101, 29);
            this.btn_SetOneNet.TabIndex = 6;
            this.btn_SetOneNet.Text = "设置云平台";
            this.btn_SetOneNet.UseVisualStyleBackColor = true;
            this.btn_SetOneNet.Click += new System.EventHandler(this.btn_SetOneNet_Click);
            // 
            // btn_ConnectOneNet
            // 
            this.btn_ConnectOneNet.Location = new System.Drawing.Point(413, 59);
            this.btn_ConnectOneNet.Name = "btn_ConnectOneNet";
            this.btn_ConnectOneNet.Size = new System.Drawing.Size(101, 29);
            this.btn_ConnectOneNet.TabIndex = 7;
            this.btn_ConnectOneNet.Text = "连接云平台";
            this.btn_ConnectOneNet.UseVisualStyleBackColor = true;
            this.btn_ConnectOneNet.Click += new System.EventHandler(this.btn_ConnectOneNet_Click);
            // 
            // btn_AlertSetting
            // 
            this.btn_AlertSetting.Location = new System.Drawing.Point(170, 60);
            this.btn_AlertSetting.Name = "btn_AlertSetting";
            this.btn_AlertSetting.Size = new System.Drawing.Size(85, 29);
            this.btn_AlertSetting.TabIndex = 8;
            this.btn_AlertSetting.Text = "设置阈值";
            this.btn_AlertSetting.UseVisualStyleBackColor = true;
            this.btn_AlertSetting.Click += new System.EventHandler(this.btn_AlertSetting_Click);
            // 
            // tbx_AlertNum
            // 
            this.tbx_AlertNum.Location = new System.Drawing.Point(100, 21);
            this.tbx_AlertNum.Name = "tbx_AlertNum";
            this.tbx_AlertNum.Size = new System.Drawing.Size(244, 26);
            this.tbx_AlertNum.TabIndex = 9;
            // 
            // chart_temp
            // 
            chartArea8.Name = "ChartArea1";
            this.chart_temp.ChartAreas.Add(chartArea8);
            this.chart_temp.Location = new System.Drawing.Point(9, 66);
            this.chart_temp.Name = "chart_temp";
            this.chart_temp.Size = new System.Drawing.Size(426, 300);
            this.chart_temp.TabIndex = 12;
            this.chart_temp.Text = "chart1";
            // 
            // chart_humi
            // 
            chartArea7.Name = "ChartArea1";
            this.chart_humi.ChartAreas.Add(chartArea7);
            this.chart_humi.Location = new System.Drawing.Point(448, 66);
            this.chart_humi.Name = "chart_humi";
            this.chart_humi.Size = new System.Drawing.Size(428, 300);
            this.chart_humi.TabIndex = 13;
            this.chart_humi.Text = "chart2";
            // 
            // btn_AlertClear
            // 
            this.btn_AlertClear.Location = new System.Drawing.Point(261, 59);
            this.btn_AlertClear.Name = "btn_AlertClear";
            this.btn_AlertClear.Size = new System.Drawing.Size(83, 29);
            this.btn_AlertClear.TabIndex = 10;
            this.btn_AlertClear.Text = "清空阈值";
            this.btn_AlertClear.UseVisualStyleBackColor = true;
            this.btn_AlertClear.Click += new System.EventHandler(this.btn_AlertClear_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 509);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_humi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_ConnectOneNet;
        private System.Windows.Forms.Button btn_SetOneNet;
        private System.Windows.Forms.Label lbl_AlertNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_ApiKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_DeviceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_humi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_temp;
        private System.Windows.Forms.Label lbl_Humidity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_AlertNum;
        private System.Windows.Forms.Button btn_AlertSetting;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_AlertClear;
        private System.Windows.Forms.Label lbl_Temperature;
        private System.Windows.Forms.Timer timer1;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using RestSharp;
using System.Windows.Forms.DataVisualization.Charting;

namespace OneNet_release_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Temp_Chart();
            Humi_Chart();
        }
        /// <summary>
        /// 创建OneNet平台变量
        /// </summary>
        public string DeviceID = "";
        public string ApiKey = "";
        public double AlertNum;

        /// <summary>
        /// 创建全局判断变量
        /// </summary>
        public bool OneNetSetting = false;
        public bool AlertNumtSetting = false;

        /// <summary>
        /// 创建全局List变量
        /// </summary>
        public List<double>TempList = new List<double>();
        public List<double>HumiList = new List<double>();
        public List<string>Temp_Time_List = new List<string>();
        public List<string>Humi_Time_List = new List<string>();

        /// <summary>
        /// 开线程
        /// </summary>
        public Thread TempVaueGet;
        public Thread HumiVaueGet;


        /// <summary>
        /// One net平台信息配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SetOneNet_Click(object sender, EventArgs e)
        {
            Form2 m2 = new Form2();
            m2.ShowDialog();

            DeviceID = m2.DeviceID;
            ApiKey = m2.ApiKey;

            lbl_DeviceID.Text = DeviceID;
            lbl_ApiKey.Text = ApiKey;

            OneNetSetting = true;
        }



        /// <summary>
        /// OneNet数据获取的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ConnectOneNet_Click(object sender, EventArgs e)
        {
            if (OneNetSetting == true)
            {
                timer1.Enabled = true;

                TempVaueGet = new Thread(new ThreadStart(OneNetTemp));
                TempVaueGet.IsBackground = true;
                HumiVaueGet = new Thread(new ThreadStart(OneNetHumi));
                HumiVaueGet.IsBackground = true;
                TempVaueGet.Start();
                HumiVaueGet.Start();
            }
            else
            {
                MessageBox.Show("请先配置云平台连接信息！", "系统提示");
            }
        }

        /// <summary>
        /// 获取温度数据
        /// </summary>
        private void OneNetTemp()
        {
            var client = new RestClient("http://api.heclouds.com/devices/"+DeviceID+"/datastreams/temperature");
            var request = new RestRequest(Method.GET);
            request.AddHeader("api-key",ApiKey);
            request.AddHeader("Content-Type", "text/plain");

            while (true)
            {
                IRestResponse response = client.Execute(request);
                string Value = response.Content;
                string Data = "";

                MatchCollection ma_co = Regex.Matches(Value, @"""current_value"":(.*)""error""", RegexOptions.IgnoreCase);
                foreach (Match i in ma_co)
                {
                    Data = i.Value;
                }

                MatchCollection ma_num = Regex.Matches(Data, "[0-9.]+");
                foreach (Match e in ma_num)
                {
                    TempList.Add(Double.Parse(e.Value));
                    Temp_Time_List.Add(DateTime.Now.ToLongTimeString());
                    lbl_Temperature.Text = e.Value;

                    if (AlertNumtSetting == true )
                    {
                        if (Double.Parse(e.Value) > AlertNum)
                        {
                            Command("1");

                        }
                        else
                        {
                            Command("0");
                        }
                    }
                }
                
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// 获取湿度方法
        /// </summary>
        private void OneNetHumi()
        {
            var client = new RestClient("http://api.heclouds.com/devices/" + DeviceID + "/datastreams/humidity");
            var request = new RestRequest(Method.GET);
            request.AddHeader("api-key", ApiKey);
            request.AddHeader("Content-Type", "text/plain");

            while (true)
            {
                IRestResponse response = client.Execute(request);
                string Value = response.Content;
                string Data = "";

                MatchCollection ma_co = Regex.Matches(Value, @"""current_value"":(.*)""error""", RegexOptions.IgnoreCase);
                foreach (Match i in ma_co)
                {
                    Data = i.Value;
                }

                MatchCollection ma_num = Regex.Matches(Data, "[0-9.]+");
                foreach (Match e in ma_num)
                {
                    HumiList.Add(Double.Parse(e.Value));
                    Humi_Time_List.Add(DateTime.Now.ToLongTimeString());
                    lbl_Humidity.Text = e.Value;
                }
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// 蜂鸣器使能
        /// </summary>
        /// <param name="cmds"></param>
        private void Command(string cmds)
        {
            var client = new RestClient("http://api.heclouds.com/cmds?device_id=700219232&qos=1&timeout=3600");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("api-key", "VoHjD6R9TNYnFMiWi9Sntiax3bA=");
            request.AddHeader("Content-Type", "text/plain");
            request.AddParameter("text/plain", "Beep:" + cmds, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
        }


        /// <summary>
        /// 设置触发阈值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AlertSetting_Click(object sender, EventArgs e)
        {
            AlertNumtSetting = true;
            AlertNum = Double.Parse(tbx_AlertNum.Text);
            if (lbl_ApiKey.Text == "暂无信息" && lbl_DeviceID.Text == "暂无信息")
            {
                MessageBox.Show("当前无平添配置信息，触发阈值功能将不会启动，请添加后再重试！", "系统信息");
            }
            else
            {
                MessageBox.Show("设置成功！", "系统信息");
            }
        }


        /// <summary>
        /// 清空触发阈值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AlertClear_Click(object sender, EventArgs e)
        {
            AlertNumtSetting = false;
            tbx_AlertNum.Clear();
            MessageBox.Show("清除成功！", "系统信息");

        }


        /// <summary>
        /// 温度表
        /// </summary>
        private void Temp_Chart()
        {
            chart_temp.Series.Add("TempLine");
            chart_temp.Series["TempLine"].Color = Color.Red;
            chart_temp.Series["TempLine"].BorderWidth = 3;
            chart_temp.Series["TempLine"].ChartType = SeriesChartType.Line;

            chart_temp.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chart_temp.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart_temp.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chart_temp.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            chart_temp.ChartAreas[0].AxisY.Minimum = 0;
            chart_temp.ChartAreas[0].AxisY.Maximum = 100;
            chart_temp.ChartAreas[0].AxisY.Interval = 5;

            chart_temp.Series[0].XValueType = ChartValueType.Time;
            chart_temp.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            chart_temp.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
        }

        /// <summary>
        /// 创建温度图表
        /// </summary>
        private void Humi_Chart()
        {
            chart_humi.Series.Add("HumiLine");
            chart_humi.Series["HumiLine"].Color = Color.Blue;
            chart_humi.Series["HumiLine"].BorderWidth = 3;
            chart_humi.Series["HumiLine"].ChartType = SeriesChartType.Spline;

            chart_humi.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chart_humi.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart_humi.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chart_humi.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            chart_humi.ChartAreas[0].AxisY.Minimum = 0;
            chart_humi.ChartAreas[0].AxisY.Maximum = 100;
            chart_humi.ChartAreas[0].AxisY.Interval = 10;

            chart_humi.Series[0].XValueType = ChartValueType.Time;
            chart_humi.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            chart_humi.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
        }

        /// <summary>
        /// 图表数据方法
        /// </summary>
        private void Chart_Display()
        {
            try
            {
                chart_temp.Series[0].Points.DataBindXY(Temp_Time_List, TempList);
                chart_humi.Series[0].Points.DataBindXY(Humi_Time_List, HumiList);
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Chart_Display();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Chart_Display();
        }
    }
}

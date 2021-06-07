using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;

namespace OneNet_release_2._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 创建全局变量
        /// </summary>
        public string DeviceID = "";
        public string ApiKey = "";



        private void button1_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]+");
            Match ma_deviceid = reg.Match(tbx_DeviceID.Text);

            if (tbx_ApiKey.Text != "" && tbx_DeviceID.Text != "")
            {
                if (ma_deviceid.Success)
                {
                    if (tbx_DeviceID.Text != ConfigurationManager.AppSettings["DeviceID"] || tbx_ApiKey.Text != ConfigurationManager.AppSettings["ApiKey"])
                    {
                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config.AppSettings.Settings["DeviceID"].Value = tbx_DeviceID.Text;
                        config.AppSettings.Settings["ApiKey"].Value = tbx_ApiKey.Text;
                        config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection("appSettings");

                        DeviceID = tbx_DeviceID.Text;
                        ApiKey = tbx_ApiKey.Text;

                        MessageBox.Show("修改配置并保存成功！", "系统提示");
                        this.Close();
                    }
                    else
                    {
                        DeviceID = tbx_DeviceID.Text;
                        ApiKey = tbx_ApiKey.Text;

                        MessageBox.Show("信息保存成功！", "系统提示");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("信息保存失败！设备ID必须是纯数字！", "系统提示");
                }
            }
            else
            {
                MessageBox.Show("信息保存失败！设备ID和ApiKey不得为空！", "系统提示");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tbx_DeviceID.Text = ConfigurationManager.AppSettings["DeviceID"];
            tbx_ApiKey.Text = ConfigurationManager.AppSettings["ApiKey"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbx_DeviceID.Clear();
            tbx_ApiKey.Clear();

            DeviceID = "暂无信息";
            ApiKey = "暂无信息";

            MessageBox.Show("信息清空成功！","系统提示");
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.Management;

namespace Tool_Macro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private string GetHWID()
        {
            //            The following code will retrieve the CPU ID(processor id):
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_processor");
            mbsList = mbs.Get();
            string cpuid = "";
            foreach (ManagementObject mo in mbsList)
            {
                cpuid = mo["ProcessorID"].ToString();
            }

            //            The following code will generate hard-disk id:
            ManagementObject dsk = new ManagementObject(@"win32_logicaldisk.deviceid=""c:""");
            dsk.Get();
            string diskid = dsk["VolumeSerialNumber"].ToString();

            //            The following code will generate motherboard id:
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection moc = mos.Get();
            string motherboardid = "";
            foreach (ManagementObject mo in moc)
            {
                motherboardid = (string)mo["SerialNumber"];
            }

            return cpuid + diskid + motherboardid;
        }
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> GetHttpContentAsync(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            return content;
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            buttonLogin.Enabled = false;
            string hwid = GetHWID();
            //string hwid = "123456";
            string data = await GetHttpContentAsync($"https://cohuy98.io.vn/toolautocf/check_submit.php?username={textUsername.Text}&hwid={hwid}");
            if (data.Contains("Fail"))
            {
                MessageBox.Show("Chua nhap username");
            }
            else if (data.Contains("Het han"))
            {
                MessageBox.Show("Het han");
            }
            else if (data.Contains("Denied"))
            {
                MessageBox.Show("Denied");
            }
            else
            {
                Tool tool = new Tool(); 
                this.Hide();
                tool.Show();
            }
            buttonLogin.Enabled = true;
        }

        private void textUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

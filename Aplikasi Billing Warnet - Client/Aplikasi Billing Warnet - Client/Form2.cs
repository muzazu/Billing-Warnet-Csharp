using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using System.Runtime.InteropServices;

namespace Aplikasi_Billing_Warnet___Client
{
    public partial class Form2 : Form
    {
        private Stopwatch wkt = new Stopwatch();
        int lastHour = 0, total = 3000;
        Socket s;
        string n;
        public Form2(Socket sc,string nama)
        {
            InitializeComponent();
            //setup form
            Icon appIcon = Icon.ExtractAssociatedIcon(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Assets\\internet.ico");
            this.Icon = ((Icon)appIcon);
            this.Height = 20;
            this.Location = new Point(0, 0);

            //setup main
            wkt.Start();
            timer1.Start();
            lastHour = DateTime.Now.Hour;
            bayar.Text = total.ToString();
            timer2.Interval = 60 * 60 * 1000;//set interval 1 jam
            timer2.Start();
            s = sc; //pass variabel socket dari form1
            n = nama;
            dc.FlatAppearance.BorderSize = 0;
        }

        #region drag form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void dc_Click(object sender, EventArgs e)
        {
            s.Send(Encoding.Default.GetBytes("Disconnected," + n + ","+total));
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lastHour < DateTime.Now.Hour || (lastHour == 23 && DateTime.Now.Hour == 0))
            {
                lastHour = DateTime.Now.Hour;
                total = total + 3000;
                bayar.Text = total.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (wkt != null) {
                label1.Text = wkt.Elapsed.ToString(@"hh\:mm\:ss");
            }
        }
    }
}

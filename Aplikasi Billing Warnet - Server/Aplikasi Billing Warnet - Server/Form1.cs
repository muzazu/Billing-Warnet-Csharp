using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Koneksi;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Aplikasi_Billing_Warnet___Server
{
    public partial class Form1 : Form
    {
        //global variables
        Listener listener;
        Model db = new Model();
        string clientName;
        #region form style
        //Setup Color Variables
        Color dasar = ColorTranslator.FromHtml("#2c3e50");
        Color bg_txtbox = ColorTranslator.FromHtml("#455B71");
        Color bg_txtbox_focus = ColorTranslator.FromHtml("#63788C");
        Color bg_button = ColorTranslator.FromHtml("#34495e");

        //Form Styles Variables
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //membuat form bisa didrag / draggable
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && WindowState != FormWindowState.Maximized)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //membuat drop shadow pada form
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        void reset()
        {
            //setup left panel 
            panel_menu.Top = panel_heading.Height;
            panel_menu.Width = this.Width * 25 / 100;
            panel_menu.Height = this.Height;
            panel_menu.BackColor = dasar;
            //setup main panel
            panel_konten.Height = this.Height;
            panel_konten.Width = this.Width - panel_menu.Width;
            panel_konten.Location = new Point(panel_menu.Width, panel_heading.Height);
            //setup heading panel
            panel_heading.Top = 0;
            panel_heading.Width = this.Width;
            panel_heading.BackColor = bg_txtbox;
            //setup panel konten
            foreach (Control spanl in panel_konten.Controls)
            {
                if (spanl is Panel)
                {
                    if (spanl is Panel)
                    {
                        Panel pnl = (Panel)spanl;
                        pnl.Width = panel_konten.Width;
                        pnl.Height = panel_konten.Height;
                        pnl.AutoScroll = true;
                        pnl.Hide();
                    }
                }
            }
            //setup datagrid
            dataGridView1.Width = panel_konten.Width - 5;
            dataGridView2.Width = panel_konten.Width - 5;
            dataGridView1.Height = panel_konten.Height - 15;
            dataGridView2.Height = panel_konten.Height - 15;
        }

        void reset(string el)
        {
            #region button_reset
            if(el == "button")
            {
                //reset defaul bg to all buttons
                int i = this.Height * 10 / 100;
                foreach (Control button in panel_menu.Controls)
                {
                    if (button is Button)
                    {
                        Button btn = (Button)button;
                        btn.BackColor = bg_button;
                        btn.Width = panel_menu.Width;
                        btn.Height = 40;
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.TextAlign = ContentAlignment.MiddleLeft;
                        btn.Enabled = true;
                        btn.Padding = new Padding(25, 0, 0, 0);
                        if (btn.Name == "about")
                            btn.Location = new Point(0, this.Height - btn.Height - 35);
                        else
                            btn.Location = new Point(0, i);
                        i = i + button.Height + 2;
                    }
                }
            }
            #endregion

            #region button_Control
            if (el == "control")
            {
                //reset defaul bg to all buttons
                int i = this.Width - exit.Width;

                foreach (Control button in panel_heading.Controls)
                {
                    if (button is Button)
                    {
                        Button btn = (Button)button;
                        btn.Location = new Point(i, panel_heading.Height - button.Height + 4);
                        btn.FlatAppearance.BorderSize = 0;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.TextAlign = ContentAlignment.MiddleLeft;
                        i = i - button.Width;
                    }
                }
            }
            #endregion

            #region panel
            //setup panel konten
            foreach (Control spanl in panel_konten.Controls)
            {
                if (spanl is Panel)
                {
                    Panel pnl = (Panel)spanl;
                    pnl.Width = panel_konten.Width;
                    pnl.Height = panel_konten.Height;
                    pnl.Hide();
                }
            }
            #endregion
        }

        private void btnSelect(object sender, EventArgs e)
        {
            //run reset function
            reset("button");
            reset("panel");
            //set current selected button
            Button bt = (Button)sender;
            bt.Enabled = false;
            bt.BackColor = bg_txtbox;
            bt.ForeColor = Color.White;
            if (!string.IsNullOrEmpty(bt.Tag.ToString()))
            {
                Panel pn = Controls.Find(bt.Tag.ToString(), true).FirstOrDefault() as Panel;
                pn.Show();
                pn.Location = new Point(20, 40);
            }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
            Icon appIcon = Icon.ExtractAssociatedIcon(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Assets\\internet.ico");
            this.Icon = ((Icon)appIcon);
            this.Width = Screen.PrimaryScreen.WorkingArea.Width * 80 / 100;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height * 80 / 100;
            reset();
            reset("button");
            reset("control");
            reset("panel");
            foreach (Control button in panel_menu.Controls)
            {
                if (button is Button)
                {
                    Button btn = (Button)button;
                    btn.Click += new EventHandler(this.btnSelect);
                }
            }

            listener = new Listener(6620);
            listener.SocketAccepted += new Listener.SocketAcceptHandler(listener_SocketAccepted);
        }

        void listener_SocketAccepted(Socket e)
        {
            Client client = new Client(e);
            client.Received += new Client.ClientReceivedHandler(client_recived);
            client.Disconnected += new Client.ClientDisconnectedHandler(client_disconnected);

            Invoke((MethodInvoker)delegate
            {
                ListViewItem i = new ListViewItem();
                i.Text = client.EndPoint.ToString();
                i.SubItems.Add(client.ID);
                i.SubItems.Add("xx");
                i.SubItems.Add("xx");
                i.SubItems.Add("xx");
                i.SubItems.Add("xx");
                i.Tag = client;
                listView1.Items.Add(i);
            });
        }

        private void client_disconnected(Client sender)
        {
            Invoke((MethodInvoker)delegate
            {
                for(int i = 0; i< listView1.Items.Count; i++)
                {
                    Client client = listView1.Items[i].Tag as Client;

                    if(client.ID == sender.ID)
                    {
                        listView1.Items.RemoveAt(i);
                        break;
                    }
                }
            });
        }

        private void client_recived(Client sender, byte[] data)
        {
            Invoke((MethodInvoker)delegate
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    Client client = listView1.Items[i].Tag as Client;

                    if (client.ID == sender.ID)
                    {
                        string datax = Encoding.Default.GetString(data);
                        string[] words = datax.Split(',');
                        for(int x = 0; x < words.Length; x++)
                        {
                            if(x == 0)
                                listView1.Items[i].SubItems[5].Text = words[x];
                            else if (x == 1)
                                listView1.Items[i].SubItems[2].Text = words[x];
                            else if (x == 2)
                                listView1.Items[i].SubItems[3].Text = words[x];

                            if (words[x] == "Disconnected")
                                sound();
                        }
                        listView1.Items[i].SubItems[4].Text = DateTime.Now.ToString();
                        break;
                    }
                }
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.refresh(databaseDataSet.pengaturan, "pengaturan");
            // TODO: This line of code loads data into the 'databaseDataSet.pengaturan' table. You can move, or remove it, as needed.
            this.pengaturanTableAdapter.Fill(this.databaseDataSet.pengaturan);

            db.refresh(databaseDataSet.pc, "pc", dataGridView1);
            db.refresh(databaseDataSet.Users, "Users", dataGridView2);
            listener.start();
            button1.PerformClick();
        }

        private void max_Click(object sender, EventArgs e)
        {
            if (max.Text == "□")
            {
                this.WindowState = FormWindowState.Maximized;
                max.Text = "▫";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                max.Text = "□";
            }
            reset();
            reset("button");
            reset("control");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public static void sound()
        {
            string rootLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string fullPathToSound = Path.Combine(rootLocation, @"assets\suara.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(fullPathToSound);
            player.Play();
        }

    }
}

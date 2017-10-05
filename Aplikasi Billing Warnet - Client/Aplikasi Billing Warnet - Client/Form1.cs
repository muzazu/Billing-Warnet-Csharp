using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
namespace Aplikasi_Billing_Warnet___Client
{
    public partial class Form1 : Form
    {
        Socket sck;
        public Form1()
        {
            InitializeComponent();
            Icon appIcon = Icon.ExtractAssociatedIcon(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Assets\\internet.ico");
            this.Icon = ((Icon)appIcon);
            try
            {
                sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sck.Connect(Properties.Settings.Default.ip_address, 6620);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                //this.Close();
            }
            panel_loader.SendToBack();
            panel_loader.Hide();
            //Load += new EventHandler(load_data);
        }
        /*private void load_data(object sender, EventArgs e)
        {
            panel_loader.Width = this.Width;
            panel_loader.Height = this.Height;
            panel_loader.BackColor = dasar;
            panel_loader.ForeColor = Color.White;
            panel_loader.Location = new Point(0,0);

            pictureBox1.ImageLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Assets\\loading.gif";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.Location = new Point(30, 20);
            loading_label.Location = new Point(pictureBox1.Width + 50, pictureBox1.Height - 20);
            loading_label.ForeColor = bg_txtbox_focus;
            load_desc.Location = new Point(30, pictureBox1.Height + 20);

            panel_loader.BringToFront();
        }*/

        protected override void OnClosed(EventArgs e)
        {
            sck.Close();
            sck.Dispose();
            Close();
        }

        #region Form Design
        //Setup Color Variables
        Color dasar = ColorTranslator.FromHtml("#2c3e50");
        Color bg_txtbox = ColorTranslator.FromHtml("#455B71");
        Color bg_txtbox_focus = ColorTranslator.FromHtml("#63788C");
        Color bg_button = ColorTranslator.FromHtml("#34495e");


        private void reset()
        {
            //reset defaul bg to all buttons
            foreach (Control c in this.Controls)
            {
                if (c.Name == "panel1")
                {
                    foreach (Control button in c.Controls)
                    {
                        if (button is Button)
                        {
                            Button btn = (Button)button;
                            btn.BackColor = bg_button;
                        }
                    }
                }
            }
            //reset panel_ 
            foreach (Control pn in this.Controls)
            {
                if (pn.Name == "panel2")
                {
                    foreach (Control panel in pn.Controls)
                    {
                        if (panel is Panel)
                        {
                            Panel pan = (Panel)panel;
                            pan.Hide();
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            //setup left panel 
            panel1.Top = 0;
            panel1.Width = this.Width * 20 / 100;
            panel1.Height = this.Height;
            panel1.BackColor = dasar;
            //setup main panel
            panel2.Height = this.Height;
            panel2.Width = this.Width - panel1.Width;
            panel2.Location = new Point(panel1.Width,0);

            #region panel_login
            //setup panel_login_panels
            panel_login.Width = panel2.Width;
            panel_login_panel1.Width = (panel2.Width * 48 / 100);
            panel_login_panel2.Width = (panel2.Width * 48 / 100);
            panel_login_panel1.Location = new Point(panel_login_heading.Location.X, line.Location.Y + 40);
            panel_login_panel2.Location = new Point(panel2.Width - panel_login_panel2.Width - panel_login_heading.Location.X, line.Location.Y + 40);
            //setup form
            foreach (Control c in this.Controls)
            {
                if (c.Name == "panel2")
                {
                    //get all controls from panel1
                    foreach (Control panel in c.Controls)
                    {
                        foreach (Control ren in panel.Controls)
                        {
                            foreach (Control xren in ren.Controls)
                            {
                                if (xren is TextBox)
                                {
                                    TextBox txt = (TextBox)xren;
                                    txt.Width = ren.Width * 70 / 100;
                                    txt.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                                    txt.Height = 24;
                                    txt.ForeColor = bg_txtbox;
                                }
                                else if (xren is Label)
                                {
                                    Label txt = (Label)xren;
                                    txt.Width = ren.Width * 25 / 100;
                                }
                                else if (xren is Button)
                                {
                                    Button txt = (Button)xren;
                                    txt.Location = new Point(ren.Width - txt.Width - 45, ren.Height - txt.Height);
                                }
                            }
                        }
                    }
                }
            }
            //line width
            line.Width = panel2.Width - panel1.Width;
            #endregion

            #region panel_paket
            #endregion

            #region panel_enter
            #endregion

            #region menu
            //setup buttons menu
            int i = this.Height * 10 / 100;
            //get all controls from form
            foreach (Control c in this.Controls) 
            {
                if (c.Name == "panel1")
                {
                    //get all controls from panel1
                    foreach (Control button in c.Controls)
                    {
                        if (button is Button)
                        {
                            Button btn = (Button)button;
                            if (btn.Name == "about")
                                btn.Location = new Point(0, this.Height - btn.Height);
                            else
                                btn.Location = new Point(0, i);

                            btn.Width = panel1.Width;
                            btn.FlatAppearance.BorderSize = 0;
                            btn.TextAlign = ContentAlignment.MiddleLeft;
                            btn.Padding = new Padding(25,0,0,0);
                            btn.Click += new EventHandler(this.btnSelect);
                            i = i + button.Height + 2;
                        }
                    }
                }
            }
            //run reset function
            reset();
            setting.Location = new Point(this.Width - setting.Width, this.Height - setting.Width);
            #endregion
        }

        private void btnSelect(object sender, EventArgs e)
        {
            //run reset function
            reset();
            //set current selected button
            Button bt = (Button)sender;
            bt.BackColor = bg_txtbox;
            if (bt.Tag.ToString() != "")
            {
                Panel pn = Controls.Find(bt.Tag.ToString(), true).FirstOrDefault() as Panel;
                pn.Show();
                pn.Location = new Point(20, 40);
            }
        }
        #endregion

        #region login/register
        private void btn_register_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void btn_enter_without_login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                sck.Send(Encoding.Default.GetBytes("Connected," + textBox1.Text + ",3000"));
                Form2 form = new Form2(sck,textBox1.Text);
                form.Show();
                this.Hide();
                this.WindowState = FormWindowState.Minimized;
                form.Closed += delegate {
                    this.Show();
                    this.WindowState = FormWindowState.Maximized;
                    ShowInTaskbar = true; 
                };
            }
            else
                textBox1.Focus();
        }

        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => {
                if (!string.IsNullOrEmpty(textBox.Text))
                    prompt.Close(); 
            };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void setting_Click(object sender, EventArgs e)
        {
            string ip = ShowDialog("IP ADDRESS", "Pengaturan IP Server");
            Properties.Settings.Default["ip_address"] = ip;
            Properties.Settings.Default.Save();
        }
    }
}

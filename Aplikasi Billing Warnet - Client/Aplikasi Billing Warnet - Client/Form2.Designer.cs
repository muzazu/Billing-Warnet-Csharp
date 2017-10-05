namespace Aplikasi_Billing_Warnet___Client
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bayar = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // dc
            // 
            this.dc.AutoSize = true;
            this.dc.BackColor = System.Drawing.Color.LightCoral;
            this.dc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dc.Location = new System.Drawing.Point(243, -1);
            this.dc.Margin = new System.Windows.Forms.Padding(0);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(26, 25);
            this.dc.TabIndex = 0;
            this.dc.Text = "X";
            this.dc.UseVisualStyleBackColor = false;
            this.dc.Click += new System.EventHandler(this.dc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jam";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // bayar
            // 
            this.bayar.AutoSize = true;
            this.bayar.Location = new System.Drawing.Point(113, 5);
            this.bayar.Name = "bayar";
            this.bayar.Size = new System.Drawing.Size(34, 13);
            this.bayar.TabIndex = 2;
            this.bayar.Text = "Bayar";
            this.bayar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(268, 24);
            this.ControlBox = false;
            this.Controls.Add(this.bayar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Opacity = 0.6D;
            this.Text = "Form2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bayar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
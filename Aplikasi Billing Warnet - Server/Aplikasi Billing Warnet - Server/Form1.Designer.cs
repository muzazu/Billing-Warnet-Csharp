using System.IO;

namespace Aplikasi_Billing_Warnet___Server
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_heading = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel_konten = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.panel_status = new System.Windows.Forms.Panel();
            this.panel_status_h1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bayarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Aplikasi_Billing_Warnet___Server.DatabaseDataSet();
            this.panel_kuota = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pengaturanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.panel_member = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_pengaturan = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.simpan_paket = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pcTableAdapter = new Aplikasi_Billing_Warnet___Server.DatabaseDataSetTableAdapters.pcTableAdapter();
            this.usersTableAdapter = new Aplikasi_Billing_Warnet___Server.DatabaseDataSetTableAdapters.UsersTableAdapter();
            this.pengaturanTableAdapter = new Aplikasi_Billing_Warnet___Server.DatabaseDataSetTableAdapters.pengaturanTableAdapter();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_heading.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.panel_konten.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.panel_kuota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pengaturanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            this.panel_member.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.panel_pengaturan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1015, 682);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(41, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "▲▼";
            // 
            // panel_heading
            // 
            this.panel_heading.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_heading.Controls.Add(this.label6);
            this.panel_heading.Controls.Add(this.exit);
            this.panel_heading.Controls.Add(this.max);
            this.panel_heading.Controls.Add(this.min);
            this.panel_heading.Location = new System.Drawing.Point(0, 0);
            this.panel_heading.Name = "panel_heading";
            this.panel_heading.Size = new System.Drawing.Size(891, 35);
            this.panel_heading.TabIndex = 1;
            this.panel_heading.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Billing Warnet Server";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.LightSlateGray;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(844, -10);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(47, 49);
            this.exit.TabIndex = 0;
            this.exit.Text = "×";
            this.exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.max.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.max.Location = new System.Drawing.Point(801, -13);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(46, 49);
            this.max.TabIndex = 7;
            this.max.Text = "□";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.min.Location = new System.Drawing.Point(754, -14);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(47, 49);
            this.min.TabIndex = 6;
            this.min.Text = "_ ";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_menu.Controls.Add(this.button1);
            this.panel_menu.Controls.Add(this.button2);
            this.panel_menu.Controls.Add(this.button3);
            this.panel_menu.Controls.Add(this.button4);
            this.panel_menu.Location = new System.Drawing.Point(0, 37);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(178, 522);
            this.panel_menu.TabIndex = 2;
            this.panel_menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 2;
            this.button1.Tag = "panel1";
            this.button1.Text = "Status";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 3;
            this.button2.Tag = "panel_member";
            this.button2.Text = "Member";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 4;
            this.button3.Tag = "panel_pengaturan";
            this.button3.Text = "Pengaturan";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 23);
            this.button4.TabIndex = 5;
            this.button4.Tag = "panel_kuota";
            this.button4.Text = "+ Kuota";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel_konten
            // 
            this.panel_konten.Controls.Add(this.panel1);
            this.panel_konten.Controls.Add(this.panel_status);
            this.panel_konten.Controls.Add(this.panel_kuota);
            this.panel_konten.Controls.Add(this.panel_member);
            this.panel_konten.Controls.Add(this.panel_pengaturan);
            this.panel_konten.Location = new System.Drawing.Point(184, 37);
            this.panel_konten.Name = "panel_konten";
            this.panel_konten.Size = new System.Drawing.Size(707, 522);
            this.panel_konten.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 502);
            this.panel1.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader6});
            this.listView1.Location = new System.Drawing.Point(10, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(681, 278);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Endpoint";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nama";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Last Rec : Time";
            this.columnHeader4.Width = 233;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status Komputer";
            // 
            // panel_status
            // 
            this.panel_status.Controls.Add(this.panel_status_h1);
            this.panel_status.Controls.Add(this.dataGridView1);
            this.panel_status.Location = new System.Drawing.Point(38, 8);
            this.panel_status.Name = "panel_status";
            this.panel_status.Size = new System.Drawing.Size(701, 502);
            this.panel_status.TabIndex = 0;
            // 
            // panel_status_h1
            // 
            this.panel_status_h1.AutoSize = true;
            this.panel_status_h1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_status_h1.Location = new System.Drawing.Point(3, 12);
            this.panel_status_h1.Name = "panel_status_h1";
            this.panel_status_h1.Size = new System.Drawing.Size(230, 40);
            this.panel_status_h1.TabIndex = 1;
            this.panel_status_h1.Text = "Status Komputer";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.pcDataGridViewTextBoxColumn,
            this.jamDataGridViewTextBoxColumn,
            this.bayarDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.memberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pcBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 423);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // pcDataGridViewTextBoxColumn
            // 
            this.pcDataGridViewTextBoxColumn.DataPropertyName = "pc";
            this.pcDataGridViewTextBoxColumn.HeaderText = "PC Name";
            this.pcDataGridViewTextBoxColumn.Name = "pcDataGridViewTextBoxColumn";
            // 
            // jamDataGridViewTextBoxColumn
            // 
            this.jamDataGridViewTextBoxColumn.DataPropertyName = "jam";
            this.jamDataGridViewTextBoxColumn.HeaderText = "Jam";
            this.jamDataGridViewTextBoxColumn.Name = "jamDataGridViewTextBoxColumn";
            // 
            // bayarDataGridViewTextBoxColumn
            // 
            this.bayarDataGridViewTextBoxColumn.DataPropertyName = "bayar";
            this.bayarDataGridViewTextBoxColumn.HeaderText = "Bayar";
            this.bayarDataGridViewTextBoxColumn.Name = "bayarDataGridViewTextBoxColumn";
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "user";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            // 
            // memberDataGridViewTextBoxColumn
            // 
            this.memberDataGridViewTextBoxColumn.DataPropertyName = "member";
            this.memberDataGridViewTextBoxColumn.HeaderText = "Member";
            this.memberDataGridViewTextBoxColumn.Name = "memberDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // pcBindingSource
            // 
            this.pcBindingSource.DataMember = "pc";
            this.pcBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel_kuota
            // 
            this.panel_kuota.Controls.Add(this.button6);
            this.panel_kuota.Controls.Add(this.label5);
            this.panel_kuota.Controls.Add(this.textBox2);
            this.panel_kuota.Controls.Add(this.comboBox1);
            this.panel_kuota.Controls.Add(this.label3);
            this.panel_kuota.Controls.Add(this.Id);
            this.panel_kuota.Location = new System.Drawing.Point(3, 40);
            this.panel_kuota.Name = "panel_kuota";
            this.panel_kuota.Size = new System.Drawing.Size(707, 439);
            this.panel_kuota.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(240, 172);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 39);
            this.button6.TabIndex = 7;
            this.button6.Text = "Simpan";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 40);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tambah Jam Pelanggan";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 27);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pengaturanBindingSource;
            this.comboBox1.DisplayMember = "nama";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "Id";
            // 
            // pengaturanBindingSource
            // 
            this.pengaturanBindingSource.DataMember = "pengaturan";
            this.pengaturanBindingSource.DataSource = this.databaseDataSetBindingSource;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Paket";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(31, 83);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(24, 20);
            this.Id.TabIndex = 0;
            this.Id.Text = "ID";
            // 
            // panel_member
            // 
            this.panel_member.Controls.Add(this.label7);
            this.panel_member.Controls.Add(this.dataGridView2);
            this.panel_member.Location = new System.Drawing.Point(3, 55);
            this.panel_member.Name = "panel_member";
            this.panel_member.Size = new System.Drawing.Size(701, 502);
            this.panel_member.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 40);
            this.label7.TabIndex = 1;
            this.label7.Text = "Daftar Member ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nama,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView2.DataSource = this.usersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(698, 423);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "nama";
            this.nama.Name = "nama";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "jam";
            this.dataGridViewTextBoxColumn3.HeaderText = "Jam";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn7.HeaderText = "Status";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.databaseDataSet;
            // 
            // panel_pengaturan
            // 
            this.panel_pengaturan.Controls.Add(this.button5);
            this.panel_pengaturan.Controls.Add(this.simpan_paket);
            this.panel_pengaturan.Controls.Add(this.label12);
            this.panel_pengaturan.Controls.Add(this.textBox6);
            this.panel_pengaturan.Controls.Add(this.label11);
            this.panel_pengaturan.Controls.Add(this.label10);
            this.panel_pengaturan.Controls.Add(this.label9);
            this.panel_pengaturan.Controls.Add(this.textBox5);
            this.panel_pengaturan.Controls.Add(this.textBox4);
            this.panel_pengaturan.Controls.Add(this.textBox3);
            this.panel_pengaturan.Controls.Add(this.label8);
            this.panel_pengaturan.Location = new System.Drawing.Point(0, 277);
            this.panel_pengaturan.Name = "panel_pengaturan";
            this.panel_pengaturan.Size = new System.Drawing.Size(701, 502);
            this.panel_pengaturan.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.Location = new System.Drawing.Point(7, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(691, 2);
            this.button5.TabIndex = 11;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // simpan_paket
            // 
            this.simpan_paket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpan_paket.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.simpan_paket.Location = new System.Drawing.Point(435, 302);
            this.simpan_paket.Name = "simpan_paket";
            this.simpan_paket.Size = new System.Drawing.Size(84, 34);
            this.simpan_paket.TabIndex = 10;
            this.simpan_paket.Text = "Tambah";
            this.simpan_paket.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Jam";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(220, 249);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(299, 27);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "00:00:00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Harga";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nama Paket";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Harga /Jam";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(220, 205);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(299, 27);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(220, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(299, 27);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(220, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(299, 27);
            this.textBox3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 40);
            this.label8.TabIndex = 1;
            this.label8.Text = "Pengaturan";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcTableAdapter
            // 
            this.pcTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // pengaturanTableAdapter
            // 
            this.pengaturanTableAdapter.ClearBeforeFill = true;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "Bayar";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(890, 555);
            this.ControlBox = false;
            this.Controls.Add(this.panel_konten);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_heading);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Billing Warnet - Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_heading.ResumeLayout(false);
            this.panel_heading.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.panel_konten.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_status.ResumeLayout(false);
            this.panel_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.panel_kuota.ResumeLayout(false);
            this.panel_kuota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pengaturanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            this.panel_member.ResumeLayout(false);
            this.panel_member.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.panel_pengaturan.ResumeLayout(false);
            this.panel_pengaturan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_heading;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_konten;
        private System.Windows.Forms.Panel panel_status;
        private System.Windows.Forms.Label panel_status_h1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_kuota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Id;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource pcBindingSource;
        private DatabaseDataSetTableAdapters.pcTableAdapter pcTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bayarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_member;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Panel panel_pengaturan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button simpan_paket;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource pengaturanBindingSource;
        private DatabaseDataSetTableAdapters.pengaturanTableAdapter pengaturanTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}


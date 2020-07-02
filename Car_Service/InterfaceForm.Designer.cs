namespace Car_Service
{
    partial class InterfaceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.History_button = new System.Windows.Forms.Button();
            this.shortage_GridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Down_pictureBox7 = new System.Windows.Forms.PictureBox();
            this.Up_pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RegisterCar_button1 = new System.Windows.Forms.Button();
            this.Operations_button = new System.Windows.Forms.Button();
            this.AddData_button = new System.Windows.Forms.Button();
            this.ShowEditDelete_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.main_panel5 = new System.Windows.Forms.Panel();
            this.add1 = new Car_Service.Add();
            this.showEditDelete1 = new Car_Service.ShowEditDelete();
            this.operationsC1 = new Car_Service.OperationsC();
            this.historyC1 = new Car_Service.HistoryC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shortage_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Down_pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Up_pictureBox6)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.History_button);
            this.panel1.Controls.Add(this.shortage_GridView);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Down_pictureBox7);
            this.panel1.Controls.Add(this.Up_pictureBox6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.RegisterCar_button1);
            this.panel1.Controls.Add(this.Operations_button);
            this.panel1.Controls.Add(this.AddData_button);
            this.panel1.Controls.Add(this.ShowEditDelete_button);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 520);
            this.panel1.TabIndex = 40;
            // 
            // History_button
            // 
            this.History_button.BackColor = System.Drawing.Color.Transparent;
            this.History_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.History_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.History_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.History_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.History_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.History_button.Font = new System.Drawing.Font("Century Gothic", 14.75F, System.Drawing.FontStyle.Italic);
            this.History_button.ForeColor = System.Drawing.Color.White;
            this.History_button.Location = new System.Drawing.Point(3, 203);
            this.History_button.Name = "History_button";
            this.History_button.Size = new System.Drawing.Size(239, 42);
            this.History_button.TabIndex = 4;
            this.History_button.Tag = "";
            this.History_button.Text = "History";
            this.History_button.UseCompatibleTextRendering = true;
            this.History_button.UseVisualStyleBackColor = false;
            this.History_button.Click += new System.EventHandler(this.History_button_Click);
            this.History_button.MouseEnter += new System.EventHandler(this.History_button_MouseEnter);
            this.History_button.MouseLeave += new System.EventHandler(this.History_button_MouseLeave);
            // 
            // shortage_GridView
            // 
            this.shortage_GridView.AllowUserToAddRows = false;
            this.shortage_GridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.shortage_GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.shortage_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shortage_GridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.shortage_GridView.BackgroundColor = System.Drawing.Color.Silver;
            this.shortage_GridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.shortage_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shortage_GridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shortage_GridView.Location = new System.Drawing.Point(3, 332);
            this.shortage_GridView.MultiSelect = false;
            this.shortage_GridView.Name = "shortage_GridView";
            this.shortage_GridView.ReadOnly = true;
            this.shortage_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shortage_GridView.Size = new System.Drawing.Size(239, 183);
            this.shortage_GridView.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(36, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Shortage";
            // 
            // Down_pictureBox7
            // 
            this.Down_pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.Down_pictureBox7.Image = global::Car_Service.Properties.Resources.double_down_30px;
            this.Down_pictureBox7.Location = new System.Drawing.Point(3, 299);
            this.Down_pictureBox7.Name = "Down_pictureBox7";
            this.Down_pictureBox7.Size = new System.Drawing.Size(33, 33);
            this.Down_pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Down_pictureBox7.TabIndex = 49;
            this.Down_pictureBox7.TabStop = false;
            this.Down_pictureBox7.Click += new System.EventHandler(this.Down_pictureBox7_Click);
            // 
            // Up_pictureBox6
            // 
            this.Up_pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.Up_pictureBox6.Image = global::Car_Service.Properties.Resources.double_up_30px;
            this.Up_pictureBox6.Location = new System.Drawing.Point(3, 299);
            this.Up_pictureBox6.Name = "Up_pictureBox6";
            this.Up_pictureBox6.Size = new System.Drawing.Size(33, 33);
            this.Up_pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Up_pictureBox6.TabIndex = 48;
            this.Up_pictureBox6.TabStop = false;
            this.Up_pictureBox6.Click += new System.EventHandler(this.Up_pictureBox6_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(105, 321);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(137, 5);
            this.panel5.TabIndex = 6;
            // 
            // RegisterCar_button1
            // 
            this.RegisterCar_button1.BackColor = System.Drawing.Color.Transparent;
            this.RegisterCar_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterCar_button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RegisterCar_button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.RegisterCar_button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RegisterCar_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterCar_button1.Font = new System.Drawing.Font("Century Gothic", 14.75F, System.Drawing.FontStyle.Italic);
            this.RegisterCar_button1.ForeColor = System.Drawing.Color.White;
            this.RegisterCar_button1.Location = new System.Drawing.Point(3, 251);
            this.RegisterCar_button1.Name = "RegisterCar_button1";
            this.RegisterCar_button1.Size = new System.Drawing.Size(239, 42);
            this.RegisterCar_button1.TabIndex = 3;
            this.RegisterCar_button1.Tag = "";
            this.RegisterCar_button1.Text = "Register Car";
            this.RegisterCar_button1.UseCompatibleTextRendering = true;
            this.RegisterCar_button1.UseVisualStyleBackColor = false;
            this.RegisterCar_button1.Click += new System.EventHandler(this.RegisterCar_button1_Click);
            this.RegisterCar_button1.MouseEnter += new System.EventHandler(this.RegisterCar_button1_MouseEnter);
            this.RegisterCar_button1.MouseLeave += new System.EventHandler(this.RegisterCar_button1_MouseLeave);
            // 
            // Operations_button
            // 
            this.Operations_button.BackColor = System.Drawing.Color.Transparent;
            this.Operations_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Operations_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Operations_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.Operations_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Operations_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Operations_button.Font = new System.Drawing.Font("Century Gothic", 14.75F, System.Drawing.FontStyle.Italic);
            this.Operations_button.ForeColor = System.Drawing.Color.White;
            this.Operations_button.Location = new System.Drawing.Point(3, 155);
            this.Operations_button.Name = "Operations_button";
            this.Operations_button.Size = new System.Drawing.Size(239, 42);
            this.Operations_button.TabIndex = 2;
            this.Operations_button.Tag = "";
            this.Operations_button.Text = "Operations";
            this.Operations_button.UseCompatibleTextRendering = true;
            this.Operations_button.UseVisualStyleBackColor = false;
            this.Operations_button.Click += new System.EventHandler(this.Operations_button_Click);
            this.Operations_button.MouseEnter += new System.EventHandler(this.Operations_button_MouseEnter);
            this.Operations_button.MouseLeave += new System.EventHandler(this.Operations_button_MouseLeave);
            // 
            // AddData_button
            // 
            this.AddData_button.BackColor = System.Drawing.Color.Transparent;
            this.AddData_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddData_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddData_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddData_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddData_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddData_button.Font = new System.Drawing.Font("Century Gothic", 14.75F, System.Drawing.FontStyle.Italic);
            this.AddData_button.ForeColor = System.Drawing.Color.White;
            this.AddData_button.Location = new System.Drawing.Point(3, 105);
            this.AddData_button.Name = "AddData_button";
            this.AddData_button.Size = new System.Drawing.Size(239, 42);
            this.AddData_button.TabIndex = 1;
            this.AddData_button.Tag = "";
            this.AddData_button.Text = "Add Data";
            this.AddData_button.UseCompatibleTextRendering = true;
            this.AddData_button.UseVisualStyleBackColor = false;
            this.AddData_button.Click += new System.EventHandler(this.AddData_button_Click);
            this.AddData_button.MouseEnter += new System.EventHandler(this.AddData_button_MouseEnter);
            this.AddData_button.MouseLeave += new System.EventHandler(this.AddData_button_MouseLeave);
            // 
            // ShowEditDelete_button
            // 
            this.ShowEditDelete_button.BackColor = System.Drawing.Color.Transparent;
            this.ShowEditDelete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowEditDelete_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ShowEditDelete_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.ShowEditDelete_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ShowEditDelete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowEditDelete_button.Font = new System.Drawing.Font("Century Gothic", 14.75F, System.Drawing.FontStyle.Italic);
            this.ShowEditDelete_button.ForeColor = System.Drawing.Color.White;
            this.ShowEditDelete_button.Location = new System.Drawing.Point(3, 57);
            this.ShowEditDelete_button.Name = "ShowEditDelete_button";
            this.ShowEditDelete_button.Size = new System.Drawing.Size(239, 42);
            this.ShowEditDelete_button.TabIndex = 0;
            this.ShowEditDelete_button.Tag = "";
            this.ShowEditDelete_button.Text = "~Show  ~Edit  ~Delete";
            this.ShowEditDelete_button.UseCompatibleTextRendering = true;
            this.ShowEditDelete_button.UseVisualStyleBackColor = false;
            this.ShowEditDelete_button.Click += new System.EventHandler(this.ShowEditDelete_button_Click);
            this.ShowEditDelete_button.MouseEnter += new System.EventHandler(this.ShowEditDelete_button_MouseEnter);
            this.ShowEditDelete_button.MouseLeave += new System.EventHandler(this.ShowEditDelete_button_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 51);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Car_Service.Properties.Resources.вшэ_png_11;
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Service Center";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(245, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 51);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Car_Service.Properties.Resources.home_page_80px;
            this.pictureBox5.Location = new System.Drawing.Point(6, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 47;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.PictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Car_Service.Properties.Resources.minimize_window_80px;
            this.pictureBox4.Location = new System.Drawing.Point(607, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Car_Service.Properties.Resources.close_window_80px;
            this.pictureBox3.Location = new System.Drawing.Point(643, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Car_Service.Properties.Resources.details_80px;
            this.pictureBox2.Location = new System.Drawing.Point(45, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(84, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "DashBoard";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Car_Service.Properties.Resources._27957324newww;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.main_panel5);
            this.panel4.Controls.Add(this.add1);
            this.panel4.Controls.Add(this.showEditDelete1);
            this.panel4.Controls.Add(this.operationsC1);
            this.panel4.Controls.Add(this.historyC1);
            this.panel4.Location = new System.Drawing.Point(245, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(676, 472);
            this.panel4.TabIndex = 42;
            // 
            // main_panel5
            // 
            this.main_panel5.BackgroundImage = global::Car_Service.Properties.Resources._27957324newwww;
            this.main_panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel5.Location = new System.Drawing.Point(0, 0);
            this.main_panel5.Name = "main_panel5";
            this.main_panel5.Size = new System.Drawing.Size(676, 472);
            this.main_panel5.TabIndex = 4;
            // 
            // add1
            // 
            this.add1.BackColor = System.Drawing.Color.LightGray;
            this.add1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add1.BackgroundImage")));
            this.add1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic);
            this.add1.IsAdmain = false;
            this.add1.Location = new System.Drawing.Point(0, 0);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(676, 472);
            this.add1.TabIndex = 1;
            // 
            // showEditDelete1
            // 
            this.showEditDelete1.BackColor = System.Drawing.Color.LightGray;
            this.showEditDelete1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showEditDelete1.BackgroundImage")));
            this.showEditDelete1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showEditDelete1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic);
            this.showEditDelete1.IsAdmain = false;
            this.showEditDelete1.Location = new System.Drawing.Point(0, 0);
            this.showEditDelete1.Name = "showEditDelete1";
            this.showEditDelete1.Size = new System.Drawing.Size(676, 472);
            this.showEditDelete1.TabIndex = 0;
            // 
            // operationsC1
            // 
            this.operationsC1.BackColor = System.Drawing.Color.LightGray;
            this.operationsC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("operationsC1.BackgroundImage")));
            this.operationsC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.operationsC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationsC1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic);
            this.operationsC1.Location = new System.Drawing.Point(0, 0);
            this.operationsC1.Name = "operationsC1";
            this.operationsC1.Size = new System.Drawing.Size(676, 472);
            this.operationsC1.TabIndex = 2;
            // 
            // historyC1
            // 
            this.historyC1.BackColor = System.Drawing.Color.LightGray;
            this.historyC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("historyC1.BackgroundImage")));
            this.historyC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.historyC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyC1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic);
            this.historyC1.Location = new System.Drawing.Point(0, 0);
            this.historyC1.Name = "historyC1";
            this.historyC1.Size = new System.Drawing.Size(676, 472);
            this.historyC1.TabIndex = 3;
            // 
            // InterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(921, 520);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "InterfaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.InterfaceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shortage_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Down_pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Up_pictureBox6)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ShowEditDelete_button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button Operations_button;
        private System.Windows.Forms.Button History_button;
        private System.Windows.Forms.Button AddData_button;
        private System.Windows.Forms.Button RegisterCar_button1;
        private System.Windows.Forms.Panel panel4;
        private ShowEditDelete showEditDelete1;
        private Add add1;
        private OperationsC operationsC1;
        private HistoryC historyC1;
        private System.Windows.Forms.Panel main_panel5;
        private System.Windows.Forms.PictureBox Up_pictureBox6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox Down_pictureBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView shortage_GridView;
    }
}
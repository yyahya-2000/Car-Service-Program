namespace Car_Service
{
    partial class ShowEditCompanies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowEditCompanies));
            this.dataCompaniesGridView = new System.Windows.Forms.DataGridView();
            this.email_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.companyOwner_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entryDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_label = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.phoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.adress_textBox = new System.Windows.Forms.TextBox();
            this.note_textBox = new System.Windows.Forms.TextBox();
            this.companyName_textBox = new System.Windows.Forms.TextBox();
            this.note_label = new System.Windows.Forms.Label();
            this.rigistrationDate_label = new System.Windows.Forms.Label();
            this.adress_label = new System.Windows.Forms.Label();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serOwner_textBox1 = new System.Windows.Forms.TextBox();
            this.serName_textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataCompaniesGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataCompaniesGridView
            // 
            this.dataCompaniesGridView.AllowUserToAddRows = false;
            this.dataCompaniesGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataCompaniesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataCompaniesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCompaniesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCompaniesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataCompaniesGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.dataCompaniesGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCompaniesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataCompaniesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCompaniesGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataCompaniesGridView.Location = new System.Drawing.Point(292, 47);
            this.dataCompaniesGridView.MultiSelect = false;
            this.dataCompaniesGridView.Name = "dataCompaniesGridView";
            this.dataCompaniesGridView.ReadOnly = true;
            this.dataCompaniesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCompaniesGridView.Size = new System.Drawing.Size(610, 489);
            this.dataCompaniesGridView.TabIndex = 2;
            this.dataCompaniesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataToolsGridView_CellClick);
            // 
            // email_textBox1
            // 
            this.email_textBox1.BackColor = System.Drawing.Color.Silver;
            this.email_textBox1.Enabled = false;
            this.email_textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textBox1.Location = new System.Drawing.Point(6, 292);
            this.email_textBox1.Multiline = true;
            this.email_textBox1.Name = "email_textBox1";
            this.email_textBox1.Size = new System.Drawing.Size(280, 28);
            this.email_textBox1.TabIndex = 96;
            this.email_textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.CompanyName_textBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageKey = "(none)";
            this.label2.Location = new System.Drawing.Point(4, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 108;
            this.label2.Text = "Company Email:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // companyOwner_textBox
            // 
            this.companyOwner_textBox.BackColor = System.Drawing.Color.Silver;
            this.companyOwner_textBox.Enabled = false;
            this.companyOwner_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyOwner_textBox.Location = new System.Drawing.Point(7, 139);
            this.companyOwner_textBox.Multiline = true;
            this.companyOwner_textBox.Name = "companyOwner_textBox";
            this.companyOwner_textBox.Size = new System.Drawing.Size(280, 28);
            this.companyOwner_textBox.TabIndex = 93;
            this.companyOwner_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.CompanyName_textBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(4, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 107;
            this.label1.Text = "Company Owner:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // entryDate_dateTimePicker
            // 
            this.entryDate_dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.entryDate_dateTimePicker.Enabled = false;
            this.entryDate_dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryDate_dateTimePicker.Location = new System.Drawing.Point(6, 397);
            this.entryDate_dateTimePicker.Name = "entryDate_dateTimePicker";
            this.entryDate_dateTimePicker.Size = new System.Drawing.Size(279, 23);
            this.entryDate_dateTimePicker.TabIndex = 98;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.BackColor = System.Drawing.Color.Transparent;
            this.id_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.ImageKey = "(none)";
            this.id_label.Location = new System.Drawing.Point(4, 15);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(26, 18);
            this.id_label.TabIndex = 100;
            this.id_label.Text = "Id:";
            this.id_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // id_textBox
            // 
            this.id_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.id_textBox.Font = new System.Drawing.Font("Palatia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.id_textBox.ForeColor = System.Drawing.Color.Black;
            this.id_textBox.Location = new System.Drawing.Point(7, 36);
            this.id_textBox.Multiline = true;
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.ReadOnly = true;
            this.id_textBox.Size = new System.Drawing.Size(280, 28);
            this.id_textBox.TabIndex = 101;
            // 
            // phoneNumber_textBox
            // 
            this.phoneNumber_textBox.BackColor = System.Drawing.Color.Silver;
            this.phoneNumber_textBox.Enabled = false;
            this.phoneNumber_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber_textBox.Location = new System.Drawing.Point(7, 190);
            this.phoneNumber_textBox.Multiline = true;
            this.phoneNumber_textBox.Name = "phoneNumber_textBox";
            this.phoneNumber_textBox.Size = new System.Drawing.Size(280, 28);
            this.phoneNumber_textBox.TabIndex = 94;
            this.phoneNumber_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.CompanyName_textBox_Validating);
            // 
            // adress_textBox
            // 
            this.adress_textBox.BackColor = System.Drawing.Color.Silver;
            this.adress_textBox.Enabled = false;
            this.adress_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress_textBox.Location = new System.Drawing.Point(6, 242);
            this.adress_textBox.Multiline = true;
            this.adress_textBox.Name = "adress_textBox";
            this.adress_textBox.Size = new System.Drawing.Size(280, 28);
            this.adress_textBox.TabIndex = 95;
            this.adress_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.CompanyName_textBox_Validating);
            // 
            // note_textBox
            // 
            this.note_textBox.BackColor = System.Drawing.Color.Silver;
            this.note_textBox.Enabled = false;
            this.note_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note_textBox.Location = new System.Drawing.Point(6, 342);
            this.note_textBox.Multiline = true;
            this.note_textBox.Name = "note_textBox";
            this.note_textBox.Size = new System.Drawing.Size(280, 28);
            this.note_textBox.TabIndex = 97;
            this.note_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.CompanyName_textBox_Validating);
            // 
            // companyName_textBox
            // 
            this.companyName_textBox.BackColor = System.Drawing.Color.Silver;
            this.companyName_textBox.Enabled = false;
            this.companyName_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName_textBox.Location = new System.Drawing.Point(7, 86);
            this.companyName_textBox.Multiline = true;
            this.companyName_textBox.Name = "companyName_textBox";
            this.companyName_textBox.Size = new System.Drawing.Size(280, 28);
            this.companyName_textBox.TabIndex = 92;
            this.companyName_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.CompanyName_textBox_Validating);
            // 
            // note_label
            // 
            this.note_label.AutoSize = true;
            this.note_label.BackColor = System.Drawing.Color.Transparent;
            this.note_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.note_label.ForeColor = System.Drawing.Color.White;
            this.note_label.ImageKey = "(none)";
            this.note_label.Location = new System.Drawing.Point(4, 322);
            this.note_label.Name = "note_label";
            this.note_label.Size = new System.Drawing.Size(47, 18);
            this.note_label.TabIndex = 106;
            this.note_label.Text = "Note:";
            this.note_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rigistrationDate_label
            // 
            this.rigistrationDate_label.AutoSize = true;
            this.rigistrationDate_label.BackColor = System.Drawing.Color.Transparent;
            this.rigistrationDate_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.rigistrationDate_label.ForeColor = System.Drawing.Color.White;
            this.rigistrationDate_label.ImageKey = "(none)";
            this.rigistrationDate_label.Location = new System.Drawing.Point(4, 376);
            this.rigistrationDate_label.Name = "rigistrationDate_label";
            this.rigistrationDate_label.Size = new System.Drawing.Size(136, 18);
            this.rigistrationDate_label.TabIndex = 105;
            this.rigistrationDate_label.Text = "Registration Date:";
            this.rigistrationDate_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adress_label
            // 
            this.adress_label.AutoSize = true;
            this.adress_label.BackColor = System.Drawing.Color.Transparent;
            this.adress_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.adress_label.ForeColor = System.Drawing.Color.White;
            this.adress_label.ImageKey = "(none)";
            this.adress_label.Location = new System.Drawing.Point(4, 222);
            this.adress_label.Name = "adress_label";
            this.adress_label.Size = new System.Drawing.Size(148, 18);
            this.adress_label.TabIndex = 104;
            this.adress_label.Text = "Company Address:";
            this.adress_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumber_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.phoneNumber_label.ForeColor = System.Drawing.Color.White;
            this.phoneNumber_label.ImageKey = "(none)";
            this.phoneNumber_label.Location = new System.Drawing.Point(4, 170);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(121, 18);
            this.phoneNumber_label.TabIndex = 103;
            this.phoneNumber_label.Text = "Phone Number:";
            this.phoneNumber_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.ImageKey = "(none)";
            this.name_label.Location = new System.Drawing.Point(4, 66);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(135, 18);
            this.name_label.TabIndex = 102;
            this.name_label.Text = "Company Name:";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Delete_button
            // 
            this.Delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete_button.BackColor = System.Drawing.Color.Transparent;
            this.Delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_button.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Delete_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Delete_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.ForeColor = System.Drawing.Color.White;
            this.Delete_button.Location = new System.Drawing.Point(6, 488);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(279, 40);
            this.Delete_button.TabIndex = 110;
            this.Delete_button.Tag = "";
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseCompatibleTextRendering = true;
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            this.Delete_button.MouseEnter += new System.EventHandler(this.Delete_button_MouseEnter);
            this.Delete_button.MouseLeave += new System.EventHandler(this.Delete_button_MouseLeave);
            // 
            // Edit_button
            // 
            this.Edit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Edit_button.BackColor = System.Drawing.Color.Transparent;
            this.Edit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Edit_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Edit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_button.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_button.ForeColor = System.Drawing.Color.White;
            this.Edit_button.Location = new System.Drawing.Point(6, 440);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(279, 42);
            this.Edit_button.TabIndex = 109;
            this.Edit_button.Tag = "";
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseCompatibleTextRendering = true;
            this.Edit_button.UseVisualStyleBackColor = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            this.Edit_button.MouseEnter += new System.EventHandler(this.Edit_button_MouseEnter);
            this.Edit_button.MouseLeave += new System.EventHandler(this.Edit_button_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.serOwner_textBox1);
            this.groupBox2.Controls.Add(this.serName_textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(292, -4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 45);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search:";
            // 
            // serOwner_textBox1
            // 
            this.serOwner_textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.serOwner_textBox1.BackColor = System.Drawing.Color.Silver;
            this.serOwner_textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serOwner_textBox1.Location = new System.Drawing.Point(444, 16);
            this.serOwner_textBox1.Multiline = true;
            this.serOwner_textBox1.Name = "serOwner_textBox1";
            this.serOwner_textBox1.Size = new System.Drawing.Size(154, 23);
            this.serOwner_textBox1.TabIndex = 1;
            this.serOwner_textBox1.TextChanged += new System.EventHandler(this.SerName_textBox1_TextChanged);
            // 
            // serName_textBox1
            // 
            this.serName_textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.serName_textBox1.BackColor = System.Drawing.Color.Silver;
            this.serName_textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serName_textBox1.Location = new System.Drawing.Point(147, 16);
            this.serName_textBox1.Multiline = true;
            this.serName_textBox1.Name = "serName_textBox1";
            this.serName_textBox1.Size = new System.Drawing.Size(152, 23);
            this.serName_textBox1.TabIndex = 0;
            this.serName_textBox1.TextChanged += new System.EventHandler(this.SerName_textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageKey = "(none)";
            this.label3.Location = new System.Drawing.Point(305, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Company Owner:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageKey = "(none)";
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Company Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShowEditCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(902, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.email_textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companyOwner_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entryDate_dateTimePicker);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.phoneNumber_textBox);
            this.Controls.Add(this.adress_textBox);
            this.Controls.Add(this.note_textBox);
            this.Controls.Add(this.companyName_textBox);
            this.Controls.Add(this.note_label);
            this.Controls.Add(this.rigistrationDate_label);
            this.Controls.Add(this.adress_label);
            this.Controls.Add(this.phoneNumber_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.dataCompaniesGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(833, 564);
            this.Name = "ShowEditCompanies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show & Edit Companies";
            ((System.ComponentModel.ISupportInitialize)(this.dataCompaniesGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCompaniesGridView;
        private System.Windows.Forms.TextBox email_textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox companyOwner_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker entryDate_dateTimePicker;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox phoneNumber_textBox;
        private System.Windows.Forms.TextBox adress_textBox;
        private System.Windows.Forms.TextBox note_textBox;
        private System.Windows.Forms.TextBox companyName_textBox;
        private System.Windows.Forms.Label note_label;
        private System.Windows.Forms.Label rigistrationDate_label;
        private System.Windows.Forms.Label adress_label;
        private System.Windows.Forms.Label phoneNumber_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox serOwner_textBox1;
        private System.Windows.Forms.TextBox serName_textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
namespace Car_Service
{
    partial class ShowEditEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowEditEmployees));
            this.dataEmployeesGridView = new System.Windows.Forms.DataGridView();
            this.register_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_label = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.phoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.adress_textBox = new System.Windows.Forms.TextBox();
            this.career_textBox = new System.Windows.Forms.TextBox();
            this.salary_textBox = new System.Windows.Forms.TextBox();
            this.note_textBox = new System.Windows.Forms.TextBox();
            this.employeeName_textBox = new System.Windows.Forms.TextBox();
            this.note_label = new System.Windows.Forms.Label();
            this.rigistrationTime_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.career_label = new System.Windows.Forms.Label();
            this.adress_label = new System.Windows.Forms.Label();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.employeeName_label = new System.Windows.Forms.Label();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serName_textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployeesGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataEmployeesGridView
            // 
            this.dataEmployeesGridView.AllowUserToAddRows = false;
            this.dataEmployeesGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataEmployeesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataEmployeesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEmployeesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEmployeesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataEmployeesGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.dataEmployeesGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataEmployeesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataEmployeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmployeesGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataEmployeesGridView.Location = new System.Drawing.Point(280, 48);
            this.dataEmployeesGridView.MultiSelect = false;
            this.dataEmployeesGridView.Name = "dataEmployeesGridView";
            this.dataEmployeesGridView.ReadOnly = true;
            this.dataEmployeesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEmployeesGridView.Size = new System.Drawing.Size(607, 486);
            this.dataEmployeesGridView.TabIndex = 3;
            this.dataEmployeesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataToolsGridView_CellClick);
            // 
            // register_dateTimePicker
            // 
            this.register_dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.register_dateTimePicker.Enabled = false;
            this.register_dateTimePicker.Font = new System.Drawing.Font("Palatia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.register_dateTimePicker.Location = new System.Drawing.Point(9, 402);
            this.register_dateTimePicker.Name = "register_dateTimePicker";
            this.register_dateTimePicker.Size = new System.Drawing.Size(266, 24);
            this.register_dateTimePicker.TabIndex = 46;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.BackColor = System.Drawing.Color.Transparent;
            this.id_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.ImageKey = "(none)";
            this.id_label.Location = new System.Drawing.Point(4, 11);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(26, 18);
            this.id_label.TabIndex = 47;
            this.id_label.Text = "Id:";
            this.id_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // id_textBox
            // 
            this.id_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.id_textBox.Font = new System.Drawing.Font("Palatia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.id_textBox.ForeColor = System.Drawing.Color.Black;
            this.id_textBox.Location = new System.Drawing.Point(7, 32);
            this.id_textBox.Multiline = true;
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.ReadOnly = true;
            this.id_textBox.Size = new System.Drawing.Size(267, 28);
            this.id_textBox.TabIndex = 49;
            // 
            // phoneNumber_textBox
            // 
            this.phoneNumber_textBox.BackColor = System.Drawing.Color.Silver;
            this.phoneNumber_textBox.Enabled = false;
            this.phoneNumber_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber_textBox.Location = new System.Drawing.Point(7, 191);
            this.phoneNumber_textBox.Multiline = true;
            this.phoneNumber_textBox.Name = "phoneNumber_textBox";
            this.phoneNumber_textBox.Size = new System.Drawing.Size(267, 28);
            this.phoneNumber_textBox.TabIndex = 42;
            this.phoneNumber_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Note_textBox_Validating);
            // 
            // adress_textBox
            // 
            this.adress_textBox.BackColor = System.Drawing.Color.Silver;
            this.adress_textBox.Enabled = false;
            this.adress_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress_textBox.Location = new System.Drawing.Point(7, 132);
            this.adress_textBox.Multiline = true;
            this.adress_textBox.Name = "adress_textBox";
            this.adress_textBox.Size = new System.Drawing.Size(267, 28);
            this.adress_textBox.TabIndex = 43;
            this.adress_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Note_textBox_Validating);
            // 
            // career_textBox
            // 
            this.career_textBox.BackColor = System.Drawing.Color.Silver;
            this.career_textBox.Enabled = false;
            this.career_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.career_textBox.Location = new System.Drawing.Point(7, 243);
            this.career_textBox.Multiline = true;
            this.career_textBox.Name = "career_textBox";
            this.career_textBox.Size = new System.Drawing.Size(267, 28);
            this.career_textBox.TabIndex = 44;
            this.career_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Note_textBox_Validating);
            // 
            // salary_textBox
            // 
            this.salary_textBox.BackColor = System.Drawing.Color.Silver;
            this.salary_textBox.Enabled = false;
            this.salary_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_textBox.Location = new System.Drawing.Point(7, 298);
            this.salary_textBox.Multiline = true;
            this.salary_textBox.Name = "salary_textBox";
            this.salary_textBox.Size = new System.Drawing.Size(267, 28);
            this.salary_textBox.TabIndex = 45;
            this.salary_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Note_textBox_Validating);
            // 
            // note_textBox
            // 
            this.note_textBox.BackColor = System.Drawing.Color.Silver;
            this.note_textBox.Enabled = false;
            this.note_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note_textBox.Location = new System.Drawing.Point(8, 350);
            this.note_textBox.Multiline = true;
            this.note_textBox.Name = "note_textBox";
            this.note_textBox.Size = new System.Drawing.Size(267, 28);
            this.note_textBox.TabIndex = 48;
            this.note_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Note_textBox_Validating);
            // 
            // employeeName_textBox
            // 
            this.employeeName_textBox.BackColor = System.Drawing.Color.Silver;
            this.employeeName_textBox.Enabled = false;
            this.employeeName_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeName_textBox.Location = new System.Drawing.Point(7, 82);
            this.employeeName_textBox.Multiline = true;
            this.employeeName_textBox.Name = "employeeName_textBox";
            this.employeeName_textBox.Size = new System.Drawing.Size(267, 28);
            this.employeeName_textBox.TabIndex = 41;
            this.employeeName_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Note_textBox_Validating);
            // 
            // note_label
            // 
            this.note_label.AutoSize = true;
            this.note_label.BackColor = System.Drawing.Color.Transparent;
            this.note_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.note_label.ForeColor = System.Drawing.Color.White;
            this.note_label.ImageKey = "(none)";
            this.note_label.Location = new System.Drawing.Point(5, 329);
            this.note_label.Name = "note_label";
            this.note_label.Size = new System.Drawing.Size(47, 18);
            this.note_label.TabIndex = 56;
            this.note_label.Text = "Note:";
            this.note_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rigistrationTime_label
            // 
            this.rigistrationTime_label.AutoSize = true;
            this.rigistrationTime_label.BackColor = System.Drawing.Color.Transparent;
            this.rigistrationTime_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.rigistrationTime_label.ForeColor = System.Drawing.Color.White;
            this.rigistrationTime_label.ImageKey = "(none)";
            this.rigistrationTime_label.Location = new System.Drawing.Point(5, 381);
            this.rigistrationTime_label.Name = "rigistrationTime_label";
            this.rigistrationTime_label.Size = new System.Drawing.Size(129, 18);
            this.rigistrationTime_label.TabIndex = 55;
            this.rigistrationTime_label.Text = "Rigistration Time:";
            this.rigistrationTime_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageKey = "(none)";
            this.label5.Location = new System.Drawing.Point(4, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "Salary:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // career_label
            // 
            this.career_label.AutoSize = true;
            this.career_label.BackColor = System.Drawing.Color.Transparent;
            this.career_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.career_label.ForeColor = System.Drawing.Color.White;
            this.career_label.ImageKey = "(none)";
            this.career_label.Location = new System.Drawing.Point(4, 222);
            this.career_label.Name = "career_label";
            this.career_label.Size = new System.Drawing.Size(103, 18);
            this.career_label.TabIndex = 53;
            this.career_label.Text = "Career Type:";
            this.career_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adress_label
            // 
            this.adress_label.AutoSize = true;
            this.adress_label.BackColor = System.Drawing.Color.Transparent;
            this.adress_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.adress_label.ForeColor = System.Drawing.Color.White;
            this.adress_label.ImageKey = "(none)";
            this.adress_label.Location = new System.Drawing.Point(5, 113);
            this.adress_label.Name = "adress_label";
            this.adress_label.Size = new System.Drawing.Size(70, 18);
            this.adress_label.TabIndex = 52;
            this.adress_label.Text = "Address:";
            this.adress_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumber_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.phoneNumber_label.ForeColor = System.Drawing.Color.White;
            this.phoneNumber_label.ImageKey = "(none)";
            this.phoneNumber_label.Location = new System.Drawing.Point(4, 167);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(121, 18);
            this.phoneNumber_label.TabIndex = 51;
            this.phoneNumber_label.Text = "Phone Number:";
            this.phoneNumber_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // employeeName_label
            // 
            this.employeeName_label.AutoSize = true;
            this.employeeName_label.BackColor = System.Drawing.Color.Transparent;
            this.employeeName_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.employeeName_label.ForeColor = System.Drawing.Color.White;
            this.employeeName_label.ImageKey = "(none)";
            this.employeeName_label.Location = new System.Drawing.Point(4, 61);
            this.employeeName_label.Name = "employeeName_label";
            this.employeeName_label.Size = new System.Drawing.Size(136, 18);
            this.employeeName_label.TabIndex = 50;
            this.employeeName_label.Text = "Employee Name:";
            this.employeeName_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.Delete_button.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.ForeColor = System.Drawing.Color.White;
            this.Delete_button.Location = new System.Drawing.Point(7, 489);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(267, 40);
            this.Delete_button.TabIndex = 112;
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
            this.Edit_button.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Edit_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Edit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_button.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_button.ForeColor = System.Drawing.Color.White;
            this.Edit_button.Location = new System.Drawing.Point(7, 441);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(267, 42);
            this.Edit_button.TabIndex = 111;
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
            this.groupBox2.Controls.Add(this.serName_textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(280, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 44);
            this.groupBox2.TabIndex = 116;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search:";
            // 
            // serName_textBox1
            // 
            this.serName_textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.serName_textBox1.BackColor = System.Drawing.Color.Silver;
            this.serName_textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serName_textBox1.Location = new System.Drawing.Point(154, 13);
            this.serName_textBox1.Multiline = true;
            this.serName_textBox1.Name = "serName_textBox1";
            this.serName_textBox1.Size = new System.Drawing.Size(431, 25);
            this.serName_textBox1.TabIndex = 0;
            this.serName_textBox1.TextChanged += new System.EventHandler(this.SerName_textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageKey = "(none)";
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Employee\'s Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShowEditEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(886, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.register_dateTimePicker);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.phoneNumber_textBox);
            this.Controls.Add(this.adress_textBox);
            this.Controls.Add(this.career_textBox);
            this.Controls.Add(this.salary_textBox);
            this.Controls.Add(this.note_textBox);
            this.Controls.Add(this.employeeName_textBox);
            this.Controls.Add(this.note_label);
            this.Controls.Add(this.rigistrationTime_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.career_label);
            this.Controls.Add(this.adress_label);
            this.Controls.Add(this.phoneNumber_label);
            this.Controls.Add(this.employeeName_label);
            this.Controls.Add(this.dataEmployeesGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowEditEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show & Edit Employees";
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployeesGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataEmployeesGridView;
        private System.Windows.Forms.DateTimePicker register_dateTimePicker;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox phoneNumber_textBox;
        private System.Windows.Forms.TextBox adress_textBox;
        private System.Windows.Forms.TextBox career_textBox;
        private System.Windows.Forms.TextBox salary_textBox;
        private System.Windows.Forms.TextBox note_textBox;
        private System.Windows.Forms.TextBox employeeName_textBox;
        private System.Windows.Forms.Label note_label;
        private System.Windows.Forms.Label rigistrationTime_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label career_label;
        private System.Windows.Forms.Label adress_label;
        private System.Windows.Forms.Label phoneNumber_label;
        private System.Windows.Forms.Label employeeName_label;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox serName_textBox1;
        private System.Windows.Forms.Label label4;
    }
}
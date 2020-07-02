namespace Car_Service
{
    partial class ShowEditUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowEditUsers));
            this.datausersGridView = new System.Windows.Forms.DataGridView();
            this.isAdmain_comboBox = new System.Windows.Forms.ComboBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.note_textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.userName_textBox = new System.Windows.Forms.TextBox();
            this.uName_label = new System.Windows.Forms.Label();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serName_textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datausersGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datausersGridView
            // 
            this.datausersGridView.AllowUserToAddRows = false;
            this.datausersGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.datausersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datausersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datausersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datausersGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.datausersGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.datausersGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datausersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datausersGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datausersGridView.Location = new System.Drawing.Point(264, 52);
            this.datausersGridView.MultiSelect = false;
            this.datausersGridView.Name = "datausersGridView";
            this.datausersGridView.ReadOnly = true;
            this.datausersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datausersGridView.Size = new System.Drawing.Size(607, 484);
            this.datausersGridView.TabIndex = 4;
            this.datausersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataToolsGridView_CellClick);
            // 
            // isAdmain_comboBox
            // 
            this.isAdmain_comboBox.BackColor = System.Drawing.Color.Silver;
            this.isAdmain_comboBox.Enabled = false;
            this.isAdmain_comboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAdmain_comboBox.FormattingEnabled = true;
            this.isAdmain_comboBox.Items.AddRange(new object[] {
            "true",
            "false"});
            this.isAdmain_comboBox.Location = new System.Drawing.Point(8, 188);
            this.isAdmain_comboBox.Name = "isAdmain_comboBox";
            this.isAdmain_comboBox.Size = new System.Drawing.Size(250, 25);
            this.isAdmain_comboBox.TabIndex = 47;
            // 
            // password_textBox
            // 
            this.password_textBox.BackColor = System.Drawing.Color.Silver;
            this.password_textBox.Enabled = false;
            this.password_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.Location = new System.Drawing.Point(8, 136);
            this.password_textBox.Multiline = true;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(250, 28);
            this.password_textBox.TabIndex = 46;
            this.password_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.ShowEditUsers_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageKey = "(none)";
            this.label3.Location = new System.Drawing.Point(5, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // note_textBox2
            // 
            this.note_textBox2.BackColor = System.Drawing.Color.Silver;
            this.note_textBox2.Enabled = false;
            this.note_textBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note_textBox2.Location = new System.Drawing.Point(8, 235);
            this.note_textBox2.Multiline = true;
            this.note_textBox2.Name = "note_textBox2";
            this.note_textBox2.Size = new System.Drawing.Size(250, 28);
            this.note_textBox2.TabIndex = 48;
            this.note_textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.ShowEditUsers_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageKey = "(none)";
            this.label2.Location = new System.Drawing.Point(5, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 53;
            this.label2.Text = "Note:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(5, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "Is Admain:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.BackColor = System.Drawing.Color.Transparent;
            this.id_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.ImageKey = "(none)";
            this.id_label.Location = new System.Drawing.Point(5, 11);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(26, 18);
            this.id_label.TabIndex = 50;
            this.id_label.Text = "Id:";
            this.id_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // id_textBox
            // 
            this.id_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.id_textBox.Enabled = false;
            this.id_textBox.Font = new System.Drawing.Font("Palatia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.id_textBox.ForeColor = System.Drawing.Color.Black;
            this.id_textBox.Location = new System.Drawing.Point(8, 32);
            this.id_textBox.Multiline = true;
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.ReadOnly = true;
            this.id_textBox.Size = new System.Drawing.Size(250, 28);
            this.id_textBox.TabIndex = 51;
            // 
            // userName_textBox
            // 
            this.userName_textBox.BackColor = System.Drawing.Color.Silver;
            this.userName_textBox.Enabled = false;
            this.userName_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_textBox.Location = new System.Drawing.Point(8, 84);
            this.userName_textBox.Multiline = true;
            this.userName_textBox.Name = "userName_textBox";
            this.userName_textBox.Size = new System.Drawing.Size(250, 28);
            this.userName_textBox.TabIndex = 45;
            this.userName_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.ShowEditUsers_Validating);
            // 
            // uName_label
            // 
            this.uName_label.AutoSize = true;
            this.uName_label.BackColor = System.Drawing.Color.Transparent;
            this.uName_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.uName_label.ForeColor = System.Drawing.Color.White;
            this.uName_label.ImageKey = "(none)";
            this.uName_label.Location = new System.Drawing.Point(5, 63);
            this.uName_label.Name = "uName_label";
            this.uName_label.Size = new System.Drawing.Size(92, 18);
            this.uName_label.TabIndex = 49;
            this.uName_label.Text = "User Name:";
            this.uName_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.Delete_button.Location = new System.Drawing.Point(8, 490);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(250, 40);
            this.Delete_button.TabIndex = 114;
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
            this.Edit_button.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_button.ForeColor = System.Drawing.Color.White;
            this.Edit_button.Location = new System.Drawing.Point(8, 442);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(250, 42);
            this.Edit_button.TabIndex = 113;
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
            this.groupBox2.Location = new System.Drawing.Point(264, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 48);
            this.groupBox2.TabIndex = 115;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search:";
            // 
            // serName_textBox1
            // 
            this.serName_textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.serName_textBox1.BackColor = System.Drawing.Color.Silver;
            this.serName_textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serName_textBox1.Location = new System.Drawing.Point(96, 15);
            this.serName_textBox1.Multiline = true;
            this.serName_textBox1.Name = "serName_textBox1";
            this.serName_textBox1.Size = new System.Drawing.Size(460, 27);
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
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "User Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShowEditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(872, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.isAdmain_comboBox);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.note_textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.userName_textBox);
            this.Controls.Add(this.uName_label);
            this.Controls.Add(this.datausersGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowEditUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show & Edit Users";
            this.Validating += new System.ComponentModel.CancelEventHandler(this.ShowEditUsers_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.datausersGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datausersGridView;
        private System.Windows.Forms.ComboBox isAdmain_comboBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox note_textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox userName_textBox;
        private System.Windows.Forms.Label uName_label;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox serName_textBox1;
        private System.Windows.Forms.Label label4;
    }
}
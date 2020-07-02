namespace Car_Service
{
    partial class SendOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendOrder));
            this.company_list_comboBox = new System.Windows.Forms.ComboBox();
            this.company_email_label = new System.Windows.Forms.Label();
            this.subject_label = new System.Windows.Forms.Label();
            this.subject_textBox = new System.Windows.Forms.TextBox();
            this.message_label = new System.Windows.Forms.Label();
            this.message_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ssl_checkBox = new System.Windows.Forms.CheckBox();
            this.Send_button = new System.Windows.Forms.Button();
            this.smtp_textBox = new System.Windows.Forms.TextBox();
            this.smtp_label = new System.Windows.Forms.Label();
            this.port_textBox = new System.Windows.Forms.TextBox();
            this.Port_label = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.userName_textBox = new System.Windows.Forms.TextBox();
            this.user_name_label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // company_list_comboBox
            // 
            this.company_list_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.company_list_comboBox.BackColor = System.Drawing.Color.Silver;
            this.company_list_comboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_list_comboBox.FormattingEnabled = true;
            this.company_list_comboBox.Location = new System.Drawing.Point(147, 13);
            this.company_list_comboBox.Name = "company_list_comboBox";
            this.company_list_comboBox.Size = new System.Drawing.Size(433, 24);
            this.company_list_comboBox.TabIndex = 0;
            this.company_list_comboBox.Text = "Choice Company";
            // 
            // company_email_label
            // 
            this.company_email_label.AutoSize = true;
            this.company_email_label.BackColor = System.Drawing.Color.Transparent;
            this.company_email_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.company_email_label.ForeColor = System.Drawing.Color.White;
            this.company_email_label.ImageKey = "(none)";
            this.company_email_label.Location = new System.Drawing.Point(9, 15);
            this.company_email_label.Name = "company_email_label";
            this.company_email_label.Size = new System.Drawing.Size(130, 18);
            this.company_email_label.TabIndex = 33;
            this.company_email_label.Text = "Company Email:";
            this.company_email_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subject_label
            // 
            this.subject_label.AutoSize = true;
            this.subject_label.BackColor = System.Drawing.Color.Transparent;
            this.subject_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.subject_label.ForeColor = System.Drawing.Color.White;
            this.subject_label.ImageKey = "(none)";
            this.subject_label.Location = new System.Drawing.Point(9, 43);
            this.subject_label.Name = "subject_label";
            this.subject_label.Size = new System.Drawing.Size(67, 18);
            this.subject_label.TabIndex = 34;
            this.subject_label.Text = "Subject:";
            this.subject_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subject_textBox
            // 
            this.subject_textBox.BackColor = System.Drawing.Color.Silver;
            this.subject_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_textBox.Location = new System.Drawing.Point(147, 41);
            this.subject_textBox.Name = "subject_textBox";
            this.subject_textBox.Size = new System.Drawing.Size(433, 23);
            this.subject_textBox.TabIndex = 35;
            // 
            // message_label
            // 
            this.message_label.AutoSize = true;
            this.message_label.BackColor = System.Drawing.Color.Transparent;
            this.message_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.message_label.ForeColor = System.Drawing.Color.White;
            this.message_label.ImageKey = "(none)";
            this.message_label.Location = new System.Drawing.Point(9, 75);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(78, 18);
            this.message_label.TabIndex = 36;
            this.message_label.Text = "Message:";
            this.message_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // message_textBox
            // 
            this.message_textBox.BackColor = System.Drawing.Color.Silver;
            this.message_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_textBox.Location = new System.Drawing.Point(146, 73);
            this.message_textBox.Multiline = true;
            this.message_textBox.Name = "message_textBox";
            this.message_textBox.Size = new System.Drawing.Size(434, 200);
            this.message_textBox.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ssl_checkBox);
            this.groupBox1.Controls.Add(this.Send_button);
            this.groupBox1.Controls.Add(this.smtp_textBox);
            this.groupBox1.Controls.Add(this.smtp_label);
            this.groupBox1.Controls.Add(this.port_textBox);
            this.groupBox1.Controls.Add(this.Port_label);
            this.groupBox1.Controls.Add(this.password_textBox);
            this.groupBox1.Controls.Add(this.password_label);
            this.groupBox1.Controls.Add(this.userName_textBox);
            this.groupBox1.Controls.Add(this.user_name_label);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(146, 292);
            this.groupBox1.MaximumSize = new System.Drawing.Size(434, 128);
            this.groupBox1.MinimumSize = new System.Drawing.Size(434, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 128);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ssl_checkBox
            // 
            this.ssl_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ssl_checkBox.AutoSize = true;
            this.ssl_checkBox.Checked = true;
            this.ssl_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ssl_checkBox.Enabled = false;
            this.ssl_checkBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.ssl_checkBox.ForeColor = System.Drawing.Color.White;
            this.ssl_checkBox.Location = new System.Drawing.Point(300, 19);
            this.ssl_checkBox.Name = "ssl_checkBox";
            this.ssl_checkBox.Size = new System.Drawing.Size(47, 22);
            this.ssl_checkBox.TabIndex = 48;
            this.ssl_checkBox.Text = "SSl";
            this.ssl_checkBox.UseVisualStyleBackColor = true;
            // 
            // Send_button
            // 
            this.Send_button.BackColor = System.Drawing.Color.Transparent;
            this.Send_button.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Send_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.Send_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Send_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Send_button.ForeColor = System.Drawing.Color.White;
            this.Send_button.Location = new System.Drawing.Point(300, 49);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(112, 28);
            this.Send_button.TabIndex = 47;
            this.Send_button.Tag = "";
            this.Send_button.Text = "Send";
            this.Send_button.UseCompatibleTextRendering = true;
            this.Send_button.UseVisualStyleBackColor = false;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            this.Send_button.MouseEnter += new System.EventHandler(this.Send_button_MouseEnter);
            this.Send_button.MouseLeave += new System.EventHandler(this.Send_button_MouseLeave);
            // 
            // smtp_textBox
            // 
            this.smtp_textBox.BackColor = System.Drawing.Color.Silver;
            this.smtp_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smtp_textBox.Location = new System.Drawing.Point(231, 85);
            this.smtp_textBox.Multiline = true;
            this.smtp_textBox.Name = "smtp_textBox";
            this.smtp_textBox.ReadOnly = true;
            this.smtp_textBox.Size = new System.Drawing.Size(181, 27);
            this.smtp_textBox.TabIndex = 46;
            this.smtp_textBox.Text = "smtp.gmail.com";
            // 
            // smtp_label
            // 
            this.smtp_label.AutoSize = true;
            this.smtp_label.BackColor = System.Drawing.Color.Transparent;
            this.smtp_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.smtp_label.ForeColor = System.Drawing.Color.White;
            this.smtp_label.ImageKey = "(none)";
            this.smtp_label.Location = new System.Drawing.Point(177, 88);
            this.smtp_label.Name = "smtp_label";
            this.smtp_label.Size = new System.Drawing.Size(48, 18);
            this.smtp_label.TabIndex = 45;
            this.smtp_label.Text = "Smtp:";
            this.smtp_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // port_textBox
            // 
            this.port_textBox.BackColor = System.Drawing.Color.Silver;
            this.port_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_textBox.Location = new System.Drawing.Point(94, 85);
            this.port_textBox.Multiline = true;
            this.port_textBox.Name = "port_textBox";
            this.port_textBox.ReadOnly = true;
            this.port_textBox.Size = new System.Drawing.Size(41, 27);
            this.port_textBox.TabIndex = 44;
            this.port_textBox.Text = "587";
            // 
            // Port_label
            // 
            this.Port_label.AutoSize = true;
            this.Port_label.BackColor = System.Drawing.Color.Transparent;
            this.Port_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Port_label.ForeColor = System.Drawing.Color.White;
            this.Port_label.ImageKey = "(none)";
            this.Port_label.Location = new System.Drawing.Point(6, 88);
            this.Port_label.Name = "Port_label";
            this.Port_label.Size = new System.Drawing.Size(39, 18);
            this.Port_label.TabIndex = 43;
            this.Port_label.Text = "Port:";
            this.Port_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // password_textBox
            // 
            this.password_textBox.BackColor = System.Drawing.Color.Silver;
            this.password_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.Location = new System.Drawing.Point(94, 50);
            this.password_textBox.Multiline = true;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(179, 27);
            this.password_textBox.TabIndex = 42;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.password_label.ForeColor = System.Drawing.Color.White;
            this.password_label.ImageKey = "(none)";
            this.password_label.Location = new System.Drawing.Point(6, 53);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(79, 18);
            this.password_label.TabIndex = 41;
            this.password_label.Text = "Password:";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userName_textBox
            // 
            this.userName_textBox.BackColor = System.Drawing.Color.Silver;
            this.userName_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_textBox.Location = new System.Drawing.Point(94, 19);
            this.userName_textBox.Multiline = true;
            this.userName_textBox.Name = "userName_textBox";
            this.userName_textBox.Size = new System.Drawing.Size(179, 26);
            this.userName_textBox.TabIndex = 40;
            // 
            // user_name_label
            // 
            this.user_name_label.AutoSize = true;
            this.user_name_label.BackColor = System.Drawing.Color.Transparent;
            this.user_name_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.user_name_label.ForeColor = System.Drawing.Color.White;
            this.user_name_label.ImageKey = "(none)";
            this.user_name_label.Location = new System.Drawing.Point(6, 23);
            this.user_name_label.Name = "user_name_label";
            this.user_name_label.Size = new System.Drawing.Size(92, 18);
            this.user_name_label.TabIndex = 39;
            this.user_name_label.Text = "User Name:";
            this.user_name_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SendOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.message_textBox);
            this.Controls.Add(this.message_label);
            this.Controls.Add(this.subject_textBox);
            this.Controls.Add(this.subject_label);
            this.Controls.Add(this.company_email_label);
            this.Controls.Add(this.company_list_comboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(608, 489);
            this.MinimumSize = new System.Drawing.Size(608, 489);
            this.Name = "SendOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox company_list_comboBox;
        private System.Windows.Forms.Label company_email_label;
        private System.Windows.Forms.Label subject_label;
        private System.Windows.Forms.TextBox subject_textBox;
        private System.Windows.Forms.Label message_label;
        private System.Windows.Forms.TextBox message_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox userName_textBox;
        private System.Windows.Forms.Label user_name_label;
        private System.Windows.Forms.TextBox smtp_textBox;
        private System.Windows.Forms.Label smtp_label;
        private System.Windows.Forms.TextBox port_textBox;
        private System.Windows.Forms.Label Port_label;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.CheckBox ssl_checkBox;
    }
}
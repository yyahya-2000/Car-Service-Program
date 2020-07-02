namespace Car_Service
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.userName_textBox = new System.Windows.Forms.TextBox();
            this.uName_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.note_textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isAdmain_comboBox = new System.Windows.Forms.ComboBox();
            this.Add_User_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userName_textBox
            // 
            this.userName_textBox.BackColor = System.Drawing.Color.Silver;
            this.userName_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_textBox.Location = new System.Drawing.Point(104, 62);
            this.userName_textBox.Multiline = true;
            this.userName_textBox.Name = "userName_textBox";
            this.userName_textBox.Size = new System.Drawing.Size(280, 28);
            this.userName_textBox.TabIndex = 0;
            this.userName_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddUser_Validating);
            // 
            // uName_label
            // 
            this.uName_label.AutoSize = true;
            this.uName_label.BackColor = System.Drawing.Color.Transparent;
            this.uName_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.uName_label.ForeColor = System.Drawing.Color.White;
            this.uName_label.ImageKey = "(none)";
            this.uName_label.Location = new System.Drawing.Point(12, 63);
            this.uName_label.Name = "uName_label";
            this.uName_label.Size = new System.Drawing.Size(92, 18);
            this.uName_label.TabIndex = 36;
            this.uName_label.Text = "User Name:";
            this.uName_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.BackColor = System.Drawing.Color.Transparent;
            this.id_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.ImageKey = "(none)";
            this.id_label.Location = new System.Drawing.Point(12, 13);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(26, 18);
            this.id_label.TabIndex = 37;
            this.id_label.Text = "Id:";
            this.id_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // id_textBox
            // 
            this.id_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.id_textBox.Font = new System.Drawing.Font("Palatia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.id_textBox.ForeColor = System.Drawing.Color.Black;
            this.id_textBox.Location = new System.Drawing.Point(104, 12);
            this.id_textBox.Multiline = true;
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.ReadOnly = true;
            this.id_textBox.Size = new System.Drawing.Size(280, 28);
            this.id_textBox.TabIndex = 38;
            this.id_textBox.Text = "                                        New";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Is Admain:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // note_textBox2
            // 
            this.note_textBox2.BackColor = System.Drawing.Color.Silver;
            this.note_textBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note_textBox2.Location = new System.Drawing.Point(104, 204);
            this.note_textBox2.Multiline = true;
            this.note_textBox2.Name = "note_textBox2";
            this.note_textBox2.Size = new System.Drawing.Size(280, 28);
            this.note_textBox2.TabIndex = 3;
            this.note_textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.AddUser_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageKey = "(none)";
            this.label2.Location = new System.Drawing.Point(12, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Note:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // password_textBox
            // 
            this.password_textBox.BackColor = System.Drawing.Color.Silver;
            this.password_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.Location = new System.Drawing.Point(104, 108);
            this.password_textBox.Multiline = true;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(280, 28);
            this.password_textBox.TabIndex = 1;
            this.password_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddUser_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageKey = "(none)";
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // isAdmain_comboBox
            // 
            this.isAdmain_comboBox.BackColor = System.Drawing.Color.Silver;
            this.isAdmain_comboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAdmain_comboBox.FormattingEnabled = true;
            this.isAdmain_comboBox.Items.AddRange(new object[] {
            "true",
            "false"});
            this.isAdmain_comboBox.Location = new System.Drawing.Point(104, 162);
            this.isAdmain_comboBox.Name = "isAdmain_comboBox";
            this.isAdmain_comboBox.Size = new System.Drawing.Size(280, 24);
            this.isAdmain_comboBox.TabIndex = 2;
            this.isAdmain_comboBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddUser_Validating);
            // 
            // Add_User_button
            // 
            this.Add_User_button.BackColor = System.Drawing.Color.Transparent;
            this.Add_User_button.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Add_User_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.Add_User_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Add_User_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_User_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Add_User_button.ForeColor = System.Drawing.Color.White;
            this.Add_User_button.Location = new System.Drawing.Point(251, 249);
            this.Add_User_button.Name = "Add_User_button";
            this.Add_User_button.Size = new System.Drawing.Size(133, 36);
            this.Add_User_button.TabIndex = 4;
            this.Add_User_button.Tag = "";
            this.Add_User_button.Text = "Add";
            this.Add_User_button.UseCompatibleTextRendering = true;
            this.Add_User_button.UseVisualStyleBackColor = false;
            this.Add_User_button.Click += new System.EventHandler(this.Add_User_button_Click);
            this.Add_User_button.MouseEnter += new System.EventHandler(this.Add_Employee_button_MouseEnter);
            this.Add_User_button.MouseLeave += new System.EventHandler(this.Add_Employee_button_MouseLeave);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(396, 297);
            this.Controls.Add(this.Add_User_button);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(412, 336);
            this.MinimumSize = new System.Drawing.Size(412, 336);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add User";
            this.Validating += new System.ComponentModel.CancelEventHandler(this.AddUser_Validating);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName_textBox;
        private System.Windows.Forms.Label uName_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox note_textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox isAdmain_comboBox;
        private System.Windows.Forms.Button Add_User_button;
    }
}
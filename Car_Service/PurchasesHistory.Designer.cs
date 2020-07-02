namespace Car_Service
{
    partial class PurchasesHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasesHistory));
            this.purchasesGridView = new System.Windows.Forms.DataGridView();
            this.search_groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.to_dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.from_dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.On_off_checkBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ownerName_textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serName_textBox = new System.Windows.Forms.TextBox();
            this.serName_label = new System.Windows.Forms.Label();
            this.Delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesGridView)).BeginInit();
            this.search_groupBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // purchasesGridView
            // 
            this.purchasesGridView.AllowUserToAddRows = false;
            this.purchasesGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.purchasesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.purchasesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchasesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchasesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.purchasesGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.purchasesGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchasesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.purchasesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasesGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchasesGridView.Location = new System.Drawing.Point(262, 0);
            this.purchasesGridView.MultiSelect = false;
            this.purchasesGridView.Name = "purchasesGridView";
            this.purchasesGridView.ReadOnly = true;
            this.purchasesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchasesGridView.Size = new System.Drawing.Size(681, 528);
            this.purchasesGridView.TabIndex = 3;
            this.purchasesGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SalesGridView_MouseDoubleClick);
            // 
            // search_groupBox1
            // 
            this.search_groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.search_groupBox1.Controls.Add(this.groupBox1);
            this.search_groupBox1.Controls.Add(this.ownerName_textBox1);
            this.search_groupBox1.Controls.Add(this.label1);
            this.search_groupBox1.Controls.Add(this.serName_textBox);
            this.search_groupBox1.Controls.Add(this.serName_label);
            this.search_groupBox1.Font = new System.Drawing.Font("Palatia", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.search_groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.search_groupBox1.Location = new System.Drawing.Point(12, 12);
            this.search_groupBox1.Name = "search_groupBox1";
            this.search_groupBox1.Size = new System.Drawing.Size(244, 292);
            this.search_groupBox1.TabIndex = 4;
            this.search_groupBox1.TabStop = false;
            this.search_groupBox1.Text = "Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.to_dateTimePicker2);
            this.groupBox1.Controls.Add(this.from_dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.On_off_checkBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 154);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date:";
            // 
            // to_dateTimePicker2
            // 
            this.to_dateTimePicker2.CalendarFont = new System.Drawing.Font("Palatia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.to_dateTimePicker2.Enabled = false;
            this.to_dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.to_dateTimePicker2.Location = new System.Drawing.Point(3, 122);
            this.to_dateTimePicker2.Name = "to_dateTimePicker2";
            this.to_dateTimePicker2.Size = new System.Drawing.Size(216, 21);
            this.to_dateTimePicker2.TabIndex = 34;
            this.to_dateTimePicker2.Value = new System.DateTime(2099, 12, 25, 23, 59, 59, 0);
            this.to_dateTimePicker2.ValueChanged += new System.EventHandler(this.To_dateTimePicker2_ValueChanged);
            // 
            // from_dateTimePicker1
            // 
            this.from_dateTimePicker1.CalendarFont = new System.Drawing.Font("Palatia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.from_dateTimePicker1.Enabled = false;
            this.from_dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.from_dateTimePicker1.Location = new System.Drawing.Point(3, 76);
            this.from_dateTimePicker1.Name = "from_dateTimePicker1";
            this.from_dateTimePicker1.Size = new System.Drawing.Size(216, 21);
            this.from_dateTimePicker1.TabIndex = 33;
            this.from_dateTimePicker1.Value = new System.DateTime(1900, 1, 25, 23, 59, 59, 0);
            this.from_dateTimePicker1.ValueChanged += new System.EventHandler(this.To_dateTimePicker2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageKey = "(none)";
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "To:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // On_off_checkBox
            // 
            this.On_off_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.On_off_checkBox.AutoSize = true;
            this.On_off_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.On_off_checkBox.Location = new System.Drawing.Point(6, 26);
            this.On_off_checkBox.Name = "On_off_checkBox";
            this.On_off_checkBox.Size = new System.Drawing.Size(60, 17);
            this.On_off_checkBox.TabIndex = 30;
            this.On_off_checkBox.Text = "On_Off";
            this.On_off_checkBox.UseVisualStyleBackColor = true;
            this.On_off_checkBox.CheckedChanged += new System.EventHandler(this.On_off_checkBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageKey = "(none)";
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "from:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ownerName_textBox1
            // 
            this.ownerName_textBox1.BackColor = System.Drawing.Color.Silver;
            this.ownerName_textBox1.Location = new System.Drawing.Point(6, 96);
            this.ownerName_textBox1.Name = "ownerName_textBox1";
            this.ownerName_textBox1.Size = new System.Drawing.Size(228, 27);
            this.ownerName_textBox1.TabIndex = 30;
            this.ownerName_textBox1.TextChanged += new System.EventHandler(this.OwnerName_textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Owner Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // serName_textBox
            // 
            this.serName_textBox.BackColor = System.Drawing.Color.Silver;
            this.serName_textBox.Location = new System.Drawing.Point(6, 45);
            this.serName_textBox.Name = "serName_textBox";
            this.serName_textBox.Size = new System.Drawing.Size(228, 27);
            this.serName_textBox.TabIndex = 28;
            this.serName_textBox.TextChanged += new System.EventHandler(this.OwnerName_textBox1_TextChanged);
            // 
            // serName_label
            // 
            this.serName_label.AutoSize = true;
            this.serName_label.BackColor = System.Drawing.Color.Transparent;
            this.serName_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.serName_label.ForeColor = System.Drawing.Color.White;
            this.serName_label.ImageKey = "(none)";
            this.serName_label.Location = new System.Drawing.Point(6, 24);
            this.serName_label.Name = "serName_label";
            this.serName_label.Size = new System.Drawing.Size(135, 18);
            this.serName_label.TabIndex = 27;
            this.serName_label.Text = "Company Name:";
            this.serName_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Delete_button
            // 
            this.Delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete_button.BackColor = System.Drawing.Color.Transparent;
            this.Delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_button.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Delete_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.Delete_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Italic);
            this.Delete_button.ForeColor = System.Drawing.Color.White;
            this.Delete_button.Location = new System.Drawing.Point(12, 476);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(234, 40);
            this.Delete_button.TabIndex = 113;
            this.Delete_button.Tag = "";
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseCompatibleTextRendering = true;
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            this.Delete_button.MouseEnter += new System.EventHandler(this.Delete_button_MouseEnter);
            this.Delete_button.MouseLeave += new System.EventHandler(this.Delete_button_MouseLeave);
            // 
            // PurchasesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(943, 528);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.search_groupBox1);
            this.Controls.Add(this.purchasesGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(959, 567);
            this.Name = "PurchasesHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchases History";
            ((System.ComponentModel.ISupportInitialize)(this.purchasesGridView)).EndInit();
            this.search_groupBox1.ResumeLayout(false);
            this.search_groupBox1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView purchasesGridView;
        private System.Windows.Forms.GroupBox search_groupBox1;
        private System.Windows.Forms.TextBox serName_textBox;
        private System.Windows.Forms.Label serName_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ownerName_textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker to_dateTimePicker2;
        private System.Windows.Forms.DateTimePicker from_dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox On_off_checkBox;
        private System.Windows.Forms.Button Delete_button;
    }
}
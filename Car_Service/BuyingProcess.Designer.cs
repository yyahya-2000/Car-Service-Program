namespace Car_Service
{
    partial class BuyingProcess
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyingProcess));
            this.dataToolsGridView = new System.Windows.Forms.DataGridView();
            this.AddTool = new System.Windows.Forms.Button();
            this.tools_services_label = new System.Windows.Forms.Label();
            this.quantity_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Show_all_tools_checkBox = new System.Windows.Forms.CheckBox();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buying_list_dataGridView = new System.Windows.Forms.DataGridView();
            this.total_label = new System.Windows.Forms.Label();
            this.Buy_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serName_textBox1 = new System.Windows.Forms.TextBox();
            this.toolUnit_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.total_textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataToolsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buying_list_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataToolsGridView
            // 
            this.dataToolsGridView.AllowUserToAddRows = false;
            this.dataToolsGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataToolsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataToolsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataToolsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataToolsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataToolsGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.dataToolsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataToolsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataToolsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataToolsGridView.Location = new System.Drawing.Point(1, 49);
            this.dataToolsGridView.MultiSelect = false;
            this.dataToolsGridView.Name = "dataToolsGridView";
            this.dataToolsGridView.ReadOnly = true;
            this.dataToolsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataToolsGridView.Size = new System.Drawing.Size(799, 199);
            this.dataToolsGridView.TabIndex = 1;
            // 
            // AddTool
            // 
            this.AddTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddTool.BackColor = System.Drawing.Color.Transparent;
            this.AddTool.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.AddTool.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.AddTool.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTool.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.AddTool.ForeColor = System.Drawing.Color.White;
            this.AddTool.Location = new System.Drawing.Point(8, 310);
            this.AddTool.Name = "AddTool";
            this.AddTool.Size = new System.Drawing.Size(154, 36);
            this.AddTool.TabIndex = 2;
            this.AddTool.Tag = "";
            this.AddTool.Text = "Add";
            this.AddTool.UseCompatibleTextRendering = true;
            this.AddTool.UseVisualStyleBackColor = false;
            this.AddTool.Click += new System.EventHandler(this.AddTool_button_Click);
            this.AddTool.MouseEnter += new System.EventHandler(this.AddTool_MouseEnter);
            this.AddTool.MouseLeave += new System.EventHandler(this.AddTool_MouseLeave);
            // 
            // tools_services_label
            // 
            this.tools_services_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tools_services_label.BackColor = System.Drawing.Color.Transparent;
            this.tools_services_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tools_services_label.ForeColor = System.Drawing.Color.White;
            this.tools_services_label.ImageKey = "(none)";
            this.tools_services_label.Location = new System.Drawing.Point(-2, 256);
            this.tools_services_label.Name = "tools_services_label";
            this.tools_services_label.Size = new System.Drawing.Size(102, 28);
            this.tools_services_label.TabIndex = 26;
            this.tools_services_label.Text = "quantity:";
            this.tools_services_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quantity_numericUpDown
            // 
            this.quantity_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quantity_numericUpDown.BackColor = System.Drawing.Color.Teal;
            this.quantity_numericUpDown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_numericUpDown.Location = new System.Drawing.Point(106, 256);
            this.quantity_numericUpDown.Name = "quantity_numericUpDown";
            this.quantity_numericUpDown.Size = new System.Drawing.Size(56, 23);
            this.quantity_numericUpDown.TabIndex = 1;
            // 
            // Show_all_tools_checkBox
            // 
            this.Show_all_tools_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Show_all_tools_checkBox.AutoSize = true;
            this.Show_all_tools_checkBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Show_all_tools_checkBox.ForeColor = System.Drawing.Color.White;
            this.Show_all_tools_checkBox.Location = new System.Drawing.Point(12, 282);
            this.Show_all_tools_checkBox.Name = "Show_all_tools_checkBox";
            this.Show_all_tools_checkBox.Size = new System.Drawing.Size(129, 22);
            this.Show_all_tools_checkBox.TabIndex = 29;
            this.Show_all_tools_checkBox.Text = "Show All Tools";
            this.Show_all_tools_checkBox.UseVisualStyleBackColor = true;
            this.Show_all_tools_checkBox.CheckedChanged += new System.EventHandler(this.Show_all_tools_checkBox_CheckedChanged);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete me";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // ToolUnit
            // 
            this.ToolUnit.HeaderText = "ToolUnit";
            this.ToolUnit.Name = "ToolUnit";
            this.ToolUnit.ReadOnly = true;
            // 
            // ToolName
            // 
            this.ToolName.HeaderText = "Tool Name";
            this.ToolName.Name = "ToolName";
            this.ToolName.ReadOnly = true;
            // 
            // Buying_list_dataGridView
            // 
            this.Buying_list_dataGridView.AllowUserToAddRows = false;
            this.Buying_list_dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Buying_list_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Buying_list_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buying_list_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Buying_list_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Buying_list_dataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.Buying_list_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Buying_list_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Buying_list_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Buying_list_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ToolName,
            this.ToolUnit,
            this.Price,
            this.Quantity,
            this.Note,
            this.Delete});
            this.Buying_list_dataGridView.Location = new System.Drawing.Point(168, 254);
            this.Buying_list_dataGridView.MultiSelect = false;
            this.Buying_list_dataGridView.Name = "Buying_list_dataGridView";
            this.Buying_list_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Buying_list_dataGridView.Size = new System.Drawing.Size(632, 198);
            this.Buying_list_dataGridView.TabIndex = 31;
            this.Buying_list_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Buying_list_dataGridView_CellClick);
            // 
            // total_label
            // 
            this.total_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.total_label.AutoSize = true;
            this.total_label.BackColor = System.Drawing.Color.Transparent;
            this.total_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.total_label.ForeColor = System.Drawing.Color.White;
            this.total_label.ImageKey = "(none)";
            this.total_label.Location = new System.Drawing.Point(5, 391);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(107, 18);
            this.total_label.TabIndex = 32;
            this.total_label.Text = "Total Amount:";
            this.total_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Buy_button
            // 
            this.Buy_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Buy_button.BackColor = System.Drawing.Color.Transparent;
            this.Buy_button.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Buy_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.Buy_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Buy_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buy_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Buy_button.ForeColor = System.Drawing.Color.White;
            this.Buy_button.Location = new System.Drawing.Point(8, 352);
            this.Buy_button.Name = "Buy_button";
            this.Buy_button.Size = new System.Drawing.Size(154, 36);
            this.Buy_button.TabIndex = 3;
            this.Buy_button.Tag = "";
            this.Buy_button.Text = "Buy";
            this.Buy_button.UseCompatibleTextRendering = true;
            this.Buy_button.UseVisualStyleBackColor = false;
            this.Buy_button.Click += new System.EventHandler(this.Buy_button_Click);
            this.Buy_button.MouseEnter += new System.EventHandler(this.Buy_button_MouseEnter);
            this.Buy_button.MouseLeave += new System.EventHandler(this.Buy_button_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tool Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // serName_textBox1
            // 
            this.serName_textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.serName_textBox1.BackColor = System.Drawing.Color.Silver;
            this.serName_textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serName_textBox1.Location = new System.Drawing.Point(106, 14);
            this.serName_textBox1.Multiline = true;
            this.serName_textBox1.Name = "serName_textBox1";
            this.serName_textBox1.Size = new System.Drawing.Size(256, 25);
            this.serName_textBox1.TabIndex = 0;
            this.serName_textBox1.TextChanged += new System.EventHandler(this.ToolUnit_textBox1_TextChanged);
            // 
            // toolUnit_textBox1
            // 
            this.toolUnit_textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.toolUnit_textBox1.BackColor = System.Drawing.Color.Silver;
            this.toolUnit_textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolUnit_textBox1.Location = new System.Drawing.Point(520, 14);
            this.toolUnit_textBox1.Multiline = true;
            this.toolUnit_textBox1.Name = "toolUnit_textBox1";
            this.toolUnit_textBox1.Size = new System.Drawing.Size(239, 25);
            this.toolUnit_textBox1.TabIndex = 1;
            this.toolUnit_textBox1.TextChanged += new System.EventHandler(this.ToolUnit_textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageKey = "(none)";
            this.label2.Location = new System.Drawing.Point(431, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tool Unit:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.serName_textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.toolUnit_textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search:";
            // 
            // total_textBox1
            // 
            this.total_textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.total_textBox1.BackColor = System.Drawing.Color.Green;
            this.total_textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_textBox1.Location = new System.Drawing.Point(8, 413);
            this.total_textBox1.Multiline = true;
            this.total_textBox1.Name = "total_textBox1";
            this.total_textBox1.Size = new System.Drawing.Size(154, 28);
            this.total_textBox1.TabIndex = 37;
            this.total_textBox1.Text = "0.00";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel1.Location = new System.Drawing.Point(1, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 4);
            this.panel1.TabIndex = 95;
            // 
            // BuyingProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.total_textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Buy_button);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.Buying_list_dataGridView);
            this.Controls.Add(this.Show_all_tools_checkBox);
            this.Controls.Add(this.quantity_numericUpDown);
            this.Controls.Add(this.tools_services_label);
            this.Controls.Add(this.AddTool);
            this.Controls.Add(this.dataToolsGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuyingProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buying Process";
            ((System.ComponentModel.ISupportInitialize)(this.dataToolsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buying_list_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataToolsGridView;
        private System.Windows.Forms.Button AddTool;
        private System.Windows.Forms.Label tools_services_label;
        private System.Windows.Forms.NumericUpDown quantity_numericUpDown;
        private System.Windows.Forms.CheckBox Show_all_tools_checkBox;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolName;
        public System.Windows.Forms.DataGridView Buying_list_dataGridView;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Button Buy_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serName_textBox1;
        private System.Windows.Forms.TextBox toolUnit_textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox total_textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
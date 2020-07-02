namespace Car_Service
{
    partial class ChoiceUsedTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceUsedTools));
            this.GetInvoice_button = new System.Windows.Forms.Button();
            this.selling_list_dataGridView = new System.Windows.Forms.DataGridView();
            this.ToolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.quantity_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tools_services_label = new System.Windows.Forms.Label();
            this.AddTool = new System.Windows.Forms.Button();
            this.toolsDataToolsGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serName_textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolUnit_textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.note_textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.selling_list_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsDataToolsGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetInvoice_button
            // 
            this.GetInvoice_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GetInvoice_button.BackColor = System.Drawing.Color.Transparent;
            this.GetInvoice_button.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.GetInvoice_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.GetInvoice_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GetInvoice_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetInvoice_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.GetInvoice_button.ForeColor = System.Drawing.Color.White;
            this.GetInvoice_button.Location = new System.Drawing.Point(12, 487);
            this.GetInvoice_button.Name = "GetInvoice_button";
            this.GetInvoice_button.Size = new System.Drawing.Size(163, 36);
            this.GetInvoice_button.TabIndex = 3;
            this.GetInvoice_button.Tag = "";
            this.GetInvoice_button.Text = "Get Invoice";
            this.GetInvoice_button.UseCompatibleTextRendering = true;
            this.GetInvoice_button.UseVisualStyleBackColor = false;
            this.GetInvoice_button.Click += new System.EventHandler(this.GetInvoice_button_Click);
            this.GetInvoice_button.MouseEnter += new System.EventHandler(this.GetInvoice_button_MouseEnter);
            this.GetInvoice_button.MouseLeave += new System.EventHandler(this.GetInvoice_button_MouseLeave);
            // 
            // selling_list_dataGridView
            // 
            this.selling_list_dataGridView.AllowUserToAddRows = false;
            this.selling_list_dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(129)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.selling_list_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.selling_list_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selling_list_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.selling_list_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.selling_list_dataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.selling_list_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selling_list_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selling_list_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ToolName,
            this.ToolUnit,
            this.Price,
            this.Quantity,
            this.Note,
            this.Delete});
            this.selling_list_dataGridView.Location = new System.Drawing.Point(182, 273);
            this.selling_list_dataGridView.MultiSelect = false;
            this.selling_list_dataGridView.Name = "selling_list_dataGridView";
            this.selling_list_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selling_list_dataGridView.Size = new System.Drawing.Size(721, 261);
            this.selling_list_dataGridView.TabIndex = 39;
            this.selling_list_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Selling_list_dataGridView_CellClick);
            // 
            // ToolName
            // 
            this.ToolName.HeaderText = "Tool Name";
            this.ToolName.Name = "ToolName";
            this.ToolName.ReadOnly = true;
            // 
            // ToolUnit
            // 
            this.ToolUnit.HeaderText = "ToolUnit";
            this.ToolUnit.Name = "ToolUnit";
            this.ToolUnit.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete me";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // quantity_numericUpDown
            // 
            this.quantity_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quantity_numericUpDown.BackColor = System.Drawing.Color.Teal;
            this.quantity_numericUpDown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_numericUpDown.Location = new System.Drawing.Point(122, 274);
            this.quantity_numericUpDown.Name = "quantity_numericUpDown";
            this.quantity_numericUpDown.Size = new System.Drawing.Size(54, 23);
            this.quantity_numericUpDown.TabIndex = 1;
            // 
            // tools_services_label
            // 
            this.tools_services_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tools_services_label.BackColor = System.Drawing.Color.Transparent;
            this.tools_services_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tools_services_label.ForeColor = System.Drawing.Color.White;
            this.tools_services_label.ImageKey = "(none)";
            this.tools_services_label.Location = new System.Drawing.Point(-1, 273);
            this.tools_services_label.Name = "tools_services_label";
            this.tools_services_label.Size = new System.Drawing.Size(102, 28);
            this.tools_services_label.TabIndex = 36;
            this.tools_services_label.Text = "quantity:";
            this.tools_services_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.AddTool.Location = new System.Drawing.Point(12, 445);
            this.AddTool.Name = "AddTool";
            this.AddTool.Size = new System.Drawing.Size(164, 36);
            this.AddTool.TabIndex = 2;
            this.AddTool.Tag = "";
            this.AddTool.Text = "Add";
            this.AddTool.UseCompatibleTextRendering = true;
            this.AddTool.UseVisualStyleBackColor = false;
            this.AddTool.Click += new System.EventHandler(this.AddTool_Click);
            this.AddTool.MouseEnter += new System.EventHandler(this.AddTool_MouseEnter);
            this.AddTool.MouseLeave += new System.EventHandler(this.AddTool_MouseLeave);
            // 
            // toolsDataToolsGridView
            // 
            this.toolsDataToolsGridView.AllowUserToAddRows = false;
            this.toolsDataToolsGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(129)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.toolsDataToolsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.toolsDataToolsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolsDataToolsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.toolsDataToolsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.toolsDataToolsGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.toolsDataToolsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toolsDataToolsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toolsDataToolsGridView.Location = new System.Drawing.Point(0, 45);
            this.toolsDataToolsGridView.MultiSelect = false;
            this.toolsDataToolsGridView.Name = "toolsDataToolsGridView";
            this.toolsDataToolsGridView.ReadOnly = true;
            this.toolsDataToolsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolsDataToolsGridView.Size = new System.Drawing.Size(903, 218);
            this.toolsDataToolsGridView.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.serName_textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.toolUnit_textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(2, -3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(901, 42);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search:";
            // 
            // serName_textBox1
            // 
            this.serName_textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.serName_textBox1.BackColor = System.Drawing.Color.Silver;
            this.serName_textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serName_textBox1.Location = new System.Drawing.Point(96, 11);
            this.serName_textBox1.Multiline = true;
            this.serName_textBox1.Name = "serName_textBox1";
            this.serName_textBox1.Size = new System.Drawing.Size(293, 25);
            this.serName_textBox1.TabIndex = 0;
            this.serName_textBox1.TextChanged += new System.EventHandler(this.ToolUnit_textBox1_TextChanged);
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
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tool Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolUnit_textBox1
            // 
            this.toolUnit_textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.toolUnit_textBox1.BackColor = System.Drawing.Color.Silver;
            this.toolUnit_textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolUnit_textBox1.Location = new System.Drawing.Point(560, 12);
            this.toolUnit_textBox1.Multiline = true;
            this.toolUnit_textBox1.Name = "toolUnit_textBox1";
            this.toolUnit_textBox1.Size = new System.Drawing.Size(330, 25);
            this.toolUnit_textBox1.TabIndex = 1;
            this.toolUnit_textBox1.TextChanged += new System.EventHandler(this.ToolUnit_textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageKey = "(none)";
            this.label3.Location = new System.Drawing.Point(471, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tool Unit:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(8, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Add Note:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // note_textBox1
            // 
            this.note_textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.note_textBox1.BackColor = System.Drawing.Color.Silver;
            this.note_textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note_textBox1.ForeColor = System.Drawing.Color.Black;
            this.note_textBox1.Location = new System.Drawing.Point(11, 334);
            this.note_textBox1.Multiline = true;
            this.note_textBox1.Name = "note_textBox1";
            this.note_textBox1.Size = new System.Drawing.Size(164, 90);
            this.note_textBox1.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel1.Location = new System.Drawing.Point(2, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 4);
            this.panel1.TabIndex = 96;
            // 
            // ChoiceUsedTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(904, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.note_textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GetInvoice_button);
            this.Controls.Add(this.selling_list_dataGridView);
            this.Controls.Add(this.quantity_numericUpDown);
            this.Controls.Add(this.tools_services_label);
            this.Controls.Add(this.AddTool);
            this.Controls.Add(this.toolsDataToolsGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(920, 574);
            this.Name = "ChoiceUsedTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choice Used Tools";
            ((System.ComponentModel.ISupportInitialize)(this.selling_list_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsDataToolsGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetInvoice_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.NumericUpDown quantity_numericUpDown;
        private System.Windows.Forms.Label tools_services_label;
        private System.Windows.Forms.Button AddTool;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox serName_textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox toolUnit_textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView selling_list_dataGridView;
        private System.Windows.Forms.DataGridView toolsDataToolsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox note_textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
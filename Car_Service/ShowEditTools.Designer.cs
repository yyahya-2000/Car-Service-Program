namespace Car_Service
{
    partial class ShowEditTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowEditTools));
            this.dataToolsGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.current_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.min_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._label = new System.Windows.Forms.Label();
            this.max_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.id_label = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.unit_textBox = new System.Windows.Forms.TextBox();
            this.sellPrice_textBox = new System.Windows.Forms.TextBox();
            this.purchasePrice_textBox = new System.Windows.Forms.TextBox();
            this.note_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.note_label = new System.Windows.Forms.Label();
            this.purchasePrice_label = new System.Windows.Forms.Label();
            this.sellPrice_label = new System.Windows.Forms.Label();
            this.unit_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serName_textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolUnit_textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataToolsGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.current_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_numericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataToolsGridView
            // 
            this.dataToolsGridView.AllowUserToAddRows = false;
            this.dataToolsGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataToolsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataToolsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataToolsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataToolsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataToolsGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.dataToolsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataToolsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataToolsGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataToolsGridView.Location = new System.Drawing.Point(256, 50);
            this.dataToolsGridView.MultiSelect = false;
            this.dataToolsGridView.Name = "dataToolsGridView";
            this.dataToolsGridView.ReadOnly = true;
            this.dataToolsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataToolsGridView.Size = new System.Drawing.Size(614, 488);
            this.dataToolsGridView.TabIndex = 1;
            this.dataToolsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataToolsGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.current_numericUpDown);
            this.groupBox1.Controls.Add(this.min_numericUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._label);
            this.groupBox1.Controls.Add(this.max_numericUpDown);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 93);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quantity";
            // 
            // current_numericUpDown
            // 
            this.current_numericUpDown.BackColor = System.Drawing.Color.Silver;
            this.current_numericUpDown.Enabled = false;
            this.current_numericUpDown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_numericUpDown.Location = new System.Drawing.Point(175, 21);
            this.current_numericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.current_numericUpDown.Name = "current_numericUpDown";
            this.current_numericUpDown.Size = new System.Drawing.Size(56, 23);
            this.current_numericUpDown.TabIndex = 0;
            // 
            // min_numericUpDown
            // 
            this.min_numericUpDown.BackColor = System.Drawing.Color.Silver;
            this.min_numericUpDown.Enabled = false;
            this.min_numericUpDown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_numericUpDown.Location = new System.Drawing.Point(56, 60);
            this.min_numericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.min_numericUpDown.Name = "min_numericUpDown";
            this.min_numericUpDown.Size = new System.Drawing.Size(56, 23);
            this.min_numericUpDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Min:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageKey = "(none)";
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 73;
            this.label2.Text = "Current:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.BackColor = System.Drawing.Color.Transparent;
            this._label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this._label.ForeColor = System.Drawing.Color.White;
            this._label.ImageKey = "(none)";
            this._label.Location = new System.Drawing.Point(126, 61);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(44, 18);
            this._label.TabIndex = 65;
            this._label.Text = "Max:";
            this._label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // max_numericUpDown
            // 
            this.max_numericUpDown.BackColor = System.Drawing.Color.Silver;
            this.max_numericUpDown.Enabled = false;
            this.max_numericUpDown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_numericUpDown.Location = new System.Drawing.Point(175, 60);
            this.max_numericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.max_numericUpDown.Name = "max_numericUpDown";
            this.max_numericUpDown.Size = new System.Drawing.Size(56, 23);
            this.max_numericUpDown.TabIndex = 2;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.BackColor = System.Drawing.Color.Transparent;
            this.id_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.ImageKey = "(none)";
            this.id_label.Location = new System.Drawing.Point(3, 13);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(26, 18);
            this.id_label.TabIndex = 81;
            this.id_label.Text = "Id:";
            this.id_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // id_textBox
            // 
            this.id_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.id_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_textBox.ForeColor = System.Drawing.Color.Black;
            this.id_textBox.Location = new System.Drawing.Point(3, 32);
            this.id_textBox.Multiline = true;
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.ReadOnly = true;
            this.id_textBox.Size = new System.Drawing.Size(245, 28);
            this.id_textBox.TabIndex = 75;
            // 
            // unit_textBox
            // 
            this.unit_textBox.BackColor = System.Drawing.Color.Silver;
            this.unit_textBox.Enabled = false;
            this.unit_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_textBox.Location = new System.Drawing.Point(3, 136);
            this.unit_textBox.Multiline = true;
            this.unit_textBox.Name = "unit_textBox";
            this.unit_textBox.Size = new System.Drawing.Size(245, 29);
            this.unit_textBox.TabIndex = 69;
            this.unit_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Name_textBox_Validating);
            // 
            // sellPrice_textBox
            // 
            this.sellPrice_textBox.BackColor = System.Drawing.Color.Silver;
            this.sellPrice_textBox.Enabled = false;
            this.sellPrice_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellPrice_textBox.Location = new System.Drawing.Point(3, 189);
            this.sellPrice_textBox.Multiline = true;
            this.sellPrice_textBox.Name = "sellPrice_textBox";
            this.sellPrice_textBox.Size = new System.Drawing.Size(245, 28);
            this.sellPrice_textBox.TabIndex = 70;
            this.sellPrice_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Name_textBox_Validating);
            // 
            // purchasePrice_textBox
            // 
            this.purchasePrice_textBox.BackColor = System.Drawing.Color.Silver;
            this.purchasePrice_textBox.Enabled = false;
            this.purchasePrice_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasePrice_textBox.Location = new System.Drawing.Point(3, 245);
            this.purchasePrice_textBox.Multiline = true;
            this.purchasePrice_textBox.Name = "purchasePrice_textBox";
            this.purchasePrice_textBox.Size = new System.Drawing.Size(245, 29);
            this.purchasePrice_textBox.TabIndex = 71;
            this.purchasePrice_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Name_textBox_Validating);
            // 
            // note_textBox
            // 
            this.note_textBox.BackColor = System.Drawing.Color.Silver;
            this.note_textBox.Enabled = false;
            this.note_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note_textBox.Location = new System.Drawing.Point(3, 298);
            this.note_textBox.Multiline = true;
            this.note_textBox.Name = "note_textBox";
            this.note_textBox.Size = new System.Drawing.Size(245, 28);
            this.note_textBox.TabIndex = 72;
            this.note_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Name_textBox_Validating);
            // 
            // name_textBox
            // 
            this.name_textBox.BackColor = System.Drawing.Color.Silver;
            this.name_textBox.Enabled = false;
            this.name_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textBox.Location = new System.Drawing.Point(3, 84);
            this.name_textBox.Multiline = true;
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(245, 28);
            this.name_textBox.TabIndex = 68;
            this.name_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Name_textBox_Validating);
            // 
            // note_label
            // 
            this.note_label.AutoSize = true;
            this.note_label.BackColor = System.Drawing.Color.Transparent;
            this.note_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.note_label.ForeColor = System.Drawing.Color.White;
            this.note_label.ImageKey = "(none)";
            this.note_label.Location = new System.Drawing.Point(3, 277);
            this.note_label.Name = "note_label";
            this.note_label.Size = new System.Drawing.Size(47, 18);
            this.note_label.TabIndex = 80;
            this.note_label.Text = "Note:";
            this.note_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // purchasePrice_label
            // 
            this.purchasePrice_label.AutoSize = true;
            this.purchasePrice_label.BackColor = System.Drawing.Color.Transparent;
            this.purchasePrice_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.purchasePrice_label.ForeColor = System.Drawing.Color.White;
            this.purchasePrice_label.ImageKey = "(none)";
            this.purchasePrice_label.Location = new System.Drawing.Point(3, 224);
            this.purchasePrice_label.Name = "purchasePrice_label";
            this.purchasePrice_label.Size = new System.Drawing.Size(120, 18);
            this.purchasePrice_label.TabIndex = 79;
            this.purchasePrice_label.Text = "Purchase Price:";
            this.purchasePrice_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sellPrice_label
            // 
            this.sellPrice_label.AutoSize = true;
            this.sellPrice_label.BackColor = System.Drawing.Color.Transparent;
            this.sellPrice_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.sellPrice_label.ForeColor = System.Drawing.Color.White;
            this.sellPrice_label.ImageKey = "(none)";
            this.sellPrice_label.Location = new System.Drawing.Point(3, 168);
            this.sellPrice_label.Name = "sellPrice_label";
            this.sellPrice_label.Size = new System.Drawing.Size(79, 18);
            this.sellPrice_label.TabIndex = 78;
            this.sellPrice_label.Text = "Sell Price:";
            this.sellPrice_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // unit_label
            // 
            this.unit_label.AutoSize = true;
            this.unit_label.BackColor = System.Drawing.Color.Transparent;
            this.unit_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.unit_label.ForeColor = System.Drawing.Color.White;
            this.unit_label.ImageKey = "(none)";
            this.unit_label.Location = new System.Drawing.Point(3, 115);
            this.unit_label.Name = "unit_label";
            this.unit_label.Size = new System.Drawing.Size(39, 18);
            this.unit_label.TabIndex = 77;
            this.unit_label.Text = "Unit:";
            this.unit_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.ImageKey = "(none)";
            this.name_label.Location = new System.Drawing.Point(3, 63);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(91, 18);
            this.name_label.TabIndex = 76;
            this.name_label.Text = "Tool Name:";
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
            this.Delete_button.Location = new System.Drawing.Point(3, 492);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(244, 40);
            this.Delete_button.TabIndex = 83;
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
            this.Edit_button.Location = new System.Drawing.Point(3, 444);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(244, 42);
            this.Edit_button.TabIndex = 82;
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
            this.groupBox2.Controls.Add(this.toolUnit_textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(256, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 42);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search:";
            // 
            // serName_textBox1
            // 
            this.serName_textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.serName_textBox1.BackColor = System.Drawing.Color.Silver;
            this.serName_textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serName_textBox1.Location = new System.Drawing.Point(96, 13);
            this.serName_textBox1.Multiline = true;
            this.serName_textBox1.Name = "serName_textBox1";
            this.serName_textBox1.Size = new System.Drawing.Size(197, 23);
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
            this.label4.Location = new System.Drawing.Point(6, 13);
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
            this.toolUnit_textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolUnit_textBox1.Location = new System.Drawing.Point(411, 13);
            this.toolUnit_textBox1.Multiline = true;
            this.toolUnit_textBox1.Name = "toolUnit_textBox1";
            this.toolUnit_textBox1.Size = new System.Drawing.Size(185, 22);
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
            this.label3.Location = new System.Drawing.Point(322, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tool Unit:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShowEditTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(870, 539);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.unit_textBox);
            this.Controls.Add(this.sellPrice_textBox);
            this.Controls.Add(this.purchasePrice_textBox);
            this.Controls.Add(this.note_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.note_label);
            this.Controls.Add(this.purchasePrice_label);
            this.Controls.Add(this.sellPrice_label);
            this.Controls.Add(this.unit_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.dataToolsGridView);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowEditTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show & Edit Tools";
            ((System.ComponentModel.ISupportInitialize)(this.dataToolsGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.current_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_numericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown current_numericUpDown;
        private System.Windows.Forms.NumericUpDown min_numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.NumericUpDown max_numericUpDown;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox unit_textBox;
        private System.Windows.Forms.TextBox sellPrice_textBox;
        private System.Windows.Forms.TextBox purchasePrice_textBox;
        private System.Windows.Forms.TextBox note_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label note_label;
        private System.Windows.Forms.Label purchasePrice_label;
        private System.Windows.Forms.Label sellPrice_label;
        private System.Windows.Forms.Label unit_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.DataGridView dataToolsGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox serName_textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox toolUnit_textBox1;
        private System.Windows.Forms.Label label3;
    }
}
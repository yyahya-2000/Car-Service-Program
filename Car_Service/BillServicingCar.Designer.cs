namespace Car_Service
{
    partial class BillServicingCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillServicingCar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_label2 = new System.Windows.Forms.Label();
            this.phone_label2 = new System.Windows.Forms.Label();
            this.identification_label = new System.Windows.Forms.Label();
            this.sName_label3 = new System.Windows.Forms.Label();
            this.fName_label = new System.Windows.Forms.Label();
            this.adress_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.note_textBox1 = new System.Windows.Forms.TextBox();
            this.note_label5 = new System.Windows.Forms.Label();
            this.carModel_label4 = new System.Windows.Forms.Label();
            this.carColor_label3 = new System.Windows.Forms.Label();
            this.CarType_label2 = new System.Windows.Forms.Label();
            this.car_number_label4 = new System.Windows.Forms.Label();
            this.entry_label = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bill_list_dataGridView = new System.Windows.Forms.DataGridView();
            this.ToolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.total_textBox2 = new System.Windows.Forms.TextBox();
            this.exit_label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bill_list_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 57);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 37);
            this.label1.TabIndex = 105;
            this.label1.Text = "Invoice";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.id_label2);
            this.groupBox1.Controls.Add(this.phone_label2);
            this.groupBox1.Controls.Add(this.identification_label);
            this.groupBox1.Controls.Add(this.sName_label3);
            this.groupBox1.Controls.Add(this.fName_label);
            this.groupBox1.Controls.Add(this.adress_label);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Costomer Data";
            // 
            // id_label2
            // 
            this.id_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.id_label2.AutoSize = true;
            this.id_label2.BackColor = System.Drawing.Color.Transparent;
            this.id_label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.id_label2.ForeColor = System.Drawing.Color.Black;
            this.id_label2.ImageKey = "(none)";
            this.id_label2.Location = new System.Drawing.Point(6, 23);
            this.id_label2.Name = "id_label2";
            this.id_label2.Size = new System.Drawing.Size(26, 18);
            this.id_label2.TabIndex = 5;
            this.id_label2.Text = "Id:";
            this.id_label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // phone_label2
            // 
            this.phone_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.phone_label2.AutoSize = true;
            this.phone_label2.BackColor = System.Drawing.Color.Transparent;
            this.phone_label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.phone_label2.ForeColor = System.Drawing.Color.Black;
            this.phone_label2.ImageKey = "(none)";
            this.phone_label2.Location = new System.Drawing.Point(6, 109);
            this.phone_label2.Name = "phone_label2";
            this.phone_label2.Size = new System.Drawing.Size(121, 18);
            this.phone_label2.TabIndex = 2;
            this.phone_label2.Text = "Phone Number:";
            this.phone_label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // identification_label
            // 
            this.identification_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.identification_label.AutoSize = true;
            this.identification_label.BackColor = System.Drawing.Color.Transparent;
            this.identification_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.identification_label.ForeColor = System.Drawing.Color.Black;
            this.identification_label.ImageKey = "(none)";
            this.identification_label.Location = new System.Drawing.Point(6, 166);
            this.identification_label.Name = "identification_label";
            this.identification_label.Size = new System.Drawing.Size(108, 18);
            this.identification_label.TabIndex = 4;
            this.identification_label.Text = "Identification:";
            this.identification_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sName_label3
            // 
            this.sName_label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sName_label3.AutoSize = true;
            this.sName_label3.BackColor = System.Drawing.Color.Transparent;
            this.sName_label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.sName_label3.ForeColor = System.Drawing.Color.Black;
            this.sName_label3.ImageKey = "(none)";
            this.sName_label3.Location = new System.Drawing.Point(6, 81);
            this.sName_label3.Name = "sName_label3";
            this.sName_label3.Size = new System.Drawing.Size(118, 18);
            this.sName_label3.TabIndex = 1;
            this.sName_label3.Text = "Second Name:";
            this.sName_label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fName_label
            // 
            this.fName_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fName_label.AutoSize = true;
            this.fName_label.BackColor = System.Drawing.Color.Transparent;
            this.fName_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.fName_label.ForeColor = System.Drawing.Color.Black;
            this.fName_label.ImageKey = "(none)";
            this.fName_label.Location = new System.Drawing.Point(6, 52);
            this.fName_label.Name = "fName_label";
            this.fName_label.Size = new System.Drawing.Size(87, 18);
            this.fName_label.TabIndex = 0;
            this.fName_label.Text = "First Name:";
            this.fName_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adress_label
            // 
            this.adress_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.adress_label.AutoSize = true;
            this.adress_label.BackColor = System.Drawing.Color.Transparent;
            this.adress_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.adress_label.ForeColor = System.Drawing.Color.Black;
            this.adress_label.ImageKey = "(none)";
            this.adress_label.Location = new System.Drawing.Point(6, 138);
            this.adress_label.Name = "adress_label";
            this.adress_label.Size = new System.Drawing.Size(70, 18);
            this.adress_label.TabIndex = 3;
            this.adress_label.Text = "Address:";
            this.adress_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.note_textBox1);
            this.groupBox2.Controls.Add(this.note_label5);
            this.groupBox2.Controls.Add(this.carModel_label4);
            this.groupBox2.Controls.Add(this.carColor_label3);
            this.groupBox2.Controls.Add(this.CarType_label2);
            this.groupBox2.Controls.Add(this.car_number_label4);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(488, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoice Data";
            // 
            // note_textBox1
            // 
            this.note_textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.note_textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.note_textBox1.Location = new System.Drawing.Point(57, 133);
            this.note_textBox1.Multiline = true;
            this.note_textBox1.Name = "note_textBox1";
            this.note_textBox1.ReadOnly = true;
            this.note_textBox1.Size = new System.Drawing.Size(312, 60);
            this.note_textBox1.TabIndex = 111;
            // 
            // note_label5
            // 
            this.note_label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.note_label5.AutoSize = true;
            this.note_label5.BackColor = System.Drawing.Color.Transparent;
            this.note_label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.note_label5.ForeColor = System.Drawing.Color.Black;
            this.note_label5.ImageKey = "(none)";
            this.note_label5.Location = new System.Drawing.Point(6, 137);
            this.note_label5.Name = "note_label5";
            this.note_label5.Size = new System.Drawing.Size(47, 18);
            this.note_label5.TabIndex = 110;
            this.note_label5.Text = "Note:";
            this.note_label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // carModel_label4
            // 
            this.carModel_label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carModel_label4.AutoSize = true;
            this.carModel_label4.BackColor = System.Drawing.Color.Transparent;
            this.carModel_label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.carModel_label4.ForeColor = System.Drawing.Color.Black;
            this.carModel_label4.ImageKey = "(none)";
            this.carModel_label4.Location = new System.Drawing.Point(6, 109);
            this.carModel_label4.Name = "carModel_label4";
            this.carModel_label4.Size = new System.Drawing.Size(91, 18);
            this.carModel_label4.TabIndex = 3;
            this.carModel_label4.Text = "Car Model:";
            this.carModel_label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // carColor_label3
            // 
            this.carColor_label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carColor_label3.AutoSize = true;
            this.carColor_label3.BackColor = System.Drawing.Color.Transparent;
            this.carColor_label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.carColor_label3.ForeColor = System.Drawing.Color.Black;
            this.carColor_label3.ImageKey = "(none)";
            this.carColor_label3.Location = new System.Drawing.Point(6, 80);
            this.carColor_label3.Name = "carColor_label3";
            this.carColor_label3.Size = new System.Drawing.Size(84, 18);
            this.carColor_label3.TabIndex = 2;
            this.carColor_label3.Text = "Car Color:";
            this.carColor_label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CarType_label2
            // 
            this.CarType_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarType_label2.AutoSize = true;
            this.CarType_label2.BackColor = System.Drawing.Color.Transparent;
            this.CarType_label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.CarType_label2.ForeColor = System.Drawing.Color.Black;
            this.CarType_label2.ImageKey = "(none)";
            this.CarType_label2.Location = new System.Drawing.Point(6, 52);
            this.CarType_label2.Name = "CarType_label2";
            this.CarType_label2.Size = new System.Drawing.Size(78, 18);
            this.CarType_label2.TabIndex = 1;
            this.CarType_label2.Text = "Car Type:";
            this.CarType_label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // car_number_label4
            // 
            this.car_number_label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.car_number_label4.AutoSize = true;
            this.car_number_label4.BackColor = System.Drawing.Color.Transparent;
            this.car_number_label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.car_number_label4.ForeColor = System.Drawing.Color.Black;
            this.car_number_label4.ImageKey = "(none)";
            this.car_number_label4.Location = new System.Drawing.Point(6, 23);
            this.car_number_label4.Name = "car_number_label4";
            this.car_number_label4.Size = new System.Drawing.Size(102, 18);
            this.car_number_label4.TabIndex = 0;
            this.car_number_label4.Text = "Car Number:";
            this.car_number_label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // entry_label
            // 
            this.entry_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.entry_label.AutoSize = true;
            this.entry_label.BackColor = System.Drawing.Color.Transparent;
            this.entry_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.entry_label.ForeColor = System.Drawing.Color.Black;
            this.entry_label.ImageKey = "(none)";
            this.entry_label.Location = new System.Drawing.Point(595, 538);
            this.entry_label.Name = "entry_label";
            this.entry_label.Size = new System.Drawing.Size(86, 18);
            this.entry_label.TabIndex = 109;
            this.entry_label.Text = "Entry Date:";
            this.entry_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.bill_list_dataGridView);
            this.groupBox3.Font = new System.Drawing.Font("Palatia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox3.Location = new System.Drawing.Point(7, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(850, 207);
            this.groupBox3.TabIndex = 107;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Tools";
            // 
            // bill_list_dataGridView
            // 
            this.bill_list_dataGridView.AllowUserToAddRows = false;
            this.bill_list_dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.bill_list_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bill_list_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bill_list_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bill_list_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.bill_list_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bill_list_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bill_list_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bill_list_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ToolName,
            this.ToolUnit,
            this.Price,
            this.Quantity});
            this.bill_list_dataGridView.Location = new System.Drawing.Point(5, 17);
            this.bill_list_dataGridView.Name = "bill_list_dataGridView";
            this.bill_list_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bill_list_dataGridView.Size = new System.Drawing.Size(839, 184);
            this.bill_list_dataGridView.TabIndex = 40;
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
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageKey = "(none)";
            this.label6.Location = new System.Drawing.Point(-3, 563);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 116;
            this.label6.Text = "Total Amount:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // total_textBox2
            // 
            this.total_textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.total_textBox2.BackColor = System.Drawing.Color.Yellow;
            this.total_textBox2.Font = new System.Drawing.Font("Palatia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.total_textBox2.Location = new System.Drawing.Point(158, 564);
            this.total_textBox2.Name = "total_textBox2";
            this.total_textBox2.ReadOnly = true;
            this.total_textBox2.Size = new System.Drawing.Size(121, 27);
            this.total_textBox2.TabIndex = 0;
            // 
            // exit_label7
            // 
            this.exit_label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_label7.AutoSize = true;
            this.exit_label7.BackColor = System.Drawing.Color.Transparent;
            this.exit_label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.exit_label7.ForeColor = System.Drawing.Color.Black;
            this.exit_label7.ImageKey = "(none)";
            this.exit_label7.Location = new System.Drawing.Point(595, 567);
            this.exit_label7.Name = "exit_label7";
            this.exit_label7.Size = new System.Drawing.Size(75, 18);
            this.exit_label7.TabIndex = 112;
            this.exit_label7.Text = "Exit Date:";
            this.exit_label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BillServicingCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 596);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.exit_label7);
            this.Controls.Add(this.total_textBox2);
            this.Controls.Add(this.entry_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(891, 635);
            this.Name = "BillServicingCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Servicing Car";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bill_list_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label phone_label2;
        private System.Windows.Forms.Label identification_label;
        private System.Windows.Forms.Label sName_label3;
        private System.Windows.Forms.Label fName_label;
        private System.Windows.Forms.Label adress_label;
        private System.Windows.Forms.Label entry_label;
        private System.Windows.Forms.Label car_number_label4;
        private System.Windows.Forms.Label note_label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox total_textBox2;
        private System.Windows.Forms.Label exit_label7;
        private System.Windows.Forms.Label carModel_label4;
        private System.Windows.Forms.Label carColor_label3;
        private System.Windows.Forms.Label CarType_label2;
        private System.Windows.Forms.DataGridView bill_list_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Label id_label2;
        private System.Windows.Forms.TextBox note_textBox1;
    }
}
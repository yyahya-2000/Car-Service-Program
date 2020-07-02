namespace Car_Service
{
    partial class PurchaseInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseInvoice));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bill_list_dataGridView = new System.Windows.Forms.DataGridView();
            this.ToolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_textBox2 = new System.Windows.Forms.TextBox();
            this.date_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.compOwnerlabel2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.id_label2 = new System.Windows.Forms.Label();
            this.phone_label2 = new System.Windows.Forms.Label();
            this.email_label3 = new System.Windows.Forms.Label();
            this.compName_label = new System.Windows.Forms.Label();
            this.adress_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bill_list_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.bill_list_dataGridView);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(7, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(750, 290);
            this.groupBox3.TabIndex = 121;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Tools";
            // 
            // bill_list_dataGridView
            // 
            this.bill_list_dataGridView.AllowUserToAddRows = false;
            this.bill_list_dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.bill_list_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bill_list_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bill_list_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bill_list_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.bill_list_dataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.bill_list_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bill_list_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bill_list_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bill_list_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ToolName,
            this.ToolUnit,
            this.Price,
            this.Quantity});
            this.bill_list_dataGridView.Location = new System.Drawing.Point(5, 23);
            this.bill_list_dataGridView.Name = "bill_list_dataGridView";
            this.bill_list_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bill_list_dataGridView.Size = new System.Drawing.Size(739, 261);
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
            // total_textBox2
            // 
            this.total_textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.total_textBox2.BackColor = System.Drawing.Color.Yellow;
            this.total_textBox2.Font = new System.Drawing.Font("Palatia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.total_textBox2.Location = new System.Drawing.Point(161, 523);
            this.total_textBox2.Name = "total_textBox2";
            this.total_textBox2.ReadOnly = true;
            this.total_textBox2.Size = new System.Drawing.Size(86, 27);
            this.total_textBox2.TabIndex = 125;
            // 
            // date_label
            // 
            this.date_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.date_label.AutoSize = true;
            this.date_label.BackColor = System.Drawing.Color.Transparent;
            this.date_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.date_label.ForeColor = System.Drawing.Color.Black;
            this.date_label.ImageKey = "(none)";
            this.date_label.Location = new System.Drawing.Point(539, 526);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(47, 18);
            this.date_label.TabIndex = 122;
            this.date_label.Text = "Date:";
            this.date_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageKey = "(none)";
            this.label6.Location = new System.Drawing.Point(3, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 124;
            this.label6.Text = "Total Amount:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.compOwnerlabel2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.id_label2);
            this.groupBox1.Controls.Add(this.phone_label2);
            this.groupBox1.Controls.Add(this.email_label3);
            this.groupBox1.Controls.Add(this.compName_label);
            this.groupBox1.Controls.Add(this.adress_label);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 113);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Data";
            // 
            // compOwnerlabel2
            // 
            this.compOwnerlabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.compOwnerlabel2.AutoSize = true;
            this.compOwnerlabel2.BackColor = System.Drawing.Color.Transparent;
            this.compOwnerlabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.compOwnerlabel2.ForeColor = System.Drawing.Color.Black;
            this.compOwnerlabel2.ImageKey = "(none)";
            this.compOwnerlabel2.Location = new System.Drawing.Point(6, 85);
            this.compOwnerlabel2.Name = "compOwnerlabel2";
            this.compOwnerlabel2.Size = new System.Drawing.Size(139, 18);
            this.compOwnerlabel2.TabIndex = 121;
            this.compOwnerlabel2.Text = "Company Owner:";
            this.compOwnerlabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(355, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 113);
            this.panel2.TabIndex = 120;
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
            this.phone_label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.phone_label2.AutoSize = true;
            this.phone_label2.BackColor = System.Drawing.Color.Transparent;
            this.phone_label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.phone_label2.ForeColor = System.Drawing.Color.Black;
            this.phone_label2.ImageKey = "(none)";
            this.phone_label2.Location = new System.Drawing.Point(382, 23);
            this.phone_label2.Name = "phone_label2";
            this.phone_label2.Size = new System.Drawing.Size(121, 18);
            this.phone_label2.TabIndex = 2;
            this.phone_label2.Text = "Phone Number:";
            this.phone_label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // email_label3
            // 
            this.email_label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.email_label3.AutoSize = true;
            this.email_label3.BackColor = System.Drawing.Color.Transparent;
            this.email_label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.email_label3.ForeColor = System.Drawing.Color.Black;
            this.email_label3.ImageKey = "(none)";
            this.email_label3.Location = new System.Drawing.Point(382, 85);
            this.email_label3.Name = "email_label3";
            this.email_label3.Size = new System.Drawing.Size(130, 18);
            this.email_label3.TabIndex = 1;
            this.email_label3.Text = "Company Email:";
            this.email_label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // compName_label
            // 
            this.compName_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.compName_label.AutoSize = true;
            this.compName_label.BackColor = System.Drawing.Color.Transparent;
            this.compName_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.compName_label.ForeColor = System.Drawing.Color.Black;
            this.compName_label.ImageKey = "(none)";
            this.compName_label.Location = new System.Drawing.Point(6, 53);
            this.compName_label.Name = "compName_label";
            this.compName_label.Size = new System.Drawing.Size(135, 18);
            this.compName_label.TabIndex = 0;
            this.compName_label.Text = "Company Name:";
            this.compName_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adress_label
            // 
            this.adress_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.adress_label.AutoSize = true;
            this.adress_label.BackColor = System.Drawing.Color.Transparent;
            this.adress_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.adress_label.ForeColor = System.Drawing.Color.Black;
            this.adress_label.ImageKey = "(none)";
            this.adress_label.Location = new System.Drawing.Point(382, 53);
            this.adress_label.Name = "adress_label";
            this.adress_label.Size = new System.Drawing.Size(148, 18);
            this.adress_label.TabIndex = 3;
            this.adress_label.Text = "Company Address:";
            this.adress_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 57);
            this.panel1.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(322, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 37);
            this.label1.TabIndex = 105;
            this.label1.Text = "Invoice";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 557);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.total_textBox2);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(793, 596);
            this.Name = "PurchaseInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Invoice";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bill_list_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView bill_list_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.TextBox total_textBox2;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label id_label2;
        private System.Windows.Forms.Label phone_label2;
        private System.Windows.Forms.Label email_label3;
        private System.Windows.Forms.Label compName_label;
        private System.Windows.Forms.Label adress_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label compOwnerlabel2;
    }
}
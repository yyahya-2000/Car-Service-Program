namespace Car_Service
{
    partial class CarRegisters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRegisters));
            this.dataToolsGridView = new System.Windows.Forms.DataGridView();
            this.Repair_button = new System.Windows.Forms.Button();
            this.Delete_button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataToolsGridView)).BeginInit();
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
            this.dataToolsGridView.Location = new System.Drawing.Point(1, 1);
            this.dataToolsGridView.MultiSelect = false;
            this.dataToolsGridView.Name = "dataToolsGridView";
            this.dataToolsGridView.ReadOnly = true;
            this.dataToolsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataToolsGridView.Size = new System.Drawing.Size(593, 352);
            this.dataToolsGridView.TabIndex = 5;
            // 
            // Repair_button
            // 
            this.Repair_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Repair_button.BackColor = System.Drawing.Color.Transparent;
            this.Repair_button.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Repair_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.Repair_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Repair_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Repair_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Repair_button.ForeColor = System.Drawing.Color.White;
            this.Repair_button.Location = new System.Drawing.Point(428, 359);
            this.Repair_button.Name = "Repair_button";
            this.Repair_button.Size = new System.Drawing.Size(155, 36);
            this.Repair_button.TabIndex = 6;
            this.Repair_button.Tag = "";
            this.Repair_button.Text = "Repair";
            this.Repair_button.UseCompatibleTextRendering = true;
            this.Repair_button.UseVisualStyleBackColor = false;
            this.Repair_button.Click += new System.EventHandler(this.Repair_button_Click);
            this.Repair_button.MouseEnter += new System.EventHandler(this.Repair_button_MouseEnter);
            this.Repair_button.MouseLeave += new System.EventHandler(this.Repair_button_MouseLeave);
            // 
            // Delete_button1
            // 
            this.Delete_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_button1.BackColor = System.Drawing.Color.Transparent;
            this.Delete_button1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Delete_button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.Delete_button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Delete_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Delete_button1.ForeColor = System.Drawing.Color.White;
            this.Delete_button1.Location = new System.Drawing.Point(267, 359);
            this.Delete_button1.Name = "Delete_button1";
            this.Delete_button1.Size = new System.Drawing.Size(155, 36);
            this.Delete_button1.TabIndex = 7;
            this.Delete_button1.Tag = "";
            this.Delete_button1.Text = "Delete";
            this.Delete_button1.UseCompatibleTextRendering = true;
            this.Delete_button1.UseVisualStyleBackColor = false;
            this.Delete_button1.Click += new System.EventHandler(this.Delete_button1_Click);
            this.Delete_button1.MouseEnter += new System.EventHandler(this.Delete_button1_MouseEnter);
            this.Delete_button1.MouseLeave += new System.EventHandler(this.Delete_button1_MouseLeave);
            // 
            // CarDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(595, 407);
            this.Controls.Add(this.Delete_button1);
            this.Controls.Add(this.Repair_button);
            this.Controls.Add(this.dataToolsGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Registers";
            ((System.ComponentModel.ISupportInitialize)(this.dataToolsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataToolsGridView;
        private System.Windows.Forms.Button Repair_button;
        private System.Windows.Forms.Button Delete_button1;
    }
}
namespace Car_Service
{
    partial class AddTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTool));
            this.AddTool_button = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.unit_textBox = new System.Windows.Forms.TextBox();
            this.sellPrice_textBox = new System.Windows.Forms.TextBox();
            this.purchasePrice_textBox = new System.Windows.Forms.TextBox();
            this.note_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.note_label = new System.Windows.Forms.Label();
            this._label = new System.Windows.Forms.Label();
            this.purchasePrice_label = new System.Windows.Forms.Label();
            this.sellPrice_label = new System.Windows.Forms.Label();
            this.unit_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.max_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.min_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.current_numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.max_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_numericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.current_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTool_button
            // 
            this.AddTool_button.BackColor = System.Drawing.Color.Transparent;
            this.AddTool_button.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.AddTool_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(70, 68, 53);
            this.AddTool_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddTool_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTool_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.AddTool_button.ForeColor = System.Drawing.Color.White;
            this.AddTool_button.Location = new System.Drawing.Point(303, 402);
            this.AddTool_button.Name = "AddTool_button";
            this.AddTool_button.Size = new System.Drawing.Size(133, 36);
            this.AddTool_button.TabIndex = 6;
            this.AddTool_button.Tag = "";
            this.AddTool_button.Text = "Add";
            this.AddTool_button.UseCompatibleTextRendering = true;
            this.AddTool_button.UseVisualStyleBackColor = false;
            this.AddTool_button.Click += new System.EventHandler(this.AddTool_button_Click);
            this.AddTool_button.MouseEnter += new System.EventHandler(this.AddTool_button_MouseEnter);
            this.AddTool_button.MouseLeave += new System.EventHandler(this.AddTool_button_MouseLeave);
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
            this.id_label.TabIndex = 67;
            this.id_label.Text = "Id:";
            this.id_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // id_textBox
            // 
            this.id_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.id_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_textBox.ForeColor = System.Drawing.Color.Black;
            this.id_textBox.Location = new System.Drawing.Point(138, 12);
            this.id_textBox.Multiline = true;
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.ReadOnly = true;
            this.id_textBox.Size = new System.Drawing.Size(298, 28);
            this.id_textBox.TabIndex = 52;
            this.id_textBox.Text = "                                New";
            // 
            // unit_textBox
            // 
            this.unit_textBox.BackColor = System.Drawing.Color.Silver;
            this.unit_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_textBox.ForeColor = System.Drawing.Color.Black;
            this.unit_textBox.Location = new System.Drawing.Point(138, 114);
            this.unit_textBox.Multiline = true;
            this.unit_textBox.Name = "unit_textBox";
            this.unit_textBox.Size = new System.Drawing.Size(298, 28);
            this.unit_textBox.TabIndex = 1;
            this.unit_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Name_textBox_Validating);
            // 
            // sellPrice_textBox
            // 
            this.sellPrice_textBox.BackColor = System.Drawing.Color.Silver;
            this.sellPrice_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellPrice_textBox.ForeColor = System.Drawing.Color.Black;
            this.sellPrice_textBox.Location = new System.Drawing.Point(138, 167);
            this.sellPrice_textBox.Multiline = true;
            this.sellPrice_textBox.Name = "sellPrice_textBox";
            this.sellPrice_textBox.Size = new System.Drawing.Size(298, 28);
            this.sellPrice_textBox.TabIndex = 2;
            this.sellPrice_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Name_textBox_Validating);
            // 
            // purchasePrice_textBox
            // 
            this.purchasePrice_textBox.BackColor = System.Drawing.Color.Silver;
            this.purchasePrice_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasePrice_textBox.ForeColor = System.Drawing.Color.Black;
            this.purchasePrice_textBox.Location = new System.Drawing.Point(138, 223);
            this.purchasePrice_textBox.Multiline = true;
            this.purchasePrice_textBox.Name = "purchasePrice_textBox";
            this.purchasePrice_textBox.Size = new System.Drawing.Size(298, 28);
            this.purchasePrice_textBox.TabIndex = 3;
            this.purchasePrice_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Name_textBox_Validating);
            // 
            // note_textBox
            // 
            this.note_textBox.BackColor = System.Drawing.Color.Silver;
            this.note_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note_textBox.ForeColor = System.Drawing.Color.Black;
            this.note_textBox.Location = new System.Drawing.Point(138, 276);
            this.note_textBox.Multiline = true;
            this.note_textBox.Name = "note_textBox";
            this.note_textBox.Size = new System.Drawing.Size(298, 28);
            this.note_textBox.TabIndex = 4;
            this.note_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Name_textBox_Validating);
            // 
            // name_textBox
            // 
            this.name_textBox.BackColor = System.Drawing.Color.Silver;
            this.name_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textBox.ForeColor = System.Drawing.Color.Black;
            this.name_textBox.Location = new System.Drawing.Point(138, 62);
            this.name_textBox.Multiline = true;
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(298, 28);
            this.name_textBox.TabIndex = 0;
            this.name_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Name_textBox_Validating);
            // 
            // note_label
            // 
            this.note_label.AutoSize = true;
            this.note_label.BackColor = System.Drawing.Color.Transparent;
            this.note_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.note_label.ForeColor = System.Drawing.Color.White;
            this.note_label.ImageKey = "(none)";
            this.note_label.Location = new System.Drawing.Point(12, 277);
            this.note_label.Name = "note_label";
            this.note_label.Size = new System.Drawing.Size(47, 18);
            this.note_label.TabIndex = 66;
            this.note_label.Text = "Note:";
            this.note_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.BackColor = System.Drawing.Color.Transparent;
            this._label.ForeColor = System.Drawing.Color.White;
            this._label.ImageKey = "(none)";
            this._label.Location = new System.Drawing.Point(291, 38);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(44, 18);
            this._label.TabIndex = 65;
            this._label.Text = "Max:";
            this._label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // purchasePrice_label
            // 
            this.purchasePrice_label.AutoSize = true;
            this.purchasePrice_label.BackColor = System.Drawing.Color.Transparent;
            this.purchasePrice_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.purchasePrice_label.ForeColor = System.Drawing.Color.White;
            this.purchasePrice_label.ImageKey = "(none)";
            this.purchasePrice_label.Location = new System.Drawing.Point(12, 224);
            this.purchasePrice_label.Name = "purchasePrice_label";
            this.purchasePrice_label.Size = new System.Drawing.Size(120, 18);
            this.purchasePrice_label.TabIndex = 63;
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
            this.sellPrice_label.Location = new System.Drawing.Point(12, 168);
            this.sellPrice_label.Name = "sellPrice_label";
            this.sellPrice_label.Size = new System.Drawing.Size(79, 18);
            this.sellPrice_label.TabIndex = 62;
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
            this.unit_label.Location = new System.Drawing.Point(12, 115);
            this.unit_label.Name = "unit_label";
            this.unit_label.Size = new System.Drawing.Size(39, 18);
            this.unit_label.TabIndex = 61;
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
            this.name_label.Location = new System.Drawing.Point(12, 63);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(91, 18);
            this.name_label.TabIndex = 60;
            this.name_label.Text = "Tool Name:";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(173, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Min:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // max_numericUpDown
            // 
            this.max_numericUpDown.BackColor = System.Drawing.Color.Silver;
            this.max_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.max_numericUpDown.ForeColor = System.Drawing.Color.Black;
            this.max_numericUpDown.Location = new System.Drawing.Point(341, 38);
            this.max_numericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.max_numericUpDown.Name = "max_numericUpDown";
            this.max_numericUpDown.Size = new System.Drawing.Size(56, 23);
            this.max_numericUpDown.TabIndex = 2;
            // 
            // min_numericUpDown
            // 
            this.min_numericUpDown.BackColor = System.Drawing.Color.Silver;
            this.min_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.min_numericUpDown.ForeColor = System.Drawing.Color.Black;
            this.min_numericUpDown.Location = new System.Drawing.Point(218, 38);
            this.min_numericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.min_numericUpDown.Name = "min_numericUpDown";
            this.min_numericUpDown.Size = new System.Drawing.Size(56, 23);
            this.min_numericUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageKey = "(none)";
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 73;
            this.label2.Text = "Current:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.current_numericUpDown);
            this.groupBox1.Controls.Add(this.max_numericUpDown);
            this.groupBox1.Controls.Add(this.min_numericUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._label);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quantity";
            // 
            // current_numericUpDown
            // 
            this.current_numericUpDown.BackColor = System.Drawing.Color.Silver;
            this.current_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.current_numericUpDown.ForeColor = System.Drawing.Color.Black;
            this.current_numericUpDown.Location = new System.Drawing.Point(84, 38);
            this.current_numericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.current_numericUpDown.Name = "current_numericUpDown";
            this.current_numericUpDown.Size = new System.Drawing.Size(56, 23);
            this.current_numericUpDown.TabIndex = 0;
            // 
            // AddTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddTool_button);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(467, 489);
            this.MinimumSize = new System.Drawing.Size(467, 489);
            this.Name = "AddTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Tool";
            ((System.ComponentModel.ISupportInitialize)(this.max_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_numericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.current_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTool_button;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox unit_textBox;
        private System.Windows.Forms.TextBox sellPrice_textBox;
        private System.Windows.Forms.TextBox purchasePrice_textBox;
        private System.Windows.Forms.TextBox note_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label note_label;
        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.Label purchasePrice_label;
        private System.Windows.Forms.Label sellPrice_label;
        private System.Windows.Forms.Label unit_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown max_numericUpDown;
        private System.Windows.Forms.NumericUpDown min_numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown current_numericUpDown;
    }
}
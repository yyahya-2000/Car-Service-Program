using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataBasesLibrary;

namespace Car_Service
{
    public partial class AddTool : Form
    {
        //constrocter
        public AddTool()
        {
            InitializeComponent();//F12 to see the functions of this method
        }

        /// <summary>
        /// button click event to add tool to datebase 
        /// </summary>
        private void AddTool_button_Click(object sender, EventArgs e)
        {

            /*
            * testing the input data
            */
            if (IsFullData() && !HasQuotationChar() && CheckQuantity() && CheckPrices() && !Exist())
            {
                try
                {
                    //creat list from user input
                    List<string> tool = new List<string>() { name_textBox.Text, unit_textBox.Text,
                         sellPrice_textBox.Text, purchasePrice_textBox.Text, current_numericUpDown.Value.ToString(),
                         max_numericUpDown.Value.ToString(),min_numericUpDown.Value.ToString(),note_textBox.Text};
                    ToolsDatabase toolsData = new ToolsDatabase();
                    //send list to ToolsDatabase.AddData method in order to add this tool's data to database
                    toolsData.AddData(tool);
                    MessageBox.Show($"The tool was added successfully.", "Successful Operation",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanBoxes();//clean the boxes from previous input

                }
                catch (SqlException)
                {
                    MessageBox.Show($"Could not get the DataBase!!", "Unsuccessful Operation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        /// <summary>
        /// check if employee's input data already exists in database
        /// </summary>
        /// <returns>true if input data already exists in database, false if not</returns>
        private bool Exist()
        {
            try
            {
                ToolsDatabase toolsData = new ToolsDatabase();
                if (toolsData.GetSpecificRow(name_textBox.Text, unit_textBox.Text).Count > 0)
                {
                    MessageBox.Show($"This tool already exist in you database!!", "Unsuccessful Operation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show($"Could not get the DataBase!!", "Unsuccessful Operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return false;
        }

        /// <summary>
        /// check if input has quotation mark
        /// </summary>
        /// <returns></returns>
        private bool HasQuotationChar()
        {
            if (name_textBox.Text.Contains("'") || unit_textBox.Text.Contains("'") ||
                note_textBox.Text.Contains("'"))
            {
                MessageBox.Show($"Unclosed quotation mark after the character ( ' )!!", "Unsuccessful Operation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        /// <summary>
        /// check the type and the logical of entering prices
        /// </summary>
        /// <returns></returns>
        private bool CheckPrices()
        {
            if (double.TryParse(sellPrice_textBox.Text, out double sell) && double.TryParse(purchasePrice_textBox.Text, out double purchase))
            {
                if (sell >= purchase)
                    return true;
                //if selling price lower than  purchase the user will be asked about that (it might be a typo)
                else if (DialogResult.Yes == MessageBox.Show("Are you sure that you will sell this tool at a lower price than purchase price ?",
                    "Strange Input", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                    return true;
                return false;
            }
            else
            {
                MessageBox.Show($"Prices boxes can't contain a char!!", "Unsuccessful Operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        /// <summary>
        /// check the logical of tool's quantity input
        /// </summary>
        /// <returns>true for logical input, fasle for not</returns>
        private bool CheckQuantity()
        {
            if (current_numericUpDown.Value <= max_numericUpDown.Value && min_numericUpDown.Value <= max_numericUpDown.Value)
                return true;
            MessageBox.Show($"The order of quantity is not logical!!", "Unsuccessful Operation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        /// <summary>
        /// check if boxes contain input 
        /// </summary>
        /// <returns>true for full data, and false for not</returns>
        private bool IsFullData()
        {
            if (!string.IsNullOrEmpty(name_textBox.Text.Trim()) && !string.IsNullOrEmpty(unit_textBox.Text.Trim()))
                return true;
            MessageBox.Show($"You have forgot to fill some information, please check your input!!",
                "Unsuccessful Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        /// <summary>
        /// make texts of boxes empty
        /// </summary>
        private void CleanBoxes()
        {
            name_textBox.Text = "";
            unit_textBox.Text = "";
            sellPrice_textBox.Text = "";
            purchasePrice_textBox.Text = "";
            current_numericUpDown.Value = 0;
            min_numericUpDown.Value = 0;
            max_numericUpDown.Value = 0;
            note_textBox.Text = "";
        }

        /// <summary>
        /// event fire after each change on boxes to delete extra space from first and end the input
        /// </summary>
        private void Name_textBox_Validating(object sender, CancelEventArgs e)
        {
            name_textBox.Text = name_textBox.Text.Trim();
            unit_textBox.Text = unit_textBox.Text.Trim();
            sellPrice_textBox.Text = sellPrice_textBox.Text.Trim();
            purchasePrice_textBox.Text = purchasePrice_textBox.Text.Trim();
            note_textBox.Text = note_textBox.Text.Trim();
        }

        /*
         * these two events help to make good Effects when cursor mouse enter or leave  Add_Employee_button boundaries
         */
        private void AddTool_button_MouseEnter(object sender, EventArgs e)
        {
            AddTool_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 126, 49);
            AddTool_button.ForeColor = System.Drawing.Color.FromArgb(229, 126, 49);
        }
        private void AddTool_button_MouseLeave(object sender, EventArgs e)
        {
            AddTool_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            AddTool_button.ForeColor = System.Drawing.Color.White;
        }
    }
}

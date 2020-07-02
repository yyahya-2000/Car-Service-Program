using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarServiceLibrary;
using DataBasesLibrary;

namespace Car_Service
{
    public partial class ShowEditTools : Form
    {

        DataTable table = new DataTable();
        /// <summary>
        /// constrocter
        /// </summary>
        public ShowEditTools()
        {
            InitializeComponent();//F12 to see the functions of this mehtod
            DownloadToolsData();
        }

        /// <summary>
        /// download data of tools into dataToolsGridView(table)
        /// </summary>
        private void DownloadToolsData()
        {
            try
            {
                ReadClass read = new ReadClass("Tools");
                table = read.GetDataTable();
                if (table != null)
                    dataToolsGridView.DataSource = table;
            }
            catch (SqlException)
            {
                MessageBox.Show($"couldn't get the database", "Unsuccessful operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"{ex.Message}", "Unsuccessful Operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unsuccessful Operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        /// <summary>
        /// Make Enabled of boxes true and fill the boxes by data of selected row in table
        /// </summary>
        private void EnabledAndFillBoxes()
        {
            if (table != null)
            {
                // Make Enabled of boxes true
                name_textBox.Enabled = true;
                unit_textBox.Enabled = true;
                sellPrice_textBox.Enabled = true;
                purchasePrice_textBox.Enabled = true;
                note_textBox.Enabled = true;
                current_numericUpDown.Enabled = true;
                min_numericUpDown.Enabled = true;
                max_numericUpDown.Enabled = true;
                //fill the boxes by data of selected row in table
                id_textBox.Text = dataToolsGridView.SelectedRows[0].Cells[0].Value.ToString();
                name_textBox.Text = dataToolsGridView.SelectedRows[0].Cells[1].Value.ToString();
                unit_textBox.Text = dataToolsGridView.SelectedRows[0].Cells[2].Value.ToString();
                sellPrice_textBox.Text = dataToolsGridView.SelectedRows[0].Cells[3].Value.ToString();
                purchasePrice_textBox.Text = dataToolsGridView.SelectedRows[0].Cells[4].Value.ToString();
                note_textBox.Text = dataToolsGridView.SelectedRows[0].Cells[8].Value.ToString();
                current_numericUpDown.Value = int.Parse(dataToolsGridView.SelectedRows[0].Cells[5].Value.ToString());
                min_numericUpDown.Value = int.Parse(dataToolsGridView.SelectedRows[0].Cells[7].Value.ToString());
                max_numericUpDown.Value = int.Parse(dataToolsGridView.SelectedRows[0].Cells[6].Value.ToString());

            }
        }

        /// <summary>
        /// check if Tool's input data already exists in database
        /// </summary>
        /// <returns>true if input data already exists in database, false if not</returns>
        private bool Exist()
        {
            ToolsDatabase toolsDatabase = new ToolsDatabase();
            if (toolsDatabase.GetSpecificRow(name_textBox.Text, unit_textBox.Text).Count > 0)
            {
                MessageBox.Show($"This tool already exist in you database!!", "Unsuccessful Operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        /// <summary>
        /// cell click event 
        /// </summary>
        private void DataToolsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnabledAndFillBoxes();

        }

        /// <summary>
        /// click button event to edit selected tool's data
        /// </summary>
        private void Edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsFullData() && CheckQuantity() && CheckPrices() && !Exist())
                {

                    dataToolsGridView.SelectedRows[0].Cells[0].Value = id_textBox.Text;
                    dataToolsGridView.SelectedRows[0].Cells[1].Value = name_textBox.Text;
                    dataToolsGridView.SelectedRows[0].Cells[2].Value = unit_textBox.Text;
                    dataToolsGridView.SelectedRows[0].Cells[3].Value = sellPrice_textBox.Text;
                    dataToolsGridView.SelectedRows[0].Cells[4].Value = purchasePrice_textBox.Text;
                    dataToolsGridView.SelectedRows[0].Cells[8].Value = note_textBox.Text;
                    dataToolsGridView.SelectedRows[0].Cells[5].Value = current_numericUpDown.Value;
                    dataToolsGridView.SelectedRows[0].Cells[7].Value = min_numericUpDown.Value;
                    dataToolsGridView.SelectedRows[0].Cells[6].Value = max_numericUpDown.Value;
                    List<string> row = new List<string>() { id_textBox.Text, name_textBox.Text,
                    unit_textBox.Text,sellPrice_textBox.Text, purchasePrice_textBox.Text,
                    current_numericUpDown.Value.ToString(),max_numericUpDown.Value.ToString(),
                    min_numericUpDown.Value.ToString(), note_textBox.Text};

                    ToolsDatabase tools = new ToolsDatabase();
                    tools.EditRow(row);
                    MessageBox.Show($"The tool information was edited!!", "Successful Operation",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message}", "Unsuccessful Operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// check the type and the logical of entering prices
        /// </summary>
        /// <returns></returns>
        private bool CheckPrices()
        {
            if (double.TryParse(sellPrice_textBox.Text, out double sell) &&
                double.TryParse(purchasePrice_textBox.Text, out double purchase))
            {
                if (sell >= purchase)
                    return true;
                //if selling price lower than  purchase the user will be asked about that (it might be a typo)
                else if (DialogResult.Yes == MessageBox.Show("Are you sure that you will sell this tool" +
                    " at a lower price than the purchase price ?", "Strange Editing",
               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
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
            MessageBox.Show($"The order of quantity is not logical!!", "Unsuccessful Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            MessageBox.Show($"You have forgot to fill some information, please check your input!!", "Unsuccessful Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
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


        /// <summary>
        /// click button event to delete specefic tool's data
        /// </summary>
        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (dataToolsGridView.SelectedRows.Count > 0)
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this tool ?", "Delete",
               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    DeleteFromDatabase tooldelete = new DeleteFromDatabase();
                    tooldelete.DeleteRow("Tools", dataToolsGridView.SelectedRows[0].Cells[0].Value.ToString());
                    dataToolsGridView.Rows.RemoveAt(dataToolsGridView.SelectedRows[0].Index);
                }
        }

        /// <summary>
        /// event of searching operation
        /// </summary>
        private void ToolUnit_textBox1_TextChanged(object sender, EventArgs e)
        {
            ToolsDatabase toolsDatabase = new ToolsDatabase();
            DataTable temp = new DataTable();
            if (!serName_textBox1.Text.Contains("'") && !toolUnit_textBox1.Text.Contains("'"))
            {
                temp = toolsDatabase.SearchFor(serName_textBox1.Text, toolUnit_textBox1.Text);
                dataToolsGridView.DataSource = temp;
            }
        }

        /*
         * these 4 events help to make good Effects when cursor mouse enter or leave
         * Delete_button and Edit_button boundaries
         */
        private void Edit_button_MouseEnter(object sender, EventArgs e)
        {
            Edit_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            Edit_button.ForeColor = System.Drawing.Color.DarkGreen;
        }
        private void Edit_button_MouseLeave(object sender, EventArgs e)
        {
            Edit_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Edit_button.ForeColor = System.Drawing.Color.White;
        }
        private void Delete_button_MouseEnter(object sender, EventArgs e)
        {
            Delete_button.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            Delete_button.ForeColor = System.Drawing.Color.Red;
        }
        private void Delete_button_MouseLeave(object sender, EventArgs e)
        {
            Delete_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Delete_button.ForeColor = System.Drawing.Color.White;
        }
    }
}

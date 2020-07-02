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
    public partial class ShowEditEmployees : Form
    {
        
        DataTable table = new DataTable();
        /// <summary>
        /// constrocter
        /// </summary>
        public ShowEditEmployees()
        {
            InitializeComponent();//F12 to see the functions of this mehtod
            DownloadToolsData();
        }

        /// <summary>
        /// download data of Staffs into dataEmployeesGridView(table)
        /// </summary>
        private void DownloadToolsData()
        {
            try
            {
                ReadClass read = new ReadClass("Staffs");
                table = read.GetDataTable();
                var topLeftHeaderCell = dataEmployeesGridView.TopLeftHeaderCell;
                if (table != null && topLeftHeaderCell != null)
                    dataEmployeesGridView.DataSource = table;
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
                //Make Enabled of boxes true 
                id_textBox.Enabled = true;
                employeeName_textBox.Enabled = true;
                adress_textBox.Enabled = true;
                phoneNumber_textBox.Enabled = true;
                career_textBox.Enabled = true;
                salary_textBox.Enabled = true;
                note_textBox.Enabled = true;
                //fill the boxes by data of selected row in table
                id_textBox.Text = dataEmployeesGridView.SelectedRows[0].Cells[0].Value.ToString();
                employeeName_textBox.Text = dataEmployeesGridView.SelectedRows[0].Cells[1].Value.ToString();
                adress_textBox.Text = dataEmployeesGridView.SelectedRows[0].Cells[2].Value.ToString();
                phoneNumber_textBox.Text = dataEmployeesGridView.SelectedRows[0].Cells[3].Value.ToString();
                career_textBox.Text = dataEmployeesGridView.SelectedRows[0].Cells[4].Value.ToString();
                salary_textBox.Text = dataEmployeesGridView.SelectedRows[0].Cells[5].Value.ToString();
                register_dateTimePicker.Value = DateTime.Parse(dataEmployeesGridView.SelectedRows[0].Cells[6].Value.ToString());
                note_textBox.Text = dataEmployeesGridView.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        /// <summary>
        /// click button event to edit selected employee's data
        /// </summary>
        private void Edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ISFullData() && CheckPhoneNumber() && !Exist())
                {
                    dataEmployeesGridView.SelectedRows[0].Cells[0].Value = id_textBox.Text;
                    dataEmployeesGridView.SelectedRows[0].Cells[1].Value = employeeName_textBox.Text;
                    dataEmployeesGridView.SelectedRows[0].Cells[2].Value = adress_textBox.Text;
                    dataEmployeesGridView.SelectedRows[0].Cells[3].Value = phoneNumber_textBox.Text;
                    dataEmployeesGridView.SelectedRows[0].Cells[4].Value = career_textBox.Text;
                    dataEmployeesGridView.SelectedRows[0].Cells[5].Value = salary_textBox.Text;
                    dataEmployeesGridView.SelectedRows[0].Cells[6].Value = register_dateTimePicker.Value;
                    dataEmployeesGridView.SelectedRows[0].Cells[7].Value = note_textBox.Text;
                    List<string> row = new List<string>() { id_textBox.Text, employeeName_textBox.Text,
                    adress_textBox.Text,phoneNumber_textBox.Text, career_textBox.Text,
                    salary_textBox.Text,register_dateTimePicker.Value.ToString(),
                    note_textBox.Text};

                    EmployeesDatabase employee = new EmployeesDatabase();
                    employee.EditRow(row);
                    MessageBox.Show($"The Employee information was edited!!", "successful Operation",
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
        /// check if employee's input data already exists in database
        /// </summary>
        /// <returns>true if input data already exists in database, false if not</returns>
        private bool Exist()
        {
            EmployeesDatabase _employeesDatabase = new EmployeesDatabase();
            if (_employeesDatabase.GetSpecificRow(employeeName_textBox.Text).Count > 0)
            {
                MessageBox.Show($"This Employee's name already exist in you database, Please choose another one!!", "Unsuccessful Operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        /// <summary>
        /// make sure if phonenumber box contain only possitive numbers
        /// </summary>
        /// <returns>false if phonenumber box contain char or negative number</returns>
        private bool CheckPhoneNumber()
        {
            if (uint.TryParse(phoneNumber_textBox.Text, out _))
                return true;
            MessageBox.Show($"Phone Number box can't contain a char or negative number!!",
                    "Unsuccessful Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        /// <summary>
        /// click button event to delete specefic employee's data
        /// </summary>
        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (dataEmployeesGridView.SelectedRows.Count > 0)
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this employee ?", "Delete",
              MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    DeleteFromDatabase tooldelete = new DeleteFromDatabase();
                    tooldelete.DeleteRow("Staffs", dataEmployeesGridView.SelectedRows[0].Cells[0].Value.ToString());
                    dataEmployeesGridView.Rows.RemoveAt(dataEmployeesGridView.SelectedRows[0].Index);
                }

        }

        /// <summary>
        /// event fire after each change on boxes to delete extra space from first and end the input
        /// </summary>
        private void Note_textBox_Validating(object sender, CancelEventArgs e)
        {
            employeeName_textBox.Text = employeeName_textBox.Text.Trim();
            adress_textBox.Text = adress_textBox.Text.Trim();
            phoneNumber_textBox.Text = phoneNumber_textBox.Text.Trim();
            career_textBox.Text = career_textBox.Text.Trim();
            salary_textBox.Text = salary_textBox.Text.Trim();
            note_textBox.Text = note_textBox.Text.Trim();

        }

        /// <summary>
        /// check if boxes contain input 
        /// </summary>
        /// <returns>true for full data, and false for not</returns>
        private bool ISFullData()
        {
            if (!string.IsNullOrEmpty(employeeName_textBox.Text.Trim()) && !string.IsNullOrEmpty(phoneNumber_textBox.Text.Trim()) &&
                !string.IsNullOrEmpty(adress_textBox.Text.Trim()) && !string.IsNullOrEmpty(career_textBox.Text.Trim()) &&
                !string.IsNullOrEmpty(salary_textBox.Text.Trim()))
                return true;
            MessageBox.Show($"You have forgot to fill some information, please check your input!!", "Unsuccessful Operation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        /// event of searching operation
        /// </summary>
        private void SerName_textBox1_TextChanged(object sender, EventArgs e)
        {
            EmployeesDatabase employeesDatabase = new EmployeesDatabase();
            DataTable temp = new DataTable();
            if (!serName_textBox1.Text.Contains("'"))
            {
                temp = employeesDatabase.SearchFor(serName_textBox1.Text);
                dataEmployeesGridView.DataSource = temp;
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

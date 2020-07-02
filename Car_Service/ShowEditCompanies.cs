using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataBasesLibrary;
using CarServiceLibrary;


namespace Car_Service
{
    public partial class ShowEditCompanies : Form
    {
        DataTable table = new DataTable();
        /// <summary>
        /// constrocter
        /// </summary>
        public ShowEditCompanies()
        {
            InitializeComponent();//F12 to see the functions of this mehtod
            DownloadToolsData();
        }

        /// <summary>
        /// download data of Companies into dataCompaniesGridView(table)
        /// </summary>
        private void DownloadToolsData()
        {
            try
            {
                ReadClass read = new ReadClass("Companies");
                table = read.GetDataTable();
                if (table != null)
                    dataCompaniesGridView.DataSource = table;
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
                companyName_textBox.Enabled = true;
                companyOwner_textBox.Enabled = true;
                phoneNumber_textBox.Enabled = true;
                adress_textBox.Enabled = true;
                note_textBox.Enabled = true;
                email_textBox1.Enabled = true;
                //fill the boxes by data of selected row in table
                id_textBox.Text = dataCompaniesGridView.SelectedRows[0].Cells[0].Value.ToString();
                companyName_textBox.Text = dataCompaniesGridView.SelectedRows[0].Cells[1].Value.ToString();
                companyOwner_textBox.Text = dataCompaniesGridView.SelectedRows[0].Cells[2].Value.ToString();
                phoneNumber_textBox.Text = dataCompaniesGridView.SelectedRows[0].Cells[3].Value.ToString();
                adress_textBox.Text = dataCompaniesGridView.SelectedRows[0].Cells[4].Value.ToString();
                email_textBox1.Text = dataCompaniesGridView.SelectedRows[0].Cells[5].Value.ToString();
                entryDate_dateTimePicker.Value = DateTime.Parse(dataCompaniesGridView.SelectedRows[0].Cells[6].Value.ToString());
                note_textBox.Text = dataCompaniesGridView.SelectedRows[0].Cells[7].Value.ToString();
            }

        }

        /// <summary>
        /// click button event to edit selected company data
        /// </summary>
        private void Edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ISFullData() && IsValidEmail() && CheckPhoneNumber() && !Exist())
                {
                    dataCompaniesGridView.SelectedRows[0].Cells[0].Value = id_textBox.Text;
                    dataCompaniesGridView.SelectedRows[0].Cells[1].Value = companyName_textBox.Text;
                    dataCompaniesGridView.SelectedRows[0].Cells[2].Value = companyOwner_textBox.Text;
                    dataCompaniesGridView.SelectedRows[0].Cells[3].Value = phoneNumber_textBox.Text;
                    dataCompaniesGridView.SelectedRows[0].Cells[4].Value = adress_textBox.Text;
                    dataCompaniesGridView.SelectedRows[0].Cells[7].Value = note_textBox.Text;
                    dataCompaniesGridView.SelectedRows[0].Cells[5].Value = email_textBox1.Text;
                    dataCompaniesGridView.SelectedRows[0].Cells[6].Value = entryDate_dateTimePicker.Value;

                    List<string> row = new List<string>() { id_textBox.Text, companyName_textBox.Text,
                    companyOwner_textBox.Text,phoneNumber_textBox.Text, adress_textBox.Text,
                    email_textBox1.Text,entryDate_dateTimePicker.Value.ToString(),
                    note_textBox.Text};

                    CompaniesDataBase companyEditor = new CompaniesDataBase();
                    companyEditor.EditRow(row);
                    MessageBox.Show($"The company information was edited!!", "successful Operation",
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
        /// check if company's input data already exists in database
        /// </summary>
        /// <returns>true if input data already exists in database, false if not</returns>
        private bool Exist()
        {
            CompaniesDataBase _companiesData = new CompaniesDataBase();
            if (_companiesData.GetSpecificRow(companyName_textBox.Text, companyOwner_textBox.Text).Count > 0)
            {
                MessageBox.Show($"This Company already exist in you database!!", "Unsuccessful Operation",
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
        /// check if email address input is valid or not
        /// </summary>
        bool IsValidEmail()
        {
            bool methodresult = false;
            try
            {

                var addr = new System.Net.Mail.MailAddress(email_textBox1.Text);
                methodresult = addr.Address == email_textBox1.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, please enter another one!!",
                    "Invalid Email Adress", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            return methodresult;
        }

        /// <summary>
        /// check if boxes contain input 
        /// </summary>
        /// <returns>true for full data, and false for not</returns>
        private bool ISFullData()
        {
            if (!string.IsNullOrEmpty(companyName_textBox.Text.Trim()) && !string.IsNullOrEmpty(companyOwner_textBox.Text.Trim()) &&
                !string.IsNullOrEmpty(adress_textBox.Text.Trim()) && !string.IsNullOrEmpty(email_textBox1.Text.Trim()))
                return true;
            MessageBox.Show($"You have forgot to fill some information, please check your input!!", "Unsuccessful Operation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        /// <summary>
        /// event fire after each change on boxes to delete extra space from first and end the input
        /// </summary>
        private void CompanyName_textBox_Validating(object sender, CancelEventArgs e)
        {
            companyName_textBox.Text = companyName_textBox.Text.Trim();
            companyOwner_textBox.Text = companyOwner_textBox.Text.Trim();
            phoneNumber_textBox.Text = phoneNumber_textBox.Text.Trim();
            adress_textBox.Text = adress_textBox.Text.Trim();
            email_textBox1.Text = email_textBox1.Text.Trim();
            note_textBox.Text = note_textBox.Text.Trim();
        }

        /// <summary>
        /// click button event to delete specefic data company
        /// </summary>
        private void Delete_button_Click(object sender, EventArgs e)
        {

            if (dataCompaniesGridView.SelectedRows.Count > 0)
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this Company ?", "Delete",
               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    DeleteFromDatabase tooldelete = new DeleteFromDatabase();
                    tooldelete.DeleteRow("Companies", dataCompaniesGridView.SelectedRows[0].Cells[0].Value.ToString());
                    dataCompaniesGridView.Rows.RemoveAt(dataCompaniesGridView.SelectedRows[0].Index);
                }
        }

        /// <summary>
        /// cell click event 
        /// </summary>
        private void DataToolsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnabledAndFillBoxes();
        }



        /// <summary>
        /// searching operation
        /// </summary>
        private void SerName_textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable temp = new DataTable();
            CompaniesDataBase companies = new CompaniesDataBase();
            if (!serName_textBox1.Text.Contains("'") && !serOwner_textBox1.Text.Contains("'"))
            {
                temp = companies.SearchFor(serName_textBox1.Text, serOwner_textBox1.Text);
                dataCompaniesGridView.DataSource = temp;
            }

        }
        /*
         * these 4 events help to make good Effects when cursor mouse enter or leave
         * Delete_button and Edit_button boundaries
         */
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
    }
}

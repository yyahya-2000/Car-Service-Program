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
    public partial class ShowEditUsers : Form
    {
        DataTable table = new DataTable();

        /// <summary>
        /// constrocter
        /// </summary>
        public ShowEditUsers()
        {
            InitializeComponent();
            DownloadToolsData();
        }

        /// <summary>
        /// download data of users into datausersGridView(table)
        /// </summary>
        private void DownloadToolsData()
        {
            try
            {
                ReadClass read = new ReadClass("users");
                table = read.GetDataTable();
                var topLeftHeaderCell = datausersGridView.TopLeftHeaderCell;
                if (table != null && topLeftHeaderCell != null)
                    datausersGridView.DataSource = table;
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
                userName_textBox.Enabled = true;
                password_textBox.Enabled = true;
                isAdmain_comboBox.Enabled = true;
                note_textBox2.Enabled = true;
                //fill the boxes by data of selected row in table
                id_textBox.Text = datausersGridView.SelectedRows[0].Cells[0].Value.ToString();
                userName_textBox.Text = datausersGridView.SelectedRows[0].Cells[1].Value.ToString();
                password_textBox.Text = datausersGridView.SelectedRows[0].Cells[2].Value.ToString();
                isAdmain_comboBox.Text = datausersGridView.SelectedRows[0].Cells[3].Value.ToString();
                note_textBox2.Text = datausersGridView.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        /// <summary>
        /// check if boxes contain input 
        /// </summary>
        /// <returns>true for full data, and false for not</returns>
        private bool ISFullData()
        {
            if (!string.IsNullOrEmpty(userName_textBox.Text.Trim()) && !string.IsNullOrEmpty(password_textBox.Text.Trim()) &&
                isAdmain_comboBox.SelectedItem != null)
                return true;
            MessageBox.Show($"You have forgot to fill some information, please check your input!!",
                "Unsuccessful Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        /// <summary>
        /// event fire after each change on boxes to delete extra space from first and end the input
        /// </summary>
        private void ShowEditUsers_Validating(object sender, CancelEventArgs e)
        {
            userName_textBox.Text = userName_textBox.Text.Trim();
            password_textBox.Text = password_textBox.Text.Trim();
            isAdmain_comboBox.Text = isAdmain_comboBox.Text.Trim();
            note_textBox2.Text = note_textBox2.Text.Trim();
        }

        /// <summary>
        /// click button event to edit selected user's data
        /// </summary>
        private void Edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ISFullData() && !Exist())
                {
                    datausersGridView.SelectedRows[0].Cells[0].Value = id_textBox.Text;
                    datausersGridView.SelectedRows[0].Cells[1].Value = userName_textBox.Text;
                    datausersGridView.SelectedRows[0].Cells[2].Value = password_textBox.Text;
                    datausersGridView.SelectedRows[0].Cells[3].Value = isAdmain_comboBox.Text;
                    datausersGridView.SelectedRows[0].Cells[4].Value = note_textBox2.Text;

                    List<string> row = new List<string>() { id_textBox.Text, userName_textBox.Text,
                    password_textBox.Text,isAdmain_comboBox.Text, note_textBox2.Text};
                    UserDatabase user = new UserDatabase();
                    user.EditRow(row);
                    MessageBox.Show($"The User information was edited!!", "successful Operation",
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
        /// check if user's input data already exists in database
        /// </summary>
        /// <returns>true if input data already exists in database, false if not</returns>
        private bool Exist()
        {
            UserDatabase _user = new UserDatabase();
            if (_user.GetSpecificRow(userName_textBox.Text, password_textBox.Text).Count > 0)
            {
                MessageBox.Show($"This user already exist in your database!!", "Unsuccessful Operation",
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
        /// click button event to delete specefic user's data
        /// </summary>
        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (datausersGridView.SelectedRows.Count > 0)
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this user ?", "Delete",
             MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    DeleteFromDatabase tooldelete = new DeleteFromDatabase();
                    tooldelete.DeleteRow("users", datausersGridView.SelectedRows[0].Cells[0].Value.ToString());
                    datausersGridView.Rows.RemoveAt(datausersGridView.SelectedRows[0].Index);
                }
        }

        /// <summary>
        /// event of searching operation
        /// </summary>
        private void SerName_textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable temp = new DataTable();
            UserDatabase user = new UserDatabase();
            if (!serName_textBox1.Text.Contains("'"))
            {
                temp = user.SearchFor(serName_textBox1.Text);
                datausersGridView.DataSource = temp;
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

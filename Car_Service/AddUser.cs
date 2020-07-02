using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataBasesLibrary;

namespace Car_Service
{
    public partial class AddUser : Form
    {

        //constrocter
        public AddUser()
        {
            InitializeComponent();//F12 to see the functions of this method
        }

        /// <summary>
        /// button click event to add user to datebase 
        /// </summary>
        private void Add_User_button_Click(object sender, EventArgs e)
        {
            /*
             * testing input's data
             */
            if (ISFullData() && !HasQuotationChar() && !Exist())
            {
                //creat list from user input
                List<string> userpro = new List<string>() { userName_textBox.Text, password_textBox.Text,
                    isAdmain_comboBox.Text, note_textBox2.Text };
                try
                {
                    UserDatabase _user = new UserDatabase();
                    //send list to UserDatabase.AddData method in order to add this user's data to database
                    _user.AddData(userpro);
                    MessageBox.Show($"The User was added successfully.", "Successful Operation",
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
        /// make texts of boxes empty
        /// </summary>
        private void CleanBoxes()
        {
            userName_textBox.Text = "";
            password_textBox.Text = "";
            isAdmain_comboBox.Text = "";
            note_textBox2.Text = "";
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
        /// check if input has quotation mark
        /// </summary>
        /// <returns></returns>
        private bool HasQuotationChar()
        {
            if (userName_textBox.Text.Contains("'") || password_textBox.Text.Contains("'") ||
                note_textBox2.Text.Contains("'"))
            {
                MessageBox.Show($"Unclosed quotation mark after the character ( ' )!!", "Unsuccessful Operation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        /// <summary>
        /// event fire after each change on boxes to delete extra space from first and end the input
        /// </summary>
        private void AddUser_Validating(object sender, CancelEventArgs e)
        {
            userName_textBox.Text = userName_textBox.Text.Trim();
            password_textBox.Text = password_textBox.Text.Trim();
            isAdmain_comboBox.Text = isAdmain_comboBox.Text.Trim();
            note_textBox2.Text = note_textBox2.Text.Trim();
        }

        /*
         * these two events help to make good Effects when cursor mouse enter or leave  Add_Employee_button boundaries
         */
        private void Add_Employee_button_MouseEnter(object sender, EventArgs e)
        {
            Add_User_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 126, 49);
            Add_User_button.ForeColor = System.Drawing.Color.FromArgb(229, 126, 49);
        }
        private void Add_Employee_button_MouseLeave(object sender, EventArgs e)
        {
            Add_User_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Add_User_button.ForeColor = System.Drawing.Color.White;
        }
    }
}

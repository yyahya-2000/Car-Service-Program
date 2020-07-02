using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DataBasesLibrary;
using System.Data.SqlClient;


namespace Car_Service
{
    public partial class AddEmployees : Form
    {
        //constrocter
        public AddEmployees()
        {
            InitializeComponent();//F12 to see the functions of this method
            register_dateTimePicker.Value = DateTime.Now;//determine the time of adding car register
        }

        /// <summary>
        /// button click event to add employee to datebase 
        /// </summary>
        private void Add_Employee_button_Click(object sender, EventArgs e)
        {
            /*
            * testing the input data
            */
            if (ISFullData() && !HasQuotationChar() && CheckPhoneNumber() && !Exist())
            {
                //creat list from user input
                List<string> employee = new List<string>
                 {
                     employeeName_textBox.Text,
                     adress_textBox.Text,
                     phoneNumber_textBox.Text,
                     career_textBox.Text,
                     salary_textBox.Text,
                     register_dateTimePicker.Value.ToString(),
                     note_textBox.Text
                 };
                try
                {
                    EmployeesDatabase employees = new EmployeesDatabase();
                    //send list to EmployeesDatabase.AddData method in order to add this employee's data to database
                    employees.AddData(employee);
                    MessageBox.Show($"The employee was added successfully.", "Successful Operation",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanBoxes();//clean the boxes from previous input
                }
                catch (SqlException)
                {
                    MessageBox.Show($"Salary box can't contain a char!!", "Unsuccessful Operation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
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
        /// make texts of boxes empty
        /// </summary>
        private void CleanBoxes()
        {
            employeeName_textBox.Text = "";
            adress_textBox.Text = "";
            phoneNumber_textBox.Text = "";
            career_textBox.Text = "";
            salary_textBox.Text = "";
            note_textBox.Text = "";
            register_dateTimePicker.Value = DateTime.Now;
        }

        /// <summary>
        /// check if employee's input data already exists in database
        /// </summary>
        /// <returns>true if input data already exists in database, false if not</returns>
        private bool Exist()
        {
            EmployeesDatabase employees = new EmployeesDatabase();
            if (employees.GetSpecificRow(employeeName_textBox.Text).Count > 0)
            {
                MessageBox.Show($"This Employee's name already exist in you database, Please choose another one!!", "Unsuccessful Operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
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
        /// check if input has quotation mark
        /// </summary>
        /// <returns></returns>
        private bool HasQuotationChar()
        {
            if (employeeName_textBox.Text.Contains("'") || adress_textBox.Text.Contains("'") ||
                career_textBox.Text.Contains("'") || note_textBox.Text.Contains("'"))
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
        private void EmployeeName_textBox_Validating(object sender, CancelEventArgs e)
        {
            employeeName_textBox.Text = employeeName_textBox.Text.Trim();
            adress_textBox.Text = adress_textBox.Text.Trim();
            phoneNumber_textBox.Text = phoneNumber_textBox.Text.Trim();
            career_textBox.Text = career_textBox.Text.Trim();
            salary_textBox.Text = salary_textBox.Text.Trim();
            note_textBox.Text = note_textBox.Text.Trim();
        }

        /*
         * these two events help to make good Effects when cursor mouse enter or leave  Add_Employee_button boundaries
         */
        private void Add_Employee_button_MouseEnter(object sender, EventArgs e)
        {
            Add_Employee_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 126, 49);
            Add_Employee_button.ForeColor = System.Drawing.Color.FromArgb(229, 126, 49);
        }
        private void Add_Employee_button_MouseLeave(object sender, EventArgs e)
        {
            Add_Employee_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Add_Employee_button.ForeColor = System.Drawing.Color.White;
        }
    }
}

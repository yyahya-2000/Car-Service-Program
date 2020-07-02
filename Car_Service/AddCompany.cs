using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataBasesLibrary;


namespace Car_Service
{
    public partial class AddCompany : Form
    {
        /// <summary>
        /// constrocter
        /// </summary>
        public AddCompany()
        {
            InitializeComponent();//F12 to see the functions of this mehtod
        }

        /// <summary>
        /// button click event to add company to datebase 
        /// </summary>
        private void Add_Company_button_Click(object sender, EventArgs e)
        {
            /*
             * testing the input data
             */
            if (ISFullData() && !HasQuotationChar() && CheckPhoneNumber() && IsValidEmail() && !Exist())
            {
                try
                {
                    //creat list from user input
                    List<string> companyPro = new List<string>() {companyName_textBox.Text,companyOwner_textBox.Text,
                        phoneNumber_textBox.Text,adress_textBox.Text,email_textBox1.Text,
                        entryDate_dateTimePicker.Value.ToString(),note_textBox.Text };
                    //send list to CompaniesDataBase.AddData method in order to add this company's data to database
                    CompaniesDataBase companies = new CompaniesDataBase();
                    companies.AddData(companyPro);
                    MessageBox.Show($"The company was added successfully.", "Successful Operation",
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
        /// check if input has quotation mark
        /// </summary>
        /// <returns></returns>
        private bool HasQuotationChar()
        {
            if (companyName_textBox.Text.Contains("'") || companyOwner_textBox.Text.Contains("'") ||
                adress_textBox.Text.Contains("'") || note_textBox.Text.Contains("'"))
            {
                MessageBox.Show($"Unclosed quotation mark after the character ( ' )!!", "Unsuccessful Operation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        /// <summary>
        /// check if company's input data already exists in database
        /// </summary>
        /// <returns>true if input data already exists in database, false if not</returns>
        private bool Exist()
        {
            CompaniesDataBase companies = new CompaniesDataBase();
            if (companies.GetSpecificRow(companyName_textBox.Text, companyOwner_textBox.Text).Count > 0)
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
        /// make texts of boxes empty
        /// </summary>
        private void CleanBoxes()
        {
            companyName_textBox.Text = "";
            companyOwner_textBox.Text = "";
            phoneNumber_textBox.Text = "";
            adress_textBox.Text = "";
            email_textBox1.Text = "";
            note_textBox.Text = "";
            entryDate_dateTimePicker.Value = DateTime.Now;
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
        private void FName_textBox_Validating(object sender, CancelEventArgs e)
        {
            companyName_textBox.Text = companyName_textBox.Text.Trim();
            companyOwner_textBox.Text = companyOwner_textBox.Text.Trim();
            phoneNumber_textBox.Text = phoneNumber_textBox.Text.Trim();
            adress_textBox.Text = adress_textBox.Text.Trim();
            email_textBox1.Text = email_textBox1.Text.Trim();
            note_textBox.Text = note_textBox.Text.Trim();
        }

        /*
         * these two events help to make good Effects when cursor mouse enter or leave  Add_Company_button boundaries
         */
        private void Add_Company_button_MouseEnter(object sender, EventArgs e)
        {
            Add_Company_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 126, 49);
            Add_Company_button.ForeColor = System.Drawing.Color.FromArgb(229, 126, 49);
        }
        private void Add_Company_button_MouseLeave(object sender, EventArgs e)
        {
            Add_Company_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Add_Company_button.ForeColor = System.Drawing.Color.White;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DataBasesLibrary;
using System.Data.SqlClient;

namespace Car_Service
{
    public partial class AddCarRegister : Form
    {
        //constroctor
        public AddCarRegister()
        {
            InitializeComponent(); //F12 to see the functions of this method
            entryDate_dateTimePicker.Value = DateTime.Now;//determine the time of adding car register
        }

        /// <summary>
        /// button click event to add car register to datebase 
        /// </summary>
        private void Add_CarRegister_button_Click(object sender, EventArgs e)
        {
            /*
             * testing the input data
             */
            bool isFullData = ISFullData();
            if (isFullData && !HasQuotationChar() && uint.TryParse(phoneNumber_textBox1.Text, out _))
            {
                try
                {
                    //creat list from user input
                    List<string> registerCar = new List<string>() { fName_textBox.Text,sName_textBox.Text,
                         carNumber_textBox.Text,type_textBox1.Text,color_comboBox1.SelectedItem.ToString(),
                         model_comboBox2.SelectedItem.ToString(), phoneNumber_textBox1.Text,adress_textBox.Text,
                         entryDate_dateTimePicker.Value.ToString(),identif_textBox.Text,note_textBox.Text};
                    CarRegisterDatabase car = new CarRegisterDatabase();
                    //send list to CarRegisterDatabase.AddData method in order to add this data of carregister to database
                    car.AddData(registerCar);
                    MessageBox.Show($"The car was added successfully.", "Successful Operation",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanBoxes();//clean the boxes from previous input

                }
                catch (SqlException)
                {
                    MessageBox.Show($"Could not get the DataBase!!", "Unsuccessful Operation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else if (isFullData)
            {
                MessageBox.Show($"Phone Number box can't contain a char or negative number!!",
                    "Unsuccessful Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// make texts of boxes empty
        /// </summary>
        private void CleanBoxes()
        {
            fName_textBox.Text = "";
            sName_textBox.Text = "";
            phoneNumber_textBox1.Text = "";
            carNumber_textBox.Text = "";
            type_textBox1.Text = "";
            color_comboBox1.Text = "";
            model_comboBox2.Text = "";
            adress_textBox.Text = "";
            note_textBox.Text = "";
            identif_textBox.Text = "";
            entryDate_dateTimePicker.Value = DateTime.Now;
        }

        /// <summary>
        /// check if boxes contain input 
        /// </summary>
        /// <returns>true for full data, and false for not</returns>
        private bool ISFullData()
        {
            try
            {
                if (!string.IsNullOrEmpty(fName_textBox.Text.Trim()) && !string.IsNullOrEmpty(sName_textBox.Text.Trim()) &&
                    !string.IsNullOrEmpty(type_textBox1.Text.Trim()) && !string.IsNullOrEmpty(adress_textBox.Text.Trim()) &&
                    !string.IsNullOrEmpty(carNumber_textBox.Text.Trim()) && color_comboBox1.SelectedItem.ToString() != "" &&
                     model_comboBox2.SelectedItem.ToString() != "" &&
                    !string.IsNullOrEmpty(identif_textBox.Text.Trim()))
                    return true;

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Incorrect input", "Erorr Inputing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            if (fName_textBox.Text.Contains("'") || sName_textBox.Text.Contains("'") || carNumber_textBox.Text.Contains("'") ||
                type_textBox1.Text.Contains("'") || adress_textBox.Text.Contains("'") || identif_textBox.Text.Contains("'")
                || note_textBox.Text.Contains("'"))
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
        private void FName_textBox_Validating(object sender, CancelEventArgs e)
        {
            fName_textBox.Text = fName_textBox.Text.Trim();
            sName_textBox.Text = sName_textBox.Text.Trim();
            phoneNumber_textBox1.Text = phoneNumber_textBox1.Text.Trim();
            carNumber_textBox.Text = carNumber_textBox.Text.Trim();
            type_textBox1.Text = type_textBox1.Text.Trim();
            adress_textBox.Text = adress_textBox.Text.Trim();
            note_textBox.Text = note_textBox.Text.Trim();
            identif_textBox.Text = identif_textBox.Text.Trim();
        }


        /*
         * these two events help to make good Effects when cursor mouse enter or leave  Add_CarRegister_button boundaries
         */
        private void Add_CarRegister_button_MouseEnter(object sender, EventArgs e)
        {

            Add_CarRegister_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 126, 49);
            Add_CarRegister_button.ForeColor = System.Drawing.Color.FromArgb(229, 126, 49);
        }
        private void Add_CarRegister_button_MouseLeave(object sender, EventArgs e)
        {
            Add_CarRegister_button.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            Add_CarRegister_button.ForeColor = System.Drawing.Color.LightGray;
        }

    }
}

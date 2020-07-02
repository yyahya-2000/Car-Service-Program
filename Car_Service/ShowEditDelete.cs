using System;
using System.Windows.Forms;

namespace Car_Service
{
    //Inherited class from Windows.forms.UserControl class
    public partial class ShowEditDelete : UserControl
    {
        bool isAdmain;
        public bool IsAdmain { get => isAdmain; set => isAdmain = value; }

        //constrocter
        public ShowEditDelete()
        {
            InitializeComponent();//F12 to see the functions of this method
        }

        /// <summary>
        /// click on pic event, to move user to ShowEditTools form
        /// </summary>
        private void ShowTool_pictureBox2_Click(object sender, EventArgs e)
        {
            ShowEditTools editor = new ShowEditTools();
            editor.ShowDialog();
        }

        /// <summary>
        /// click on pic event, to move user to ShowEditCompanies form
        /// </summary>
        private void ShowCompany_pictureBox3_Click(object sender, EventArgs e)
        {
            ShowEditCompanies editCompanies = new ShowEditCompanies();
            editCompanies.ShowDialog();
        }

        /// <summary>
        /// click on pic event, to move user to ShowEditUsers form if he is admain
        /// </summary>
        private void ShowUser_pictureBox1_Click(object sender, EventArgs e)
        {
            if (IsAdmain)
            {
                ShowEditUsers showEditUsers = new ShowEditUsers();
                showEditUsers.ShowDialog();
            }
            else
                MessageBox.Show($"You are not an admain, so you can't add a user!!",
                    "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        /// <summary>
        /// click on pic event, to move user to ShowEditEmployees form
        /// </summary>
        private void ShowEmployee_pictureBox4_Click(object sender, EventArgs e)
        {
            ShowEditEmployees employeeEditor = new ShowEditEmployees();
            employeeEditor.ShowDialog();
        }

    }
}

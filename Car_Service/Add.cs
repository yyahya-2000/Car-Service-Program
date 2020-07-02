using System;
using System.Windows.Forms;

namespace Car_Service
{
    /// <summary>
    /// inherited class from Windows.Forms.UserControl class was Shared in config initializeuring interface form
    /// </summary>
    public partial class Add : UserControl
    {
        bool isAdmain; //determine if the user is admain to make some spicial property for him
        public bool IsAdmain { get => isAdmain; set => isAdmain = value; } //isAdmain's property 

        public Add()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event move user to AddUser form when click on pic
        /// </summary>
        private void AddUser_pictureBox1_Click(object sender, EventArgs e)
        {
            //accses there only for admains
            if (IsAdmain)
            {
                try
                {
                    AddUser addUser = new AddUser();
                    addUser.ShowDialog();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show($"{ex.Message}",
                   "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show($"You are not an admain, so you can't add a user!!",
                    "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// event move user to AddCompanie form when click on pic
        /// </summary>
        private void AddCompany_pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                AddCompany companie = new AddCompany();
                companie.ShowDialog();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"{ex.Message}",
                   "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// event move user to AddTool form when click on pic
        /// </summary>
        private void AddTool_pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                AddTool tool = new AddTool();
                tool.ShowDialog();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"{ex.Message}",
                   "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// event move user to AddEmployees form when click on pic
        /// </summary>
        private void AddEmployee_pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                AddEmployees employees = new AddEmployees();
                employees.ShowDialog();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"{ex.Message}",
                   "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

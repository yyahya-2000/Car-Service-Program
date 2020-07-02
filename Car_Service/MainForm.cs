using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Car_Service
{
    public partial class MainForm : Form
    {
        readonly FileInfo file;//help in getting path of database
        static string constring;
        readonly SqlConnection Sql;
        /// <summary>
        /// constrocter
        /// </summary>
        public MainForm()
        {
            InitializeComponent();//F12 to see the functions of this method
            if (!File.Exists(@"../../CarsDatabase.mdf"))
            {
                MessageBox.Show(@"Database Was not found, Please copy it here (Course work\Car_Service)!", "No Connection",
              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }

            file = new FileInfo(@"../../CarsDatabase.mdf");
            constring = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={file.FullName};Integrated Security=True";
            Sql = new SqlConnection(constring);
        }

        /// <summary>
        /// click button event check the input data and determine if 
        /// user admain or note if pass and user name was correct
        /// and move user to InterfaceForm
        /// </summary>
        private void Logain_button_Click(object sender, EventArgs e)
        {
            if (CheckInput())
                return;
            string is_admain = null;
            if (DetermineUser(ref is_admain))
            {
                InterfaceForm form = new InterfaceForm(bool.Parse(is_admain));
                form.ShowDialog();
            }

        }
        /// <summary>
        /// method help to Determine user the program
        /// </summary>
        /// <param name="is_admain"> the state if user(admain or not)</param>
        /// <returns>true is data user exist in database, false if not</returns>
        private bool DetermineUser(ref string is_admain)
        {
            try
            {
                Sql.Open();
                SqlCommand cmd = new SqlCommand("select * from users where User_name='" + username_textBox.Text +
                    "' and Password ='" + password_textBox.Text + "'", Sql);//instruction to get this data from database if it exists
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        if (username_textBox.Text == rd.GetValue(1).ToString())
                        {
                            is_admain = rd.GetValue(3).ToString();
                        }
                    }
                    Sql.Close();
                    username_textBox.Text = "";
                    password_textBox.Text = "";
                    return true;
                }
                else
                {

                    MessageBox.Show("incorrect username or password!", "Unsuccessful Operation",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Sql.Close();
                    return false;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("incorrect username or password!", "Unsuccessful Operation",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Sql.Close();
            }
            return false;

        }

        /// <summary>
        /// method to check if input data has <'> symbol
        /// </summary>
        private bool CheckInput()
        {
            if (username_textBox.Text.Contains("'") || password_textBox.Text.Contains("'"))
            {
                MessageBox.Show("You cannot enter this symbol <'>!", "Not Allowed Entry",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        /// <summary>
        /// click on pic event to close the form
        /// </summary>
        private void Close_pictureBox3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to exit?", "EXIT",
               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                this.Close();
        }

        /// <summary>
        /// click on pic event to minimize the form
        /// </summary>
        private void Minimize_pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /*
         * these 2 events help to make good Effects when cursor mouse enter or leave Logain_button boundaries
         */
        private void Logain_button_MouseEnter(object sender, EventArgs e)
        {
            Logain_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            Logain_button.ForeColor = System.Drawing.Color.DarkGreen;
        }
        private void Logain_button_MouseLeave(object sender, EventArgs e)
        {
            Logain_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Logain_button.ForeColor = System.Drawing.Color.White;
        }
    }
}

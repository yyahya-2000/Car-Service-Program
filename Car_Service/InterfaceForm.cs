using System;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarServiceLibrary;

namespace Car_Service
{
    public partial class InterfaceForm : Form
    {
        private const bool f = false;

        //if login user is admain
        readonly bool isAdmain = f;
        /*
         * these 5 bool variables help in making efficte on buttons while moving between controles
         */
        bool pressedShowEdit = false;
        bool pressedAdd = false;
        bool pressedOperation = false;
        bool pressedRegister = false;
        bool pressedHistory = false;

        /// <summary>
        /// Constrocter
        /// </summary>
        /// <param name="isAdmain"> check if login user is admain</param>
        public InterfaceForm(bool isAdmain)
        {
            this.isAdmain = isAdmain;
            InitializeComponent();//F12 to see the functions of this method
            Warning();
            if (shortage_GridView.Rows.Count > 0)
                panel5.BackColor = Color.Red;
            shortage_GridView.Visible = false;
            Up_pictureBox6.Visible = false;
            showEditDelete1.IsAdmain = isAdmain;
            add1.IsAdmain = isAdmain;
            historyC1.IsAdmain = isAdmain;
            operationsC1.IsAdmain = isAdmain;
        }
        /// <summary>
        /// load form event
        /// </summary>
        private void InterfaceForm_Load(object sender, EventArgs e)
        {
            /*
             * the panels where controles locate
             */
            main_panel5.Show();
            showEditDelete1.Hide();
            add1.Hide();
            operationsC1.Hide();
            historyC1.Hide();

        }

        /// <summary>
        /// getting tools which have shortage
        /// </summary>
        private void Warning()
        {
            try
            {
                ReadClass check = new ReadClass("Tools");
                shortage_GridView.DataSource = check.CheckTools();
            }
            catch (SqlException)
            {
                MessageBox.Show($"couldn't get the database", "Unsuccessful operation",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        /// <summary>
        /// click on pic event to close the form
        /// </summary>
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// click on pic event to minimize the form
        /// </summary>
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// event move user to AddCarRegister form
        /// </summary>
        private void RegisterCar_button1_Click(object sender, EventArgs e)
        {
            #region help in design
            ChangeBorderColorAndForeColor();
            RegisterCar_button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 126, 49);
            RegisterCar_button1.ForeColor = System.Drawing.Color.FromArgb(229, 126, 49);
            Pressed("register");
            main_panel5.Show();
            showEditDelete1.Hide();
            add1.Hide();
            operationsC1.Hide();
            historyC1.Hide();
            #endregion
            AddCarRegister addCar = new AddCarRegister();
            addCar.ShowDialog();
        }

        /// <summary>
        /// click button event to  show panel were locate ShowEditDelete user control
        /// </summary>
        private void ShowEditDelete_button_Click(object sender, EventArgs e)
        {
            //hide other user controls
            add1.Hide();
            operationsC1.Hide();
            historyC1.Hide();
            //show current user control
            showEditDelete1.Show();
            showEditDelete1.BringToFront();
            ChangeBorderColorAndForeColor();
            ShowEditDelete_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 126, 49);
            ShowEditDelete_button.ForeColor = System.Drawing.Color.FromArgb(229, 126, 49);
            Pressed("show");
        }


        /// <summary>
        /// click button event to show panel were locate Add user control
        /// </summary>
        private void AddData_button_Click(object sender, EventArgs e)
        {
            //hide other user controls
            showEditDelete1.Hide();
            operationsC1.Hide();
            historyC1.Hide();
            //show current user control
            add1.Show();
            add1.BringToFront();
            ChangeBorderColorAndForeColor();
            AddData_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 126, 49);
            AddData_button.ForeColor = System.Drawing.Color.FromArgb(229, 126, 49);
            Pressed("add");
        }

        /// <summary>
        /// click button event to show panel were locate OperationC user control
        /// </summary>
        private void Operations_button_Click(object sender, EventArgs e)
        {
            //hide other user controls
            showEditDelete1.Hide();
            add1.Hide();
            historyC1.Hide();
            //show current user control
            operationsC1.Show();
            operationsC1.BringToFront();
            ChangeBorderColorAndForeColor();
            Operations_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 126, 49);
            Operations_button.ForeColor = System.Drawing.Color.FromArgb(229, 126, 49);
            Pressed("operation");
        }

        /// <summary>
        /// click button event to show panel were locate HistoryC user control
        /// </summary>
        private void History_button_Click(object sender, EventArgs e)
        {
            //hide other user controls
            showEditDelete1.Hide();
            add1.Hide();
            operationsC1.Hide();
            //show current user control
            historyC1.Show();
            historyC1.BringToFront();
            ChangeBorderColorAndForeColor();
            History_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 126, 49);
            History_button.ForeColor = System.Drawing.Color.FromArgb(229, 126, 49);
            Pressed("history");
        }

        /// <summary>
        /// click pic event to back to main panel
        /// </summary>
        private void PictureBox5_Click(object sender, EventArgs e)
        {
            main_panel5.Show();
            showEditDelete1.Hide();
            add1.Hide();
            operationsC1.Hide();
            historyC1.Hide();
            ChangeBorderColorAndForeColor();
            pressedShowEdit = pressedRegister = pressedAdd = pressedOperation = pressedHistory = false;
        }

        /// <summary>
        /// this method help to get required design and effects
        /// </summary>
        private void Pressed(string nameButton)
        {
            switch (nameButton)
            {
                case "show":
                    pressedShowEdit = true;
                    pressedRegister = pressedAdd = pressedOperation = pressedHistory = false;
                    break;
                case "add":
                    pressedAdd = true;
                    pressedRegister = pressedShowEdit = pressedOperation = pressedHistory = false;
                    break;
                case "operation":
                    pressedOperation = true;
                    pressedRegister = pressedShowEdit = pressedAdd = pressedHistory = false;
                    break;
                case "register":
                    pressedRegister = true;
                    pressedAdd = pressedShowEdit = pressedOperation = pressedHistory = false;
                    break;
                case "history":
                    pressedHistory = true;
                    pressedRegister = pressedShowEdit = pressedOperation = pressedAdd = false;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// reset the color of buttons
        /// </summary>
        private void ChangeBorderColorAndForeColor()
        {
            History_button.FlatAppearance.BorderColor = Color.White;
            History_button.ForeColor = Color.White;
            RegisterCar_button1.FlatAppearance.BorderColor = Color.White;
            RegisterCar_button1.ForeColor = Color.White;
            Operations_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Operations_button.ForeColor = Color.White;
            AddData_button.FlatAppearance.BorderColor = Color.White;
            AddData_button.ForeColor = Color.White;
            ShowEditDelete_button.FlatAppearance.BorderColor = Color.White;
            ShowEditDelete_button.ForeColor = Color.White;
        }

        /// <summary>
        /// click pic event help to hide list of tools which have shortage
        /// </summary>
        private void Up_pictureBox6_Click(object sender, EventArgs e)
        {
            shortage_GridView.Visible = false;
            Up_pictureBox6.Visible = false;
            Down_pictureBox7.Visible = true;
        }

        /// <summary>
        /// click pic event help to show list of tools which have shortage
        /// </summary>
        private void Down_pictureBox7_Click(object sender, EventArgs e)
        {
            shortage_GridView.Visible = true;
            Up_pictureBox6.Visible = true;
            Down_pictureBox7.Visible = false;
        }


        /*
         * these 10 events help to make good Effects when cursor mouse enter or leave buttons boundaries
         */
        private void ShowEditDelete_button_MouseEnter(object sender, EventArgs e)
        {
            ShowEditDelete_button.FlatAppearance.BorderColor = Color.FromArgb(229, 126, 49);
            ShowEditDelete_button.ForeColor = Color.FromArgb(229, 126, 49);
        }
        private void ShowEditDelete_button_MouseLeave(object sender, EventArgs e)
        {
            if (!pressedShowEdit)
            {
                ShowEditDelete_button.FlatAppearance.BorderColor = Color.White;
                ShowEditDelete_button.ForeColor = Color.White;
            }
        }
        private void AddData_button_MouseEnter(object sender, EventArgs e)
        {
            AddData_button.FlatAppearance.BorderColor = Color.FromArgb(229, 126, 49);
            AddData_button.ForeColor = Color.FromArgb(229, 126, 49);
        }
        private void AddData_button_MouseLeave(object sender, EventArgs e)
        {
            if (!pressedAdd)
            {
                AddData_button.FlatAppearance.BorderColor = Color.White;
                AddData_button.ForeColor = Color.White;
            }

        }
        private void Operations_button_MouseEnter(object sender, EventArgs e)
        {
            Operations_button.FlatAppearance.BorderColor = Color.FromArgb(229, 126, 49);
            Operations_button.ForeColor = Color.FromArgb(229, 126, 49);
        }
        private void Operations_button_MouseLeave(object sender, EventArgs e)
        {
            if (!pressedOperation)
            {
                Operations_button.FlatAppearance.BorderColor = Color.White;
                Operations_button.ForeColor = Color.White;
            }
        }
        private void RegisterCar_button1_MouseEnter(object sender, EventArgs e)
        {
            RegisterCar_button1.FlatAppearance.BorderColor = Color.FromArgb(229, 126, 49);
            RegisterCar_button1.ForeColor = Color.FromArgb(229, 126, 49);
        }
        private void RegisterCar_button1_MouseLeave(object sender, EventArgs e)
        {
            if (!pressedRegister)
            {
                RegisterCar_button1.FlatAppearance.BorderColor = Color.White;
                RegisterCar_button1.ForeColor = Color.White;
            }
        }
        private void History_button_MouseEnter(object sender, EventArgs e)
        {
            History_button.FlatAppearance.BorderColor = Color.FromArgb(229, 126, 49);
            History_button.ForeColor = Color.FromArgb(229, 126, 49);
        }
        private void History_button_MouseLeave(object sender, EventArgs e)
        {
            if (!pressedHistory)
            {
                History_button.FlatAppearance.BorderColor = Color.White;
                History_button.ForeColor = Color.White;
            }
        }


    }
}

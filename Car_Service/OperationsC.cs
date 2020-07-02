using System;
using System.Windows.Forms;

namespace Car_Service
{
    //Inherited class from Windows.forms.UserControl class
    public partial class OperationsC : UserControl
    {
        bool isAdmain;

        public bool IsAdmain { get => isAdmain; set => isAdmain = value; }

        //constrocter
        public OperationsC()
        {
            InitializeComponent();//F12 to see the functions of this method
        }

        /// <summary>
        /// click on pic event, to move user to BuyingProcess form
        /// </summary>
        private void Order_pictureBox2_Click(object sender, EventArgs e)
        {
            BuyingProcess buying = new BuyingProcess();
            buying.Show();
        }

        /// <summary>
        /// click on pic event, to move user to Reports form
        /// </summary>
        private void Report_pictureBox1_Click(object sender, EventArgs e)
        {
            if (isAdmain)
            {
                try
                {
                    Reports reports = new Reports();
                    reports.ShowDialog();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show($"{ex.Message}!!", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show($"You are not an admain, so you can't add a user!!",
                   "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// click on pic event, to move user to CarRegisters form
        /// </summary>
        private void Repair_pictureBox1_Click(object sender, EventArgs e)
        {
            CarRegisters delivery = new CarRegisters();
            delivery.ShowDialog();
        }
    }
}

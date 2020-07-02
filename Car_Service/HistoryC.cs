using System;
using System.Windows.Forms;

namespace Car_Service
{
    //Inherited class from Windows.forms.UserControl class
    public partial class HistoryC : UserControl
    {
        bool isAdmain;

        //constrocter
        public HistoryC()
        {
            InitializeComponent();//F12 to see the functions of this method
        }

        public bool IsAdmain { get => isAdmain; set => isAdmain = value; }

        /// <summary>
        /// click on pic event, to move user to PurchasesHistory form
        /// </summary>
        private void ShowPurchases_pictureBox2_Click(object sender, EventArgs e)
        {
            if (isAdmain)
            {
                PurchasesHistory purchases = new PurchasesHistory();
                purchases.ShowDialog();
            }
            else
                MessageBox.Show($"You are not an admain, you can't see this!!",
                   "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// click on pic event, to move user to History form
        /// </summary>
        private void ShowSeles_pictureBox1_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.ShowDialog();
        }
    }
}

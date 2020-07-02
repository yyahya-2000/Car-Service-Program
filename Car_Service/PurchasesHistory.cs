using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarServiceLibrary;
using DataBasesLibrary;

namespace Car_Service
{
    public partial class PurchasesHistory : Form
    {
        DataTable temp = new DataTable();
        readonly ShoppingDatabase purchase = new ShoppingDatabase();
        //constroctor
        public PurchasesHistory()
        {
            InitializeComponent();//F12 to see the functions of this method
            DownloadToolsData();
        }

        /// <summary>
        /// get CarDelivery database into salesGridView (table)
        /// </summary>
        private void DownloadToolsData()
        {
            DataTable purchases = new DataTable();
            try
            {
                ReadClass read = new ReadClass("Shopping");
                purchases = read.GetDataTable();
                purchases.Columns.RemoveAt(7);
                if (purchases != null)
                    purchasesGridView.DataSource = purchases;
            }
            catch (SqlException)
            {
                MessageBox.Show($"couldn't get the database", "Unsuccessful operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}", "Unsuccessfully Operation",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        /// <summary>
        /// double click event to get the invoice of shopping register
        /// </summary>
        private void SalesGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ShoppingDatabase purchase = new ShoppingDatabase();
                PurchaseInvoice invoice = new PurchaseInvoice(purchasesGridView.SelectedRows[0],
                    purchase.GetBillRow(int.Parse(purchasesGridView.SelectedRows[0].Cells[0].Value.ToString())));
                invoice.ShowDialog();
            }
            catch (Exception) { }
        }

        /// <summary>
        /// check Box event to allow searching by date
        /// </summary>
        private void On_off_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (On_off_checkBox.Checked)
            {
                from_dateTimePicker1.Enabled = true;
                to_dateTimePicker2.Enabled = true;
            }
            else
            {
                from_dateTimePicker1.Value = DateTime.Parse("1/25/1900 11:59 PM");
                to_dateTimePicker2.Value = DateTime.Parse("12/25/2099 11:59 PM");
                from_dateTimePicker1.Enabled = false;
                to_dateTimePicker2.Enabled = false;
            }
        }

        /// <summary>
        /// event of searching operation
        /// </summary>
        private void To_dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            temp = purchase.SearchFor(serName_textBox.Text, ownerName_textBox1.Text,
                from_dateTimePicker1.Value, to_dateTimePicker2.Value);
            temp.Columns.RemoveAt(7);
            purchasesGridView.DataSource = temp;
        }

        /// <summary>
        /// event of searching operation
        /// </summary>
        private void OwnerName_textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!serName_textBox.Text.Contains("'") && !ownerName_textBox1.Text.Contains("'"))
            {
                temp = purchase.SearchFor(serName_textBox.Text, ownerName_textBox1.Text,
                    from_dateTimePicker1.Value, to_dateTimePicker2.Value);
                temp.Columns.RemoveAt(7);
                purchasesGridView.DataSource = temp;
            }
        }

        /// <summary>
        /// button click event to delete purchase register from database
        /// </summary>
        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (purchasesGridView.SelectedRows.Count > 0)
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this invoice?",
                    "Deleting Operation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    DeleteFromDatabase tooldelete = new DeleteFromDatabase();
                    tooldelete.DeleteRow("Shopping", purchasesGridView.SelectedRows[0].Cells[0].Value.ToString());
                    purchasesGridView.Rows.RemoveAt(purchasesGridView.SelectedRows[0].Index);
                }
        }

        /*
        * these two events help to make good Effects when cursor mouse enter or leave  
        *  Delete_button boundaries
        */
        private void Delete_button_MouseEnter(object sender, EventArgs e)
        {
            Delete_button.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            Delete_button.ForeColor = System.Drawing.Color.Red;
        }
        private void Delete_button_MouseLeave(object sender, EventArgs e)
        {
            Delete_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Delete_button.ForeColor = System.Drawing.Color.White;

        }
    }
}

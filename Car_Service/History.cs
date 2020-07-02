using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarServiceLibrary;
using DataBasesLibrary;

namespace Car_Service
{
    public partial class History : Form
    {      
        //constroctor
        public History()
        {
            InitializeComponent();//F12 to see the functions of this method
            DownloadToolsData();
        }
        /// <summary>
        /// get CarDelivery database into salesGridView (table)
        /// </summary>
        private void DownloadToolsData()
        {
            DataTable sales = new DataTable();
            try
            {
                ReadClass read = new ReadClass("CarDelivery");
                sales = read.GetDataTable();
                sales.Columns.RemoveAt(13);
                if (sales != null)
                    salesGridView.DataSource = sales;
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
        /// double click event to get the invoice of Car Delivery register
        /// </summary>
        private void SalesGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                CarDeliveryDatabase CarDelivery = new CarDeliveryDatabase();
                BillServicingCar bill = new BillServicingCar(salesGridView.SelectedRows[0],
                        CarDelivery.GetBillRow(int.Parse(salesGridView.SelectedRows[0].Cells[0].Value.ToString())));
                bill.ShowDialog();
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
        private void History_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        /// <summary>
        /// event fire when user enter data in search boxes
        /// </summary>
        private void From_dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GetData();
        }

        /// <summary>
        /// Display the required data for searching operations
        /// </summary>
        private void GetData()
        {
            DataTable temp = new DataTable();
            List<string> clientSearch = new List<string>() {fName_textBox.Text,
                sName_textBox.Text,carNumber_textBox.Text,type_textBox1.Text,color_comboBox1.Text,
                model_comboBox2.Text};
            if (clientSearch.All<string>(c => !c.Contains("'")))
            {
                //calling method SearchFor which located in CarDeliveryDatabase class
                try
                {
                    CarDeliveryDatabase CarDelivery = new CarDeliveryDatabase();
                    temp = CarDelivery.SearchFor(clientSearch, from_dateTimePicker1.Value, to_dateTimePicker2.Value);
                    temp.Columns.RemoveAt(13);
                    salesGridView.DataSource = temp;
                }
                catch (SqlException) { }
            }
        }

        /// <summary>
        /// button click event to delete car delivery register from database
        /// </summary>
        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (salesGridView.SelectedRows.Count > 0)
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this invoice ?", "Delete",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    DeleteFromDatabase tooldelete = new DeleteFromDatabase();
                    tooldelete.DeleteRow("CarDelivery", salesGridView.SelectedRows[0].Cells[0].Value.ToString());
                    salesGridView.Rows.RemoveAt(salesGridView.SelectedRows[0].Index);
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

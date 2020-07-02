using System;
using System.Data;
using System.Windows.Forms;
using CarServiceLibrary;
using System.Data.SqlClient;

namespace Car_Service
{
    public partial class CarRegisters : Form
    {      
        //constrocter
        public CarRegisters()
        {
            InitializeComponent();//F12 to see the functions of this method
            DownloadToolsData();
        }
        /// <summary>
        /// download registered cars into DataGridView( dataToolsGridView)
        /// </summary>
        private void DownloadToolsData()
        {
            DataTable table = new DataTable();
            ReadClass read = new ReadClass("CarRegister");
            table = read.GetDataTable();
            var topLeftHeaderCell = dataToolsGridView.TopLeftHeaderCell;
            if (table != null && topLeftHeaderCell != null)
                dataToolsGridView.DataSource = table;
        }

        /// <summary>
        /// click button event move user to ChoiceUsedTools form to choose 
        /// the tools which were used in order to repair the car
        /// </summary>
        private void Repair_button_Click(object sender, EventArgs e)
        {
            if (dataToolsGridView.SelectedRows.Count > 0)
            {
                this.Visible = false;
                this.Close();
                ChoiceUsedTools tools = new ChoiceUsedTools(dataToolsGridView.SelectedRows[0]);
                tools.ShowDialog();
            }
        }

        /// <summary>
        /// click button event to delete selected car register
        /// </summary>
        private void Delete_button1_Click(object sender, EventArgs e)
        {
            if (dataToolsGridView.SelectedRows.Count > 0)
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this car register?", "Delete",
                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    try
                    {
                        DeleteFromDatabase registerdelete = new DeleteFromDatabase();
                        registerdelete.DeleteRow("CarRegister", dataToolsGridView.SelectedRows[0].Cells[0].Value.ToString());
                        dataToolsGridView.Rows.RemoveAt(dataToolsGridView.SelectedRows[0].Index);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show($"couldn't get the database", "Unsuccessful operation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
        }

        /*
         * these 4 events help to make good Effects when cursor mouse enter or leave Repair_button and Delete_button1 boundaries
         */
        private void Repair_button_MouseEnter(object sender, EventArgs e)
        {
            Repair_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 126, 49);
            Repair_button.ForeColor = System.Drawing.Color.FromArgb(229, 126, 49);
        }
        private void Repair_button_MouseLeave(object sender, EventArgs e)
        {
            Repair_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Repair_button.ForeColor = System.Drawing.Color.White;
        }
        private void Delete_button1_MouseEnter(object sender, EventArgs e)
        {
            Delete_button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 126, 49);
            Delete_button1.ForeColor = System.Drawing.Color.FromArgb(229, 126, 49);
        }
        private void Delete_button1_MouseLeave(object sender, EventArgs e)
        {
            Delete_button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Delete_button1.ForeColor = System.Drawing.Color.White;
        }
    }
}

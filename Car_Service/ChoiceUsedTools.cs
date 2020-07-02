using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarServiceLibrary;
using DataBasesLibrary;

namespace Car_Service
{
    public partial class ChoiceUsedTools : Form
    {
       
        readonly DataGridViewRow order;//to save receivde information of car register
        readonly ToolsDatabase toolsDatabase = new ToolsDatabase();

        //constrocter
        public ChoiceUsedTools(DataGridViewRow order)
        {
            InitializeComponent();//F12 to see the functions of this method
            DownloadToolsData();
            this.order = order;
        }

        /// <summary>
        /// get tools data from database and show it in toolsDataToolsGridView(Tebale)
        /// </summary>
        private void DownloadToolsData()
        {
            DataTable toolsTable = new DataTable();
            try
            {
                ReadClass read = new ReadClass("Tools");
                toolsTable = read.GetDataTable();
            }
            catch (SqlException)
            {
                MessageBox.Show($"couldn't get the database", "Unsuccessful operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            var topLeftHeaderCell = toolsDataToolsGridView.TopLeftHeaderCell;
            if (toolsTable != null && topLeftHeaderCell != null)
                toolsDataToolsGridView.DataSource = toolsTable;
        }

        /// <summary>
        /// click button event to add tool with specific quantity to the list of purchases
        /// </summary>
        private void AddTool_Click(object sender, EventArgs e)
        {
            var dataRow = toolsDataToolsGridView.SelectedRows;
            if (quantity_numericUpDown.Value == 0)
                MessageBox.Show($"Please select the quantity of the tool!!", "Quantity Is Zero",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (quantity_numericUpDown.Value > (int)dataRow[0].Cells[5].Value)
                MessageBox.Show($"the quantity of this tool is not available!!", "Unsuccessfully Operation",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                //if user already added this tool
                if (HasBuyingListRow(dataRow))
                {

                    MessageBox.Show($"You have just added this tool!", "Already Exist",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    quantity_numericUpDown.Value = 0;
                    return;

                }
                ArrayList row = new ArrayList
                {
                    dataRow[0].Cells[1].Value.ToString(),
                    dataRow[0].Cells[2].Value.ToString(),
                    dataRow[0].Cells[3].Value.ToString(),
                    quantity_numericUpDown.Value.ToString()
                };
                //add tool to sales table
                selling_list_dataGridView.Rows.Add(row.ToArray());
                toolsDataToolsGridView.SelectedRows[0].Cells[5].Value = (int)toolsDataToolsGridView.SelectedRows[0].Cells[5].Value
                    - (int)quantity_numericUpDown.Value;
            }
            quantity_numericUpDown.Value = 0;
        }

        /// <summary>
        /// check if user has already added specific tool to sales table
        /// </summary>
        /// <param name="dataRow">tool which need to check it</param>
        /// <returns>true if exit in sales table, false if not</returns>
        private bool HasBuyingListRow(DataGridViewSelectedRowCollection dataRow)
        {
            for (int i = 0; i < selling_list_dataGridView.Rows.Count; i++)
            {
                if (selling_list_dataGridView.Rows[i].Cells[0].Value.ToString() == dataRow[0].Cells[1].Value.ToString() &&
                    selling_list_dataGridView.Rows[i].Cells[1].Value.ToString() == dataRow[0].Cells[2].Value.ToString())
                    return true;
            }
            return false;
        }

        /// <summary>
        /// event to delete tool from sales table when click on Delete me button exists in sales table
        /// </summary>
        private void Selling_list_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && selling_list_dataGridView.SelectedRows.Count != 0)
            {
                FixQuantityInDataTools(e.RowIndex);

                selling_list_dataGridView.Rows.RemoveAt(e.RowIndex);
            }
        }

        /// <summary>
        /// this method help to fix the quantity of tools when add or delete it to(from) sales table
        /// </summary>
        /// <param name="rowIndex"> index row where quantity was changed</param>
        private void FixQuantityInDataTools(int rowIndex)
        {
            int index = (from r in toolsDataToolsGridView.Rows.Cast<DataGridViewRow>()
                         where r.Cells[1].Value == selling_list_dataGridView.Rows[rowIndex].Cells[0].Value
                         where r.Cells[2].Value == selling_list_dataGridView.Rows[rowIndex].Cells[1].Value
                         select r.Index).First();
            int quantityInDataTools = (int)toolsDataToolsGridView.Rows[index].Cells[5].Value;
            int quantityInSellingTools = int.Parse(selling_list_dataGridView.Rows[rowIndex].Cells[3].Value.ToString());
            toolsDataToolsGridView.Rows[index].Cells[5].Value = quantityInDataTools + quantityInSellingTools;
        }

        /// <summary>
        /// save delivery data / delete this register from CarRegister database becuase it saved already
        /// in CarDelivery database / move to BillServicingCar form
        /// </summary>
        private void GetInvoice_button_Click(object sender, EventArgs e)
        {
            if (selling_list_dataGridView.Rows.Count > 0)
            {
                string billSerial = GetSerialize();
                List<string> rowDeliveryRegister = new List<string>() {order.Cells[1].Value.ToString(),
                    order.Cells[2].Value.ToString(), order.Cells[3].Value.ToString(), order.Cells[4].Value.ToString(),
                    order.Cells[5].Value.ToString(), order.Cells[6].Value.ToString(),order.Cells[7].Value.ToString(),
                    order.Cells[8].Value.ToString(), order.Cells[9].Value.ToString(),DateTime.Now.ToString(),
                    order.Cells[10].Value.ToString(),note_textBox1.Text,billSerial};
                try
                {
                    CarDeliveryDatabase delivery = new CarDeliveryDatabase();
                    //save delivery data
                    delivery.AddData(rowDeliveryRegister);
                    DeleteFromDatabase write = new DeleteFromDatabase();
                    //delete this register from CarRegister database
                    write.DeleteRow("CarRegister", order.Cells[0].Value.ToString());
                    this.Close();
                    order.Cells[11].Value = note_textBox1.Text;
                    //move to BillServicingCar form
                    BillServicingCar bill = new BillServicingCar(order, billSer: billSerial);
                    bill.ShowDialog();
                }
                catch (SqlException)
                {
                    MessageBox.Show($"couldn't get the database",
                   "Unsuccessful operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
            }
            else
                MessageBox.Show($"You should choose at least one tool!!", "Empty List",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// get string of tools array which was used for client from JSON serialization  
        /// </summary>
        /// <returns>serialized tools array </returns>
        private string GetSerialize()
        {
            Tool[] tools = new Tool[selling_list_dataGridView.Rows.Count];
            for (int i = 0; i < selling_list_dataGridView.Rows.Count; i++)
            {
                tools[i] = new Tool(selling_list_dataGridView.Rows[i]);
            }
            SaveToolsIntoInvoice(tools);
            string getStringJSON = JSONserialize.Serialize(tools);
            return getStringJSON;
        }


        /// <summary>
        /// save saled tools in specefic database
        /// </summary>
        /// <param name="tools"> array of saled tools</param>
        private void SaveToolsIntoInvoice(Tool[] tools)
        {
            Invoice invoice = new Invoice("SalesInvoice");
            List<string> row;
            for (int i = 0; i < tools.Length; i++)
            {
                row = new List<string>() { tools[i].ToolName, tools[i].ToolUnit, (tools[i].Quantity).ToString(),
                    (tools[i].Quantity * tools[i].PurchasePrice).ToString(), DateTime.Now.ToString() };
                invoice.AddData(row);
                toolsDatabase.EditQuantity(tools[i].ToolName, tools[i].ToolUnit, -(int)tools[i].Quantity);
            }
        }

        /// <summary>
        /// event of searching operation
        /// </summary>
        private void ToolUnit_textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable temp = new DataTable();
            if (!serName_textBox1.Text.Contains("'") && !toolUnit_textBox1.Text.Contains("'"))
            {
                temp = toolsDatabase.SearchFor(serName_textBox1.Text, toolUnit_textBox1.Text);
                toolsDataToolsGridView.DataSource = temp;
            }
        }

        /*
         *  these 4 events help to make good Effects when cursor mouse enter or leave  
         *  AddTool_button and GetInvoice_button boundaries
         */
        private void AddTool_MouseEnter(object sender, EventArgs e)
        {
            AddTool.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 126, 49);
            AddTool.ForeColor = System.Drawing.Color.FromArgb(229, 126, 49);
        }
        private void AddTool_MouseLeave(object sender, EventArgs e)
        {
            AddTool.FlatAppearance.BorderColor = System.Drawing.Color.White;
            AddTool.ForeColor = System.Drawing.Color.White;
        }
        private void GetInvoice_button_MouseEnter(object sender, EventArgs e)
        {
            GetInvoice_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 126, 49);
            GetInvoice_button.ForeColor = System.Drawing.Color.FromArgb(229, 126, 49);
        }
        private void GetInvoice_button_MouseLeave(object sender, EventArgs e)
        {
            GetInvoice_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            GetInvoice_button.ForeColor = System.Drawing.Color.White;
        }
    }
}

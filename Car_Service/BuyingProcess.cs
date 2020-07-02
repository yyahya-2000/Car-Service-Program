using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using CarServiceLibrary;
using DataBasesLibrary;
using System.Data.SqlClient;

namespace Car_Service
{
    public partial class BuyingProcess : Form
    {
        readonly DataTable purchases;
        readonly DataTable alldata, baddata;//baddata represent tools which have shortage in their quantity.
        readonly ToolsDatabase tools = new ToolsDatabase();
        //constrocter
        public BuyingProcess()
        {
            InitializeComponent();//F12 to see the functions of this method
            try
            {
                ReadClass toolsData = new ReadClass("Tools");
                alldata = toolsData.GetDataTable();//get all tools data
                baddata = toolsData.GetBadTools();//get bad tools data
            }
            catch (SqlException)
            {
                MessageBox.Show($"couldn't get the database",
                    "Unsuccessful operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            purchases = alldata.Copy();
            purchases.Rows.Clear();
            dataToolsGridView.DataSource = baddata;
        }

        /// <summary>
        /// click button event to add tool with specific quantity to the list of purchases
        /// </summary>
        private void AddTool_button_Click(object sender, EventArgs e)
        {
            if (quantity_numericUpDown.Value == 0)
                MessageBox.Show($"Please select the quantity of the tool!!",
                    "Quantity Is Zero", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var dataRow = dataToolsGridView.SelectedRows;
                //if user already added this tool
                if (HasBuyingListRow(dataRow))
                {
                    MessageBox.Show($"You have just add this tool!", "Already Exist",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    quantity_numericUpDown.Value = 0;
                    return;
                }
                ArrayList row = new ArrayList
                {
                    dataRow[0].Cells[1].Value.ToString(),
                    dataRow[0].Cells[2].Value.ToString(),
                    dataRow[0].Cells[4].Value.ToString(),
                    quantity_numericUpDown.Value.ToString()
                };
                //add tool to purchases list
                Buying_list_dataGridView.Rows.Add(row.ToArray());
                FixTotal();
                string[] temp = new string[dataRow[0].Cells.Count];
                for (int i = 0; i < dataRow[0].Cells.Count; i++)
                {
                    temp[i] = dataRow[0].Cells[i].Value.ToString();
                }
                purchases.Rows.Add(temp);
            }
            quantity_numericUpDown.Value = 0;
        }

        /// <summary>
        /// change total amount of tools price  when add(delete) to(from) purchases list
        /// </summary>
        private void FixTotal()
        {
            double total = 0;
            for (int i = 0; i < Buying_list_dataGridView.Rows.Count; i++)
            {
                total += double.Parse(Buying_list_dataGridView.Rows[i].Cells[2].Value.ToString()) *
                    double.Parse(Buying_list_dataGridView.Rows[i].Cells[3].Value.ToString());
            }
            total_textBox1.Text = total.ToString();
        }

        /// <summary>
        /// check if user has already added specific tool to purchases list
        /// </summary>
        /// <param name="dataRow">tool which need to check it</param>
        /// <returns>true if exit in purchases list, false if not</returns>
        private bool HasBuyingListRow(DataGridViewSelectedRowCollection dataRow)
        {
            for (int i = 0; i < Buying_list_dataGridView.Rows.Count; i++)
            {
                if (Buying_list_dataGridView.Rows[i].Cells[0].Value.ToString() == dataRow[0].Cells[1].Value.ToString() &&
                    Buying_list_dataGridView.Rows[i].Cells[1].Value.ToString() == dataRow[0].Cells[2].Value.ToString())
                    return true;
            }
            return false;
        }

        /// <summary>
        /// event to delete tool from purchases list when click on Delete me button exists in purchases table
        /// </summary>
        private void Buying_list_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Buying_list_dataGridView.Rows.RemoveAt(e.RowIndex);
                FixTotal();
            }
        }

        /// <summary>
        /// button click event to move to SendOrder form where order will be sent to some company
        /// </summary>
        private void Buy_button_Click(object sender, EventArgs e)
        {
            if (Buying_list_dataGridView.Rows.Count > 0)
            {
                SendOrder order = new SendOrder(Buying_list_dataGridView);
                order.Show();
            }
        }



        /// <summary>
        /// event fire when search about somedata into DataGridView
        /// </summary>
        private void ToolUnit_textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable temp = new DataTable();
            if (!serName_textBox1.Text.Contains("'") && !toolUnit_textBox1.Text.Contains("'"))
            {
                temp = tools.SearchFor(serName_textBox1.Text, toolUnit_textBox1.Text);
                dataToolsGridView.DataSource = temp;
            }
        }

        /*
         * these 4 events help to make good Effects when cursor mouse enter or leave  AddTool_button and Buy_button boundaries
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
        private void Buy_button_MouseEnter(object sender, EventArgs e)
        {
            Buy_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 126, 49);
            Buy_button.ForeColor = System.Drawing.Color.FromArgb(229, 126, 49);

        }
        private void Buy_button_MouseLeave(object sender, EventArgs e)
        {
            Buy_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Buy_button.ForeColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// event of checkBox tool to show all tools or only tools which have shortage in their quantity
        /// </summary>
        private void Show_all_tools_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (alldata == baddata)
                MessageBox.Show("true");
            if (Show_all_tools_checkBox.Checked)
                dataToolsGridView.DataSource = alldata;
            else
                dataToolsGridView.DataSource = baddata;
            dataToolsGridView.Refresh();
        }
    }
}

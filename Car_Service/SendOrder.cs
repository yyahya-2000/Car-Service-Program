using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarServiceLibrary;
using DataBasesLibrary;

namespace Car_Service
{
    public partial class SendOrder : Form
    {
        static DataGridView order;
        static ReadClass read;
        Dictionary<string, string> companyNames;
        /// <summary>
        /// constrocter
        /// </summary>
        /// <param name="grid">the data which will be ordered</param>
        public SendOrder(DataGridView grid)
        {
            InitializeComponent();//F12 to see the functions of this method
            try
            {
                read = new ReadClass("Companies");
                order = grid;
                FillCompanyListComboBox();
            }
            catch (SqlException)
            {
                MessageBox.Show($"couldn't get the database", "Unsuccessful operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"{ex.Message}", "Unsuccessful Operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unsuccessful Operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        /// <summary>
        /// download companies from database into Companies ListComboBox
        /// </summary>
        private void FillCompanyListComboBox()
        {
            companyNames = read.GetCompaniesNames();
            foreach (var name in companyNames)
            {
                company_list_comboBox.Items.Add(name.Key);
            }
        }

        /// <summary>
        /// click button event to send order to company by entering required data
        /// </summary>
        private void Send_button_Click(object sender, EventArgs e)
        {
            /*
             * delegate with two methods which will be called back if sending operation was done in send email class
             */
            Del del = SavePurchases;
            del += InitializingBoxes;

            if (!int.TryParse(port_textBox.Text, out int port) && port <= 0)
            {
                MessageBox.Show($"The value of port is invalid!", "Invalid Value",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CheckInput() && !HasInvalidChar() && companyNames.ContainsKey(company_list_comboBox.Text.ToString()))
            {
                SendEmail sending = new SendEmail(userName_textBox.Text, password_textBox.Text, message_textBox.Text,
                    companyNames[company_list_comboBox.Text.ToString()], subject_textBox.Text, smtp_textBox.Text,
                    port, ssl_checkBox.Checked, order);
                sending.Send(del);
            }

        }
        /// <summary>
        /// checking data input
        /// </summary>
        private bool HasInvalidChar()
        {
            if (userName_textBox.Text.Contains(",") || userName_textBox.Text.Contains("'") ||
                 password_textBox.Text.Contains(",") || password_textBox.Text.Contains("'"))
            {
                MessageBox.Show($"there is invalid character(<'>|<,>) in some box !", "Invalid Value",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        /// <summary>
        /// checking data input
        /// </summary>
        private bool CheckInput()
        {
            if (string.IsNullOrEmpty(userName_textBox.Text.Trim()) || string.IsNullOrEmpty(password_textBox.Text.Trim())
                || company_list_comboBox.SelectedItem == null)
            {
                MessageBox.Show($"you have forgot to fill some main information!!", "Invalid operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// saving the bougth tools into ShoppingDatabase
        /// </summary>
        private void SavePurchases()
        {

            ShoppingDatabase writer = new ShoppingDatabase();
            List<string> row = writer.GetSpecificRow(company_list_comboBox.SelectedItem.ToString(), "Companies");
            int length = row.Count;
            List<string> shoppingRow = new List<string>();
            for (int i = 0; i < length - 1; i++)
            {
                shoppingRow.Add(row[i]);
            }
            shoppingRow.Add(DateTime.Now.ToString());
            shoppingRow.Add(GetSerialize());
            writer.AddData("Shopping", inputrow: shoppingRow);
        }

        /// <summary>
        /// Serialize tools array
        /// </summary>
        private string GetSerialize()
        {
            Tool[] tools = new Tool[order.Rows.Count];
            for (int i = 0; i < order.Rows.Count; i++)
            {
                tools[i] = new Tool(order.Rows[i]);
            }
            SaveToolsIntoInvoice(tools);
            string getStringJSON = JSONserialize.Serialize(tools);
            return getStringJSON;
        }

        /// <summary>
        /// save data of bougth tools into specefic database, which help in showing report operation
        /// </summary>
        private void SaveToolsIntoInvoice(Tool[] tools)
        {
            ToolsDatabase toolsDatabase = new ToolsDatabase();
            Invoice invoice = new Invoice("PurchasesInvoice");
            List<string> row;
            for (int i = 0; i < tools.Length; i++)
            {
                row = new List<string>() { tools[i].ToolName, tools[i].ToolUnit, (tools[i].Quantity).ToString(),
                    (tools[i].Quantity * tools[i].PurchasePrice).ToString(), DateTime.Now.ToString() };
                invoice.AddData(row);
                toolsDatabase.EditQuantity(tools[i].ToolName, tools[i].ToolUnit, (int)tools[i].Quantity);
            }
        }

        /*
         * these two events help to make good Effects when cursor mouse enter or leave  
         * Send_button boundaries
         */
        private void Send_button_MouseEnter(object sender, EventArgs e)
        {
            Send_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            Send_button.ForeColor = System.Drawing.Color.DarkGreen;

        }
        private void Send_button_MouseLeave(object sender, EventArgs e)
        {
            Send_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Send_button.ForeColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// clean boxes from previous input
        /// </summary>
        private void InitializingBoxes()
        {
            subject_textBox.Text = "";
            message_textBox.Text = "";
            userName_textBox.Text = "";
            password_textBox.Text = "";
            company_list_comboBox.Text = "Choice Comapny";
        }
    }
}

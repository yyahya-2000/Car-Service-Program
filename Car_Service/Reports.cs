using System;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataBasesLibrary;

namespace Car_Service
{
    public partial class Reports : Form
    {
        readonly EmployeesDatabase employees = new EmployeesDatabase();//help in getting Wages of staffs
        Invoice invoice = new Invoice();
        double staffWages;

        //constrocter
        public Reports()
        {
            InitializeComponent();//F12 to see the functions of this method
            try
            {
                staffWages = employees.GetStaffWages();
                InitializePayment();
                InitializeSales();
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
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"{ex.Message}", "Unsuccessful Operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show($"{ex.Message}", "Unsuccessful Operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            catch (IndexOutOfRangeException ex)
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
        /// fill sales data.
        /// </summary>
        private void InitializeSales()
        {
            ToolsDatabase tools = new ToolsDatabase();
            invoice = new Invoice();
            DataTable sales = invoice.GetforReport(from_dateTimePicker1.Value, to_dateTimePicker2.Value, "SalesInvoice");
            if (sales.Rows.Count > 0)
            {
                sales_dataToolsGridView.DataSource = GetAfterGroup(sales);//group the similer data together 
                DataTable table = (DataTable)sales_dataToolsGridView.DataSource;
                double sum = table.AsEnumerable().Sum(r => r.Field<double>("Total_Amount"));//get sum of Total_Amount in all invoices
                int sumtools = table.AsEnumerable().Sum(r => r.Field<int>("Quantity"));//get sum of Quantity of used tools in all invoices
                soldTools_label.Text = $"Sold Tools:  {sum:0.00}";
                numOfSold_label2.Text = $"Number of sold Tools:  {sumtools}";
            }
            else
            {
                sales_dataToolsGridView.DataSource = sales;
                soldTools_label.Text = $"Sold Tools:";
                numOfSold_label2.Text = $"Number of sold Tools:";
            }
            double totalProfit = 0;
            for (int i = 0; i < sales_dataToolsGridView.Rows.Count; i++)
            {
                totalProfit += double.Parse(sales_dataToolsGridView.Rows[i].Cells[3].Value.ToString()) *
                    tools.GetPurchasesPrice(sales_dataToolsGridView.Rows[i].Cells[1].Value.ToString(),
                    sales_dataToolsGridView.Rows[i].Cells[2].Value.ToString());

            }
            totalProfit_label4.Text = $"Total Profits:  {totalProfit}";
        }

        /// <summary>
        /// fill payment data.
        /// </summary>
        private void InitializePayment()
        {
            /*
             * set staffs wages
             */
            invoice = new Invoice();
            double months = (to_dateTimePicker2.Value.Month + to_dateTimePicker2.Value.Year * 12) -
                (from_dateTimePicker1.Value.Month + from_dateTimePicker1.Value.Year * 12);
            staffWages_label3.Text = $"Staff Wages:  {(months * staffWages):0.00}";

            DataTable payments = invoice.GetforReport(from_dateTimePicker1.Value, to_dateTimePicker2.Value, "PurchasesInvoice");
            if (payments.Rows.Count > 0)
            {
                purchases_dataGridView.DataSource = GetAfterGroup(payments);//group the similer data together 
                DataTable table = (DataTable)purchases_dataGridView.DataSource;
                double sum = table.AsEnumerable().Sum(r => r.Field<double>("Total_Amount"));//get sum of Total_Amount in all invoices
                int sumtools = table.AsEnumerable().Sum(r => r.Field<int>("Quantity"));//get sum of Quantity of bougth tools in all invoices
                purchasesTools_label.Text = $"Purchased Tools:  {sum:0.00}";
                numOfPurchasesTools_label3.Text = $"Number of Purchased Tools:  {sumtools}";
            }
            else
            {
                purchases_dataGridView.DataSource = payments;
                purchasesTools_label.Text = $"Purchased Tools:";
                numOfPurchasesTools_label3.Text = $"Number of Purchased Tools:";
            }
        }

        /// <summary>
        /// method to group datatable
        /// </summary>
        /// <param name="table"> table befor grouping</param>
        /// <returns>table after grouping it </returns>
        private DataTable GetAfterGroup(DataTable table)
        {
            table = table.AsEnumerable()
             .GroupBy(r => new { Col1 = r["Tool_Name"], Col2 = r["Tool_Unit"] })
             /*
              * make anonymous opject every different register
              */
             .Select(g =>
             {
                 var row = table.NewRow();
                 row["ID"] = g.Min(r => r.Field<int>("Id"));
                 row["Tool_Name"] = g.Key.Col1;
                 row["Tool_Unit"] = g.Key.Col2;
                 row["Quantity"] = g.Sum(r => r.Field<int>("Quantity"));
                 row["Total_Amount"] = g.Sum(r => r.Field<double>("Total_Amount"));
                 row["Date"] = g.Min(r => r.Field<DateTime>("Date"));
                 return row;
             })
             .CopyToDataTable();

            return table;
        }

        /// <summary>
        /// event will be fired when data will change
        /// </summary>
        private void To_dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            staffWages = employees.GetStaffWages();
            InitializePayment();
            InitializeSales();
        }
    }
}

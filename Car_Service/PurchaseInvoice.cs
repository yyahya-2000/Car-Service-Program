using System.Windows.Forms;
using CarServiceLibrary;

namespace Car_Service
{
    public partial class PurchaseInvoice : Form
    {
        readonly DataGridViewRow row;//to save received data invoice
        readonly string billSer;//text JSON serialization of tools array (tools which was bought from specefic company)
        public PurchaseInvoice(DataGridViewRow row, string billSer)
        {
            InitializeComponent();
            this.billSer = billSer;//F12 to see the functions of this method
            this.row = row;
            FillData();
            FillDataGridView();
        }

        /// <summary>
        /// deserialize tools array and fill data into dataGridView (table)
        /// </summary>
        private void FillDataGridView()
        {
            double totalAmount = 0;

            Tool[] tools = JSONserialize.Deserialize(billSer);
            for (int i = 0; i < tools.Length; i++)
            {
                totalAmount += tools[i].PurchasePrice * tools[i].Quantity;
                bill_list_dataGridView.Rows.Add(tools[i].ToolName.ToString(), tools[i].ToolUnit.ToString(),
                    tools[i].PurchasePrice.ToString(), tools[i].Quantity.ToString());

            }
            total_textBox2.Text = $"{totalAmount:0.00}";
        }

        /// <summary>
        /// fill client's information in labels
        /// </summary>
        private void FillData()
        {
            id_label2.Text += $"  {row.Cells[0].Value}";
            compName_label.Text += $"  {row.Cells[1].Value}";
            compOwnerlabel2.Text += $"  {row.Cells[2].Value}";
            phone_label2.Text += $"  {row.Cells[3].Value}";
            adress_label.Text += $"  {row.Cells[4].Value}";
            email_label3.Text += $"  {row.Cells[5].Value}";
            date_label.Text += $"  {row.Cells[6].Value}";
        }
    }
}

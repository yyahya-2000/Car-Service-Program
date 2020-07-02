using System;
using System.Windows.Forms;
using CarServiceLibrary;

namespace Car_Service
{
    public partial class BillServicingCar : Form
    {
        readonly DataGridViewRow row;//to save the received row (client's data)
        readonly string billSer;//text JSON serialization of tools array (tools which was used for this client)

        public BillServicingCar(DataGridViewRow row, string billSer)
        {
            InitializeComponent();//F12 to see the functions of this method
            this.billSer = billSer;
            this.row = row;
            FillData();
            FillDataGridView();
        }

        /// <summary>
        /// deserialization tools's array and fill data into dataGridView (table)
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
            fName_label.Text += $"  {row.Cells[1].Value}";
            sName_label3.Text += $"  {row.Cells[2].Value}";
            car_number_label4.Text += $"  {row.Cells[3].Value}";
            CarType_label2.Text += $"  {row.Cells[4].Value}";
            carColor_label3.Text += $"  {row.Cells[5].Value}";
            carModel_label4.Text += $"  {row.Cells[6].Value}";
            phone_label2.Text += $"  {row.Cells[7].Value}";
            adress_label.Text += $"  {row.Cells[8].Value}";
            entry_label.Text += $"  {row.Cells[9].Value}";
            /*
             * these two conditions becuase {row} can be data from CarRegister database or CarDelivery database
             * there is difference in one variabale
             */
            if (row.Cells.Count > 12)
            {
                exit_label7.Text += $"  {row.Cells[10].Value}";
                identification_label.Text += $"  {row.Cells[11].Value}";
                note_textBox1.Text += row.Cells[12].Value.ToString();

            }
            else
            {
                exit_label7.Text += $"  {DateTime.Now}";
                identification_label.Text += $"  {row.Cells[10].Value}";
                note_textBox1.Text += row.Cells[11].Value.ToString();
            }

        }
    }
}

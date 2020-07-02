using System.Windows.Forms;

namespace CarServiceLibrary
{
    /// <summary>
    /// class help to creat tools array from bouth and saled tools in order to serialize it
    /// </summary>
    public class Tool
    {

        /*
         * required variables to save the tools
         */
        string toolName;
        string toolUnit;
        double purchasePrice;
        uint quantity;
        string note;
        public string ToolName { get => toolName; set => toolName = value; }
        public string ToolUnit { get => toolUnit; set => toolUnit = value; }
        public double PurchasePrice { get => purchasePrice; set => purchasePrice = value; }
        public uint Quantity { get => quantity; set => quantity = value; }
        public string Note { get => note; set => note = value; }

        /// <summary>
        /// constrocter
        /// </summary>
        /// <param name="row"> row of some register from datagridview</param>
        public Tool(DataGridViewRow row)
        {
            this.ToolName = row.Cells[0].Value.ToString();
            this.ToolUnit = row.Cells[1].Value.ToString();
            this.PurchasePrice = double.Parse(row.Cells[2].Value.ToString());
            this.Quantity = uint.Parse(row.Cells[3].Value.ToString());
            if (row.Cells[4].Value != null)
                this.Note = row.Cells[4].Value.ToString();

        }
        //becuase of serialization
        public Tool() { }
    }
}

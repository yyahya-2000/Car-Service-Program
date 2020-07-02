using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace DataBasesLibrary
{
    public class ToolsDatabase
    {
        readonly FileInfo file;//help to get the path of database
        static string constring;//help to get the path of database 
        //help in adding new register to database
        static readonly string ToolsData = $"INSERT INTO Tools (Name_Tool, Tool_Unit, Sell_Price, Purchase_Price," +
            $" Current_Quantity, Max_Quantity, Min_Quantity, Note) VALUES (@Name_Tool, @Tool_Unit, @Sell_Price," +
            $" @Purchase_Price, @Current_Quantity, @Max_Quantity, @Min_Quantity, @Note)";
        SqlConnection conn;
        readonly SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapt;

        /// <summary>
        /// constrocter
        /// </summary>
        public ToolsDatabase()
        {
            /*
             * initialize the connection to database
             */
            file = new FileInfo(@"../../CarsDatabase.mdf");
            constring = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={file.FullName};Integrated Security=True";
            conn = new SqlConnection(constring);
        }

        /// <summary>
        /// adding a new register into Tools database
        /// </summary>
        /// <param name="inputrow">get data in list form</param>
        public void AddData(List<string> inputrow)
        {
            cmd.Connection = conn;
            cmd.CommandText = ToolsData;
            conn.Open();
            cmd.Parameters.AddWithValue("@Name_Tool", inputrow[0]);
            cmd.Parameters.AddWithValue("@Tool_Unit", inputrow[1]);
            cmd.Parameters.AddWithValue("@Sell_Price", inputrow[2]);
            cmd.Parameters.AddWithValue("@Purchase_Price", inputrow[3]);
            cmd.Parameters.AddWithValue("@Current_Quantity", inputrow[4]);
            cmd.Parameters.AddWithValue("@Max_Quantity", inputrow[5]);
            cmd.Parameters.AddWithValue("@Min_Quantity", inputrow[6]);
            cmd.Parameters.AddWithValue("@Note", inputrow[7]);
            cmd.ExecuteNonQuery();
            conn.Dispose();
        }

        /// <summary>
        /// edit specific register by knowing Id's register
        /// </summary>
        /// <param name="row">renewed data register</param>
        public void EditRow(List<string> row)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "update Tools set Name_Tool='" + row[1] + "', Tool_Unit='" + row[2] + "'," +
                " Sell_Price='" + row[3] + "', Purchase_Price='" + row[4] + "', Current_Quantity='" + row[5] + "'," +
                " Max_Quantity='" + row[6] + "', Min_Quantity='" + row[7] + "', Note='" + row[8] + "' where Id='" + row[0] + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// update data of specific register
        /// </summary>
        /// <param name="name">tool's name </param>
        /// <param name="unit">tool's unit</param>
        /// <param name="quantity">tool's quantity</param>
        public void EditQuantity(string name, string unit, int quantity)
        {
            List<string> temp = GetSpecificRow(name, unit);
            string note = temp.Count > 7 ? temp[7] : null;
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "update Tools set Name_Tool='" + temp[0] + "', Tool_Unit='" + temp[1] + "', Sell_Price='" + temp[2] + "', " +
                "Purchase_Price='" + temp[3] + "', Current_Quantity='" + (int.Parse(temp[4]) + quantity).ToString() + "'," +
                " Max_Quantity='" + temp[5] + "', Min_Quantity='" + temp[6] + "', Note='" + note + "' " +
                "where Name_Tool='" + name + "' and Tool_Unit='" + unit + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// get specific register from Tools database where tool's name equal 
        /// received name's value  and tools's unit = unit
        /// </summary>
        /// <param name="name">tool's name </param>
        /// <param name="unit">tool's unit</param>
        /// <returns></returns>
        public List<string> GetSpecificRow(string name, string unit)
        {
            List<string> row = new List<string>();
            using (SqlConnection conn = new SqlConnection(constring))
            {
                string SQL = $"select * from Tools where Name_Tool='" + name + "' and Tool_Unit='" + unit + "'";
                conn.Open();
                using (SqlDataReader reader = new SqlCommand(SQL, conn).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 1; i < reader.FieldCount - 1; i++)
                        {
                            row.Add(reader[i].ToString());

                        }
                    }
                }
            }
            return row;
        }

        /// <summary>
        ///  get all data from Tools database which have similar tool's name  and tools's unit
        /// </summary>
        /// <param name="name">tool's name</param>
        /// <param name="unit">tool's unit</param>
        /// <returns></returns>
        public DataTable SearchFor(string name, string unit)
        {
            DataTable dt;
            conn.Open();
            adapt = new SqlDataAdapter("select * from Tools where Name_Tool like '" + name + "%' and Tool_Unit like '" + unit + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            conn.Close();
            return dt;
        }

        /// <summary>
        /// get purchases price of specific register knowing tool's name and tool's unit
        /// </summary>
        /// <param name="name">tool's name</param>
        /// <param name="unit">tool's unit</param>
        /// <returns></returns>
        public double GetPurchasesPrice(string name, string unit)
        {
            double price = 0;
            conn = new SqlConnection(constring);
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("select Purchase_Price from Tools where Name_Tool='" + name + "' and " +
                "Tool_Unit ='" + unit + "'", conn))
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    price = double.Parse(rdr.GetValue(0).ToString());
                }
            }
            return price;

        }
    }
}

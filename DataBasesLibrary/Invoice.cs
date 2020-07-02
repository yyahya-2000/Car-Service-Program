using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DataBasesLibrary
{
    public class Invoice
    {
        readonly FileInfo file;//help to get the path of database
        static string constring;//help to get the path of database 
        readonly string invoiceData;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapt;

        /// <summary>
        /// constrocter
        /// </summary>
        /// <param name="dataBaseName"> name of database</param>
        public Invoice(string dataBaseName) : this()
        {
            //help in adding new register to database
            invoiceData = $"INSERT INTO {dataBaseName} (Tool_Name, Tool_Unit, Quantity, Total_Amount, Date) " +
                $"VALUES (@Tool_Name, @Tool_Unit, @Quantity, @Total_Amount, @Date)";

        }
        /// <summary>
        /// constrocter
        /// </summary>
        public Invoice()
        {
            /*
             * initialize the connection to database
             */
            file = new FileInfo(@"../../CarsDatabase.mdf");
            constring = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={file.FullName};Integrated Security=True";
        }
        /// <summary>
        /// adding a new register into Invoices database (there is two)
        /// </summary>
        /// <param name="inputrow">get data in list form</param>
        public void AddData(List<string> inputrow)
        {
            conn = new SqlConnection(constring);
            cmd = new SqlCommand(invoiceData)
            {
                Connection = conn
            };
            conn.Open();
            cmd.Parameters.AddWithValue("@Tool_Name", inputrow[0]);
            cmd.Parameters.AddWithValue("@Tool_Unit", inputrow[1]);
            cmd.Parameters.AddWithValue("@Quantity", inputrow[2]);
            cmd.Parameters.AddWithValue("@Total_Amount", inputrow[3]);
            cmd.Parameters.AddWithValue("@Date", inputrow[4]);
            cmd.ExecuteNonQuery();
            conn.Dispose();
        }


        /// <summary>
        /// get registers of tools between two specific periods
        /// </summary>
        /// <param name="from">the first period</param>
        /// <param name="to">the secod period</param>
        /// <param name="namedata">name of database</param>
        /// <returns></returns>
        public DataTable GetforReport(DateTime from, DateTime to, string namedata)
        {
            DataTable tempDT = new DataTable();
            tempDT.Columns.Add("Id", typeof(int));
            tempDT.Columns.Add("Tool_Name", typeof(string));
            tempDT.Columns.Add("Tool_Unit", typeof(string));
            tempDT.Columns.Add("Quantity", typeof(int));
            tempDT.Columns.Add("Total_Amount", typeof(double));
            tempDT.Columns.Add("Date", typeof(DateTime));
            conn = new SqlConnection(constring);
            conn.Open();
            adapt = new SqlDataAdapter($"SELECT * FROM {namedata} where Date between '" + from + "' and '" + to + "'", conn);
            adapt.Fill(tempDT);
            conn.Close();
            return tempDT;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace DataBasesLibrary
{
    public class ShoppingDatabase
    {
        readonly FileInfo file;//help to get the path of database
        static string constring;//help to get the path of database 
        //help in adding new register to database
        static readonly string shoppingData = $"INSERT INTO Shopping (Company_Name, Company_Owner, Phone_Number, Adress, " +
            $"Email, Date, Bill) VALUES (@Company_Name, @Company_Owner, @Phone_Number, @Adress, @Email, @Date, @Bill)";
        SqlDataAdapter adapt;
        readonly SqlConnection conn;
        SqlCommand cmd;

        /// <summary>
        /// constrocter
        /// </summary>
        public ShoppingDatabase()
        {
            /*
             * initialize the connection to database
             */
            file = new FileInfo(@"../../CarsDatabase.mdf");
            constring = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={file.FullName};Integrated Security=True";
            conn = new SqlConnection(constring);
        }



        /// <summary>
        /// adding a new register into ShoppingDatabase database
        /// </summary>
        /// <param name="tableName">name of database</param>
        /// <param name="inputrow">list of data which will be added to database</param>
        public void AddData(string tableName, List<string> inputrow = null)
        {
            #region Add data to Shopping Database
            cmd = new SqlCommand(shoppingData)
            {
                Connection = conn
            };
            conn.Open();
            cmd.Parameters.AddWithValue("@Company_Name", inputrow[0]);
            cmd.Parameters.AddWithValue("@Company_Owner", inputrow[1]);
            cmd.Parameters.AddWithValue("@Phone_Number", inputrow[2]);
            cmd.Parameters.AddWithValue("@Adress", inputrow[3]);
            cmd.Parameters.AddWithValue("@Email", inputrow[4]);
            cmd.Parameters.AddWithValue("@Date", inputrow[5]);
            cmd.Parameters.AddWithValue("@Bill", Encoding.ASCII.GetBytes(inputrow[6]));
            cmd.ExecuteNonQuery();
            conn.Dispose();
            #endregion
        }

        /// <summary>
        /// get specific register from Shoppingdatabase or from CompaniesDatabase where name of company equal 
        /// received name's value 
        /// </summary>
        /// <param name="name">company name </param>
        /// <param name="tableName">name of database</param>
        /// <returns></returns>
        public List<string> GetSpecificRow(string name, string tableName)
        {
            List<string> row = new List<string>();
            using (SqlConnection conn = new SqlConnection(constring))
            {
                string SQL = $"select * from {tableName} where Company_name='" + name + "'";
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
        /// get specific register from Shopping database knowing id's  register
        /// </summary>
        /// <param name="id">id of data register</param>
        /// <returns></returns>
        public string GetBillRow(int id)
        {
            string SQL = $"select * from Shopping where Id='" + id + "'";
            string temp = null;
            conn.Open();
            using (SqlDataReader reader = new SqlCommand(SQL, conn).ExecuteReader())
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (i == 7)
                        {
                            temp = Encoding.ASCII.GetString((byte[])reader[i]);
                        }

                    }
                }
            }
            return temp;


        }

        /// <summary>
        /// get data from Shopping database which has register time between two periods of time, similar company's name and similar company's owner name
        /// </summary>
        /// <param name="name">company's name</param>
        /// <param name="owner"> company's owner name</param>
        /// <param name="from">first period</param>
        /// <param name="to">second period</param>
        /// <returns>datatabe of found data</returns>
        public DataTable SearchFor(string name, string owner, DateTime from, DateTime to)
        {
            DataTable dt;
            conn.Open();
            adapt = new SqlDataAdapter("select * from Shopping where Company_Name like '" + name + "%' and Company_Owner like '" + owner + "%' and Date between '" + from + "' and '" + to + "' ", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            conn.Close();
            return dt;
        }

        /// <summary>
        /// get list of bills values which was added in specific period
        /// </summary>
        /// <param name="from">start period</param>
        /// <param name="to">end period</param>
        /// <returns></returns>
        public List<string> GetforReport(DateTime from, DateTime to)
        {
            List<string> dates = new List<string>();

            using (SqlCommand cmd = new SqlCommand("SELECT Bill FROM Shopping where Date between '" + from + "' and '" + to + "'", conn))
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    dates.Add(Encoding.ASCII.GetString((byte[])rdr.GetValue(0)));
                }
            }
            return dates;
        }
    }
}

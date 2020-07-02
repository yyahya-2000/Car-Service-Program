using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace DataBasesLibrary
{
    public class CompaniesDataBase
    {
        readonly FileInfo file;//help to get the path of database 
        static string constring;//to save the conection text to database
        //help in adding register to database
        static readonly string companiesData = $"INSERT INTO Companies (Company_Name, Company_Owner, Phone_Number, Company_Adress, " +
            $"Company_Email, Date, Note) VALUES (@Company_Name, @Company_Owner, @Phone_Number, @Company_Adress, @Company_Email, @Date, @Note)";
        readonly SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapt;

        /// <summary>
        /// constrocter
        /// </summary>
        public CompaniesDataBase()
        {
            /*
             * initialize the connection to database
             */
            file = new FileInfo(@"../../CarsDatabase.mdf");
            constring = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={file.FullName};Integrated Security=True";
            conn = new SqlConnection(constring);
        }


        /// <summary>
        /// adding a data into database
        /// </summary>
        /// <param name="inputrow">get data in list form</param>
        public void AddData(List<string> inputrow = null)
        {
            #region Add data to Companies Database
            cmd = new SqlCommand(companiesData)
            {
                Connection = conn
            };
            conn.Open();
            cmd.Parameters.AddWithValue("@Company_Name", inputrow[0]);
            cmd.Parameters.AddWithValue("@Company_Owner", inputrow[1]);
            cmd.Parameters.AddWithValue("@Phone_Number", inputrow[2]);
            cmd.Parameters.AddWithValue("@Company_Adress", inputrow[3]);
            cmd.Parameters.AddWithValue("@Company_Email", inputrow[4]);
            cmd.Parameters.AddWithValue("@Date", inputrow[5]);
            cmd.Parameters.AddWithValue("@Note", inputrow[6]);
            cmd.ExecuteNonQuery();
            conn.Dispose();
            #endregion
        }
        /// <summary>
        /// edit data of specific register in Companies database
        /// </summary>
        /// <param name="row">the renewed data of specific register</param>
        public void EditRow(List<string> row)
        {
            cmd = new SqlCommand("update Companies set Company_Name='" + row[1] + "', Company_Owner='" + row[2] + "'," +
                " Phone_Number='" + row[3] + "', Company_Adress='" + row[4] + "', Company_Email='" + row[5] + "'," +
                " Date='" + row[6] + "', Note='" + row[7] + "' where Id='" + row[0] + "'");
            conn.Open();
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        /// <summary>
        /// get all data from Companies database which have similar company name and company's owner name
        /// </summary>
        /// <param name="name">company name</param>
        /// <param name="owner">company's owner name</param>
        /// <returns></returns>
        public DataTable SearchFor(string name, string owner)
        {
            DataTable dt = new DataTable();
            conn.Open();
            adapt = new SqlDataAdapter("select * from Companies where Company_name like '" + name + "%' and Company_Owner like '" + owner + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            conn.Close();
            return dt;
        }

        /// <summary>
        /// get specific register from Companies data base by knowing company name and company's  owner name 
        /// </summary>
        /// <param name="name">company name</param>
        /// <param name="owner">company's owner name</param>
        /// <returns></returns>
        public List<string> GetSpecificRow(string name, string owner)
        {
            List<string> row = new List<string>();
            using (SqlConnection conn = new SqlConnection(constring))
            {
                string SQL = $"select * from Companies where Company_name='" + name + "' and Company_Owner='" + owner + "'";
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
    }
}

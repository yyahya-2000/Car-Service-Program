using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace DataBasesLibrary
{
    public class UserDatabase
    {
        readonly FileInfo file;//help to get the path of database
        static string constring;//help to get the path of database
        //help in adding new register to database
        static readonly string usersData = $"INSERT INTO users (User_Name, Password, Is_Admain, " +
            $"Note) VALUES (@User_Name, @Password, @Is_Admain, @Note)";
        readonly SqlConnection conn;
        SqlDataAdapter adapt;
        SqlCommand cmd;

        /// <summary>
        /// constrocter
        /// </summary>
        public UserDatabase()
        {
            /*
             * initialize the connection to database
             */
            file = new FileInfo(@"../../CarsDatabase.mdf");
            constring = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={file.FullName};Integrated Security=True";
            conn = new SqlConnection(constring);
        }

        /// <summary>
        /// adding a new register into users database
        /// </summary>
        /// <param name="inputrow">get data in list form</param>
        public void AddData(List<string> inputrow)
        {
            cmd = new SqlCommand(usersData)
            {
                Connection = conn
            };
            conn.Open();
            cmd.Parameters.AddWithValue("@User_Name", inputrow[0]);
            cmd.Parameters.AddWithValue("@Password", inputrow[1]);
            cmd.Parameters.AddWithValue("@Is_Admain", inputrow[2]);
            cmd.Parameters.AddWithValue("@Note", inputrow[3]);
            cmd.ExecuteNonQuery();
            conn.Dispose();
        }

        /// <summary>
        /// edit specific register by knowing Id's register
        /// </summary>
        /// <param name="row">renewed data register</param>
        public void EditRow(List<string> row)
        {
            cmd = new SqlCommand("update users set User_Name='" + row[1] + "', Password='" + row[2] + "'," +
                " Is_Admain='" + row[3] + "', Note='" + row[4] + "' where Id='" + row[0] + "'");
            conn.Open();
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        ///  get all data from users database which have similar name
        /// </summary>
        /// <param name="name">user name</param>
        public DataTable SearchFor(string name)
        {
            DataTable dt = new DataTable();
            conn.Open();
            adapt = new SqlDataAdapter("select * from users where User_Name like '" + name + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            conn.Close();
            return dt;
        }

        /// <summary>
        ///  get specific register from Tools database where user name equal 
        ///  received name's value  and user's password = password
        /// </summary>
        /// <param name="name">user name </param>
        /// <param name="password">user password</param>
        /// <returns></returns>
        public List<string> GetSpecificRow(string name, string password)
        {
            List<string> row = new List<string>();
            using (SqlConnection conn = new SqlConnection(constring))
            {
                string SQL = $"select * from users where User_Name='" + name + "' and Password='" + password + "'";
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

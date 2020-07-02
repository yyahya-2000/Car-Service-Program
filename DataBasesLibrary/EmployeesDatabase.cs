using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace DataBasesLibrary
{
    public class EmployeesDatabase
    {
        readonly FileInfo file;//help to get the path of database
        static string constring;//help to get the path of database 
        //help in adding new register to database
        static readonly string staffsData = $"INSERT INTO Staffs (Name, Adresse, Phone_Number, Career_Type, Salary, " +
            $"Registration_Time, Note) VALUES (@Name, @Adresse, @Phone_Number, @Career_Type, @Salary, @Registration_Time, @Note)";
        readonly SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapt;

        /// <summary>
        /// constrocter
        /// </summary>
        public EmployeesDatabase()
        {
            /*
             * initialize the connection to database
             */
            file = new FileInfo(@"../../CarsDatabase.mdf");
            constring = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={file.FullName};Integrated Security=True";
            conn = new SqlConnection(constring);
        }


        /// <summary>
        /// adding a new register into Staffs database
        /// </summary>
        /// <param name="inputrow">get data in list form</param>
        public void AddData(List<string> inputrow)
        {

            cmd = new SqlCommand(staffsData)
            {
                Connection = conn
            };
            conn.Open();
            cmd.Parameters.AddWithValue("@Name", inputrow[0]);
            cmd.Parameters.AddWithValue("@Adresse", inputrow[1]);
            cmd.Parameters.AddWithValue("@Phone_Number", inputrow[2]);
            cmd.Parameters.AddWithValue("@Career_Type", inputrow[3]);
            cmd.Parameters.AddWithValue("@Salary", inputrow[4]);
            cmd.Parameters.AddWithValue("@Registration_Time", inputrow[5]);
            cmd.Parameters.AddWithValue("@Note", inputrow[6]);
            cmd.ExecuteNonQuery();
            conn.Dispose();
        }

        /// <summary>
        /// edit data of specific register in Staffs database
        /// </summary>
        /// <param name="row">the renewed data of specific register</param>
        public void EditRow(List<string> row)
        {
            cmd = new SqlCommand("update Staffs set Name='" + row[1] + "', Adresse='" + row[2] + "'," +
                " Phone_Number='" + row[3] + "', Career_Type='" + row[4] + "', Salary='" + row[5] + "'," +
                " Registration_Time='" + row[6] + "', Note='" + row[7] + "' where Id='" + row[0] + "'");
            conn.Open();
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// get all data from Staffs database which have similar employee name
        /// </summary>
        /// <param name="name">employee name</param>
        /// <returns></returns>
        public DataTable SearchFor(string name)
        {
            DataTable dt = new DataTable();
            conn.Open();
            adapt = new SqlDataAdapter("select * from Staffs where Name like '" + name + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            conn.Close();
            return dt;
        }

        /// <summary>
        /// getting the sum of salaries of all employees
        /// </summary>
        /// <returns></returns>
        public double GetStaffWages()
        {
            conn.Open();
            SqlCommand query = new SqlCommand("select SUM(Salary) from Staffs", conn);
            double staffWages = double.Parse(query.ExecuteScalar().ToString());
            conn.Close();
            return staffWages;
        }

        /// <summary>
        /// get specific register from Staffs data base by knowing employee name
        /// </summary>
        /// <param name="name">employee name</param>
        /// <returns></returns>
        public List<string> GetSpecificRow(string name)
        {
            List<string> row = new List<string>();
            using (SqlConnection conn = new SqlConnection(constring))
            {
                string SQL = $"select * from Staffs where Name='" + name + "'";
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

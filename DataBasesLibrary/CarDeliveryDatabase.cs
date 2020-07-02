using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace DataBasesLibrary
{
    public class CarDeliveryDatabase
    {
        static FileInfo file;//help to get the path of database 
        static string constring;//to save the conection text to database
        //help in adding register to database
        static readonly string carDeliveryData = $"INSERT INTO CarDelivery (First_Name, Second_Name, Car_Number," +
            $" Car_Type, Car_Color, Car_Model, Phone_Number, Adress, Entry_Date, Exit_Date, Identification_Number, Note, Bill)" +
            $" VALUES (@First_Name, @Second_Name, @Car_Number, @Car_Type, @Car_Color, @Car_Model, @Phone_Number, @Adress, @Entry_Date," +
            $" @Exit_Date, @Identification_Number, @Note, @Bill)";
        readonly SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapt;

        /// <summary>
        /// constrocter
        /// </summary>
        public CarDeliveryDatabase()
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
        public void AddData(List<string> inputrow)
        {
            cmd = new SqlCommand(carDeliveryData)
            {
                Connection = conn
            };
            conn.Open();
            cmd.Parameters.AddWithValue("@First_Name", inputrow[0]);
            cmd.Parameters.AddWithValue("@Second_Name", inputrow[1]);
            cmd.Parameters.AddWithValue("@Car_Number", inputrow[2]);
            cmd.Parameters.AddWithValue("@Car_Type", inputrow[3]);
            cmd.Parameters.AddWithValue("@Car_Color", inputrow[4]);
            cmd.Parameters.AddWithValue("@Car_Model", inputrow[5]);
            cmd.Parameters.AddWithValue("@Phone_Number", inputrow[6]);
            cmd.Parameters.AddWithValue("@Adress", inputrow[7]);
            cmd.Parameters.AddWithValue("@Entry_Date", inputrow[8]);
            cmd.Parameters.AddWithValue("@Exit_Date", inputrow[9]);
            cmd.Parameters.AddWithValue("@Identification_Number", inputrow[10]);
            cmd.Parameters.AddWithValue("@Note", inputrow[11]);
            cmd.Parameters.AddWithValue("@Bill", Encoding.ASCII.GetBytes(inputrow[12]));
            cmd.ExecuteNonQuery();
            conn.Dispose();
        }

        /// <summary>
        /// get serialized bill of specefic register from CarDelivery database by knowing Id
        /// </summary>
        /// <param name="id"> id of specefic register </param>
        /// <returns></returns>
        public string GetBillRow(int id)
        {
            string SQL = $"select * from CarDelivery where Id='" + id + "'";
            string temp = null;
            conn.Open();
            using (SqlDataReader reader = new SqlCommand(SQL, conn).ExecuteReader())
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (i == 13)
                        {
                            temp = Encoding.ASCII.GetString((byte[])reader[i]);
                        }

                    }
                }
            }
            return temp;
        }

        /// <summary>
        /// get data which was added to CarDelivery database between two specefic periods 
        /// </summary>
        /// <param name="searchClient">list of client's information</param>
        /// <param name="from">the first period</param>
        /// <param name="to">the second period</param>
        /// <returns></returns>
        public DataTable SearchFor(List<string> searchClient, DateTime from, DateTime to)
        {
            DataTable dt = new DataTable();
            conn.Open();
            adapt = new SqlDataAdapter("select * from CarDelivery where First_Name like '" + searchClient[0] + "%' and Second_Name like '" + searchClient[1] + "%' and " +
                "Car_Number like '" + searchClient[2] + "%' and Car_Type like '" + searchClient[3] + "%' and Car_Color like '" + searchClient[4] + "%' and Car_Model like '" + searchClient[5] + "%' and Entry_Date between '" + from + "' and '" + to + "'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            conn.Close();
            return dt;
        }

        /// <summary>
        /// get column built from bills of cars which was delivered in some selected period
        /// </summary>
        /// <param name="from">the first period</param>
        /// <param name="to">the second period</param>
        /// <returns></returns>
        public List<string> GetforReport(DateTime from, DateTime to)
        {
            List<string> dates = new List<string>();
            using (SqlCommand cmd = new SqlCommand("SELECT Bill FROM CarDelivery where Exit_Date between '" + from + "' and '" + to + "'", conn))
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

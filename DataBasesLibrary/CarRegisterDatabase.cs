using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace DataBasesLibrary
{
    public class CarRegisterDatabase
    {
        readonly FileInfo file;//help to get the path of database 
        static string constring;//to save the conection text to database
        //help in adding new register to database
        static readonly string carRegisterData = $"INSERT INTO CarRegister (First_Name, Second_Name," +
            $" Car_Number,Car_Type, Car_Color, Car_Model, Phone_Number, Adress, Entry_Date, Identification_Number, Note) VALUES (@First_Name, " +
            $"@Second_Name, @Car_Number, @Car_Type, @Car_Color, @Car_Model, @Phone_Number, @Adress, @Entry_Date, @Identification_Number, @Note)";

        /// <summary>
        /// constrocter
        /// </summary>
        public CarRegisterDatabase()
        {
            /*
             * initialize the connection to database
             */
            file = new FileInfo(@"../../CarsDatabase.mdf");
            constring = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={file.FullName};Integrated Security=True";
        }
        /// <summary>
        /// adding new register into CarRegister database
        /// </summary>
        /// <param name="inputrow">get data in list form</param>
        public void AddData(List<string> inputrow)
        {
            SqlConnection conn = new SqlConnection(constring);
            SqlCommand cmd;
            cmd = new SqlCommand(carRegisterData)
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
            cmd.Parameters.AddWithValue("@Identification_Number", inputrow[9]);
            cmd.Parameters.AddWithValue("@Note", inputrow[10]);
            cmd.ExecuteNonQuery();
            conn.Dispose();
        }
    }
}

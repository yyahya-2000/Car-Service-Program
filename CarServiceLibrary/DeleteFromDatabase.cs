using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace CarServiceLibrary
{

    public class DeleteFromDatabase
    {
        readonly FileInfo file;//help to get the path of database 
        static string constring;//to save the conection text to database
        static SqlConnection conn;
        static SqlCommand cmd;

        /// <summary>
        /// constrocter
        /// </summary>
        public DeleteFromDatabase()
        {
            /*
             * initialize the connection to database
             */
            file = new FileInfo(@"../../CarsDatabase.mdf");
            constring = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={file.FullName};Integrated Security=True";
            conn = new SqlConnection(constring);
        }

        /// <summary>
        /// delete specefic register from database
        /// </summary>
        /// <param name="nameDatabase"> the name of database</param>
        /// <param name="Id"> id register in database</param>
        public void DeleteRow(string nameDatabase, string Id)
        {
            try
            {
                cmd = new SqlCommand($"delete from {nameDatabase} where Id='" + Id + "'");
                conn.Open();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show($"couldn't delete this data", "Unsuccessful operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"{ex.Message}", "Unsuccessful Operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unsuccessful Operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
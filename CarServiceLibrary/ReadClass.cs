using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace CarServiceLibrary
{
    public class ReadClass
    {

        static SqlConnection Sql;
        readonly DataTable table = new DataTable();
        static FileInfo file;//help to get the path of database 
        static string constring;//to save the conection text to database

        public ReadClass(string dataBaseName)
        {
            /*
            * initialize the connection to database
            */
            file = new FileInfo(@"../../CarsDatabase.mdf");
            constring = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={file.FullName};Integrated Security=True";
            Sql = new SqlConnection(constring);
            GetData(dataBaseName);
        }

        /// <summary>
        /// get all data from specefic database
        /// </summary>
        /// <param name="dataBaseName"> name of database</param>
        private void GetData(string dataBaseName)
        {
            Sql.Open();
            SqlDataAdapter ad = new SqlDataAdapter($"select * from {dataBaseName}", Sql);
            ad.Fill(table);
            Sql.Close();

        }
        /// <summary>
        /// help to get the database useing object of this class
        /// </summary>
        /// <returns>the data which was downloaded from specefic database</returns>
        public DataTable GetDataTable() => table;

        /// <summary>
        /// find tools data which have shortage in their quantity and return it
        /// </summary>
        public DataTable CheckTools()
        {
            DataTable badTools = new DataTable();
            badTools.Columns.Add("Tool_Name", typeof(string));
            badTools.Columns.Add("Min_Quan", typeof(string));
            badTools.Columns.Add("Max_Quan", typeof(string));
            badTools.Columns.Add("Current_Quan", typeof(string));
            object[] val = null;
            for (int i = 1; i < table.Rows.Count; i++)
            {
                val = table.Rows[i].ItemArray;

                if ((int)val[5] < (int)val[7])
                {
                    badTools.Rows.Add(val[1].ToString(), val[7].ToString(), val[6].ToString(), val[5].ToString());
                }

            }
            return badTools;
        }
        /// <summary>
        /// return tools data which have shortage in their quantity but in this method 
        /// will be returned all preporties of the these tools
        /// </summary>
        /// <returns></returns>
        public DataTable GetBadTools()
        {
            DataTable temp = table.Copy();
            object[] val;
            DataRow row = temp.NewRow();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                val = temp.Rows[i].ItemArray;
                if ((int)val[5] >= (int)val[7])
                {
                    temp.Rows[i].Delete();
                }
            }
            return temp;
        }

        /// <summary>
        /// creat dictioary of companies where keys this dictionary is the names and 
        /// the values is email addresses of companies and return this dictionary
        /// </summary>
        public Dictionary<string, string> GetCompaniesNames()
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            object[] val = null;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                val = table.Rows[i].ItemArray;
                names.Add(val[1].ToString(), val[5].ToString());
            }

            return names;
        }

    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Class
{
    public class MySQLDaTaHoya
    {
        public static string pwd { get; set; }
        //public static string pwd = "12345678";
        public string error_message;
        //public static string Server = "127.0.0.1";
        public static string Server { get; set; }
        public static string UId { get { return "root"; } }
        public static string Database { get { return "hoyadata"; } }


       // private static MySqlConnection _sQL_Connection = new MySqlConnection("Server = " + Server + ";Database =" + Database + "; UId = " + UId + "; Pwd = " + pwd + "; Pooling = false; Character Set=utf8; SslMode=none");


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Db"></param>
        /// <param name="TB"></param>
        /// <returns></returns>
        private string Check_Table_Exits(string Db, string TB)
        {
            string check = "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = '" + Db + "' AND table_name = '" + TB + "'";
            return check;
        }
        //private string StrCon = "Server = " + Server + "; UId = root; Pwd = " + pwd + "; Pooling = false; Character Set=utf8";
        private string StrCon(string Server, string pwd)
        {
            string Set = "Server = " + Server + "; UId = " + UId + "; Pwd = " + pwd + "; Pooling = false; Character Set=utf8; SslMode=none";
            return Set;
        }
        private string StrCon_Database(string Server, string pwd, string database)
        {
            string set = "Server = " + Server + ";Database =" + database + "; UId = " + UId + "; Pwd = " + pwd + "; Pooling = false; Character Set=utf8; SslMode=none";
            return set;
        }

        #region *******************************************PERMISSION*************************************************
        public string MD5Genrate(string pass)
        {
            string MD5String = string.Empty;
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            foreach (byte item in hasData)
            {
                MD5String += item;
            }
            return MD5String;
        }



        #endregion
        //public DataTable Get_Database_Name()
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {

        //        if (SQL_Connection.State == ConnectionState.Closed)
        //        {
        //            SQL_Connection.Open();
        //        }
        //        dt = SQL_Connection.GetSchema("Databases");
        //        error_message = string.Empty;
        //        SQL_Connection.Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        error_message = ex.Message;
        //        return dt;
        //    }

        //}
        //public List<string> Get_table_Name(string datebase)
        //{
        //    DataTable dt = new DataTable();
        //    List<string> listName = new List<string>();
        //    try
        //    {

        //        if (SQL_Connection.State == ConnectionState.Closed)
        //        {
        //            SQL_Connection.Open();
        //        }
        //        //using (MySqlCommand com = new MySqlCommand(" SELECT * FROM sys.tables where table_schema = 'agv_data'", con))
        //        using (MySqlCommand com = new MySqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'AND TABLE_SCHEMA='" + datebase + "' ", SQL_Connection))
        //        {

        //            using (MySqlDataReader reader = com.ExecuteReader())
        //            {

        //                while (reader.Read())
        //                {
        //                    listName.Add((string)reader["TABLE_NAME"]);
        //                }
        //            }
        //        }
        //        error_message = string.Empty;
        //        return listName;

        //    }
        //    catch (Exception ex)
        //    {

        //        error_message = ex.Message;
        //        return listName;
        //    }

        //}
        //public int count = 0;
        //public DataTable Fill_data(string database, string table)
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        if (SQL_Connection.State == ConnectionState.Closed)
        //        {
        //            SQL_Connection.Open();
        //        }

        //        string str = "SELECT * FROM " + table + "";
        //        MySqlDataAdapter adp = new MySqlDataAdapter(str, SQL_Connection);
        //        MySqlCommandBuilder cmd = new MySqlCommandBuilder(adp);

        //        adp.Fill(dt);
        //        SQL_Connection.Close();
        //        error_message = string.Empty;
        //        return dt;


        //    }
        //    catch (Exception ex)
        //    {

        //        error_message = ex.Message;
        //        return dt;
        //    }
        //}
        /// <summary>
        /// Đọc Bàng Có Điều Kiện
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public DataTable Read_Table_Group(string str)
        {
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlData;
            try
            {
                using (MySqlConnection SQL_Connection = new MySqlConnection("Server = " + Server + ";Database =" + Database + "; UId = " + UId + "; Pwd = " + pwd + "; Pooling = false; Character Set=utf8; SslMode=none"))
                {
                    SQL_Connection.Open();

                    mySqlData = new MySqlDataAdapter(str, SQL_Connection);
                    MySqlCommandBuilder mySqlCommand = new MySqlCommandBuilder(mySqlData);
                    mySqlData.Fill(dataTable);
                    SQL_Connection.Close();
                    error_message = string.Empty;
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
                return dataTable;
            }
        }

        public bool SQL_command(string command, string database)
        {
            try
            {

                using (MySqlConnection SQL_Connection = new MySqlConnection("Server = " + Server + ";Database =" + Database + "; UId = " + UId + "; Pwd = " + pwd + "; Pooling = false; Character Set=utf8; SslMode=none"))
                {

                    SQL_Connection.Open();
                    MySqlCommand cmd = new MySqlCommand(command, SQL_Connection);
                    cmd.ExecuteNonQuery();
                    SQL_Connection.Close();
                    error_message = string.Empty;
                }
                return true;

            }
            catch (Exception ex)
            {
                using (MySqlConnection SQL_Connection = new MySqlConnection("Server = " + Server + ";Database =" + Database + "; UId = " + UId + "; Pwd = " + pwd + "; Pooling = false; Character Set=utf8; SslMode=none"))
                {
                    SQL_Connection.Close();
                    error_message = ex.Message;
                }

                return false;
            }
        }
        public string getLimitRow(int low, int high)
        {
            string aa = " LIMIT " + low.ToString() + ", " + high.ToString() + "";
            return aa;
        }

        /// <summary>
        /// Lấy dữ liệu ban đầu từ Server
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="table_Name"></param>
        /// <param name="Database"></param>
        /// <returns></returns>
        public void GetData_FroM_Database(ref DataTable dataTable, string table_Name, string database, string limit = "")
        {
            MySqlDataAdapter mySqlData;
            try
            {
                using (MySqlConnection SQL_Connection = new MySqlConnection("Server = " + Server + ";Database =" + Database + "; UId = " + UId + "; Pwd = " + pwd + "; Pooling = false; Character Set=utf8; SslMode=none"))
                {
                    SQL_Connection.Open();
                    string Query = "SELECT * FROM " + table_Name + "" + limit + "";
                    mySqlData = new MySqlDataAdapter(Query, SQL_Connection);
                    MySqlCommandBuilder mySqlCommand = new MySqlCommandBuilder(mySqlData);
                    mySqlData.Fill(dataTable);
                    SQL_Connection.Close();
                    error_message = string.Empty;
                }
            }
            catch (Exception ex)
            {

                error_message = ex.Message;

            }



        }

      
       
        public T ConvertFromDBVal<T>(object obj)
        {
            if (obj == null || obj == DBNull.Value)
            {
                return default(T); // returns the default value for the type
            }
            else
            {
                return (T)obj;
            }
        }

      
    }
}

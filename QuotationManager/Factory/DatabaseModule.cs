using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace QuotationManager.Factory
{
    public class DatabaseModule
    {
        public SQLiteConnection sqlConn = new SQLiteConnection();
        public string sqlConnStr = "";
        public void OpenDatabase()
        {

            string filename = @"C:\Development\QuotationManager\QuotationManager\Database\DrapersQuotation.db";
            //string filename = Application.StartupPath + "\\Database\\DrapersQuotation.db";
            sqlConnStr = "Data Source=" + filename + ";Version=3;";
            sqlConn = new SQLiteConnection(sqlConnStr);
            sqlConn.Open();
        }

        public object ExecuteScalar(string sql, params object[] args)
        {
            object obj = 0;
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                {
                    OpenDatabase();
                }
                using (SQLiteCommand cmd = sqlConn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    obj = cmd.ExecuteScalar();

                    return obj;
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public int ExecuteNonQuery(string sql, SQLiteParameter[] sqlParams)
        {
            int rowsEffected = 0;
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                {
                    OpenDatabase();
                }

                using (SQLiteCommand cmd = sqlConn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SQLiteParameter param in sqlParams)
                    {
                        if (param != null && param.ParameterName != "")
                        {
                            cmd.Parameters.Add(param);
                        }
                    }

                    rowsEffected = cmd.ExecuteNonQuery();

                    return rowsEffected;
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public DataSet FillDataSet(string sql, SQLiteParameter[] sqlParams)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                {
                    OpenDatabase();
                }

                SQLiteDataAdapter da = new SQLiteDataAdapter();
                da = new SQLiteDataAdapter(sql, sqlConn);

                foreach (SQLiteParameter param in sqlParams)
                {
                    if (param != null && param.ParameterName != "")
                    {
                        da.SelectCommand.Parameters.Add(param);
                    }
                }

                da.Fill(ds);
                sqlConn.Close();

                return ds;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }




    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.DAO
{
    class AccessHelper
    {
        private string conn_str = null;
        private OleDbConnection ole_connection = null;
        private OleDbCommand ole_command = null;
        private OleDbDataReader ole_reader = null;
        private DataTable dt = null;

        /// <summary>
        /// 构造函数
        /// </summary>
        public AccessHelper()
        {
            conn_str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\我的文档\Visual Studio 2008\Projects\AccessOperator\AccessOperator\bin\Debug\myDb.mdb'";
            InitDB();
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="db_path">数据库路径</param>
        public AccessHelper(string db_path)
        {
            conn_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + db_path + "'";
            InitDB();
        }

        /// <summary>
        /// 
        /// </summary>
        private void InitDB()
        {
            ole_connection = new OleDbConnection(conn_str);//创建实例
            ole_command = new OleDbCommand();
        }
        /// <summary>
        /// 转换数据格式
        /// </summary>
        /// <param name="reader">数据源</param>
        /// <returns>数据列表</returns>
        private DataTable ConvertOleDbReaderToDataTable(ref OleDbDataReader reader)
        {
            DataTable dt_tmp = null;
            DataRow dr = null;
            int data_column_count = 0;
            int i = 0;

            data_column_count = reader.FieldCount;
            dt_tmp = BuildAndInitDataTable(data_column_count);

            if (dt_tmp == null)
            {
                return null;
            }

            while (reader.Read())
            {
                dr = dt_tmp.NewRow();

                for (i = 0; i < data_column_count; ++i)
                {
                    dr[i] = reader[i];
                }

                dt_tmp.Rows.Add(dr);
            }

            return dt_tmp;
        }
        /// <summary>
        /// 创建并初始化数据列表
        /// </summary>
        /// <param name="Field_Count">列的个数</param>
        /// <returns>数据列表</returns>
        private DataTable BuildAndInitDataTable(int Field_Count)
        {
            DataTable dt_tmp = null;
            DataColumn dc = null;
            int i = 0;

            if (Field_Count <= 0)
            {
                return null;
            }

            dt_tmp = new DataTable();

            for (i = 0; i < Field_Count; ++i)
            {
                dc = new DataColumn(i.ToString());
                dt_tmp.Columns.Add(dc);
            }

            return dt_tmp;
        }
        /// <summary>
        /// 从数据库里面获取数据
        /// </summary>
        /// <param name="strSql">查询语句</param>
        /// <returns>数据列表</returns>
        public DataTable GetDataTableFromDB(string strSql)
        {
            if (conn_str == null)
            {
                return null;
            }

            try
            {
                ole_connection.Open();//打开连接

                if (ole_connection.State == ConnectionState.Closed)
                {
                    return null;
                }

                ole_command.CommandText = strSql;
                ole_command.Connection = ole_connection;

                ole_reader = ole_command.ExecuteReader(CommandBehavior.Default);

                dt = ConvertOleDbReaderToDataTable(ref ole_reader);

                ole_reader.Close();
                ole_reader.Dispose();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                if (ole_connection.State != ConnectionState.Closed)
                {
                    ole_connection.Close();
                }
            }

            return dt;
        }

        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <returns>返回结果</returns>
        public int ExcuteSql(string strSql)
        {
            int nResult = 0;

            try
            {
                ole_connection.Open();//打开数据库连接
                if (ole_connection.State == ConnectionState.Closed)
                {
                    return nResult;
                }

                ole_command.Connection = ole_connection;
                ole_command.CommandText = strSql;

                nResult = ole_command.ExecuteNonQuery();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.ToString());
                return nResult;
            }
            finally
            {
                if (ole_connection.State != ConnectionState.Closed)
                {
                    ole_connection.Close();
                }
            }

            return nResult;
        }
    }
}

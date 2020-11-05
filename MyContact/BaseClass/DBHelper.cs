using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MyContact.BaseClass
{
    class DBHelper
    {
        #region 全局变量

        static string strDBFile = "\\DataBase\\db_Contact.mdb";
        static string strDBPath = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + strDBFile;
        public static string CONN_STRING = "provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + strDBPath;
        public static OleDbConnection conn;

        #endregion

        #region 建立数据库

        /// <summary>
        /// 建立数据库连接。
        /// </summary>
        /// <returns>返回OleDbConnection对象</returns>
        public static OleDbConnection getConn()
        {
            conn = new OleDbConnection(CONN_STRING);
            conn.Open();
            return conn;
        }

        #endregion

        #region 测试数据库是否加载

        /// <summary>
        /// 测试数据库是否加载。
        /// </summary>
        public void openConn()
        {
            getConn();
        }

        #endregion

        #region 关闭数据库连接

        /// <summary>
        /// 关闭数据库的连接。
        /// </summary>
        public void closeConn()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        #endregion

        #region 读取指定表中的信息

        /// <summary>
        /// 读取指定表中的信息。
        /// </summary>
        /// <param name="cmdText">SQL语句</param>
        /// <returns>返回Bool型</returns>
        public OleDbDataReader ExecuteReader(string cmdText)
        {
            getConn();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = cmdText;
            OleDbDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }

        #endregion

        #region 执行非查询SQL语句

        /// <summary>
        /// 执行非查询SQL语句
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <returns>返回Int型</returns>
        public int ExecuteNonQuery(string strSQL)
        {
            getConn();
            OleDbCommand cmd = new OleDbCommand(strSQL, conn);
            int val = cmd.ExecuteNonQuery();
            cmd.Dispose();
            closeConn();
            return val;
        }

        #endregion

        #region  创建DataSet对象

        /// <summary>
        /// 创建一个DataSet对象
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <param name="tableName">表名</param>
        /// <returns>返回DataSet对象</returns>
        public DataSet getDataSet(string strSQL, string tableName)
        {
            getConn();
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, tableName);
            closeConn();
            return ds;
        }

        #endregion
    }
}

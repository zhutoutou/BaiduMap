using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Data.OracleClient;
using System.Configuration;
using Oracle.DataAccess.Client;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Web
{
    /// <summary>
    /// Copyright (C) Maticsoft
    /// 数据访问基础类(基于Oracle)
    /// 可以用户可以修改满足自己项目的需要。
    /// </summary>
    public abstract class DbHelperOra
    {
        //数据库连接字符串(web.config来配置)，可以动态更改connectionString支持多数据库.		
        public static string constr = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        public DbHelperOra()
        {
        }


        #region 批量插入
        /// <summary>
        ///  批量插入数据
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <param name="columnRowData">键-值存储的批量数据：键是列名称，值是该列对应的数据集合</param>
        /// <returns></returns>
        public static int BatchInsert(string tableName, Dictionary<string, object[]> columnRowData)
        {
            if (string.IsNullOrEmpty(tableName))
            {
                throw new ArgumentNullException("tableName", "必须指定批量插入的表名称");
            }

            if (columnRowData == null || columnRowData.Count < 1)
            {
                throw new ArgumentException("必须指定批量插入的字段名称", "columnRowData");
            }

            int iResult = 0;
            string[] dbColumns = columnRowData.Keys.ToArray();
            StringBuilder sbCmdText = new StringBuilder();
            if (columnRowData.Count > 0)
            {
                // 准备插入SQL
                sbCmdText.AppendFormat("INSERT INTO "+tableName+" (");
                //sbCmdText.AppendFormat("INSERT INTO {1} (", tableName);
                sbCmdText.Append(string.Join(",", dbColumns));
                sbCmdText.Append(") VALUES (");
                sbCmdText.Append(":" + string.Join(", :", dbColumns));
                sbCmdText.Append(") ");

                using (Oracle.DataAccess.Client.OracleConnection conn = new Oracle.DataAccess.Client.OracleConnection(constr))
                {
                    using (Oracle.DataAccess.Client.OracleCommand cmd = conn.CreateCommand())
                    {
                        // 绑定批处理的行数
                        cmd.ArrayBindCount = columnRowData.Values.First().Length; // 很重要
                        cmd.BindByName = true;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sbCmdText.ToString();
                        cmd.CommandTimeout = 600; // 10分钟
                        // 创建参数
                        Oracle.DataAccess.Client.OracleParameter oraParam;
                        List<IDbDataParameter> cacher = new List<IDbDataParameter>();
                        OracleDbType dbType = OracleDbType.Object;
                        foreach (string colName in dbColumns)
                        {
                            dbType = GetOracleDbType(columnRowData[colName][0]);
                            oraParam = new Oracle.DataAccess.Client.OracleParameter(colName, dbType);
                            oraParam.Direction = ParameterDirection.Input;
                            oraParam.OracleDbTypeEx = dbType;

                            oraParam.Value = columnRowData[colName];
                            cmd.Parameters.Add(oraParam);
                        }

                        // 执行批处理
                        //var trans = conn.BeginTransaction();
                        try
                        {
                            cmd.Transaction = conn.BeginTransaction();
                            iResult = cmd.ExecuteNonQuery();
                            cmd.Transaction.Commit();
                        }
                        catch (Exception dbex)
                        {
                            cmd.Transaction.Rollback();
                            throw dbex;
                        }
                    }
                }
            }

            return iResult;
        }


        ///  批量更新数据
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <param name="keyColumName">主键列名称</param>
        /// <param name="columnRowData">键-值存储的批量数据：键是列名称，值是该列对应的数据集合</param>
        /// <returns></returns>
        public static int BatchUpdate(string tableName, string keyColumName, Dictionary<string, object[]> columnRowData)
        {
            if (string.IsNullOrEmpty(tableName))
            {
                throw new ArgumentNullException("tableName", "必须指定批量插入的表名称");
            }

            if (string.IsNullOrEmpty(tableName))
            {
                throw new ArgumentNullException("keyColumName", "必须指定批量插入表的主键列名称");
            }

            if (columnRowData == null || columnRowData.Count < 1)
            {
                throw new ArgumentException("必须指定批量插入的字段名称", "columnRowData");
            }

            int iResult = 0;
            string[] dbColumns = columnRowData.Keys.ToArray();
            StringBuilder sbCmdText = new StringBuilder();
            if (columnRowData.Count > 0)
            {
                // 准备更新SQL
                sbCmdText.AppendFormat("update {0} set  ", tableName);
                foreach (var col in dbColumns)
                {
                    if (keyColumName.Equals(col, StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }
                    sbCmdText.AppendFormat("{0} = :{0} ,", col);
                }
                sbCmdText.Remove(sbCmdText.Length - 1, 1);
                sbCmdText.AppendFormat(" where {0} = :{0}", keyColumName);

                using (Oracle.DataAccess.Client.OracleConnection conn = new Oracle.DataAccess.Client.OracleConnection(constr))
                {
                    using (Oracle.DataAccess.Client.OracleCommand cmd = conn.CreateCommand())
                    {
                        // 绑定批处理的行数
                        cmd.ArrayBindCount = columnRowData.Values.First().Length; // 很重要
                        cmd.BindByName = true;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sbCmdText.ToString();
                        cmd.CommandTimeout = 600; // 10分钟
                        // 创建参数
                        Oracle.DataAccess.Client.OracleParameter oraParam;
                        List<IDbDataParameter> cacher = new List<IDbDataParameter>();
                        OracleDbType dbType = OracleDbType.Object;
                        foreach (string colName in dbColumns)
                        {
                            dbType = GetOracleDbType(columnRowData[colName][0]);
                            oraParam = new Oracle.DataAccess.Client.OracleParameter(colName, dbType);
                            oraParam.Direction = ParameterDirection.Input;
                            oraParam.OracleDbTypeEx = dbType;

                            oraParam.Value = columnRowData[colName];
                            cmd.Parameters.Add(oraParam);
                        }

                        // 执行批处理
                        var trans = conn.BeginTransaction();
                        try
                        {
                            cmd.Transaction = trans;
                            iResult = cmd.ExecuteNonQuery();
                            trans.Commit();
                        }
                        catch (Exception dbex)
                        {
                            trans.Rollback();
                            throw dbex;
                        }
                    }
                }
            }

            return iResult;
        }


        /// <summary>
        ///  根据数据类型获取OracleDbType
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static OracleDbType GetOracleDbType(object value)
        {
            OracleDbType dataType = OracleDbType.Object;
            if (value is string)
            {
                dataType = OracleDbType.Varchar2;
            }
            else if (value is DateTime)
            {
                dataType = OracleDbType.TimeStamp;
            }
            else if (value is int || value is short)
            {
                dataType = OracleDbType.Int32;
            }
            else if (value is long)
            {
                dataType = OracleDbType.Int64;
            }
            else if (value is decimal || value is double)
            {
                dataType = OracleDbType.Decimal;
            }
            else if (value is Guid)
            {
                dataType = OracleDbType.Varchar2;
            }
            else if (value is bool || value is Boolean)
            {
                dataType = OracleDbType.Byte;
            }
            else if (value is byte[])
            {
                dataType = OracleDbType.Blob;
            }
            else if (value is char)
            {
                dataType = OracleDbType.Char;
            }

            return dataType;
        }
        #endregion

    }
}

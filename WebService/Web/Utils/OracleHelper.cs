using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;
using System.Configuration;
using System.Data;
using System.Reflection;
using System.Web.Script.Serialization;
using Web.Model;

namespace Web
{
    public class OracleHelper
    {
        #region 变量
        /// <summary>
        /// 数据库连接对象
        /// </summary>
        public static string constrrec = ConfigurationManager.ConnectionStrings["connectionStringrec"].ToString();
        /// <summary>
        /// 数据库连接对象
        /// </summary>
        public static string constr = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        #endregion

        #region 属性
        #endregion

        #region 方法

        #region 执行返回一行一列的数据库操作
        /// <summary>
        /// 执行返回一行一列的数据库操作
        /// </summary>
        /// <param name="commandText">Oracle语句或存储过程名</param>
        /// <param name="commandType">Oracle命令类型</param>
        /// <param name="param">Oracle命令参数数组</param>
        /// <returns>第一行第一列的记录</returns>
        public static int ExecuteScalar(string commandText, CommandType commandType, params OracleParameter[] param)
        {
            int count = 0;
            using (OracleConnection cc = new OracleConnection(constr))
            {
                using (OracleCommand cmd = new OracleCommand(commandText, cc))
                {
                    try
                    {
                        cmd.CommandType = commandType;
                        if (param != null)
                        {
                            cmd.Parameters.AddRange(param);
                        }
                        cc.Open();
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                        cc.Close();
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                    }
                    catch (Exception ex)
                    {
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        cc.Close();
                        count = 0;
                    }
                    finally
                    {
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        cc.Close();
                    }
                }
            }
            return count;
        }

        #endregion

        #region 执行不查询的数据库操作
        /// <summary>
        /// 执行不查询的数据库操作
        /// </summary>
        /// <param name="commandText">Oracle语句或存储过程名</param>
        /// <param name="commandType">Oracle命令类型</param>
        /// <param name="param">Oracle命令参数数组</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(string commandText, CommandType commandType, params OracleParameter[] param)
        {
            int result = 0;
            using (OracleConnection cc = new OracleConnection(constr))
            {
                using (OracleCommand cmd = new OracleCommand(commandText, cc))
                {
                    try
                    {
                        cmd.CommandType = commandType;
                        if (param != null)
                        {
                            cmd.Parameters.AddRange(param);
                        }
                        if (cc.State != ConnectionState.Open)
                        {
                            cc.Open();
                        }
                        result = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        cc.Close();
                    }
                    catch (Exception ex)
                    {
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        //OracleHelper.Con.Close();
                        cc.Close();
                        StringBuilder str = new StringBuilder();
                        if (param != null)
                        {
                            for (int i = 0; i < param.Length; i++)
                            {
                                str.Append(param[i].ParameterName + ":" + param[i].Value + ",");
                            }
                        }
                        LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, "参数：" + str.ToString() + ",错误：" + ex.ToString(), new LogUtility.RunningPlace("OracleHelper", commandText), "DB");

                        //LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, ex.Message.ToString(), new LogUtility.RunningPlace("", commandText), "DB");
                        result = 0;
                        throw ex;
                    }
                    finally
                    {
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        cc.Close();
                    }
                }
            }
            return result;
        }

        #endregion

        #region 执行返回一条记录的泛型对象
        /// <summary>
        /// 执行返回一条记录的泛型对象
        /// </summary>
        /// <typeparam name="T">泛型类型</typeparam>
        /// <param name="reader">只进只读对象</param>
        /// <returns>泛型对象</returns>
        private static T ExecuteDataReader<T>(IDataReader reader)
        {
            T obj = default(T);
            try
            {
                Type type = typeof(T);
                obj = (T)Activator.CreateInstance(type);//从当前程序集里面通过反射的方式创建指定类型的对象   
                //obj = (T)Assembly.Load(OracleHelper._assemblyName).CreateInstance(OracleHelper._assemblyName + "." + type.Name);//从另一个程序集里面通过反射的方式创建指定类型的对象 
                PropertyInfo[] propertyInfos = type.GetProperties();//获取指定类型里面的所有属性
                foreach (PropertyInfo propertyInfo in propertyInfos)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string fieldName = reader.GetName(i);
                        if (fieldName.ToLower() == propertyInfo.Name.ToLower())
                        {
                            object val = reader[propertyInfo.Name];//读取表中某一条记录里面的某一列
                            if (val != null && val != DBNull.Value)
                            {
                                if (val.GetType() == typeof(decimal))
                                {
                                    propertyInfo.SetValue(obj, Convert.ToDecimal(val), null);
                                }
                                else if (val.GetType() == typeof(int))
                                {
                                    propertyInfo.SetValue(obj, Convert.ToInt32(val), null);
                                }
                                else if (val.GetType() == typeof(DateTime))
                                {
                                    propertyInfo.SetValue(obj, Convert.ToDateTime(val), null);
                                }
                                else if (val.GetType() == typeof(string))
                                {
                                    propertyInfo.SetValue(obj, Convert.ToString(val), null);
                                }
                            }
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return obj;
        }
        #endregion

        #region 执行返回一条记录的泛型对象
        /// <summary>
        /// 执行返回一条记录的泛型对象
        /// </summary>
        /// <typeparam name="T">泛型类型</typeparam>
        /// <param name="commandText">Oracle语句或存储过程名</param>
        /// <param name="commandType">Oracle命令类型</param>
        /// <param name="param">Oracle命令参数数组</param>
        /// <returns>实体对象</returns>
        public static T ExecuteEntity<T>(string commandText, CommandType commandType, params OracleParameter[] param)
        {
            T obj = default(T);
            using (OracleConnection cc = new OracleConnection(constr))
            {
                using (OracleCommand cmd = new OracleCommand(commandText, cc))
                {
                    try
                    {
                        cmd.CommandType = commandType;
                        if (param != null)
                        {
                            cmd.Parameters.AddRange(param);
                        }
                        if (cc.State != ConnectionState.Open)
                        {
                            cc.Open();
                        }
                        OracleDataReader reader = cmd.ExecuteReader();
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        while (reader.Read())
                        {
                            obj = OracleHelper.ExecuteDataReader<T>(reader);
                        }
                        cc.Close();
                    }
                    catch (Exception ex)
                    {
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        cc.Close();
                        StringBuilder str = new StringBuilder();
                        if (param != null)
                        {
                            for (int i = 0; i < param.Length; i++)
                            {
                                str.Append(param[i].ParameterName + ":" + param[i].Value + ",");
                            }
                        }
                        LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, "参数：" + str.ToString() + ",错误：" + ex.ToString(), new LogUtility.RunningPlace("OracleHelper", commandText), "DB");

                        //LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, ex.Message.ToString(), new LogUtility.RunningPlace("", commandText), "DB");
                        throw ex;
                    }
                    finally
                    {
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        cc.Close();
                    }
                }
            }
            return obj;
        }

        #endregion

        #region 执行返回多条记录的泛型集合对象
        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="commandText">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        public static object GetSingle(string commandText, string constr_ = "0")
        {
            using (OracleConnection cc = new OracleConnection((constr_ == "0") ? constr : constrrec))
            {
                using (OracleCommand cmd = new OracleCommand(commandText, cc))
                {
                    try
                    {
                        cc.Open();
                        cmd.CommandType = CommandType.Text;
                        object obj = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        cc.Close();
                        return ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value))) ? null : obj;
                    }
                    catch (System.Data.OracleClient.OracleException ex)
                    {
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        cc.Close();
                        LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, ex.Message.ToString(), new LogUtility.RunningPlace("", commandText), "DB");
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        if (cc.State != ConnectionState.Closed)
                        {
                            cc.Close();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 执行返回多条记录的泛型集合对象
        /// </summary>
        /// <typeparam name="T">泛型类型</typeparam>
        /// <param name="commandText">Oracle语句或存储过程名</param>
        /// <param name="commandType">Oracle命令类型</param>
        /// <param name="param">Oracle命令参数数组</param>  using (OracleConnection cc = new OracleConnection((constr_ == "0") ? constr : constrrec))
        /// <returns>泛型集合对象</returns>
        public static List<T> ExecuteList<T>(string commandText, CommandType commandType, params OracleParameter[] param)
        {
            List<T> list = new List<T>();
            using (OracleConnection cc = new OracleConnection(constr))
            {
                using (OracleCommand cmd = new OracleCommand(commandText, cc))
                {
                    try
                    {
                        cmd.CommandType = commandType;
                        if (param != null)
                        {
                            cmd.Parameters.AddRange(param);
                        }
                        if (cc.State != ConnectionState.Open)
                        {
                            cc.Open();
                        }
                        OracleDataReader reader = cmd.ExecuteReader();
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        //cc.Close();
                        while (reader.Read())
                        {
                            T obj = OracleHelper.ExecuteDataReader<T>(reader);
                            list.Add(obj);
                        }
                    }
                    catch (Exception ex)
                    {
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        cc.Close();
                        StringBuilder str = new StringBuilder();
                        if (param != null)
                        {
                            for (int i = 0; i < param.Length; i++)
                            {
                                str.Append(param[i].ParameterName + ":" + param[i].Value + ",");
                            }
                        }
                        LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, "参数：" + str.ToString() + ",错误：" + ex.ToString(), new LogUtility.RunningPlace("OracleHelper", commandText), "DB");
                        throw ex;
                    }
                    finally
                    {
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        //if (cc.State != ConnectionState.Closed)
                        //{
                        cc.Close();
                        //}
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// 执行返回多条记录的泛型集合对象
        /// </summary>
        /// <typeparam name="T">泛型类型</typeparam>
        /// <param name="commandText">Oracle语句或存储过程名</param>
        /// <param name="commandType">Oracle命令类型</param>
        /// <param name="param">Oracle命令参数数组</param>  using (OracleConnection cc = new OracleConnection((constr_ == "0") ? constr : constrrec))
        /// <returns>泛型集合对象</returns>
        public static List<T> ExecuteList_rec<T>(string commandText, CommandType commandType, params OracleParameter[] param)
        {
            List<T> list = new List<T>();
            using (OracleConnection cc = new OracleConnection(constrrec))
            {
                using (OracleCommand cmd = new OracleCommand(commandText, cc))
                {
                    try
                    {
                        cmd.CommandType = commandType;
                        if (param != null)
                        {
                            cmd.Parameters.AddRange(param);
                        }
                        if (cc.State != ConnectionState.Open)
                        {
                            cc.Open();
                        }
                        OracleDataReader reader = cmd.ExecuteReader();
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        //cc.Close();
                        while (reader.Read())
                        {
                            T obj = OracleHelper.ExecuteDataReader<T>(reader);
                            list.Add(obj);
                        }
                    }
                    catch (Exception ex)
                    {
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        cc.Close();
                        StringBuilder str = new StringBuilder();
                        if (param != null)
                        {
                            for (int i = 0; i < param.Length; i++)
                            {
                                str.Append(param[i].ParameterName + ":" + param[i].Value + ",");
                            }
                        }
                        LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, "参数：" + str.ToString() + ",错误：" + ex.ToString(), new LogUtility.RunningPlace("OracleHelper", commandText), "DB");
                        throw ex;
                    }
                    finally
                    {
                        cmd.Parameters.Clear();
                        cmd.Dispose();
                        //if (cc.State != ConnectionState.Closed)
                        //{
                        cc.Close();
                        //}
                    }
                }
            }
            return list;
        }
        #endregion

        public static string BatchInsert2(List<AMBUL_TRAC> lst)
        {
            string result;
            //创建连接
            StringBuilder insertStr = new StringBuilder();
            var conn = new OracleConnection(constr);
            conn.Open();
            var tran = conn.BeginTransaction();  //事务
            try
            {
                var command = conn.CreateCommand();
                insertStr.Append("insert  into NB120GPS.AMBUL_TRAC (CLID,CLZT,ZHFSSJ,DXDDSJ,XSLC,SD,FX,GPS_X,GPS_Y,LSH,GZXS,KJXS,BJ,TXZT ) "
                + " select CLID,CLZT,ZHFSSJ,DXDDSJ,XSLC,SD,FX,GPS_X,GPS_Y,LSH,GZXS,KJXS,BJ,TXZT from ( ");
                for (int i = 0; i < lst.Count; i++)
                {
                    AMBUL_TRAC item = lst[i];
                    string value = string.Format(
                   "{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}", " select  (select clid from V_clxqxx where czdh='" + item.CZHM + "') as  CLID", " (select LPAD(CLZT,2,'0') from V_clxqxx where czdh='" + item.CZHM + "') as CLZT", "to_date('" + item.ZHFSSJ + "','yyyy-mm-dd hh24:mi:ss') as ZHFSSJ", "to_date('" + item.DXDDSJ + "','yyyy-mm-dd hh24:mi:ss') as DXDDSJ",
                   item.XSLC + " as  XSLC", item.SD + " as  SD", item.FX + " as  FX", item.GPS_X + " as  GPS_X", item.GPS_Y + " as  GPS_Y", (string.IsNullOrEmpty(item.LSH) ? "1" : item.LSH) + " as  LSH", item.GZXS + " as  GZXS", item.KJXS + " as  KJXS", item.BJ + " as  BJ", item.TXZT + " as  TXZT from dual ");

                    insertStr.Append(value);
                    if (i != lst.Count - 1)
                    {
                        insertStr.Append(" union all ");
                    }
                }
                insertStr.Append(" )");
                command.Transaction = tran;
                command.CommandText = insertStr.ToString().TrimEnd(',');
                command.ExecuteNonQuery();
                tran.Commit();
                result = "成功";
            }
            catch (OracleException ex)
            {
                tran.Rollback();
                result = "出现错误。\n" + ex.Message;
                LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, insertStr.ToString().TrimEnd(','), new LogUtility.RunningPlace("", "BatchInsert"), "DB");
            }
            catch (Exception ex)
            {
                result = "出现错误。\n" + ex.Message;
                LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, insertStr.ToString().TrimEnd(','), new LogUtility.RunningPlace("", "BatchInsert"), "DB");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }

        public static string BatchInsert(List<AMBUL_TRAC> lst)
        {
            string result;
            //创建连接
            StringBuilder insertStr = new StringBuilder();
            var conn = new OracleConnection(constr);
            conn.Open();
            var tran = conn.BeginTransaction();  //事务
            try
            {
                var command = conn.CreateCommand();
                insertStr.Append("insert  into NB120GPS.AMBUL_TRAC_HIS (CLID,CLZT,ZHFSSJ,DXDDSJ,XSLC,SD,FX,GPS_X,GPS_Y,LSH,GZXS,KJXS,BJ,TXZT ) "
                + " select CLID,CLZT,ZHFSSJ,DXDDSJ,XSLC,SD,FX,GPS_X,GPS_Y,LSH,GZXS,KJXS,BJ,TXZT from ( ");
                for (int i = 0; i < lst.Count; i++)
                {
                    AMBUL_TRAC item = lst[i];
                    string value = string.Format(
                   "{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}", " select  (select clid from V_clxqxx where czdh='" + item.CZHM + "') as  CLID", " (select LPAD(CLZT,2,'0') from V_clxqxx where czdh='" + item.CZHM + "') as CLZT", "to_date('" + item.ZHFSSJ + "','yyyy-mm-dd hh24:mi:ss') as ZHFSSJ", "to_date('" + item.DXDDSJ + "','yyyy-mm-dd hh24:mi:ss') as DXDDSJ",
                   item.XSLC + " as  XSLC", item.SD + " as  SD", item.FX + " as  FX", item.GPS_X + " as  GPS_X", item.GPS_Y + " as  GPS_Y", (string.IsNullOrEmpty(item.LSH) ? "1" : item.LSH) + " as  LSH", item.GZXS + " as  GZXS", item.KJXS + " as  KJXS", item.BJ + " as  BJ", item.TXZT + " as  TXZT from dual ");

                    insertStr.Append(value);
                    if (i != lst.Count - 1)
                    {
                        insertStr.Append(" union all ");
                    }
                }
                insertStr.Append(" )");
                command.Transaction = tran;
                command.CommandText = insertStr.ToString().TrimEnd(',');
                command.ExecuteNonQuery();
                tran.Commit();
                result = "成功";
            }
            catch (OracleException ex)
            {
                tran.Rollback();
                result = "出现错误。\n" + ex.Message;
                LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, insertStr.ToString().TrimEnd(','), new LogUtility.RunningPlace("", "BatchInsert"), "DB");
            }
            catch (Exception ex)
            {
                result = "出现错误。\n" + ex.Message;
                LogUtility.DataLog.WriteLog(LogUtility.LogLevel.Info, insertStr.ToString().TrimEnd(','), new LogUtility.RunningPlace("", "BatchInsert"), "DB");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }
        #endregion

    }
}

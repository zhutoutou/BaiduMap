using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 请求服务返回的数据结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DataResult<T>
    {
        /// <summary>
        /// 错误码
        /// </summary>
        public int errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string msg { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        public string operationType { get; set; }

        /// <summary>
        /// 返回数据
        /// </summary>
        public T resultData { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        public string version { get; set; }

        /// <summary>
        /// 请求的URL
        /// </summary>
        public string request { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool isSucceed { get; set; }

    }
}
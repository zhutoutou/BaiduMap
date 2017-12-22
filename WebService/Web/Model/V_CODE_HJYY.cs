using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    public class V_CODE_HJYY
    {
        private decimal _code;

        /// <summary>
        /// 编码
        /// </summary>	
        public decimal CODE
        {
            get { return _code; }
            set { _code = value; }
        }
        private string _name;

        /// <summary>
        /// 名称
        /// </summary>	
        public string NAME
        {
            get { return _name; }
            set { _name = value; }
        }
        private decimal _typeid;

        /// <summary>
        /// 父ID
        /// </summary>	
        public decimal TYPEID
        {
            get { return _typeid; }
            set { _typeid = value; }
        }
        private string _codepath;

        /// <summary>
        /// 编码路径
        /// </summary>	
        public string CODEPATH
        {
            get { return _codepath; }
            set { _codepath = value; }
        }
        private string _namepath;

        /// <summary>
        /// 名称路径
        /// </summary>	
        public string NAMEPATH
        {
            get { return _namepath; }
            set { _namepath = value; }
        }
        private decimal _codelevel;

        /// <summary>
        /// 名称路径
        /// </summary>	
        public decimal CODELEVEL
        {
            get { return _codelevel; }
            set { _codelevel = value; }
        }
    }
}
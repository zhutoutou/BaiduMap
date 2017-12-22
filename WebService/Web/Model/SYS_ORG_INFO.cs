using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 组织机构表
    /// </summary>
    [Serializable]
    public class SYS_ORG_INFO
    {

        /// <summary>
        /// 机构代码
        /// </summary>		
        private string _org_id;
        public string ORG_ID
        {
            get { return _org_id; }
            set { _org_id = value; }
        }
        /// <summary>
        /// 机构名称
        /// </summary>		
        private string _name;
        public string NAME
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// 机构类型。标识机构层级，市、县、中心、分中心、分站等
        /// </summary>		
        private decimal _type;
        public decimal TYPE
        {
            get { return _type; }
            set { _type = value; }
        }
        /// <summary>
        /// 地址
        /// </summary>		
        private string _dz;
        public string DZ
        {
            get { return _dz; }
            set { _dz = value; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>		
        private string _lxdh;
        public string LXDH
        {
            get { return _lxdh; }
            set { _lxdh = value; }
        }
        /// <summary>
        /// 行政编码
        /// </summary>		
        private decimal _xzbm;
        public decimal XZBM
        {
            get { return _xzbm; }
            set { _xzbm = value; }
        }
        /// <summary>
        /// 行政编码对应名称
        /// </summary>		
        private string _xzbm_name;
        public string QYMC
        {
            get { return _xzbm_name; }
            set { _xzbm_name = value; }
        }
        /// <summary>
        /// 行政编码对应名称
        /// </summary>		
        private string _rpid;
        public string RPID
        {
            get { return _rpid; }
            set { _rpid = value; }
        }
    }
}
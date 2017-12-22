using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 受理相关信息
    /// </summary>
    public class V_RP_INFO
    {
        private decimal _type;

        /// <summary>
        /// 分站类型
        /// </summary>	
        public decimal TYPE
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _org_id;

        /// <summary>
        /// 中心受理台所属机构id
        /// </summary>	
        public string ORG_ID
        {
            get { return _org_id; }
            set { _org_id = value; }
        }
        private string _rpid;

        /// <summary>
        /// 分站RPID
        /// </summary>	
        public string RPID
        {
            get { return _rpid; }
            set { _rpid = value; }
        }
        private string _rp_phone;

        /// <summary>
        /// 分站电话
        /// </summary>	
        public string RP_PHONE
        {
            get { return _rp_phone; }
            set { _rp_phone = value; }
        }
        private string _org_name;

        /// <summary>
        /// 分站所属机构名称
        /// </summary>	
        public string ORG_NAME
        {
            get { return _org_name; }
            set { _org_name = value; }
        }
        private string _name;

        /// <summary>
        /// 分站名称
        /// </summary>	
        public string NAME
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _status = "离线";

        /// <summary>
        /// 分站状态
        /// </summary>	
        public string STATUS
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
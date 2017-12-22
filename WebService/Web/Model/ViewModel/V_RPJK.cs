using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    ///坐席监控实体类
    /// <summary>
    [Serializable]
    public class V_RPJK
    {
        private string _ddyname;

        /// <summary>
        /// 调度员名称
        /// </summary>	
        public string DDYNAME
        {
            get { return _ddyname; }
            set { _ddyname = value; }
        }
        private DateTime _sbsj;

        /// <summary>
        /// 上班时间
        /// </summary>	
        public DateTime SBSJ
        {
            get { return _sbsj; }
            set { _sbsj = value; }
        }

        private string _rpid;

        /// <summary>
        /// RPID
        /// </summary>	
        public string RPID
        {
            get { return _rpid; }
            set { _rpid = value; }
        }

        private string _name;

        /// <summary>
        /// NAME
        /// </summary>	
        public string NAME
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _rp_phone;

        /// <summary>
        /// RP_PHONE
        /// </summary>	
        public string RP_PHONE
        {
            get { return _rp_phone; }
            set { _rp_phone = value; }
        }

        private string _ddyid;

        /// <summary>
        /// DDYID
        /// </summary>	
        public string DDYID
        {
            get { return _ddyid; }
            set { _ddyid = value; }
        }
        private decimal _type;

        /// <summary>
        /// 10:受理台，20:分站
        /// </summary>	
        public decimal TYPE
        {
            get { return _type; }
            set { _type = value; }
        }

    }
}
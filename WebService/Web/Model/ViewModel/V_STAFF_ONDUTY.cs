using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    public class V_STAFF_ONDUTY
    {
        string _id = string.Empty;
        /// <summary>
        /// id
        /// </summary>
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        string _czhm = string.Empty;
        /// <summary>
        /// 车辆电话
        /// </summary>
        public string CZHM
        {
            get { return _czhm; }
            set { _czhm = value; }
        }
        string _clid = string.Empty;
        /// <summary>
        /// 车辆id
        /// </summary>
        public string CLID
        {
            get { return _clid; }
            set { _clid = value; }
        }
        string _org_id = string.Empty;
        /// <summary>
        /// 机构id
        /// </summary>
        public string ORG_ID
        {
            get { return _org_id; }
            set { _org_id = value; }
        }
        string _name = string.Empty;
        /// <summary>
        /// 名称
        /// </summary>
        public string NAME
        {
            get { return _name; }
            set { _name = value; }
        }
        string _szfzmc = string.Empty;
        /// <summary>
        /// 所在分站名称
        /// </summary>
        public string SZFZMC
        {
            get { return _szfzmc; }
            set { _szfzmc = value; }
        }
        string _zwmc = string.Empty;
        /// <summary>
        /// 职务名称
        /// </summary>
        public string ZWMC
        {
            get { return _zwmc; }
            set { _zwmc = value; }
        }
        decimal _type = 0;
        /// <summary>
        /// 职务类型
        /// </summary>
        public decimal TYPE
        {
            get { return _type; }
            set { _type = value; }
        }
        decimal _sfsb = 0;
        /// <summary>
        /// 职务类型
        /// </summary>
        public decimal SFSB
        {
            get { return _sfsb; }
            set { _sfsb = value; }
        }
    }
}
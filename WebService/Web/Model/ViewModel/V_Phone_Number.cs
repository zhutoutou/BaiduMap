using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 组织机构电话列表
    /// </summary>
    [Serializable]
    public class V_Phone_Number
    {

        private string _org_id;

        /// <summary>
        /// 组织机构id
        /// </summary>	
        public string ORG_ID
        {
            get { return _org_id; }
            set { _org_id = value; }
        }


        private decimal _RYLX;

        /// <summary>
        /// 人员类型
        /// </summary>	
        public decimal RYLX
        {
            get { return _RYLX; }
            set { _RYLX = value; }
        }

        private string _RYLXMC;

        /// <summary>
        /// 人员类型名称
        /// </summary>	
        public string RYLXMC
        {
            get { return _RYLXMC; }
            set { _RYLXMC = value; }
        }

        private string _name;

        /// <summary>
        /// 组织机构名称
        /// </summary>	
        public string NAME
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _ssjgdm;

        /// <summary>
        /// 所属机构代码
        /// </summary>	
        public string SSJGDM
        {
            get { return _ssjgdm; }
            set { _ssjgdm = value; }
        }

        private string _ssjgmc;

        /// <summary>
        /// 所属机构名称
        /// </summary>	
        public string SSJGMC
        {
            get { return _ssjgmc; }
            set { _ssjgmc = value; }
        }

        private string _czdh;

        /// <summary>
        /// 车载电话
        /// </summary>	
        public string CZDH
        {
            get { return _czdh; }
            set { _czdh = value; }
        }

        private string _lxdh;

        /// <summary>
        /// 联系电话
        /// </summary>	
        public string LXDH
        {
            get { return _lxdh; }
            set { _lxdh = value; }
        }

        private decimal _type;

        /// <summary>
        /// 类型
        /// </summary>	
        public decimal TYPE
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _typename;

        /// <summary>
        /// 类型名称
        /// </summary>	
        public string TYPENAME
        {
            get { return _typename; }
            set { _typename = value; }
        }

        private string _gh;

        /// <summary>
        /// 工号
        /// </summary>	
        public string GH
        {
            get { return _gh; }
            set { _gh = value; }
        }

        private string _xm;

        /// <summary>
        /// 姓名
        /// </summary>	
        public string XM
        {
            get { return _xm; }
            set { _xm = value; }
        }

        private string _phone_num;

        /// <summary>
        /// 电话号码
        /// </summary>	
        public string PHONE_NUM
        {
            get { return _phone_num; }
            set { _phone_num = value; }
        }
    }
}
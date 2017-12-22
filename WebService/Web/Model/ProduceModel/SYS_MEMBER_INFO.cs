using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 系统人员信息表
    /// </summary>
    [Serializable]
    public class SYS_MEMBER_INFO
    {
        private string _id;
        /// <summary>
        /// 工号
        /// </summary>	
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;
        /// <summary>
        /// 姓名
        /// </summary>	
        public string NAME
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _password;
        /// <summary>
        /// 密码
        /// </summary>	
        public string PASSWORD
        {
            get { return _password; }
            set { _password = value; }
        }
        private decimal _type;
        /// <summary>
        /// 角色等级。存储人员权限等级编码
        /// </summary>		
        public decimal TYPE
        {
            get { return _type; }
            set { _type = value; }
        }
        private string _org_id;
        /// <summary>
        /// 所属机构
        /// </summary>	
        public string ORG_ID
        {
            get { return _org_id; }
            set { _org_id = value; }
        }
        private string _ssks;
        /// <summary>
        /// 所属科室
        /// </summary>	
        public string SSKS
        {
            get { return _ssks; }
            set { _ssks = value; }
        }
        private decimal _flag;
        /// <summary>
        /// 状态标识。标识该工号是否已禁用
        /// </summary>		
        public decimal FLAG
        {
            get { return _flag; }
            set { _flag = value; }
        }
        private string _phone_num;
        /// <summary>
        /// 通信号码
        /// </summary>
        public string PHONE_NUM
        {
            get { return _phone_num; }
            set { _phone_num = value; }
        }
        private string _text_num;
        /// <summary>
        /// 短信号码
        /// </summary>		
        public string TEXT_NUM
        {
            get { return _text_num; }
            set { _text_num = value; }
        }
        private DateTime _create_time;
        /// <summary>
        /// 创建时间
        /// </summary>		
        public DateTime CREATE_TIME
        {
            get { return _create_time; }
            set { _create_time = value; }
        }
        private DateTime _last_modity_time;
        /// <summary>
        /// 最后更新时间
        /// </summary>		
        public DateTime LAST_MODITY_TIME
        {
            get { return _last_modity_time; }
            set { _last_modity_time = value; }
        }
        private decimal _xzbm;
        /// <summary>
        /// 行政编码
        /// </summary>		
        public decimal XZBM
        {
            get { return _xzbm; }
            set { _xzbm = value; }
        }

    }
}
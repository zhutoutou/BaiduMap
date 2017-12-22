using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace Web.Model
{
    /// <summary>
    ///用户信息
    /// </summary>
    [Serializable]
    public class V_MEMBER_INFO
    {


        private string _id;

        /// <summary>
        /// ID
        /// </summary>	
        public string ID
        {
            get { return _id; }
            set { _id = value; }
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

        private string _password;

        /// <summary>
        /// PASSWORD
        /// </summary>	
        public string PASSWORD
        {
            get { return _password; }
            set { _password = value; }
        }

        private decimal _type;

        /// <summary>
        /// TYPE
        /// </summary>	
        public decimal TYPE
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _typename;

        /// <summary>
        /// TYPENAME
        /// </summary>	
        public string TYPENAME
        {
            get { return _typename; }
            set { _typename = value; }
        }

        private string _org_id;

        /// <summary>
        /// ORG_ID
        /// </summary>	
        public string ORG_ID
        {
            get { return _org_id; }
            set { _org_id = value; }
        }

        private string _org_name;

        /// <summary>
        /// ORG_NAME
        /// </summary>	
        public string ORG_NAME
        {
            get { return _org_name; }
            set { _org_name = value; }
        }

        private string _ssks;

        /// <summary>
        /// SSKS
        /// </summary>	
        public string SSKS
        {
            get { return _ssks; }
            set { _ssks = value; }
        }

        private string _ssksmc;

        /// <summary>
        /// SSKSMC
        /// </summary>	
        public string SSKSMC
        {
            get { return _ssksmc; }
            set { _ssksmc = value; }
        }

        private decimal _flag;

        /// <summary>
        /// FLAG
        /// </summary>	
        public decimal FLAG
        {
            get { return _flag; }
            set { _flag = value; }
        }

        private string _phone_num;

        /// <summary>
        /// PHONE_NUM
        /// </summary>	
        public string PHONE_NUM
        {
            get { return _phone_num; }
            set { _phone_num = value; }
        }

        private string _text_num;

        /// <summary>
        /// TEXT_NUM
        /// </summary>	
        public string TEXT_NUM
        {
            get { return _text_num; }
            set { _text_num = value; }
        }

        private DateTime _create_time;

        /// <summary>
        /// CREATE_TIME
        /// </summary>	
        public DateTime CREATE_TIME
        {
            get { return _create_time; }
            set { _create_time = value; }
        }

        private DateTime _last_modify_time;

        /// <summary>
        /// LAST_MODIFY_TIME
        /// </summary>	
        public DateTime LAST_MODIFY_TIME
        {
            get { return _last_modify_time; }
            set { _last_modify_time = value; }
        }

    }
}


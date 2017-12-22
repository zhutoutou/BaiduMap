using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace Web.Model
{
    /// <summary>
    ///通知详细实体类
    /// </summary>
    [Serializable]
    public class V_NOTICE_INFO
    {


        private string _lsh;

        /// <summary>
        /// LSH
        /// </summary>	
        public string LSH
        {
            get { return _lsh; }
            set { _lsh = value; }
        }

        private decimal _xh;

        /// <summary>
        /// XH
        /// </summary>	
        public decimal XH
        {
            get { return _xh; }
            set { _xh = value; }
        }

        private DateTime _anc_time=DateTime.Now;

        /// <summary>
        /// ANC_TIME
        /// </summary>	
        public DateTime ANC_TIME
        {
            get { return _anc_time; }
            set { _anc_time = value; }
        }

        private decimal _indate;

        /// <summary>
        /// INDATE
        /// </summary>	
        public decimal INDATE
        {
            get { return _indate; }
            set { _indate = value; }
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

        private string _anc_cont;

        /// <summary>
        /// ANC_CONT
        /// </summary>	
        public string ANC_CONT
        {
            get { return _anc_cont; }
            set { _anc_cont = value; }
        }

        private string _publisher;

        /// <summary>
        /// PUBLISHER
        /// </summary>	
        public string PUBLISHER
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        private decimal _receiver_type;

        /// <summary>
        /// RECEIVER_TYPE
        /// </summary>	
        public decimal RECEIVER_TYPE
        {
            get { return _receiver_type; }
            set { _receiver_type = value; }
        }

        private string _receiver;

        /// <summary>
        /// RECEIVER
        /// </summary>	
        public string RECEIVER
        {
            get { return _receiver; }
            set { _receiver = value; }
        }

    }
}
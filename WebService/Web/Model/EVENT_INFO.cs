using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    ///事件记录表
    /// </summary>
    [Serializable]
    public class EVENT_INFO
    {


        private string _sjh;

        /// <summary>
        /// 事件号
        /// </summary>	
        public string SJH
        {
            get { return _sjh; }
            set { _sjh = value; }
        }

        private decimal _status;

        /// <summary>
        /// 状态。填写状态编码
        /// </summary>	
        public decimal STATUS
        {
            get { return _status; }
            set { _status = value; }
        }

        private DateTime _scldsj;

        /// <summary>
        /// 首次来电时间
        /// </summary>	
        public DateTime SCLDSJ
        {
            get { return _scldsj; }
            set { _scldsj = value; }
        }

        private string _scldhm;

        /// <summary>
        /// 首次来电号码
        /// </summary>	
        public string SCLDHM
        {
            get { return _scldhm; }
            set { _scldhm = value; }
        }

        private DateTime _scslsj;

        /// <summary>
        /// 首次受理时间
        /// </summary>	
        public DateTime SCSLSJ
        {
            get { return _scslsj; }
            set { _scslsj = value; }
        }

        private string _scslrpid;

        /// <summary>
        /// 首次受理坐席ID
        /// </summary>	
        public string SCSLRPID
        {
            get { return _scslrpid; }
            set { _scslrpid = value; }
        }

        private string _scddy;

        /// <summary>
        /// 首次调度员ID
        /// </summary>	
        public string SCDDY
        {
            get { return _scddy; }
            set { _scddy = value; }
        }

        private string _hcyy;

        /// <summary>
        /// 呼车原因。存储受理记录表中的呼叫原因信息
        /// </summary>	
        public string HCYY
        {
            get { return _hcyy; }
            set { _hcyy = value; }
        }

        private decimal _sjlx;

        /// <summary>
        /// 事件类型。填写受理类型编码
        /// </summary>	
        public decimal SJLX
        {
            get { return _sjlx; }
            set { _sjlx = value; }
        }

        private decimal _sglx;

        /// <summary>
        /// 事故类型。是否重大事故，0 否，1 是 ，默认否
        /// </summary>	
        public decimal SGLX
        {
            get { return _sglx; }
            set { _sglx = value; }
        }

        private decimal _sgdj;

        /// <summary>
        /// 事故等级。存储事故等级编码
        /// </summary>	
        public decimal SGDJ
        {
            get { return _sgdj; }
            set { _sgdj = value; }
        }

        private string _xcdz;

        /// <summary>
        /// 现场地址
        /// </summary>	
        public string XCDZ
        {
            get { return _xcdz; }
            set { _xcdz = value; }
        }

        private decimal _flag;

        /// <summary>
        /// 关联标识。标识该事件是否关联其他事件，默认为0 否，1是
        /// </summary>	
        public decimal FLAG
        {
            get { return _flag; }
            set { _flag = value; }
        }

        private DateTime _create_time;

        /// <summary>
        /// 事件创建时间
        /// </summary>	
        public DateTime CREATE_TIME
        {
            get { return _create_time; }
            set { _create_time = value; }
        }

        private DateTime _last_modify_time;

        /// <summary>
        /// 最后更新时间
        /// </summary>	
        public DateTime LAST_MODIFY_TIME
        {
            get { return _last_modify_time; }
            set { _last_modify_time = value; }
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
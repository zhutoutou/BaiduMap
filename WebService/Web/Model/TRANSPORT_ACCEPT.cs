using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    ///转院受理记录表
    /// </summary>
    [Serializable]
    public class TRANSPORT_ACCEPT
    {


        private string _lsh;

        /// <summary>
        /// 流水号
        /// </summary>	
        public string LSH
        {
            get { return _lsh; }
            set { _lsh = value; }
        }

        private string _rpid;

        /// <summary>
        /// 坐席ID
        /// </summary>	
        public string RPID
        {
            get { return _rpid; }
            set { _rpid = value; }
        }

        private string _ddyid;

        /// <summary>
        /// 调度员ID
        /// </summary>	
        public string DDYID
        {
            get { return _ddyid; }
            set { _ddyid = value; }
        }

        private string _sjh;

        /// <summary>
        /// 事件号
        /// </summary>	
        public string SJH
        {
            get { return _sjh; }
            set { _sjh = value; }
        }

        private DateTime _slsj;

        /// <summary>
        /// 受理时间
        /// </summary>	
        public DateTime SLSJ
        {
            get { return _slsj; }
            set { _slsj = value; }
        }

        private decimal _slzt;

        /// <summary>
        /// 受理状态。标识是否受理完，默认为0 否，1是
        /// </summary>	
        public decimal SLZT
        {
            get { return _slzt; }
            set { _slzt = value; }
        }

        private decimal _slly;

        /// <summary>
        /// 受理来源。存储受理来源编码
        /// </summary>	
        public decimal SLLY
        {
            get { return _slly; }
            set { _slly = value; }
        }

        private decimal _sllx;

        /// <summary>
        /// 受理类型。存储受理类型编码
        /// </summary>	
        public decimal SLLX
        {
            get { return _sllx; }
            set { _sllx = value; }
        }

        private decimal _hjzlx;

        /// <summary>
        /// 呼叫者类型。存储呼叫者类型编码，如重点用户，远盟用户等
        /// </summary>	
        public decimal HJZLX
        {
            get { return _hjzlx; }
            set { _hjzlx = value; }
        }

        private string _szyy;

        /// <summary>
        /// 当前所在医院
        /// </summary>	
        public string SZYY
        {
            get { return _szyy; }
            set { _szyy = value; }
        }

        private decimal _is_ckout;

        /// <summary>
        /// 是否已办理出院。默认为1 是 已办理，0 否 ，未办理
        /// </summary>	
        public decimal IS_CKOUT
        {
            get { return _is_ckout; }
            set { _is_ckout = value; }
        }

        private string _szks;

        /// <summary>
        /// 所在科室
        /// </summary>	
        public string SZKS
        {
            get { return _szks; }
            set { _szks = value; }
        }

        private string _szbs;

        /// <summary>
        /// 所在病室
        /// </summary>	
        public string SZBS
        {
            get { return _szbs; }
            set { _szbs = value; }
        }

        private string _mqzd;

        /// <summary>
        /// 目前诊断
        /// </summary>	
        public string MQZD
        {
            get { return _mqzd; }
            set { _mqzd = value; }
        }

        private string _ybhgx;

        /// <summary>
        /// 与病患关系
        /// </summary>	
        public string YBHGX
        {
            get { return _ybhgx; }
            set { _ybhgx = value; }
        }

        private string _zwyy;

        /// <summary>
        /// 转往医院
        /// </summary>	
        public string ZWYY
        {
            get { return _zwyy; }
            set { _zwyy = value; }
        }

        private string _gcdf;

        /// <summary>
        /// 管床大夫
        /// </summary>	
        public string GCDF
        {
            get { return _gcdf; }
            set { _gcdf = value; }
        }

        private string _gcdfyj;

        /// <summary>
        /// 管床大夫意见
        /// </summary>	
        public string GCDFYJ
        {
            get { return _gcdfyj; }
            set { _gcdfyj = value; }
        }

        private string _hzxm;

        /// <summary>
        /// 患者姓名
        /// </summary>	
        public string HZXM
        {
            get { return _hzxm; }
            set { _hzxm = value; }
        }

        private decimal _hzxb;

        /// <summary>
        /// 患者性别
        /// </summary>	
        public decimal HZXB
        {
            get { return _hzxb; }
            set { _hzxb = value; }
        }

        private decimal _nl;

        /// <summary>
        /// 年龄
        /// </summary>	
        public decimal NL
        {
            get { return _nl; }
            set { _nl = value; }
        }

        private decimal _mz;

        /// <summary>
        /// 民族
        /// </summary>	
        public decimal MZ
        {
            get { return _mz; }
            set { _mz = value; }
        }

        private decimal _gj;

        /// <summary>
        /// 国籍
        /// </summary>	
        public decimal GJ
        {
            get { return _gj; }
            set { _gj = value; }
        }

        private decimal _tq;

        /// <summary>
        /// 天气
        /// </summary>	
        public decimal TQ
        {
            get { return _tq; }
            set { _tq = value; }
        }

        private decimal _lk;

        /// <summary>
        /// 路况
        /// </summary>	
        public decimal LK
        {
            get { return _lk; }
            set { _lk = value; }
        }

        private string _bz;

        /// <summary>
        /// 备注
        /// </summary>	
        public string BZ
        {
            get { return _bz; }
            set { _bz = value; }
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
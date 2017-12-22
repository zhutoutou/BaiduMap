using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    ///呼叫记录表
    /// </summary>
    [Serializable]
    public class CALL_INFO
    {
        private string _hclsh;

        /// <summary>
        /// 呼出流水号
        /// </summary>	
        public string HCLSH
        {
            get { return _hclsh; }
            set { _hclsh = value; }
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
        private string _jcdz;

        /// <summary>
        /// 接车地址
        /// </summary>	
        public string JCDZ
        {
            get { return _jcdz; }
            set { _jcdz = value; }
        }
        private string _lsh;

        /// <summary>
        /// 流水号
        /// </summary>	
        public string LSH
        {
            get { return _lsh; }
            set { _lsh = value; }
        }

        private decimal _hjlx;

        /// <summary>
        /// 呼叫类型。存储呼叫类型编码，如急救、咨询、投诉、工作电话等
        /// </summary>	
        public decimal HJLX
        {
            get { return _hjlx; }
            set { _hjlx = value; }
        }

        private string _gllsh;

        /// <summary>
        /// 关联流水号
        /// </summary>	
        public string GLLSH
        {
            get { return _gllsh; }
            set { _gllsh = value; }
        }

        private decimal _hcbz;

        /// <summary>
        /// 呼出标识。标识呼入与呼出电话，默认呼入，值为0，呼出 值为1
        /// </summary>	
        public decimal HCBZ
        {
            get { return _hcbz; }
            set { _hcbz = value; }
        }

        private decimal _hjly;

        /// <summary>
        /// 呼叫来源。存储呼叫来源编码，如老年呼叫器、短信、APP、视频等
        /// </summary>	
        public decimal HJLY
        {
            get { return _hjly; }
            set { _hjly = value; }
        }

        private DateTime? _hjsj;

        /// <summary>
        /// 呼叫时间
        /// </summary>	
        public DateTime? HJSJ
        {
            get { return _hjsj; }
            set { _hjsj = value; }
        }

        private string _hzm;

        /// <summary>
        /// 户主名
        /// </summary>	
        public string HZM
        {
            get { return _hzm; }
            set { _hzm = value; }
        }

        private string _zjdz;

        /// <summary>
        /// 装机地址
        /// </summary>	
        public string ZJDZ
        {
            get { return _zjdz; }
            set { _zjdz = value; }
        }

        private string _zjhm;

        /// <summary>
        /// 主叫号码
        /// </summary>	
        public string ZJHM
        {
            get { return _zjhm; }
            set { _zjhm = value; }
        }

        private string _bjhm;

        /// <summary>
        /// 被叫号码
        /// </summary>	
        public string BJHM
        {
            get { return _bjhm; }
            set { _bjhm = value; }
        }

        private decimal _sfjt;

        /// <summary>
        /// 是否接听。0 是，1 否
        /// </summary>	
        public decimal SFJT
        {
            get { return _sfjt; }
            set { _sfjt = value; }
        }

        private decimal _sfhb;

        /// <summary>
        /// 是否回拨。上一字段为1时，才需要填写，0是，1否
        /// </summary>	
        public decimal SFHB
        {
            get { return _sfhb; }
            set { _sfhb = value; }
        }

        private string _callid;

        /// <summary>
        /// 呼叫Id
        /// </summary>	
        public string CALLID
        {
            get { return _callid; }
            set { _callid = value; }
        }

        private string _rpid;

        /// <summary>
        /// 分配坐席Id
        /// </summary>	
        public string RPID
        {
            get { return _rpid; }
            set { _rpid = value; }
        }
        private string _ddyid;

        /// <summary>
        /// 调度员Id
        /// </summary>	
        public string DDYID
        {
            get { return _ddyid; }
            set { _ddyid = value; }
        }

        private DateTime? _zlsj;

        /// <summary>
        /// 振铃时间
        /// </summary>	
        public DateTime? ZLSJ
        {
            get { return _zlsj; }
            set { _zlsj = value; }
        }

        private DateTime? _zjsj;

        /// <summary>
        /// 摘机时间
        /// </summary>	
        public DateTime? ZJSJ
        {
            get { return _zjsj; }
            set { _zjsj = value; }
        }

        private DateTime? _gjsj;

        /// <summary>
        /// 挂机时间
        /// </summary>	
        public DateTime? GJSJ
        {
            get { return _gjsj; }
            set { _gjsj = value; }
        }

        private string _lyid;

        /// <summary>
        /// 录音ID
        /// </summary>	
        public string LYID
        {
            get { return _lyid; }
            set { _lyid = value; }
        }

        private decimal _gps_x;

        /// <summary>
        /// 呼叫地址经度
        /// </summary>	
        public decimal GPS_X
        {
            get { return _gps_x; }
            set { _gps_x = value; }
        }

        private decimal _gps_y;

        /// <summary>
        /// 呼叫地址纬度
        /// </summary>	
        public decimal GPS_Y
        {
            get { return _gps_y; }
            set { _gps_y = value; }
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


        private decimal _nflag;

        /// <summary>
        /// 标识
        /// </summary>	
        public decimal FLAG
        {
            get { return _nflag; }
            set { _nflag = value; }
        }
        private string _errmsg;

        /// <summary>
        /// 错误信息
        /// </summary>	
        public string ERRMSG
        {
            get { return _errmsg; }
            set { _errmsg = value; }
        }
    }
}
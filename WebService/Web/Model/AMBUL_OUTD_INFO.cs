using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    ///出车信息表
    /// </summary>
    [Serializable]
    public class AMBUL_OUTD_INFO
    {
        private decimal _iszxqxpc;
        /// <summary>
        /// 是否中心取消派车
        /// </summary>
        public decimal ISZXQXPC
        {
            get { return _iszxqxpc; }
            set { _iszxqxpc = value; }
        }
        private DateTime _qxpcsj;

        /// <summary>
        /// 取消派车时间
        /// </summary>	
        public DateTime QXPCSJ
        {
            get { return _qxpcsj; }
            set { _qxpcsj = value; }
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

        private decimal _ccxh;
        private DateTime _DBRSBSJ;

        /// <summary>
        /// 到达病人身边时间
        /// </summary>	
        public DateTime DBRSBSJ
        {
            get { return _DBRSBSJ; }
            set { _DBRSBSJ = value; }
        }
        /// <summary>
        /// 出车序号
        /// </summary>	
        public decimal CCXH
        {
            get { return _ccxh; }
            set { _ccxh = value; }
        }

        private string _bz;

        /// <summary>
        /// 出车备注（由分站更新）
        /// </summary>	
        public string BZ
        {
            get { return _bz; }
            set { _bz = value; }
        }

        private string _clid;

        /// <summary>
        /// 车辆ID
        /// </summary>	
        public string CLID
        {
            get { return _clid; }
            set { _clid = value; }
        }

        private string _szfz;

        /// <summary>
        /// 所在分站。存储分站的ORG_ID
        /// </summary>	
        public string SZFZ
        {
            get { return _szfz; }
            set { _szfz = value; }
        }

        private decimal _pclx;

        /// <summary>
        /// 派车类型。普通急救派车，改派，增援
        /// </summary>	
        public decimal PCLX
        {
            get { return _pclx; }
            set { _pclx = value; }
        }

        private DateTime _pcsj;

        /// <summary>
        /// 派车时间
        /// </summary>	
        public DateTime PCSJ
        {
            get { return _pcsj; }
            set { _pcsj = value; }
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

        private decimal _flag;

        /// <summary>
        /// 状态标志。标识本次出车是否结束，默认是0 未结束 1 已结束
        /// </summary>	
        public decimal FLAG
        {
            get { return _flag; }
            set { _flag = value; }
        }

        private decimal _sfqxpc;

        /// <summary>
        /// 是否取消派车。默认 0 否， 1是
        /// </summary>	
        public decimal SFQXPC
        {
            get { return _sfqxpc; }
            set { _sfqxpc = value; }
        }

        private decimal _qxyy;

        /// <summary>
        /// 取消原因。取消派车字段值为1时，存储取消派车原因编码
        /// </summary>	
        public decimal QXYY
        {
            get { return _qxyy; }
            set { _qxyy = value; }
        }

        private decimal _gpbz;

        /// <summary>
        /// 改派标识。当派车类型为改派时，对取消的车和改派的车生成一个编号，填入两次派车记录中的本字段，作为标识
        /// </summary>	
        public decimal GPBZ
        {
            get { return _gpbz; }
            set { _gpbz = value; }
        }

        private DateTime _ccsj;

        /// <summary>
        /// 出车时间
        /// </summary>	
        public DateTime CCSJ
        {
            get { return _ccsj; }
            set { _ccsj = value; }
        }

        private DateTime _ddxcsj;

        /// <summary>
        /// 到达现场时间
        /// </summary>	
        public DateTime DDXCSJ
        {
            get { return _ddxcsj; }
            set { _ddxcsj = value; }
        }

        private DateTime _scsj;

        /// <summary>
        /// 上车时间
        /// </summary>	
        public DateTime SCSJ
        {
            get { return _scsj; }
            set { _scsj = value; }
        }

        private DateTime _swsj;

        /// <summary>
        /// 送往时间
        /// </summary>	
        public DateTime SWSJ
        {
            get { return _swsj; }
            set { _swsj = value; }
        }

        private DateTime _wcsj;

        /// <summary>
        /// 完成时间
        /// </summary>	
        public DateTime WCSJ
        {
            get { return _wcsj; }
            set { _wcsj = value; }
        }

        private DateTime _fzsj;

        /// <summary>
        /// 返站时间
        /// </summary>	
        public DateTime FZSJ
        {
            get { return _fzsj; }
            set { _fzsj = value; }
        }

        private decimal _tsqk;

        /// <summary>
        /// 特殊情况。存储特殊情况编码
        /// </summary>	
        public decimal TSQK
        {
            get { return _tsqk; }
            set { _tsqk = value; }
        }

        private string _swdd;

        /// <summary>
        /// 送往地点。存储医院的ORG_ID
        /// </summary>	
        public string SWDD
        {
            get { return _swdd; }
            set { _swdd = value; }
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

        private bool  _isresult=false;

        /// <summary>
        /// 是否返回相关数据
        /// </summary>	
        public bool IsResult
        {
            get { return _isresult; }
            set { _isresult = value; }
        }

    }
}
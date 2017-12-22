using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 出车信息实体类(存储过程、视图)
    /// </summary>
    public class SP_GET_AMBUL_OUTD_INFO
    {

        private string _sllxsm;

        /// <summary>
        /// 受理类型说明
        /// </summary>	
        public string SLLXSM
        {
            get { return _sllxsm; }
            set { _sllxsm = value; }
        }
        private string _zzlxsm;

        public string ZZLXSM
        {
            get { return _zzlxsm; }
            set { _zzlxsm = value; }
        }

        private decimal _iszxqxpc;
        /// <summary>
        /// 是否中心取消派车
        /// </summary>
        public decimal ISZXQXPC
        {
            get { return _iszxqxpc; }
            set { _iszxqxpc = value; }
        }

        private decimal _zzlx;

        public decimal ZZLX
        {
            get { return _zzlx; }
            set { _zzlx = value; }
        }

        private string _lyid;

        public string LYID
        {
            get { return _lyid; }
            set { _lyid = value; }
        }

        private string _hjyybc;

        public string HJYYBC
        {
            get { return _hjyybc; }
            set { _hjyybc = value; }
        }

        private string _bjhm;

        public string BJHM
        {
            get { return _bjhm; }
            set { _bjhm = value; }
        }

        private string _yymc;

        /// <summary>
        /// 医院名称
        /// </summary>	
        public string YYMC
        {
            get { return _yymc; }
            set { _yymc = value; }
        }

        private string _zjhm;

        /// <summary>
        /// ZJHM
        /// </summary>	
        public string ZJHM
        {
            get { return _zjhm; }
            set { _zjhm = value; }
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
        private string _qxyy;

        /// <summary>
        /// 取消派车原因
        /// </summary>	
        public string QXYY
        {
            get { return _qxyy; }
            set { _qxyy = value; }
        }
        private string _pclx;

        /// <summary>
        /// 派车类型
        /// </summary>	
        public string PCLX
        {
            get { return _pclx; }
            set { _pclx = value; }
        }
        private string _bz;

        /// <summary>
        /// 分站备注上报
        /// </summary>	
        public string BZ
        {
            get { return _bz; }
            set { _bz = value; }
        }
        private string _fzrpname;

        /// <summary>
        /// 分站RP名称
        /// </summary>	
        public string FZRPMC
        {
            get { return _fzrpname; }
            set { _fzrpname = value; }
        }
        private DateTime _DBRSBSJ;

        /// <summary>
        /// 到达病人身边时间
        /// </summary>	
        public DateTime DBRSBSJ
        {
            get { return _DBRSBSJ; }
            set { _DBRSBSJ = value; }
        }
        private string _fzrpid;

        /// <summary>
        /// 分站RPID
        /// </summary>	
        public string FZRPID
        {
            get { return _fzrpid; }
            set { _fzrpid = value; }
        }
        private string _lsh;

        /// <summary>
        /// LSH
        /// </summary>	
        public string LSH
        {
            get { return _lsh; }
            set { _lsh = value; }
        }

        private string _sjh;

        /// <summary>
        /// SJH
        /// </summary>	
        public string SJH
        {
            get { return _sjh; }
            set { _sjh = value; }
        }

        private decimal _SFQXPC;

        /// <summary>
        /// 是否取消派车
        /// </summary>	
        public decimal SFQXPC
        {
            get { return _SFQXPC; }
            set { _SFQXPC = value; }
        }


        private string _czdh;

        /// <summary>
        /// 车载电话
        /// </summary>	
        public string CLDH
        {
            get { return _czdh; }
            set { _czdh = value; }
        }
        private decimal _ccxh;

        /// <summary>
        /// CCXH
        /// </summary>	
        public decimal CCXH
        {
            get { return _ccxh; }
            set { _ccxh = value; }
        }

        private string _clid;

        /// <summary>
        /// CLID
        /// </summary>	
        public string CLID
        {
            get { return _clid; }
            set { _clid = value; }
        }

        private string _clmc;

        /// <summary>
        /// CLMC
        /// </summary>	
        public string CLMC
        {
            get { return _clmc; }
            set { _clmc = value; }
        }

        private string _szfz;

        /// <summary>
        /// SZFZ
        /// </summary>	
        public string SZFZ
        {
            get { return _szfz; }
            set { _szfz = value; }
        }

        private decimal _is_fzcl;

        /// <summary>
        /// IS_FZCL
        /// </summary>	
        public decimal IS_FZCL
        {
            get { return _is_fzcl; }
            set { _is_fzcl = value; }
        }

        private string _fzmc;

        /// <summary>
        /// FZMC
        /// </summary>	
        public string FZMC
        {
            get { return _fzmc; }
            set { _fzmc = value; }
        }

        private string _rpid;
        /// <summary>
        /// 分站RPID
        /// </summary>	
        public string RPID
        {
            get { return _rpid; }
            set { _rpid = value; }
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

        private string _rpname;

        /// <summary>
        /// 分站RPNAME
        /// </summary>	
        public string RPNAME
        {
            get { return _rpname; }
            set { _rpname = value; }
        }

        private string _ddy;

        /// <summary>
        /// DDY
        /// </summary>	
        public string DDY
        {
            get { return _ddy; }
            set { _ddy = value; }
        }

        private DateTime _pcsj;

        /// <summary>
        /// PCSJ
        /// </summary>	
        public DateTime PCSJ
        {
            get { return _pcsj; }
            set { _pcsj = value; }
        }

        private DateTime _ccsj;

        /// <summary>
        /// CCSJ
        /// </summary>	
        public DateTime CCSJ
        {
            get { return _ccsj; }
            set { _ccsj = value; }
        }

        private DateTime _ddxcsj;

        /// <summary>
        /// DDXCSJ
        /// </summary>	
        public DateTime DDXCSJ
        {
            get { return _ddxcsj; }
            set { _ddxcsj = value; }
        }

        private DateTime _scsj;

        /// <summary>
        /// SCSJ
        /// </summary>	
        public DateTime SCSJ
        {
            get { return _scsj; }
            set { _scsj = value; }
        }

        private DateTime _swsj;

        /// <summary>
        /// SWSJ
        /// </summary>	
        public DateTime SWSJ
        {
            get { return _swsj; }
            set { _swsj = value; }
        }

        private DateTime _wcsj;

        /// <summary>
        /// WCSJ
        /// </summary>	
        public DateTime WCSJ
        {
            get { return _wcsj; }
            set { _wcsj = value; }
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

        private DateTime _fzsj;

        /// <summary>
        /// FZSJ
        /// </summary>	
        public DateTime FZSJ
        {
            get { return _fzsj; }
            set { _fzsj = value; }
        }

        private string _swdd;

        /// <summary>
        /// SWDD
        /// </summary>	
        public string SWDD
        {
            get { return _swdd; }
            set { _swdd = value; }
        }

        private string _tsqk;

        /// <summary>
        /// TSQK
        /// </summary>	
        public string TSQK
        {
            get { return _tsqk; }
            set { _tsqk = value; }
        }

        private string _ys;

        /// <summary>
        /// YS
        /// </summary>	
        public string YS
        {
            get { return _ys; }
            set { _ys = value; }
        }

        private string _sj;

        /// <summary>
        /// SJ
        /// </summary>	
        public string SJ
        {
            get { return _sj; }
            set { _sj = value; }
        }

        private string _hs;

        /// <summary>
        /// HS
        /// </summary>	
        public string HS
        {
            get { return _hs; }
            set { _hs = value; }
        }

        private string _djg;

        /// <summary>
        /// DJG
        /// </summary>	
        public string DJG
        {
            get { return _djg; }
            set { _djg = value; }
        }
        private decimal _clzt;

        /// <summary>
        /// 车辆状态
        /// </summary>	
        public decimal CLZT
        {
            get { return _clzt; }
            set { _clzt = value; }
        }

        private decimal _ywddq;

        /// <summary>
        /// 分站是否拥有调度权，0：无，1：有
        /// </summary>	
        public decimal YWDDQ
        {
            get { return _ywddq; }
            set { _ywddq = value; }
        }

        private string _clztsm;

        /// <summary>
        /// 车辆状态说明
        /// </summary>	
        public string CLZTSM
        {
            get { return _clztsm; }
            set { _clztsm = value; }
        }
        private DateTime _SLSJ;

        /// <summary>
        /// 受理时间
        /// </summary>	
        public DateTime SLSJ
        {
            get { return _SLSJ; }
            set { _SLSJ = value; }
        }

        private DateTime _ZLSJ;

        /// <summary>
        /// 振铃时间
        /// </summary>	
        public DateTime ZLSJ
        {
            get { return _ZLSJ; }
            set { _ZLSJ = value; }
        }
        private DateTime _HJSJ;

        /// <summary>
        /// 呼叫时间
        /// </summary>	
        public DateTime HJSJ
        {
            get { return _HJSJ; }
            set { _HJSJ = value; }
        }
        private DateTime _ZJSJ;

        /// <summary>
        /// 摘机时间
        /// </summary>	
        public DateTime ZJSJ
        {
            get { return _ZJSJ; }
            set { _ZJSJ = value; }
        }
        private DateTime _GJSJ;

        /// <summary>
        /// 挂机时间
        /// </summary>	
        public DateTime GJSJ
        {
            get { return _GJSJ; }
            set { _GJSJ = value; }
        }

    }
}
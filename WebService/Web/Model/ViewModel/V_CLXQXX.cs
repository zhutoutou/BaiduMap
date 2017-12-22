using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    ///车辆详情信息视图
    /// </summary>
    [Serializable]
    public class V_CLXQXX
    {
        private decimal _ccxh;

        /// <summary>
        /// 出车序号
        /// </summary>	
        public decimal CCXH
        {
            get { return _ccxh; }
            set { _ccxh = value; }
        }
        private decimal _rn;

        /// <summary>
        /// RN
        /// </summary>	
        public decimal RN
        {
            get { return _rn; }
            set { _rn = value; }
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

        private string _name;

        /// <summary>
        /// NAME
        /// </summary>	
        public string NAME
        {
            get { return _name; }
            set { _name = value; }
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
        private decimal _cldj;

        /// <summary>
        /// CLDJ
        /// </summary>	
        public decimal CLDJ
        {
            get { return _cldj; }
            set { _cldj = value; }
        }

        private string _cldjsm;

        /// <summary>
        /// CLDJSM
        /// </summary>	
        public string CLDJSM
        {
            get { return _cldjsm; }
            set { _cldjsm = value; }
        }

        private decimal _clzt;

        /// <summary>
        /// CLZT
        /// </summary>	
        public decimal CLZT
        {
            get { return _clzt; }
            set { _clzt = value; }
        }

        private string _clztsm;

        /// <summary>
        /// CLZTSM
        /// </summary>	
        public string CLZTSM
        {
            get { return _clztsm; }
            set { _clztsm = value; }
        }

        private string _szfzid;

        /// <summary>
        /// SZFZID
        /// </summary>	
        public string SZFZID
        {
            get { return _szfzid; }
            set { _szfzid = value; }
        }

        private string _szfzmc;

        /// <summary>
        /// SZFZMC
        /// </summary>	
        public string SZFZMC
        {
            get { return _szfzmc; }
            set { _szfzmc = value; }
        }

        private DateTime _zhgxsj;

        /// <summary>
        /// ZHGXSJ
        /// </summary>	
        public DateTime ZHGXSJ
        {
            get { return _zhgxsj; }
            set { _zhgxsj = value; }
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

        private string _sjid;

        /// <summary>
        /// SJID
        /// </summary>	
        public string SJID
        {
            get { return _sjid; }
            set { _sjid = value; }
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

        private string _sjdh;

        /// <summary>
        /// 司机电话
        /// </summary>	
        public string SJDH
        {
            get { return _sjdh; }
            set { _sjdh = value; }
        }

        private string _ysid;

        /// <summary>
        /// YSID
        /// </summary>	
        public string YSID
        {
            get { return _ysid; }
            set { _ysid = value; }
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

        private string _ysdh;

        /// <summary>
        /// 医生电话
        /// </summary>	
        public string YSDH
        {
            get { return _ysdh; }
            set { _ysdh = value; }
        }

        private string _hsid;

        /// <summary>
        /// HSID
        /// </summary>	
        public string HSID
        {
            get { return _hsid; }
            set { _hsid = value; }
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

        private string _hsdh;

        /// <summary>
        /// 护士电话
        /// </summary>	
        public string HSDH
        {
            get { return _hsdh; }
            set { _hsdh = value; }
        }

        private string _djgid;

        /// <summary>
        /// DJGID
        /// </summary>	
        public string DJGID
        {
            get { return _djgid; }
            set { _djgid = value; }
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

        private string _djgdh;

        /// <summary>
        /// 担架工电话
        /// </summary>	
        public string DJGDH
        {
            get { return _djg; }
            set { _djg = value; }
        }

        private string _ddyid;

        /// <summary>
        /// DDYID
        /// </summary>	
        public string DDYID
        {
            get { return _ddyid; }
            set { _ddyid = value; }
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

        private DateTime _fzsj;

        /// <summary>
        /// FZSJ
        /// </summary>	
        public DateTime FZSJ
        {
            get { return _fzsj; }
            set { _fzsj = value; }
        }

    }
}
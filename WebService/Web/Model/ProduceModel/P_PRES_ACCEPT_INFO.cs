using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 急救受理单实体类
    /// 根据传入的流水号或者事件号查看受理单
    /// </summary>
    [Serializable]
    public class P_PRES_ACCEPT_INFO
    {
        private decimal _zzpcsum;

        /// <summary>
        /// 正常派车总数
        /// </summary>	
        public decimal ZZPCSUM
        {
            get { return _zzpcsum; }
            set { _zzpcsum = value; }
        }
        private string _ddy;

        /// <summary>
        /// 调度员
        /// </summary>	
        public string DDY
        {
            get { return _ddy; }
            set { _ddy = value; }
        }
        string _sfjt = "未接听";
        /// <summary>
        /// 是否接听
        /// </summary>	
        public string SFJT
        {
            get { return _sfjt; }
            set { _sfjt = value; }
        }
        string _hrhc = "呼入";
        /// <summary>
        /// 呼入呼出
        /// </summary>	
        public string HRHC
        {
            get { return _hrhc; }
            set { _hrhc = value; }
        }
        string _clids;
        /// <summary>
        /// 该受理的出车id集合
        /// </summary>	
        public string clids
        {
            get { return _clids; }
            set { _clids = value; }
        }
        private decimal _hjqy;

        /// <summary>
        /// 呼叫区域编码
        /// </summary>	
        public decimal HJQY
        {
            get { return _hjqy; }
            set { _hjqy = value; }
        }
        string _hjqym;

        /// <summary>
        /// 呼叫区域说明
        /// </summary>	
        public string HJQYSM
        {
            get { return _hjqym; }
            set { _hjqym = value; }
        }
        private string _rpid;

        /// <summary>
        /// RPID
        /// </summary>	
        public string RPID
        {
            get { return _rpid; }
            set { _rpid = value; }
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
        private string _lsh;

        /// <summary>
        /// LSH
        /// </summary>	
        public string LSH
        {
            get { return _lsh; }
            set { _lsh = value; }
        }


        private decimal _hcbz;

        /// <summary>
        /// 回拨标识
        /// </summary>	
        public decimal HCBZ
        {
            get { return _hcbz; }
            set { _hcbz = value; }
        }
        private string _lyid;

        /// <summary>
        /// 录音id
        /// </summary>	
        public string LYID
        {
            get { return _lyid; }
            set { _lyid = value; }
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

        private string _zjhm;

        /// <summary>
        /// ZJHM
        /// </summary>	
        public string ZJHM
        {
            get { return _zjhm; }
            set { _zjhm = value; }
        }

        private DateTime _hjsj;

        /// <summary>
        /// HJSJ
        /// </summary>	
        public DateTime HJSJ
        {
            get { return _hjsj; }
            set { _hjsj = value; }
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
        private DateTime? _zjsj;

        /// <summary>
        /// 摘机时间
        /// </summary>	
        public DateTime? ZJSJ
        {
            get { return _zjsj; }
            set { _zjsj = value; }
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
        private DateTime? _gjsj;

        /// <summary>
        /// 挂机时间
        /// </summary>	
        public DateTime? GJSJ
        {
            get { return _gjsj; }
            set { _gjsj = value; }
        }

        private string _hzm;

        /// <summary>
        /// HZM
        /// </summary>	
        public string HZM
        {
            get { return _hzm; }
            set { _hzm = value; }
        }

        private string _zjdz;

        /// <summary>
        /// ZJDZ
        /// </summary>	
        public string ZJDZ
        {
            get { return _zjdz; }
            set { _zjdz = value; }
        }

        private decimal _slzt;

        /// <summary>
        /// SLZT
        /// </summary>	
        public decimal SLZT
        {
            get { return _slzt; }
            set { _slzt = value; }
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

        private decimal _slly;

        /// <summary>
        /// SLLY
        /// </summary>	
        public decimal SLLY
        {
            get { return _slly; }
            set { _slly = value; }
        }

        private string _sllysm;

        /// <summary>
        /// SLLYSM
        /// </summary>	
        public string SLLYSM
        {
            get { return _sllysm; }
            set { _sllysm = value; }
        }

        private decimal _sllx;

        /// <summary>
        /// SLLX
        /// </summary>	
        public decimal SLLX
        {
            get { return _sllx; }
            set { _sllx = value; }
        }

        private string _sllxsm;

        /// <summary>
        /// SLLXSM
        /// </summary>	
        public string SLLXSM
        {
            get { return _sllxsm; }
            set { _sllxsm = value; }
        }

        private decimal _hjzlx;

        /// <summary>
        /// HJZLX
        /// </summary>	
        public decimal HJZLX
        {
            get { return _hjzlx; }
            set { _hjzlx = value; }
        }

        private string _hjzlxsm;

        /// <summary>
        /// HJZLXSM
        /// </summary>	
        public string HJZLXSM
        {
            get { return _hjzlxsm; }
            set { _hjzlxsm = value; }
        }

        private decimal _sglx;

        /// <summary>
        /// SGLX
        /// </summary>	
        public decimal SGLX
        {
            get { return _sglx; }
            set { _sglx = value; }
        }

        private string _sglxsm;

        /// <summary>
        /// SGLXSM
        /// </summary>	
        public string SGLXSM
        {
            get { return _sglxsm; }
            set { _sglxsm = value; }
        }

        private decimal _hjyykb;

        /// <summary>
        /// HJYYKB
        /// </summary>	
        public decimal HJYYKB
        {
            get { return _hjyykb; }
            set { _hjyykb = value; }
        }

        private string _hjyykbsm;

        /// <summary>
        /// HJYYKBSM
        /// </summary>	
        public string HJYYKBSM
        {
            get { return _hjyykbsm; }
            set { _hjyykbsm = value; }
        }

        private decimal _hjyyzs;

        /// <summary>
        /// HJYYZS
        /// </summary>	
        public decimal HJYYZS
        {
            get { return _hjyyzs; }
            set { _hjyyzs = value; }
        }

        private string _hjyyzssm;

        /// <summary>
        /// HJYYZSSM
        /// </summary>	
        public string HJYYZSSM
        {
            get { return _hjyyzssm; }
            set { _hjyyzssm = value; }
        }

        private decimal _hjyyzz;

        /// <summary>
        /// HJYYZZ
        /// </summary>	
        public decimal HJYYZZ
        {
            get { return _hjyyzz; }
            set { _hjyyzz = value; }
        }

        private string _hjyyzzsm;

        /// <summary>
        /// HJYYZZSM
        /// </summary>	
        public string HJYYZZSM
        {
            get { return _hjyyzzsm; }
            set { _hjyyzzsm = value; }
        }

        private string _hjyybc;

        /// <summary>
        /// HJYYBC
        /// </summary>	
        public string HJYYBC
        {
            get { return _hjyybc; }
            set { _hjyybc = value; }
        }

        private string _xcdz;

        /// <summary>
        /// XCDZ
        /// </summary>	
        public string XCDZ
        {
            get { return _xcdz; }
            set { _xcdz = value; }
        }

        private string _jcdz;

        /// <summary>
        /// JCDZ
        /// </summary>	
        public string JCDZ
        {
            get { return _jcdz; }
            set { _jcdz = value; }
        }

        private string _lxdh;

        /// <summary>
        /// LXDH
        /// </summary>	
        public string LXDH
        {
            get { return _lxdh; }
            set { _lxdh = value; }
        }

        private string _lxr;

        /// <summary>
        /// LXR
        /// </summary>	
        public string LXR
        {
            get { return _lxr; }
            set { _lxr = value; }
        }

        private string _swyy;

        /// <summary>
        /// SWYY
        /// </summary>	
        public string SWYY
        {
            get { return _swyy; }
            set { _swyy = value; }
        }

        private decimal _hzrs;

        /// <summary>
        /// HZRS
        /// </summary>	
        public decimal HZRS
        {
            get { return _hzrs; }
            set { _hzrs = value; }
        }

        private string _tsyq;

        /// <summary>
        /// TSYQ
        /// </summary>	
        public string TSYQ
        {
            get { return _tsyq; }
            set { _tsyq = value; }
        }

        private string _tq;

        /// <summary>
        /// TQ
        /// </summary>	
        public string TQ
        {
            get { return _tq; }
            set { _tq = value; }
        }

        private string _lk;

        /// <summary>
        /// LK
        /// </summary>	
        public string LK
        {
            get { return _lk; }
            set { _lk = value; }
        }

        private string _hzxm;

        /// <summary>
        /// HZXM
        /// </summary>	
        public string HZXM
        {
            get { return _hzxm; }
            set { _hzxm = value; }
        }

        private string _hzxb;

        /// <summary>
        /// HZXB
        /// </summary>	
        public string HZXB
        {
            get { return _hzxb; }
            set { _hzxb = value; }
        }

        private string _nl;

        /// <summary>
        /// NL
        /// </summary>	
        public string NL
        {
            get { return _nl; }
            set { _nl = value; }
        }

        private string _gj;

        /// <summary>
        /// GJ
        /// </summary>	
        public string GJ
        {
            get { return _gj; }
            set { _gj = value; }
        }

        private string _fzfk;

        /// <summary>
        /// 分站备注反馈
        /// </summary>	
        public string FZFK
        {
            get { return _fzfk; }
            set { _fzfk = value; }
        }

        private string _bz;

        /// <summary>
        /// BZ
        /// </summary>	
        public string BZ
        {
            get { return _bz; }
            set { _bz = value; }
        }
        decimal _overrtime;
        /// <summary>
        /// 超时时间
        /// </summary>	
        public decimal OverranTime
        {
            get
            {
                return _overrtime;
            }
            set { _overrtime = value; }
        }
        private decimal _zzlx;

        /// <summary>
        /// ZZLX
        /// </summary>	
        public decimal ZZLX
        {
            get { return _zzlx; }
            set { _zzlx = value; }
        }

        private string _zzlxsm;

        /// <summary>
        /// ZZLXSM
        /// </summary>	
        public string ZZLXSM
        {
            get { return _zzlxsm; }
            set { _zzlxsm = value; }
        }

        private decimal _is_ckout;

        /// <summary>
        /// IS_CKOUT
        /// </summary>	
        public decimal IS_CKOUT
        {
            get { return _is_ckout; }
            set { _is_ckout = value; }
        }

        private string _szks;

        /// <summary>
        /// SZKS
        /// </summary>	
        public string SZKS
        {
            get { return _szks; }
            set { _szks = value; }
        }

        private string _mqzd;

        /// <summary>
        /// MQZD
        /// </summary>	
        public string MQZD
        {
            get { return _mqzd; }
            set { _mqzd = value; }
        }

        private string _ybhgx;

        /// <summary>
        /// YBHGX
        /// </summary>	
        public string YBHGX
        {
            get { return _ybhgx; }
            set { _ybhgx = value; }
        }

        private string _gcdf;

        /// <summary>
        /// GCDF
        /// </summary>	
        public string GCDF
        {
            get { return _gcdf; }
            set { _gcdf = value; }
        }

        private string _gcdfyj;

        /// <summary>
        /// GCDFYJ
        /// </summary>	
        public string GCDFYJ
        {
            get { return _gcdfyj; }
            set { _gcdfyj = value; }
        }


        string _ORDERID = string.Empty;
        /// <summary>
        /// 远盟受理单号
        /// </summary>
        public string YM_ORDERID
        {
            get { return _ORDERID; }
            set { _ORDERID = value; }
        }
        string _XZBM = string.Empty;
        /// <summary>
        /// 行政编码
        /// </summary>
        public string YM_XZBM
        {
            get { return _XZBM; }
            set { _XZBM = value; }
        }
        string _JOBNUM = string.Empty;
        /// <summary>
        /// 远盟坐席台号
        /// </summary>
        public string YM_JOBNUM
        {
            get { return _JOBNUM; }
            set { _JOBNUM = value; }
        }
        string _TELPHONE = string.Empty;
        /// <summary>
        /// 手机号码
        /// </summary>
        public string YM_TELPHONE
        {
            get { return _TELPHONE; }
            set { _TELPHONE = value; }
        }
        string _GPS_X = string.Empty;
        /// <summary>
        /// 经度
        /// </summary>
        public string YM_GPS_X
        {
            get { return _GPS_X; }
            set { _GPS_X = value; }
        }
        string _GPS_Y = string.Empty;
        /// <summary>
        /// 纬度
        /// </summary>
        public string YM_GPS_Y
        {
            get { return _GPS_Y; }
            set { _GPS_Y = value; }
        }
        string _CHINESELOCATION = string.Empty;
        /// <summary>
        /// 中文地址
        /// </summary>
        public string YM_CHINESELOCATION
        {
            get { return _CHINESELOCATION; }
            set { _CHINESELOCATION = value; }
        }
        string _PERSONNUM = string.Empty;
        /// <summary>
        /// 人数
        /// </summary>
        public string YM_PERSONNUM
        {
            get { return _PERSONNUM; }
            set { _PERSONNUM = value; }
        }
        string _CONNECTTEL = string.Empty;
        /// <summary>
        /// 联系人电话
        /// </summary>
        public string YM_CONNECTTEL
        {
            get { return _CONNECTTEL; }
            set { _CONNECTTEL = value; }
        }
        string _CONNECTOR = string.Empty;
        /// <summary>
        /// 联系人
        /// </summary>
        public string YM_CONNECTOR
        {
            get { return _CONNECTOR; }
            set { _CONNECTOR = value; }
        }
        string _VENAME = string.Empty;
        /// <summary>
        /// 联系人
        /// </summary>
        public string YM_VENAME
        {
            get { return _VENAME; }
            set { _VENAME = value; }
        }
        string _VEMODEL = string.Empty;
        /// <summary>
        /// 车辆品牌
        /// </summary>
        public string YM_VEMODEL
        {
            get { return _VEMODEL; }
            set { _VEMODEL = value; }
        }
        string _REMARK = string.Empty;
        /// <summary>
        /// 备注
        /// </summary>
        public string YM_REMARK
        {
            get { return _REMARK; }
            set { _REMARK = value; }
        }
        string _CZDH = string.Empty;
        /// <summary>
        /// 任务车辆电话
        /// </summary>
        public string YM_CZDH
        {
            get { return _CZDH; }
            set { _CZDH = value; }
        }
        private decimal _hjz;

        //20170915 修改人：朱星汉 修改内:添加呼救人
        /// <summary>
        /// 呼救者
        /// </summary>	
        public decimal HJZ
        {
            get { return _hjz; }
            set { _hjz = value; }
        }

        //20170915 修改人：朱星汉 修改内:添加呼救人
        private string _hjzsm;
        /// <summary>
        /// HJZSM
        /// </summary>	
        public string HJZSM
        {
            get { return _hjzsm; }
            set { _hjzsm = value; }
        }
    }

    public class ACCEPT_YM
    {
        string _ORDERID = string.Empty;
        /// <summary>
        /// 远盟受理单号
        /// </summary>
        public string ORDERID
        {
            get { return _ORDERID; }
            set { _ORDERID = value; }
        }
        string _XZBM = string.Empty;
        /// <summary>
        /// 行政编码
        /// </summary>
        public string XZBM
        {
            get { return _XZBM; }
            set { _XZBM = value; }
        }
        string _JOBNUM = string.Empty;
        /// <summary>
        /// 远盟坐席台号
        /// </summary>
        public string JOBNUM
        {
            get { return _JOBNUM; }
            set { _JOBNUM = value; }
        }
        string _TELPHONE = string.Empty;
        /// <summary>
        /// 手机号码
        /// </summary>
        public string TELPHONE
        {
            get { return _TELPHONE; }
            set { _TELPHONE = value; }
        }
        string _GPS_X = string.Empty;
        /// <summary>
        /// 经度
        /// </summary>
        public string GPS_X
        {
            get { return _GPS_X; }
            set { _GPS_X = value; }
        }
        string _GPS_Y = string.Empty;
        /// <summary>
        /// 纬度
        /// </summary>
        public string GPS_Y
        {
            get { return _GPS_Y; }
            set { _GPS_Y = value; }
        }
        string _CHINESELOCATION = string.Empty;
        /// <summary>
        /// 中文地址
        /// </summary>
        public string CHINESELOCATION
        {
            get { return _CHINESELOCATION; }
            set { _CHINESELOCATION = value; }
        }
        string _PERSONNUM = string.Empty;
        /// <summary>
        /// 人数
        /// </summary>
        public string PERSONNUM
        {
            get { return _PERSONNUM; }
            set { _PERSONNUM = value; }
        }
        string _NAME = string.Empty;
        /// <summary>
        /// 名字
        /// </summary>
        public string NAME
        {
            get { return _NAME; }
            set { _NAME = value; }
        }
        string _NATIONALITY = string.Empty;
        /// <summary>
        /// 国籍
        /// </summary>
        public string NATIONALITY
        {
            get { return _NATIONALITY; }
            set { _NATIONALITY = value; }
        }
        string _SEX = string.Empty;
        /// <summary>
        /// 性别
        /// </summary>
        public string SEX
        {
            get { return _SEX; }
            set { _SEX = value; }
        }
        string _CONNECTTEL = string.Empty;
        /// <summary>
        /// 联系人电话
        /// </summary>
        public string CONNECTTEL
        {
            get { return _CONNECTTEL; }
            set { _CONNECTTEL = value; }
        }
        string _CONNECTOR = string.Empty;
        /// <summary>
        /// 联系人
        /// </summary>
        public string CONNECTOR
        {
            get { return _CONNECTOR; }
            set { _CONNECTOR = value; }
        }
        string _VENAME = string.Empty;
        /// <summary>
        /// 联系人
        /// </summary>
        public string VENAME
        {
            get { return _VENAME; }
            set { _VENAME = value; }
        }
        string _VEMODEL = string.Empty;
        /// <summary>
        /// 车辆品牌
        /// </summary>
        public string VEMODEL
        {
            get { return _VEMODEL; }
            set { _VEMODEL = value; }
        }
        string _REMARK = string.Empty;
        /// <summary>
        /// 备注
        /// </summary>
        public string REMARK
        {
            get { return _REMARK; }
            set { _REMARK = value; }
        }
        string _LSH = string.Empty;
        /// <summary>
        /// 流水号。关联急救受理单流水号
        /// </summary>
        public string LSH
        {
            get { return _LSH; }
            set { _LSH = value; }
        }
        DateTime? _CREATE_TIME;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CREATE_TIME
        {
            get { return _CREATE_TIME; }
            set { _CREATE_TIME = value; }
        }
        DateTime? _LAST_MODIFY_TIME;
        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime? LAST_MODIFY_TIME
        {
            get { return _LAST_MODIFY_TIME; }
            set { _LAST_MODIFY_TIME = value; }
        }
        string _CZDH = string.Empty;
        /// <summary>
        /// 任务车辆电话
        /// </summary>
        public string CZDH
        {
            get { return _CZDH; }
            set { _CZDH = value; }
        }
    }


    public class QualityRespnose
    {
        //{"lsh":"","qualitycomment":"1","reason":"","caseid":"","commenttime":""}
        public string lsh = string.Empty;
        public string qualitycomment = string.Empty;
        public string reason = string.Empty;
        public string caseid = string.Empty;
        public DateTime? commenttime = null;
    }


    public class receiveAPPSheet
    {
        // 1:receiveAPPSheet 接收APP报警转单 7000
        //{"caseid":"2016","phone":"138","name":"","sex":"1","brithday":"","height":"","weight":"",
        //"identitycard":"","jd":"118.0001","wd":"32.001","address":"","medicalhistory":"",
        //"contactway1":"137","contactway2":"138","contactway3":"139","medicalinsurancecard":"",
        //"areacode":"320100","calltime":"","isself":"2"}
        public string caseid = string.Empty;
        public string phone = string.Empty;
        public string name = string.Empty;
        public string sex = string.Empty;
        public string brithday = string.Empty;
        public string height = "";
        public string weight = "";
        public string identitycard = string.Empty;
        public string jd = string.Empty;
        public string wd = string.Empty;
        public string address = string.Empty;

        public string medicalhistory = string.Empty;
        public string contactway1 = string.Empty;
        public string contactway2 = string.Empty;
        public string contactway3 = string.Empty;
        public string medicalinsurancecard = string.Empty;

        public string areacode = string.Empty;
        public string province = string.Empty;
        public string city = string.Empty;
        public string area = string.Empty;
        public string xzbm = string.Empty;
        public string lsh = string.Empty;
        public DateTime? calltime = null;
        public string isself = string.Empty;

    }
}
using System;
using System.Configuration;

namespace Web.Model
{
    /// <summary>
    /// 受理记录表
    /// </summary>
    [Serializable]
    public class FZ_ACCEPT_INFO
    {
        /// <summary>
        /// 流水号
        /// </summary>		
        private string _lsh;
        public string LSH
        {
            get { return _lsh; }
            set { _lsh = value; }
        }
        private decimal _ddlx;
        /// <summary>
        /// 调度类型
        /// </summary>		
        public decimal DDLX
        {
            get { return _ddlx; }
            set { _ddlx = value; }
        }
        private DateTime _fbsj;
        /// <summary>
        /// 生成时间
        /// </summary>		
        public DateTime FBSJ
        {
            get { return _fbsj; }
            set { _fbsj = value; }
        }
        private DateTime _qrsj;
        /// <summary>
        /// 确认时间
        /// </summary>		
        public DateTime QRSJ
        {
            get { return _qrsj; }
            set { _qrsj = value; }
        }
        private decimal _zt = 1;
        /// <summary>
        /// 处理状态
        /// </summary>		
        public decimal ZT
        {
            get { return _zt; }
            set { _zt = value; }
        }

        private string _fzbz;
        /// <summary>
        /// 分站备注
        /// </summary>		
        public string FZBZ
        {
            get { return _fzbz; }
            set { _fzbz = value; }
        }

        private string _ddyid;
        /// <summary>
        /// 调度员工号
        /// </summary>		
        public string DDYID
        {
            get { return _ddyid; }
            set { _ddyid = value; }
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

        private string _sjh;
        /// <summary>
        /// /// 事件号
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
        private decimal _slly;
        /// <summary>
        /// 受理来源。存储受理来源编码
        /// </summary>		
        public decimal SLLY
        {
            get { return _slly; }
            set { _slly = value; }
        }

        private string _sllysm;
        /// <summary>
        /// 受理来源。存储受理来源编码
        /// </summary>		
        public string SLLYSM
        {
            get { return _sllysm; }
            set { _sllysm = value; }
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

        private string _sllxsm;
        /// <summary>
        /// 受理类型说明
        /// </summary>		
        public string SLLXSM
        {
            get { return _sllxsm; }
            set { _sllxsm = value; }
        }
        private string _hjz;
        /// <summary>
        /// 呼叫者。存储编码
        /// </summary>		
        public string HJZ
        {
            get { return _hjz; }
            set { _hjz = value; }
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

        private string _hjzlxsm;
        /// <summary>
        /// 呼叫者类型说明
        /// </summary>		
        public string HJZLXSM
        {
            get { return _hjzlxsm; }
            set { _hjzlxsm = value; }
        }
        /// <summary>
        /// 事故类型。是否重大事故，0 否，1 是 ，默认否
        /// </summary>		
        private decimal _sglx;
        public decimal SGLX
        {
            get { return _sglx; }
            set { _sglx = value; }
        }

        private string _sglxsm;
        public string SGLXSM
        {
            get { return _sglxsm; }
            set { _sglxsm = value; }
        }

        private decimal _hjyykb;
        /// <summary>
        /// 呼叫原因-科别。存储科别编码
        /// </summary>		
        public decimal HJYYKB
        {
            get { return _hjyykb; }
            set { _hjyykb = value; }
        }
        private decimal _hjyyzs;
        /// <summary>
        /// 呼叫原因-主诉。存储主诉编码
        /// </summary>		
        public decimal HJYYZS
        {
            get { return _hjyyzs; }
            set { _hjyyzs = value; }
        }
        private decimal _hjyyzz;
        /// <summary>
        /// 呼叫原因-症状。存储三级编码的主诉编码
        /// </summary>		
        public decimal HJYYZZ
        {
            get { return _hjyyzz; }
            set { _hjyyzz = value; }
        }
        private string _hjyybc;
        /// <summary>
        /// 呼叫原因补充
        /// </summary>		
        public string HJYYBC
        {
            get { return _hjyybc; }
            set { _hjyybc = value; }
        }

        private string _hjyykbsm;
        /// <summary>
        /// 呼叫原因-科别。存储科别编码
        /// </summary>		
        public string HJYYKBSM
        {
            get { return _hjyykbsm; }
            set { _hjyykbsm = value; }
        }
        private string _hjyyzssm;
        /// <summary>
        /// 呼叫原因-主诉。存储主诉编码
        /// </summary>		
        public string HJYYZSSM
        {
            get { return _hjyyzssm; }
            set { _hjyyzssm = value; }
        }
        private string _hjyyzzsm;
        /// <summary>
        /// 呼叫原因-症状。存储三级编码的主诉编码
        /// </summary>		
        public string HJYYZZSM
        {
            get { return _hjyyzzsm; }
            set { _hjyyzzsm = value; }
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
        private string _jcdz;
        /// <summary>
        /// 接车地址
        /// </summary>		
        public string JCDZ
        {
            get { return _jcdz; }
            set { _jcdz = value; }
        }
        private decimal _hjqy;
        /// <summary>
        /// 呼叫区域
        /// </summary>		
        public decimal HJQY
        {
            get { return _hjqy; }
            set { _hjqy = value; }
        }
        private string _gxyy;
        /// <summary>
        /// 管辖医院
        /// </summary>		
        public string GXYY
        {
            get { return _gxyy; }
            set { _gxyy = value; }
        }
        private decimal _hzrs;
        /// <summary>
        /// 患者人数
        /// </summary>		
        public decimal HZRS
        {
            get { return _hzrs; }
            set { _hzrs = value; }
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
        private string _hzxb;
        /// <summary>
        /// 患者性别
        /// </summary>		
        public string HZXB
        {
            get { return _hzxb; }
            set { _hzxb = value; }
        }
        private string _nl;
        /// <summary>
        /// 年龄
        /// </summary>		
        public string NL
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
        private string _gj;
        /// <summary>
        /// 国籍
        /// </summary>		
        public string GJ
        {
            get { return _gj; }
            set { _gj = value; }
        }
        private decimal _sqcd;
        /// <summary>
        /// 伤情程度
        /// </summary>		
        public decimal SQCD
        {
            get { return _sqcd; }
            set { _sqcd = value; }
        }
        private string _zdswyy;
        /// <summary>
        /// 指定送往医院
        /// </summary>		
        public string ZDSWYY
        {
            get { return _zdswyy; }
            set { _zdswyy = value; }
        }
        private string _tsyq;
        /// <summary>
        /// 特殊要求
        /// </summary>		
        public string TSYQ
        {
            get { return _tsyq; }
            set { _tsyq = value; }
        }
        private string _tq;
        /// <summary>
        /// 天气
        /// </summary>		
        public string TQ
        {
            get { return _tq; }
            set { _tq = value; }
        }
        private string _swdd;
        /// <summary>
        /// 送往地点。存储医院编码
        /// </summary>		
        public string SWDD
        {
            get { return _swdd; }
            set { _swdd = value; }
        }

        private string _dd;
        /// <summary>
        /// 送往地点。存储医院编码
        /// </summary>		
        public string DD
        {
            get { return _dd; }
            set { _dd = value; }
        }
        private string _swyy = "";
        /// <summary>
        /// 送往地点。存储医院编码
        /// </summary>		
        public string SWYY
        {
            get { return _swyy; }
            set { _swyy = value; }
        }

        private string _lxr;
        /// <summary>
        /// 联系人
        /// </summary>		
        public string LXR
        {
            get { return _lxr; }
            set { _lxr = value; }
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
        private string _lk;
        /// <summary>
        /// 路况
        /// </summary>		
        public string LK
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

        private decimal _xzbm;
        /// <summary>
        /// 行政编码
        /// </summary>		
        public decimal XZBM
        {
            get { return _xzbm; }
            set { _xzbm = value; }
        }
        private decimal _slzt;
        /// <summary>
        /// 受理状态
        /// </summary>		
        public decimal SLZT
        {
            get { return _slzt; }
            set { _slzt = value; }
        }
        private string _slztdesc;
        /// <summary>
        /// 受理状态描述
        /// </summary>		
        public string SLZTDESC
        {
            get { return _slztdesc; }
            set { _slztdesc = value; }
        }

        private string _zjhm;
        /// <summary>
        /// 主叫号码
        /// </summary>
        public string ZJHM
        {
            get
            {
                return _zjhm;
            }
            set
            {
                _zjhm = value;
            }
        }
        private DateTime _hjsj;
        /// <summary>
        /// 呼叫时间
        /// </summary>
        public DateTime HJSJ
        {
            get
            {
                return _hjsj;
            }
            set
            {
                _hjsj = value;
            }
        }
        private string _hzm;
        /// <summary>
        /// 户主名
        /// </summary>
        public string HZM
        {
            get
            {
                return _hzm;
            }
            set
            {
                _hzm = value;
            }
        }
        private string _zjdz;
        /// <summary>
        /// 装机地址
        /// </summary>
        public string ZJDZ
        {
            get
            {
                return _zjdz;
            }
            set
            {
                _zjdz = value;
            }
        }
        /// <summary>
        /// 车辆ID
        /// </summary>		
        private string _clid;
        public string CLID
        {
            get { return _clid; }
            set { _clid = value; }
        }
        /// <summary>
        /// 出车序号
        /// </summary>		
        private decimal _ccxh;
        public decimal CCXH
        {
            get { return _ccxh; }
            set { _ccxh = value; }
        }
        /// <summary>
        /// 所在分站。存储分站编码
        /// </summary>		
        private string _szfz;
        public string SZFZ
        {
            get { return _szfz; }
            set { _szfz = value; }
        }
        /// <summary>
        /// 派车类型。普通急救派车，改派，增援
        /// </summary>		
        private decimal _pclx;
        public decimal PCLX
        {
            get { return _pclx; }
            set { _pclx = value; }
        }
        /// <summary>
        /// 派车时间
        /// </summary>		
        private DateTime _pcsj;
        public DateTime PCSJ
        {
            get { return _pcsj; }
            set { _pcsj = value; }
        }
        /// <summary>
        /// 取消原因
        /// </summary>		
        private string _qxyy;
        public string QXYY
        {
            get { return _qxyy; }
            set { _qxyy = value; }
        }
        /// <summary>
        /// 是否取消派车
        /// </summary>		
        private decimal _sfqxpc;
        public decimal SFQXPC
        {
            get { return _sfqxpc; }
            set { _sfqxpc = value; }
        }
        /// <summary>
        /// 改派标识。当派车类型为改派时，对取消的车和改派的车生成一个编号，填入两次派车记录中的本字段，作为标识
        /// </summary>		
        private string _gpbz;
        public string GPBZ
        {
            get { return _gpbz; }
            set { _gpbz = value; }
        }
        /// <summary>
        /// 出车时间
        /// </summary>		
        private DateTime _ccsj;
        public DateTime CCSJ
        {
            get { return _ccsj; }
            set { _ccsj = value; }
        }
        ///// <summary>
        ///// 现场地址
        ///// </summary>		
        //private string _xcdz;
        //public string XCDZ
        //{
        //    get { return _xcdz; }
        //    set { _xcdz = value; }
        //}
        /// <summary>
        /// 到达现场时间
        /// </summary>		
        private DateTime _ddxcsj;
        public DateTime DDXCSJ
        {
            get { return _ddxcsj; }
            set { _ddxcsj = value; }
        }
        /// <summary>
        /// 上车时间
        /// </summary>		
        private DateTime _scsj;
        public DateTime SCSJ
        {
            get { return _scsj; }
            set { _scsj = value; }
        }
        /// <summary>
        /// 送往时间
        /// </summary>		
        private DateTime _swsj;
        public DateTime SWSJ
        {
            get { return _swsj; }
            set { _swsj = value; }
        }
        /// <summary>
        /// 完成时间
        /// </summary>		
        private DateTime _wcsj;
        public DateTime WCSJ
        {
            get { return _wcsj; }
            set { _wcsj = value; }
        }
        /// <summary>
        /// 返站时间
        /// </summary>		
        private DateTime _fzsj;
        public DateTime FZSJ
        {
            get { return _fzsj; }
            set { _fzsj = value; }
        }

        /// <summary>
        /// 随车医生姓名
        /// </summary>		
        private string _ys;
        public string YS
        {
            get { return _ys; }
            set { _ys = value; }
        }

        /// <summary>
        /// 护士
        /// </summary>		
        private string _hs;
        public string HS
        {
            get { return _hs; }
            set { _hs = value; }
        }

        /// <summary>
        /// 担架工
        /// </summary>		
        private string _djg;
        public string DJG
        {
            get { return _djg; }
            set { _djg = value; }
        }

        /// <summary>
        /// 司机
        /// </summary>		
        private string _sj;
        public string SJ
        {
            get { return _sj; }
            set { _sj = value; }
        }
        /// <summary>
        /// 最后更新时间
        /// </summary>		
        private DateTime _last_modify_time;
        public DateTime LAST_MODIFY_TIME
        {
            get { return _last_modify_time; }
            set { _last_modify_time = value; }
        }

        /// <summary>
        /// 最后更新时间
        /// </summary>		
        private DateTime _createTime;
        public DateTime CREATE_TIME
        {
            get { return _createTime; }
            set { _createTime = value; }
        }
        /// <summary>
        /// 车辆状态
        /// </summary>		
        private decimal _status;
        public decimal STATUS
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// 车辆任务完成标志 0 已完成  1 未完成
        /// </summary>		
        private decimal _flag;
        public decimal FLAG
        {
            get { return _flag; }
            set { _flag = value; }
        }

        /// <summary>
        /// 特殊情况
        /// </summary>		
        private string _tsqk;
        public string TSQK
        {
            get { return _tsqk; }
            set { _tsqk = value; }
        }

        private decimal _is_ckout;
        /// <summary>
        /// 是否办理出院 0否1是
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
        /// 与病人关系
        /// </summary>	
        public string YBHGX
        {
            get { return _ybhgx; }
            set { _ybhgx = value; }
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

        private decimal _zzlx;
        /// <summary>
        /// 转诊类型
        /// </summary>
        public decimal ZZLX
        {
            get { return _zzlx; }
            set { _zzlx = value; }
        }
        private string _zzlxsm;
        /// <summary>
        /// 转诊类型说明
        /// </summary>
        public string ZZLXSM
        {
            get { return _zzlxsm; }
            set { _zzlxsm = value; }
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    ///自出受理记录表
    /// </summary>
    [Serializable]
    public class DIRECT_ACCEPT_INFO
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

        private decimal _hjz;

        /// <summary>
        /// 呼叫者。存储编码
        /// </summary>	
        public decimal HJZ
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

        private decimal _sglx;

        /// <summary>
        /// 事故类型。是否重大事故，0 否，1 是 ，默认否
        /// </summary>	
        public decimal SGLX
        {
            get { return _sglx; }
            set { _sglx = value; }
        }

        private decimal _hjyykb;

        /// <summary>
        /// 呼叫原因-科别。存储科别编码（一级）
        /// </summary>	
        public decimal HJYYKB
        {
            get { return _hjyykb; }
            set { _hjyykb = value; }
        }

        private decimal _hjyyzs;

        /// <summary>
        /// 呼叫原因-主诉。存储主诉编码（二级）
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
        /// 管辖医院。存储医院的机构ID
        /// </summary>	
        public string GXYY
        {
            get { return _gxyy; }
            set { _gxyy = value; }
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

        private decimal _hzrs;

        /// <summary>
        /// 患者人数。默认为1
        /// </summary>	
        public decimal HZRS
        {
            get { return _hzrs; }
            set { _hzrs = value; }
        }

        private string _swyy;

        /// <summary>
        /// 送往医院。存储医院的ORG_ID
        /// </summary>	
        public string SWYY
        {
            get { return _swyy; }
            set { _swyy = value; }
        }

        private string _swdd;

        /// <summary>
        /// 送往地点。填写不在系统表中的医院或地址
        /// </summary>	
        public string SWDD
        {
            get { return _swdd; }
            set { _swdd = value; }
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

        private decimal _sqcd;

        /// <summary>
        /// 伤情程度
        /// </summary>	
        public decimal SQCD
        {
            get { return _sqcd; }
            set { _sqcd = value; }
        }

        private decimal _tsyq;

        /// <summary>
        /// 特殊要求。存储特殊要求编码
        /// </summary>	
        public decimal TSYQ
        {
            get { return _tsyq; }
            set { _tsyq = value; }
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

        private decimal _sfcs;

        /// <summary>
        /// 是否测试。默认 0 否， 1是
        /// </summary>	
        public decimal SFCS
        {
            get { return _sfcs; }
            set { _sfcs = value; }
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
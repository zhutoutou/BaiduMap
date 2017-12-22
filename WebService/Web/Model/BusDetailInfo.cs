using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    [Serializable]
    /// <summary>
    /// 车辆详细信息实体类
    /// </summary>
    public class BusDetailInfo
    {
        decimal _clid;
        /// <summary>
        /// 车辆编号
        /// </summary>
        public decimal CLID
        {
            get { return _clid; }
            set { _clid = value; }
        }

        decimal _szfz;
        /// <summary>
        /// 车辆所属分站编号
        /// </summary>
        public decimal SZFZ
        {
            get { return _szfz; }
            set { _szfz = value; }
        }

        string _szfz_name;
        /// <summary>
        /// 车辆所属分站名称
        /// </summary>
        public string FZNAME
        {
            get { return _szfz_name; }
            set { _szfz_name = value; }
        }

        decimal _sjid;
        /// <summary>
        /// 司机ID
        /// </summary>
        public decimal SJID
        {
            get { return _sjid; }
            set { _sjid = value; }
        }

        string _sjid_name;
        /// <summary>
        /// 司机名称
        /// </summary>
        public string SJNAME
        {
            get { return _sjid_name; }
            set { _sjid_name = value; }
        }

        decimal _ysid;
        /// <summary>
        /// 随车医生ID
        /// </summary>
        public decimal YSID
        {
            get { return _ysid; }
            set { _ysid = value; }
        }


        string _ysid_name;
        /// <summary>
        ///  随车医生名称
        /// </summary>
        public string YSNAME
        {
            get { return _ysid_name; }
            set { _ysid_name = value; }
        }

        decimal _hsid;
        /// <summary>
        /// 护士ID
        /// </summary>
        public decimal HSID
        {
            get { return _hsid; }
            set { _hsid = value; }
        }

        string _hsid_name;
        /// <summary>
        ///  护士名称
        /// </summary>
        public string HSNAME
        {
            get { return _hsid_name; }
            set { _hsid_name = value; }
        }
        decimal _djgid;
        /// <summary>
        /// 担架工ID
        /// </summary>
        public decimal DJGID
        {
            get { return _djgid; }
            set { _djgid = value; }
        }

        string _djgid_name;
        /// <summary>
        ///  担架工名称
        /// </summary>
        public string DJGNAME
        {
            get { return _djgid_name; }
            set { _djgid_name = value; }
        }
        DateTime _pcsj = DateTime.Now;
        /// <summary>
        /// 派车时间
        /// </summary>
        public DateTime PCSJ
        {
            get { return _pcsj; }
            set { _pcsj = value; }
        }

        DateTime _ccsj = DateTime.Now;
        /// <summary>
        /// 出车时间
        /// </summary>
        public DateTime CCSJ
        {
            get { return _ccsj; }
            set { _ccsj = value; }
        }

        DateTime _ddxcsj = DateTime.Now;
        /// <summary>
        /// 到达现场时间
        /// </summary>
        public DateTime DDXCSJ
        {
            get { return _ddxcsj; }
            set { _ddxcsj = value; }
        }

        DateTime _scsj = DateTime.Now;
        /// <summary>
        /// 上车时间
        /// </summary>
        public DateTime SCSJ
        {
            get { return _scsj; }
            set { _scsj = value; }
        }

        DateTime _swsj = DateTime.Now;
        /// <summary>
        /// 上车时间
        /// </summary>
        public DateTime SWSJ
        {
            get { return _swsj; }
            set { _swsj = value; }
        }

        DateTime _wcsj = DateTime.Now;
        /// <summary>
        /// 途中待命时间
        /// </summary>
        public DateTime WCSJ
        {
            get { return _wcsj; }
            set { _wcsj = value; }
        }

        DateTime _fzsj = DateTime.Now;
        /// <summary>
        /// 返站时间
        /// </summary>
        public DateTime FZSJ
        {
            get { return _fzsj; }
            set { _fzsj = value; }
        }
    }
    public class CLRYINFO
    {
        public string clid { get; set; }
        public decimal type { get; set; }
    }

    public class TongJi
    {
        /// <summary>
        /// 呼叫次数
        /// </summary>
        public int callcount { get; set; }
        /// <summary>
        /// 未接次数
        /// </summary>
        public int uncalledcount { get; set; }
        /// <summary>
        /// 接听次数
        /// </summary>
        public int calledcount { get; set; }
        /// <summary>
        /// 出车次数
        /// </summary>
        public int ambulcount { get; set; }
        /// <summary>
        /// 取消次数
        /// </summary>
        public int cancleambulcount { get; set; }
        /// <summary>
        /// 改派次数
        /// </summary>
        public int modifyambulcount { get; set; }
        /// <summary>
        /// 受理次数
        /// </summary>
        public int accecptcount { get; set; }
        /// <summary>
        /// 无效受理次数
        /// </summary>
        public int unccecptcount { get; set; }
        /// <summary>
        /// 急救次数
        /// </summary>
        public int emccount { get; set; }
        /// <summary>
        /// 转诊次数
        /// </summary>
        public int transfercount { get; set; }
    }
}
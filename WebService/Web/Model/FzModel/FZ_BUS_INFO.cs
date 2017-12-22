using System;

namespace Web.Model
{
    [Serializable]
    /// <summary>
    /// 车辆概要信息实体类
    /// </summary>
    public class FZ_BUS_INFO
    {
        string _clid;
        /// <summary>
        /// 车辆编号
        /// </summary>
        public string CLID
        {
            get { return _clid; }
            set { _clid = value; }
        }
        decimal _cldj;
        /// <summary>
        /// 车辆等级
        /// </summary>
        public decimal CLDJ
        {
            get { return _cldj; }
            set { _cldj = value; }
        }

        string _fzName;
        /// <summary>
        /// 分站名
        /// </summary>
        public string NAME
        {
            get { return _fzName; }
            set { _fzName = value; }
        }

        string _cldjsm="";
        /// <summary>
        /// 车辆等级说明
        /// </summary>
        public string CLDJN
        {
            get { return _cldjsm; }
            set { _cldjsm = value; }
        }

        decimal _staus;
        /// <summary>
        /// 车辆状态
        /// </summary>
        public decimal STATUS
        {
            get { return _staus; }
            set { _staus = value; }
        }

        string _statussm = "";
        /// <summary>
        /// 车辆状态说明
        /// </summary>
        public string CLZT
        {
            get { return _statussm; }
            set { _statussm = value; }
        }

        DateTime _last_modifytime = DateTime.Now;
        /// <summary>
        /// 状态时间
        /// </summary>
        public DateTime LAST_MODIFY_TIME
        {
            get { return _last_modifytime; }
            set { _last_modifytime = value; }
        }

        string _sjid;
        /// <summary>
        /// 司机ID
        /// </summary>
        public string SJ
        {
            get { return _sjid; }
            set { _sjid = value; }
        }

        string _czdh;
        /// <summary>
        /// 车载电话
        /// </summary>
        public string CZDH
        {
            get { return _czdh; }
            set { _czdh = value; }
        }
    }
}

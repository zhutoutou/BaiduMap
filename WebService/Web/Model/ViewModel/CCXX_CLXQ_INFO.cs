using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    /// 根据流水号跟车辆ID获取出车信息和车辆详情
    /// </summary>
    public class CCXX_CLXQ_INFO
    {
        List<SP_GET_AMBUL_OUTD_INFO> _ambul_info_list = new List<SP_GET_AMBUL_OUTD_INFO>();
        /// <summary>
        /// 出车信息
        /// </summary>
        public List<SP_GET_AMBUL_OUTD_INFO> Ambul_Info_List
        {
            get { return _ambul_info_list; }
            set { _ambul_info_list = value; }
        }
        V_CLXQXX _clxq = new V_CLXQXX();
        /// <summary>
        /// 车辆详情信息
        /// </summary>
        public V_CLXQXX Clxq
        {
            get { return _clxq; }
            set { _clxq = value; }
        }
    }
}
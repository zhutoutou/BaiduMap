using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Model
{
    /// <summary>
    ///取消原因实体类
    /// <summary>
    [Serializable]
    public class V_Reason
    {

        private string _note;

        /// <summary>
        /// 原因描述
        /// </summary>	
        public string NOTE
        {
            get { return _note; }
            set { _note = value; }
        }
        private string _name;

        /// <summary>
        /// 原因描述
        /// </summary>	
        public string NAME
        {
            get { return _name; }
            set { _name = value; }
        }

        private decimal _id;

        /// <summary>
        /// 原因id
        /// </summary>	
        public decimal ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private decimal _type;

        /// <summary>
        /// 原因类型
        /// </summary>	
        public decimal TYPE
        {
            get { return _type; }
            set { _type = value; }
        }

    }
}
using System;

namespace Web.Model
{
    /// <summary>
    /// 通知信息
    /// </summary>
    [Serializable]
    public class FZ_NOTICE_INFO
    {
        private string _LSH;
        /// <summary>
        /// 流水号
        /// </summary>
        public string LSH
        {
            get
            {
                return _LSH;
            }
            set
            {
                _LSH = value;
            }
        }

        private DateTime _ANC_TIME = DateTime.Now;
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime ANC_TIME
        {
            get
            {
                return _ANC_TIME;
            }
            set
            {
                _ANC_TIME = value;
            }
        }

        private string _ANC_CONT = "";
        /// <summary>
        /// 发布内容
        /// </summary>
        public string ANC_CONT
        {
            get
            {
                return _ANC_CONT;
            }
            set
            {
                _ANC_CONT = value;
            }
        }

        private string _remark = "查看";
        /// <summary>
        /// 查看字段
        /// </summary>
        public string Remark
        {
            get
            {
                return _remark;
            }

            set
            {
                _remark = value;
            }
        }

        private bool _isRead = true;
        /// <summary>
        /// 是否已读
        /// </summary>
        public bool IsRead
        {
            get
            {
                return _isRead;
            }

            set
            {
                _isRead = value;
            }
        }
    }
}

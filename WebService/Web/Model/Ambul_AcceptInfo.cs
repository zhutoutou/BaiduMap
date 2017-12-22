using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Model;

namespace Web
{
    [Serializable]
    public class Ambul_AcceptInfo
    {
        List<SP_GET_AMBUL_OUTD_INFO> _ambullist = new List<SP_GET_AMBUL_OUTD_INFO>();
        public List<SP_GET_AMBUL_OUTD_INFO> AmbulInfoList
        {
            get { return _ambullist; }
            set { _ambullist = value; }
        }
        P_PRES_ACCEPT_INFO _accept = new P_PRES_ACCEPT_INFO();
        public P_PRES_ACCEPT_INFO Acceptlnfo
        {
            get { return _accept; }
            set { _accept = value; }
        }
        V_SJLB _eventinfo = new V_SJLB();
        public V_SJLB EventInfo
        {
            get { return _eventinfo; }
            set { _eventinfo = value; }
        }
    }
}
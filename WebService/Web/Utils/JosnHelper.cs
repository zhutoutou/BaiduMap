using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web
{
    public static class JosnHelper
    {
        public static T DeserializeObject<T>(string msg)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(msg);

        }
        public static string SerializeObject<T>(T msg)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(msg);

        }

    }
}
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ICEEX.ApiTest.Extensions
{
    public static class Ext
    {
        public static string ToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace TrueNorth.Testing.Helper
{
    public static class JsonExtenions
    {
        public static string ToJsonString(this object o)
        {
            return JsonConvert.SerializeObject(o, Formatting.Indented);
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValStarter.Shared
{
    public static class TempDataExtensions
    {
        public static void Set<T>(this Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary tempData, string key, T value) where T : class
        {
            tempData[key] = JsonConvert.SerializeObject(value);
        }
        public static T Get<T>(this Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary tempData, string key) where T : class
        {
            tempData.TryGetValue(key, out object o);
            return o == null ? null : JsonConvert.DeserializeObject<T>((string)o);
        }
    }
}

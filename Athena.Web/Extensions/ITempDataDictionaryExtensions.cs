using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;

namespace Athena.Web.Extensions
{
    public static class ITempDataDictionaryExtensions
    {
        public static void Store<T>(this ITempDataDictionary dict, String key, T value) where T : class
        {
            dict.Remove(key);
            dict.Add(key, value);
        }

        public static T GetValueOrNull<T>(this ITempDataDictionary dict, String key) where T : class
        {
            return dict.ContainsKey(key)
                ? dict[key] as T
                : null;
        }
    }
}
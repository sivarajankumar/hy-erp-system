using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Reflection;

namespace Hy.Erp.system.Common
{
    public static class IEnumerableHepler
    {
        public static IList<Hashtable> AddProperty<TSource>(this IEnumerable<TSource> enumerable, Func<TSource, object> fun)
        {
            IList<Hashtable> hashtable = new List<Hashtable>();
            foreach (TSource enumer in enumerable)
            {
                Type t = enumer.GetType();
                //取到对象的所有公共属性
                PropertyInfo[] propertys = t.GetProperties();
                Hashtable ht = new Hashtable();
                foreach (PropertyInfo p in propertys)
                {
                    ht[p.Name] = p.GetValue(enumer, null);

                }

                var funObj = fun(enumer);
                Type objT = funObj.GetType();
                PropertyInfo[] objPropertys = objT.GetProperties();
                foreach (PropertyInfo p in objPropertys)
                {
                    ht[p.Name] = p.GetValue(funObj, null);
                }
                hashtable.Add(ht);
            }
            return hashtable;
        }
    }
}



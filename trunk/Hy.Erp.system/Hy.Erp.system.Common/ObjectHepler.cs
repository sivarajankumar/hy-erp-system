using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
namespace Hy.Erp.system.Common
{
    public static class ObjectHepler
    {
        public static T Clone<T>(this object obj)
        {
            return (T)obj.Clone();
        }

        public static object Clone(this object obj)
        {
            if (obj == null)
            {
                return null;
            }

            BinaryFormatter Formatter = new BinaryFormatter(null, new StreamingContext(StreamingContextStates.Clone));

            MemoryStream stream = new MemoryStream();

            Formatter.Serialize(stream, obj);

            stream.Position = 0;

            object clonedObj = Formatter.Deserialize(stream);

            stream.Close();

            return clonedObj;

        }
    }
}



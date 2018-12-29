using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;

namespace QuickSon
{

    public static class Json
    {
        public static string ToJSON<T>(this T obj)
        {
            MemoryStream stream1;
            StreamReader sr;
            DataContractJsonSerializer ser;
            T Obj;

            stream1 = new MemoryStream();
            ser = new DataContractJsonSerializer(typeof(T));
            Obj = obj;
            ser.WriteObject(stream1, Obj);
            stream1.Position = 0;//must come after WriteObject()
            sr = new StreamReader(stream1);
            return sr.ReadToEnd();
        }

        public static T ToObject<T>(this string jsonstring) where T :class
        {
            MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonstring));
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            memoryStream.Position = 0;
            return (T)serializer.ReadObject(memoryStream);
            
        }
    }

    
}


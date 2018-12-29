using System.IO;
using System.Runtime.Serialization.Json;

namespace QuickSon
{
    public class MyJsonConverter<T>
    {

        MemoryStream memoryStream;
        StreamReader reader;
        DataContractJsonSerializer serializer;
        T Obj;//obj to serialize

        public MyJsonConverter(T obj)
        {
            memoryStream = new MemoryStream();

            serializer = new DataContractJsonSerializer(
                typeof(T)
            );
            Obj = obj;
        }

        public string ToJSON()
        {
            serializer.WriteObject(memoryStream, Obj);
            memoryStream.Position = 0;//must come after WriteObject()
            if (reader == null)
                reader = new StreamReader(memoryStream);
            return reader.ReadToEnd();
        }

        public T ConvertBack()
        {
            memoryStream.Position = 0;
            return (T)serializer.ReadObject(memoryStream);
        }
    }
}

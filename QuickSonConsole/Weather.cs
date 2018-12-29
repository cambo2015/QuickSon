
using System.Runtime.Serialization;
namespace Example
{
    [DataContract]
    public class Weather
    {
        [DataMember]
        public string Current { get; set; }
        [DataMember]
        public string Forecast { get; set; }
    }
}

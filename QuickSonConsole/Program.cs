using QuickSon;
using static System.Console;
using static QuickSon.Json;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var weather = new Weather
            {
                Current = "90",
                Forecast = "Windy",
            };

            var r = weather.ToJSON();
            WriteLine(r);
            var w = r.ToObject<Weather>();
            WriteLine(w.Current);
            ReadKey();
        }
    }

    

}

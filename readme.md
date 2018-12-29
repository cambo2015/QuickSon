# QuickSon
## Features:
### - Convert an object to json in 1 line!


1. Create your object with tags
   ```  
   [DataContract]
    public class Weather
    {
        [DataMember]
        public string Current;
        
        [DataMember]
        public string Forecast;
    }
    ```
2. Instanciate your object
   ```
   var weather = new Weather
            {
                Current = "30",
                Forecast = "cloudy"
            };
            ```
3. Call the method
```
     string jsonStr = weather.ToJSON();
     Console.WriteLine(jsonStr);
```
4. Convert back to orginal class object
```
var obj = jsonStr.JsonToObj();
Console.WriteLine(jsonStr);
```

#### - Also included: 
-A Wrapper class included to convert an object to json string
-Quickson builds
####  and then convert it back to the orginal object.

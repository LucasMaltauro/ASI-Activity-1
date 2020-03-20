using System;

namespace ASI_Activity_1
{
    public class WeatherForecast
    {
      
        public string Zip { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}

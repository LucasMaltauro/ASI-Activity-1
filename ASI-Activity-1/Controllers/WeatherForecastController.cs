using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASI_Activity_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private const string v = "Please insert at the end of this website's URL / and the first 4 numbers of the Zip Code required";
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;


        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public String Get()
        {
            return v;
        }

        [HttpGet ("{Zip}")]
        public IEnumerable<WeatherForecast> Get(string Zip)
        {
            var rng = new Random();
                switch (Zip)
                {
                    case "1000":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "LISBON",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "4000":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "PORTO",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "3800":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "AVEIRO",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "7800":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "BEJA",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "4700":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "BRAGA",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "5300":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "BRAGANÇA",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "6000":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "CASTELO BRANCO",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "3000":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "COIMBRA",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "7000":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "ÉVORA",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "8000":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "FARO",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "9000":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "FUNCHAL",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "6300":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "GUARDA",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "2400":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "LEIRIA",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "9500":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "PONTE DELGADA",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "7300":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "PONTALEGRE",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "2000":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "SANTARÉM",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "2900":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "SETÚBAL",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "4900~":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "VIANA DO CASTELO",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "5000":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "VILA REAL",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                case "3500":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "VISEU",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();

                default:
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Zip = "Try another ZIP",
                        Date = DateTime.Now,
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }).ToArray();                }
            }
            
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp6.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }

        public async Task<int> TestNumbers(int number1, int number2)
        {
            var test1 = Test1(number1);

            var test2 = Test1(number2);

            await Task.WhenAll(new List<Task> { test1, test2 });

            return test1.Result + test2.Result;
        }


        private async Task<int> Test1(int number)
        {
            await Task.Delay(number * 1000);

            return number;
        }
    }
}

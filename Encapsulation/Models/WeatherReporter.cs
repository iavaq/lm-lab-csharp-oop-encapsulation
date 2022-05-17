using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private string _location;
        private double _temperature;

        public WeatherReporter(string location, double temperature)
        {
            _location = location;
            _temperature = temperature;
        }

        public string Print()
        {
            
            return $"I am in {_location} and it is {Check1()}. {Check2()}. The temperature in Fahrenheit is {CelciusToFahrenheit(_temperature)}.";
        }

        private string Check1()
        {
            if (_location == "London")
            {

                return "🌦";

            }
            else if (_location == "California")
            {

                return "🌅";

            }
            else if (_location == "Cape Town")
            {

                return "🌤";

            }
            return "🔆";
        }

        private string Check2()
        {
            if (_temperature > 30)
            {

                return "It's too hot 🥵!";

            }
            else if (_temperature < 10)
            {

                return "It's too cold 🥶!";

            }
            return "Ahhh...it's just right 😊!";
        }

        private double CelciusToFahrenheit(double _temperature)
        {
            return ((9.0 / 5.0) * _temperature + 32);
        }

    }
}


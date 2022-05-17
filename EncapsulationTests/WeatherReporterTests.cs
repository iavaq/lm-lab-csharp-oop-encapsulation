using NUnit.Framework;
using FluentAssertions;
using Encapsulation.Models;
using System.Collections.Generic;


namespace EncapsulationTests
{
    public class WeatherReporterTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Print_Should_Return_Temperature_In_Fahrenheit()
        {
            string location = "London";
            double temperature = 25;

            WeatherReporter _weatherReporter = new (location, temperature);

            _weatherReporter.Print().Should().Contain("77");
        }

        [Test]
        public void Print_Should_Return_Hot_If_Temperature_Is_Over_30()
        {
            string location = "California";
            double temperature = 31;

            WeatherReporter _weatherReporter = new(location, temperature);

            _weatherReporter.Print().Should().Contain("hot");
        }

        [Test]
        public void Print_Should_Return_Cold_If_Temperature_Is_Less_Than_10()
        {
            string location = "Cape Town";
            double temperature = 8;

            WeatherReporter _weatherReporter = new(location, temperature);

            _weatherReporter.Print().Should().Contain("cold");
        }
    }
}
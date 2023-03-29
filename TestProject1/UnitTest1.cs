using WebApplication2;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var model = new WeatherForecast { TemperatureC = 37 };
            Assert.IsTrue(model.IsValidTemp());
        }
        [Test]
        public void Test2()
        {
            var model = new WeatherForecast { TemperatureC = 36 };
            Assert.IsFalse(model.IsValidTemp());
        }
    }
}
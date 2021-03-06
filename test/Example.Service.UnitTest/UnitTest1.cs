using Example.Service.Services;
using NUnit.Framework;

namespace Example.Service.UnitTest
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
            Assert.Pass();
        }

        [Test]
        public void ShouldReturnAListOfStaticValues()
        {
            var unitUnderTest = new ValuesController();
            var values = unitUnderTest.GetValues();
            Assert.That(values, Is.EqualTo(new [] { "value1", "test001", "Wei001" }));
        }
    }
}
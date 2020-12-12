using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject
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
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.demoqa.com";
            var alora = "test";
            Assert.IsTrue(alora.Contains("12345"));
            driver.Close();
        }
    }
}
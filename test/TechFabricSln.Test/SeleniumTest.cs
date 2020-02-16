using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TechFabricSln.Test
{
    class SeleniumTest
    {
        [Test]
        [Category("UITests")]
        public void VisitMicrosoft_CheckWindowsMenu()
        {
            var service = ChromeDriverService.CreateDefaultService();
            //service.WhitelistedIPAddresses = "";
            service.EnableVerboseLogging = true;
            IWebDriver driver = new ChromeDriver(service);
            driver.Navigate().GoToUrl("https://www.microsoft.com");

            Thread.Sleep(10000);

            string Windows_text = driver.FindElement(By.Id("shellmenu_1")).Text;
            Assert.AreEqual("Windows", Windows_text);

            driver.Quit();
        }
    }
}

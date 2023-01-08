using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace bushraaaa
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            {
                WebDriver driver = new ChromeDriver();
                driver.Url = "https://adactinhotelapp.com/";

                //driver.FindElement(By.Id("username")).SendKeys("AmirTester");
                //var element = driver.FindElement(By.Id("username"));
                //element.SendKeys(Keys.Tab);
                //driver.FindElement(By.Id("login")).Click();
                Thread.Sleep(5000);

                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(@"C:\Users\Bushra Rafiq\source\repos\bushraaaa", ScreenshotImageFormat.Png);
              //  screenshot.SaveAsFile(@".\\Screenshot.png", ScreenshotImageFormat.Png);


                driver.Quit();
            }
        }
    }
}


using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;

namespace MySiteTest
{
    public class Tests
    {
        [Test]
        public void TestCase7()
        {
            WebDriver driver = new ChromeDriver("D:\\webDriver\\msedgedriver.exe");
            driver.Url = "https://litnet.com";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/ul/li[1]/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/ul/li[1]/div/div/div/div[1]/div/a[2]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/a[4]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            driver.Quit();
        }
    }
}
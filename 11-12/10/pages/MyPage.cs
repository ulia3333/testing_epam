using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class MyPage
    {
        private IWebDriver driver;

        public MyPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string xPathGoToHome = "/html/body/div[3]/div/div/div[4]/ul/li[1]/a";


        public MyPage GoToHome()
        {
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[4]/ul/li[1]/a")).Click();
            return new MyPage(driver);
        }

    }
}

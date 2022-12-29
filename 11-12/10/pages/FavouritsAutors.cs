using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class FavouritsAutors
    {
        private IWebDriver driver;

        public FavouritsAutors(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string xPathGoToHome = "/html/body/div[3]/div/div/div[4]/ul/li[1]/a";


        public FavouritsAutors Unsubscrib()
        {
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[2]/div/div[1]/div/div/div/div[2]/a[2]")).Click();
            return new FavouritsAutors(driver);
        }

    }
}

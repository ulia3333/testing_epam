using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class SearchResalts
    {
        private IWebDriver driver;

        public SearchResalts(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string xPathChooseSubgenre = "/html/body/div[3]/div/div/div[1]/a[4]";


        public SearchResalts Authorr()
        {
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div/div[2]/a")).Click();
            return new SearchResalts(driver);
        }

    }
}

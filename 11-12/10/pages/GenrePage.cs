using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.pages
{
    public class GenrePage
    {
        private IWebDriver driver;

        public GenrePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //public IWebElement OpenBooksSection => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/ul/li[1]/a"));


        public GenrePage ChooseSubgenre()
        {
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/a[4]")).Click();
            return new GenrePage(driver);
        }

    }
}

using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class GenrePage
    {
        private IWebDriver driver;

        public GenrePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string xPathChooseSubgenre = "/html/body/div[3]/div/div/div[1]/a[4]";


        public GenrePage ChooseSubgenre()
        {
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/a[4]")).Click();
            return new GenrePage(driver);
        }

    }
}

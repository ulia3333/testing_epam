using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10
{
    public class AuthorPage
    {
        private IWebDriver driver;

        public AuthorPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        public AuthorPage TrackAuthor()
        {
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/form/div/button")).Click();
            return new AuthorPage(driver);
        } 
       
    }
}

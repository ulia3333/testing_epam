using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class AuthorPage
    {
        private IWebDriver driver;

        public AuthorPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string xPathTrackAuthor = "/html/body/div[3]/div/div/div[1]/form/div/button";
      

        public AuthorPage TrackAuthor()
        {
            driver.FindElement(By.XPath(xPathTrackAuthor)).Click();
            return new AuthorPage(driver);
        }

    }
}

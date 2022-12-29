using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private string xPathOpenBooksSection;
        private string xPathChooseGenre = "/html/body/div[2]/div/div/div[1]/ul/li[1]/div/div/div/div[1]/div/a[2]";
        private string xPathSelectMyLibrarySection = "/html/body/div[2]/div/div/div[1]/ul/li[4]/a";
        private string xPathSelectMyLibrarySectionn = "/html/body/div[2]/div/div/div[2]/div[2]/a/img";
        private string xPathLoginButton = "/html/body/div[2]/div/div/div[2]/div[2]/a[1]";
        private string xPathLogInByPhone = "/html/body/div[2]/div/div/div[2]/div[2]/a[1]";


        public HomePage OpenBooksSection()
        {
            xPathOpenBooksSection = "/html/body/div[2]/div/div/div[1]/ul/li[1]/a";
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/ul/li[1]/a")).Click();
            return new HomePage(driver);
        }

        public HomePage ChooseGenre()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/ul/li[1]/div/div/div/div[1]/div/a[2]")).Click();
            return new HomePage(driver);
        }
        public HomePage SelectMyLibrarySection()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/ul/li[4]/a")).Click();
            return new HomePage(driver);
        }
        public HomePage SelectMyLibrarySectionn()
        {
            driver.FindElement(By.XPath("xPathSelectMyLibrarySectionn")).Click();
            return new HomePage(driver);
        }
        public HomePage LoginButton()
        {
            driver.FindElement(By.XPath("xPathLoginButton")).Click();

            return new HomePage(driver);
        }

        public HomePage LogInByPhone()
        {
            driver.FindElement(By.XPath("xPathLogInByPhone")).Click();

            return new HomePage(driver);
        }
  
        public HomePage IconMyAvatar()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/a/img")).Click();

            return new HomePage(driver);
        }
        public HomePage AuthorSearch()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/form/input")).SendKeys("Алисия Эванс");
            return new HomePage(driver);
        }
        public HomePage ButtonSearch()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/form/i")).Click();
            return new HomePage(driver);
        }

    }
}

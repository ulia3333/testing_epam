using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public HomePage OpenBooksSection()
        {
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
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/a/img")).Click();
            return new HomePage(driver);
        }
       
        
        public HomePage LoginButton()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/a[1]")).Click();
           
            return new HomePage(driver);
        }
        
        public HomePage LogInByPhone()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/a[1]")).Click();
           
            return new HomePage(driver);
        }
    }
}

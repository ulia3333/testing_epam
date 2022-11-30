using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10
{
    internal class AuthorizationPage
    {
        private IWebDriver driver;

        public AuthorizationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public AuthorizationPage LogInPhone()
        {
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/form/div[1]/input")).SendKeys("+375447760346");
            return new AuthorizationPage(driver);
        } 
        public AuthorizationPage LogInPasword()
        {
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/form/div[2]/input")).SendKeys("6378383");
            return new AuthorizationPage(driver);
        } 
        public AuthorizationPage LogIn()
        {
         
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/form/button")).Click();

            return new AuthorizationPage(driver);
        }
    }
}

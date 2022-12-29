using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    internal class AuthorizationPage
    {
        private IWebDriver driver;

        public AuthorizationPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        private const string TARGET_URL = "https://www.litres.ru/";

        private string xPathLogInPhone = "/html/body/div[3]/div/div/div[1]/form/div[1]/input"; // кнопка войти
        private string xPathLogInPasword = "/html/body/div[3]/div/div/div[1]/form/div[2]/input"; // кнопка email
        private string xPathLogInButn = "/html/body/div[3]/div/div/div[1]/form/button"; // поле для ввода email
       


        public AuthorizationPage LogInPhone()
        {
            driver.FindElement(By.XPath(xPathLogInPhone)).SendKeys("+375447760346");
            return new AuthorizationPage(driver);
        }
        public AuthorizationPage LogInPasword()
        {
            driver.FindElement(By.XPath(xPathLogInPasword)).SendKeys("6378383");
            return new AuthorizationPage(driver);
        }
        public AuthorizationPage LogInButn()
        {
            driver.FindElement(By.XPath(xPathLogInButn)).Click();
            return new AuthorizationPage(driver);
        }
        
    }
}

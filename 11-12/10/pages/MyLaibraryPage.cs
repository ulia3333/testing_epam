using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10.Pages
{
    public class MyLaibraryPage
    {
        private IWebDriver driver;

        public MyLaibraryPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string xPathChooseAuthorChooseAuthor = "/html/body/div[3]/div/div/div[2]/div[6]/div/div[2]/p[1]/a";

        public MyLaibraryPage ChooseAuthor()
        {       
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[2]/div[6]/div/div[2]/p[1]/a")).Click();
            return new MyLaibraryPage(driver);
        }
        public MyLaibraryPage FavouritAuthor()
        {      
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[3]/ul[1]/li[5]/a")).Click();
            return new MyLaibraryPage(driver);
        }
        

    }
}

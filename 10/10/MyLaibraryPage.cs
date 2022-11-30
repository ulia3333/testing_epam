using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace _10
{
    public class MyLaibraryPage
    {
        private IWebDriver driver;

        public MyLaibraryPage(IWebDriver driver)
        {
            this.driver = driver;
        }

       public MyLaibraryPage ChooseAuthor()
        {
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[2]/div[6]/div/div[2]/p[1]/a")).Click();
            return new MyLaibraryPage(driver);
        } 
       
    }
}

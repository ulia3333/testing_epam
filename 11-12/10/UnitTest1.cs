using Docker.DotNet.Models;
using java.sql;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;

namespace _10
{
    public class Tests
    {
        private IWebDriver GetEdgeDriver()
        {
            return new EdgeDriver(driverPath, new EdgeOptions());
        }
        private IWebDriver driver { get; set; } = null!;
        private string driverPath { get; set; } = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";

        [SetUp]
        public void Setup()
        {

            driver = GetEdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://litnet.com/auth/login?classic=1&link=https%3A%2F%2Flitnet.com%2F");
            
            var AuthorizationPage = new AuthorizationPage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            AuthorizationPage.LogInPhone();
            AuthorizationPage.LogInPasword();
            AuthorizationPage.LogIn();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(70);
            var MyPage = new MyPage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            MyPage.GoToHome();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void ViewingBooksOfCertainGenreOfSelectedSubgenre()
        {
            var HomePage = new HomePage(driver);
            HomePage.OpenBooksSection();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            HomePage.ChooseGenre();
            var GenrePage = new GenrePage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            GenrePage.ChooseSubgenre();
            //Assert.Pass();
        }

        [Test]
        public void SubscribeToTheAuthorOfTheSelectedBook()
        {
            var HomePage = new HomePage(driver);
            HomePage.SelectMyLibrarySection();
            var MyLaibraryPage = new MyLaibraryPage(driver);
            MyLaibraryPage.ChooseAuthor();
            var AuthorPage = new AuthorPage(driver);
            AuthorPage.TrackAuthor();

            //Assert.Pass();
        }

    }
}
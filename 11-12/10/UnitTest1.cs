using Docker.DotNet.Models;
using java.sql;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using _10.Steps;

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
            var steps = new Steps.Steps(driver);
            steps.Autorisation();
            steps.MySite();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        ////test7
        [Test]
        public void ViewingBooksOfCertainGenreOfSelectedSubgenre()
        {
            var steps = new Steps.Steps(driver);
            steps.Wait();
            steps.SectionBook();
            steps.Wait();
            steps.ChooseGenre();
            steps.Wait();
            steps.ChooseSubgenre();
        }
        //test3
        [Test]
        public void SubscribeToTheAuthorOfTheSelectedBook()
        {
            var steps = new Steps.Steps(driver);
            steps.MyLibrorary();
            steps.AuthorName();
            steps.Sibscribe();
        }
        //test4
        [Test]
        public void UnsubscribeFromTheAuthor()
        {
            var steps = new Steps.Steps(driver);
            steps.MyLibrorary();
            steps.MyAvatar();
            steps.ChooseFavouritAuthor();
            steps.Unsubscribe();
        }

        //test5
        [Test]
        public void ViewingThePageOfTheSelectedAuthor()
        {
            var steps = new Steps.Steps(driver);
            steps.SearchAuthor();
            steps.GoToAuthorPage();
            
        }

    }
}
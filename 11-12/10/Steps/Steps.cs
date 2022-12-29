using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using _10.Driver;
using _10.Pages;
using _10.Service;

namespace _10.Steps
{
    public class Steps
    {

        private IWebDriver driver;

        public Steps(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Autorisation()
        {
            var AuthorizationPage = new Pages.AuthorizationPage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            AuthorizationPage.LogInPhone();
            AuthorizationPage.LogInPasword();
            AuthorizationPage.LogInButn();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(70);

        }
        public void MySite()
        {
            var MyPage = new Pages.MyPage(driver);
            MyPage.GoToHome();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(70);

        }

        public void SectionBook()
        {
            var HomePage = new Pages.HomePage(driver);
            HomePage.OpenBooksSection();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(70);

        }

        public void ChooseGenre()
        {            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(70);
            var HomePage = new Pages.HomePage(driver);
            HomePage.ChooseGenre();
        }
        public void ChooseSubgenre()
        {
            var GenrePage = new Pages.GenrePage(driver);
            GenrePage.ChooseSubgenre(); 
        }
        public void MyLibrorary()
        {
           var HomePage=new Pages.HomePage(driver);
           HomePage.SelectMyLibrarySection();
        }
        public void AuthorName()
        {
           var MyLaibraryPage = new Pages.MyLaibraryPage(driver);
            MyLaibraryPage.ChooseAuthor();
        }
        public void Sibscribe()
        {
           var AuthorPage = new Pages.AuthorPage(driver);
            AuthorPage.TrackAuthor();
        }
        public void Wait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
        }

        public void MyAvatar()
        {
            var HomePage = new Pages.HomePage(driver);
            HomePage.IconMyAvatar();
        }
        
        public void ChooseFavouritAuthor()
        {
           var MyLaibraryPage = new Pages.MyLaibraryPage(driver);
            MyLaibraryPage.FavouritAuthor();
        }
        public void Unsubscribe()
        {
           var FavouritsAutors = new Pages.FavouritsAutors(driver);
            FavouritsAutors.Unsubscrib();
        }

        public void SearchAuthor()
        {
            var HomePage = new Pages.HomePage(driver);
            HomePage.AuthorSearch();
            HomePage.ButtonSearch();
        }

        public void GoToAuthorPage()
        {
            var SearchResalts = new Pages.SearchResalts(driver);
            SearchResalts.Authorr();
        }
    }
}

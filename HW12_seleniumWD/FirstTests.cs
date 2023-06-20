using System;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW12_seleniumWD
{
    public class FirstTests
    {
        private WebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        
        [Test]
        public void OpenWindow()
        {
            //var
            var expectedUrl = "http://the-internet.herokuapp.com/add_remove_elements/";
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();
            
            //Act+Assert
            Assert.AreEqual(expectedUrl, driver.Url);
            for(int i = 0; i < 2; i++)
                driver.FindElement(By.XPath("//button[text()='Add Element']")).Click();
         
            int countButton = driver.FindElements(By.XPath("//button[text()='Delete']")).Count;
            Assert.AreEqual(2,countButton);
            
            Thread.Sleep(1000);
            
            driver.FindElement(By.XPath("//button[text()='Delete']")).Click();
            countButton = driver.FindElements(By.XPath("//button[text()='Delete']")).Count;
            Assert.AreEqual(1,countButton);
            
            Thread.Sleep(1000); 
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
        
    }  
}
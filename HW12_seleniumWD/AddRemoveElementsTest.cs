using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace HW12_seleniumWD
{
    internal class AddRemoveElementsTest: BaseTest
    {
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
            
            Thread.Sleep(1000); //для наглядности
            
            driver.FindElement(By.XPath("//button[text()='Delete']")).Click();
            countButton = driver.FindElements(By.XPath("//button[text()='Delete']")).Count;
            Assert.AreEqual(1,countButton);
            
            Thread.Sleep(1000); //для наглядности
        } 
    }
}
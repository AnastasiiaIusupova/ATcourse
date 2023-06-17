using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Interactions;


namespace HW12_seleniumWD
{
    public class HoversTest: BaseTest
    {
        [Test]
        public void HoverTest()
        {
            //var
            var expectedUrl = "http://the-internet.herokuapp.com/hovers";
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.FindElement(By.LinkText("Hovers")).Click();
            
            //Act+Assert
            Assert.AreEqual(expectedUrl, driver.Url);
            
            List<IWebElement> images = driver.FindElements(By.TagName("img")).ToList();
            Assert.IsNotNull(images);
            
            List<IWebElement> profiles = driver.FindElements(By.LinkText("View profile")).ToList();
            Assert.IsNotNull(profiles);
            
            Actions actions = new Actions(driver);

            for (int i = 0; i < images.Count; i++)
            {
                actions.MoveToElement(images[i]).Perform();
                Thread.Sleep(1000);
                profiles[i].Click();

            }
        }
    }
}
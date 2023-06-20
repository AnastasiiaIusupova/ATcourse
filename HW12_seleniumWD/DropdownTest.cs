using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HW12_seleniumWD
{
    public class DropdownTest: BaseTest
    {
        [Test]
        public void Dropdown()
        {
            //var
            var expectedUrl = "http://the-internet.herokuapp.com/dropdown";
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.FindElement(By.LinkText("Dropdown")).Click();
            
            //Act+Assert
            Assert.AreEqual(expectedUrl, driver.Url);

            driver.FindElement(By.Id("dropdown")).Click();
            SelectElement select = new SelectElement(driver.FindElement(By.Id("dropdown")));
       
            List<IWebElement> dropdownOptions = driver.FindElements(By.TagName("option")).ToList();
            Assert.IsNotNull(dropdownOptions);
            
            SetDropdownState(dropdownOptions[1], false);
            SetDropdownState(dropdownOptions[1], true);
            Thread.Sleep(1000);//для наглядности
            
            SetDropdownState(dropdownOptions[2], false);
            SetDropdownState(dropdownOptions[2], true);
            Thread.Sleep(2000);//для наглядности
        }
        public void SetDropdownState( IWebElement element, bool flag)
        {
            var selected = element.Selected;
            bool.TryParse(element.GetAttribute("selected"), out bool selectedByAttribute);

            if ((selected || selectedByAttribute) != flag)
            {
                element.Click();
            }
        }
    }
}
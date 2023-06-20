using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace HW12_seleniumWD
{
    public class CheckboxesTest  : BaseTest
    {
        [Test]
        public void CheckBoxes()
        {
            //var
            var expectedUrl = "http://the-internet.herokuapp.com/checkboxes";
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.FindElement(By.LinkText("Checkboxes")).Click();
            Thread.Sleep(1000);
            
            //Act+Assert
            Assert.AreEqual(expectedUrl, driver.Url);

            List<IWebElement> checkboxes = driver.FindElements(By.CssSelector("input[type = 'checkbox']")).ToList();
            Assert.IsNotNull(checkboxes);
            var checkboxOne = checkboxes[0];
            var checkboxTwo = checkboxes[1];
            
            SetCheckBoxState(checkboxOne, false);
            SetCheckBoxState(checkboxOne, true);
            SetCheckBoxState(checkboxOne, true);
            Thread.Sleep(1000);//для наглядности
            SetCheckBoxState(checkboxTwo, true);
            SetCheckBoxState(checkboxTwo, false);
            SetCheckBoxState(checkboxTwo, false);
            Thread.Sleep(1000);//для наглядности
        }

        public void SetCheckBoxState( IWebElement element, bool flag)
        {
            var selected = element.Selected;
            bool.TryParse(element.GetAttribute("checked"), out bool selectedByAttribute);

            if ((selected || selectedByAttribute) != flag)
            {
                element.Click();
            }
        }
    }
}
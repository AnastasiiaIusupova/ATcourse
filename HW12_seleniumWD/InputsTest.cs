using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace HW12_seleniumWD
{
    public class InputsTest: BaseTest
    {
        [Test]
        public void InputNumber()
        {
            //var
            var expectedUrl = "http://the-internet.herokuapp.com/inputs";
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.FindElement(By.LinkText("Inputs")).Click();
            
            //Act+Assert
            Assert.AreEqual(expectedUrl, driver.Url);

            var inputElement = driver.FindElement(By.TagName("input"));
            var text1 = "123456789";
            inputElement.SendKeys(text1);
            var text2 = inputElement.GetAttribute("value");
            
            Assert.AreEqual(text2, text1);
            
            Thread.Sleep(1000);//для наглядности
            inputElement.SendKeys(Keys.ArrowUp);
            Thread.Sleep(1000);//для наглядности
            inputElement.SendKeys(Keys.ArrowDown);
            Assert.AreEqual(text2, text1);
            
            inputElement.Clear();
            
            Thread.Sleep(1000);//для наглядности
            inputElement.SendKeys("asdfg%@");
            Assert.IsEmpty(inputElement.GetAttribute("value"));
            Thread.Sleep(1000);//для наглядности
        }
    }
}
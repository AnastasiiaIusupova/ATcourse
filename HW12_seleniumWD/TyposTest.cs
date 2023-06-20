using NUnit.Framework;
using OpenQA.Selenium;

namespace HW12_seleniumWD
{
    public class TyposTest: BaseTest
    {
        [Test]
        public void Typos()
        {
            //var
            var expectedUrl = "http://the-internet.herokuapp.com/typos";
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.FindElement(By.LinkText("Typos")).Click();

            string string1 = driver.FindElement(By.XPath("//p[1]")).Text;
            string string2 = driver.FindElement(By.XPath("//p[2]")).Text;
            
            //Assert
            Assert.AreEqual("This example demonstrates a typo being introduced. It does it randomly on each page load.", string1);
            Assert.AreEqual("Sometimes you'll see a typo, other times you won`t.", string2);

        }
    }
}
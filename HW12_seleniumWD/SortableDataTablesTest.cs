using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW12_seleniumWD
{
    public class SortableDataTablesTest: BaseTest
    {
        [Test]
        public void TebleTest()
        {
            //var
            var expectedUrl = "http://the-internet.herokuapp.com/tables";
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.FindElement(By.LinkText("Sortable Data Tables")).Click();
            
            //Act+Assert
            Assert.AreEqual(expectedUrl, driver.Url);

            var text1 = "Smith";
            var lastName = driver.FindElement(By.XPath("//table[@id ='table1']/tbody/tr[1]//td[1]")).Text;
            Assert.AreEqual(text1, lastName);
            
            var text2 = "Frank";
            var firstName = driver.FindElement(By.XPath("//table[@id ='table1']/tbody/tr[2]//td[2]")).Text;
            Assert.AreEqual(text2, firstName);
            
            var text3 = "jsmith@gmail.com";
            var email = driver.FindElement(By.XPath("//table[@id ='table2']/tbody/tr[1]//td[3]")).Text;
            Assert.AreEqual(text3, email);
            
            var text4 = "http://www.jsmith.com";
            var webSite = driver.FindElement(By.XPath("//table[@id ='table2']/tbody/tr[1]//td[5]")).Text;
            Assert.AreEqual(text4, webSite);
            
        }
    }
}
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitParam
{
    public class EngageLogin : Hooks
    {


        [Test]
        public void LoginCheck()
        {
            Driver.Navigate().GoToUrl("http://loaduser1:Vanadium2200@beacon-test/sorce/");
            System.Threading.Thread.Sleep(10000);
            TimeSpan pageloadwait = TimeSpan.FromSeconds(30.00);
            Driver.Manage().Timeouts().ImplicitlyWait(pageloadwait);
            string title = Driver.Title;
            Assert.AreEqual("Homepage", title, "Page Title");
            Driver.Close();
        }
        [Test]
        public void LoginCheck2()
        {
            Driver.Navigate().GoToUrl("http://Sorce%5CSynverse%2ETes:st%3A9874%40s@beacon-test/sorce/beacon/");
            System.Threading.Thread.Sleep(5000);
            TimeSpan pageloadwait = TimeSpan.FromSeconds(30.00);
            Driver.Manage().Timeouts().ImplicitlyWait(pageloadwait);
            string title = Driver.Title;
            Assert.AreEqual("Homepage", title, "Page Title");
            System.Threading.Thread.Sleep(3000);
            Driver.Close();
        }


    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitParam
{
    public class BuildStatus : Hooks
    {
        [Test]
        public void LoginCheck()
        {  
            TimeSpan pageloadwait = TimeSpan.FromSeconds(30.00);
            string date = DateTime.Now.AddDays(-1).ToString("yyyyMMdd", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            Driver.Navigate().GoToUrl("http://Synverse%2ETest3:st%3A9872%40s@sorce-tfsbunker:8080/tfs/DefaultCollection/Beacon/Beacon%20Team/_build#definitionUri=&_a=completed");
            System.Threading.Thread.Sleep(10000);
            Driver.Manage().Timeouts().ImplicitlyWait(pageloadwait);
            string BuildStatus = Driver.FindElement(By.XPath("(//*[contains(text(),'Engage Nightly_" + date + "')])/preceding-sibling::div[1]")).GetAttribute("title");
            Assert.AreEqual("Succeeded", BuildStatus, "BuildStatus");
            Driver.Close();
        }

    }
}

 using Coypu;
using Coypu.Drivers;
using Google.WebDrivers;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Google.Tests
{
    public class DuploClick : BrowserSessionManager
    {
        private static readonly TimeSpan WaitBeforeClickInSec = TimeSpan.FromSeconds(60);

        private readonly Options _optionsWaitBeforeClick = new Options { WaitBeforeClick = WaitBeforeClickInSec };

        [Test]
        public void Test3()
        {


            Browser.Visit("/text-box");



            Browser.FindId("userName").SendKeys("aaa");
           // Browser.FindId("userEmail").SendKeys("aaa@teste.com");


            var selenium = ((OpenQA.Selenium.Remote.RemoteWebDriver)Browser.Native);

            selenium.FindElementById("userEmail").SendKeys("aaa@teste.com");

            //Thread.Sleep(5000);
            Browser.ClickButton("submit", _optionsWaitBeforeClick);

            var coy = Browser.FindId("aaaa");
           //coy.Hover 


           


            //var selenium = ((OpenQA.Selenium.Remote.RemoteWebDriver)Browser.Native);

            //var elemetoX = selenium.FindElementByXPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/div[1]/button");

            //var sel = ((OpenQA.Selenium.IWebDriver)Browser.Native);

            //new Actions(sel).MoveToElement(elemetoX).DoubleClick().Perform();

        }

    }
}
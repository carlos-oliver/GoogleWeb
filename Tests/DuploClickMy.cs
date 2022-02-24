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
    public class DuploClickMy : BrowserSessionManager
    {
        private static readonly TimeSpan WaitBeforeClickInSec = TimeSpan.FromSeconds(60);

        private readonly Options _optionsWaitBeforeClick = new Options { WaitBeforeClick = WaitBeforeClickInSec };

        [Test]
        public void Test3()
        {


            Browser.Visit("/buttons");

            //var dblButton = Browser.FindXPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/div[1]/button");

            //dblButton.DblCliCK();


        }

    }
}
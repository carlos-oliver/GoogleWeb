using Coypu;
using Coypu.Drivers;
using Google.WebDrivers;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Tests
{
    public class ExempleDataTable : BrowserSessionManager
    {

        [Test]
        public void Test2()
        {
            Browser.Visit("https://automacaocombatista.herokuapp.com/users");

            var table = Browser.FindCss("body > div.row > div > table");

            var css = table.FindAllCss("tr");

            ///List<SnapshotElementScope> teste;
            ///
            bool texto = false;
            foreach (var tr in css)
            {


                var tds = tr.FindAllCss("td");

                for (int i = 0; i < tds.Count(); i ++) 
                {
                    var teste = tds.ToList();

                    texto = teste[i].Text.Contains("aaaaaa");
                    if (texto)
                    {
                        teste[i + 9].Click();
                    }
                    break;
                }

                if (texto)
                {
                    break;
                }

            }

            var selenium = ((OpenQA.Selenium.Remote.RemoteWebDriver)Browser.Native);

            //var elemetoX = selenium.FindElementById("noticsse");

            //var sel = ((OpenQA.Selenium.IWebDriver)Browser);

            //new Actions(sel).DoubleClick(elemetoX);

        }

    }
}
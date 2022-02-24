using Coypu;
using NUnit.Framework;
using System;

namespace Google.WebDrivers
{
    public class BrowserSessionManager
    {

        protected BrowserSession Browser;

        [SetUp]
        public void BrowserSession()
        {
            var sessionConfigurationForChromeHeadless = new SessionConfiguration()
            {
                Driver = typeof(CustomChromeHeadlessWebDriver),
                Browser = Coypu.Drivers.Browser.Chrome,
                AppHost = "https://demoqa.com", // whatever url you want
                Timeout = TimeSpan.FromSeconds(10),
                ConsiderInvisibleElements = true
            };
            Browser = new BrowserSession(sessionConfigurationForChromeHeadless);
            Browser.ResizeTo(1124, 850);

        }

        [TearDown]
        public void CloseBrowser()
        {
            Browser.Dispose();
         }

    }
}

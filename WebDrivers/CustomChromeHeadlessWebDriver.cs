using Coypu.Drivers;
using Coypu.Drivers.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Google.WebDrivers
{
    public class CustomChromeHeadlessWebDriver : SeleniumWebDriver
    {

        public CustomChromeHeadlessWebDriver(Browser browser) : base(CustomProfile(), browser)
        {
        }

        private static IWebDriver CustomProfile()
        {
            //String driverPath = "/opt/selenium/";

            //String driverExecutableFileName = "chromedriver";

            String driverPath = "C:\\Driver\\ChromeDriver";

            String driverExecutableFileName = "chromedriver.exe";

            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--headless");
            chromeOptions.AddArguments("--disable-gpu");
            chromeOptions.AddArguments("--disable-extensions");
            chromeOptions.AddArguments("no-sandbox");
            //chromeOptions.BinaryLocation = "/opt/google/chrome/chrome";

            ChromeDriverService service = ChromeDriverService.CreateDefaultService(driverPath, driverExecutableFileName);

            return new ChromeDriver(service, chromeOptions);
        }

    }
}

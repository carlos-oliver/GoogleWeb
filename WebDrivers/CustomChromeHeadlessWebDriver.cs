using Coypu.Drivers;
using Coypu.Drivers.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Google.WebDrivers
{
    public class CustomChromeHeadlessWebDriver : SeleniumWebDriver
    {

        public CustomChromeHeadlessWebDriver(Browser browser) : base(CustomProfile(), browser)
        {
        }

        private static IWebDriver CustomProfile()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--headless");
            chromeOptions.AddArguments("--disable-gpu");
            chromeOptions.AddArguments("--disable-extensions");
            chromeOptions.AddArguments("no-sandbox");

            return new ChromeDriver(chromeOptions);
        }

    }
}

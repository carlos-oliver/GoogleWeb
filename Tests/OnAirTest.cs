using Coypu.Drivers;
using Google.WebDrivers;
using NUnit.Framework;

namespace Google.Tests
{
    public class OnAirTest : BrowserSessionManager
    {

        [Test]
        public void Test1()
        {
              Browser.Visit("/images");
        }

    }
}
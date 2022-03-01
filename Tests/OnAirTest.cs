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
              Browser.Visit("https://www.google.com/imghp");

              Assert.IsTrue(Browser.Title.Contains("Imagens do Google"));
        }

    }
}
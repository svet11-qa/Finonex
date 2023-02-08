using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Finonex.Browser
{
    internal class DriverSettings
    {
        public static WebDriver driver;

        private static List<string> ChromeArguments => new List<string>()
        {
            "-inprivate",
            "--start-maximized",
            "allow-running-insecure-content",
            "test-type",
            "ignore-certificate-errors",
            "disable-extensions",
            "enable-precise-memory-info",
            "--no-sandbox",
        };

        public static WebDriver SetupBrowser(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    var driverService = ChromeDriverService.CreateDefaultService();
                    var chromeOptions = new ChromeOptions();
                    //chromeOptions.AddArgument("--headless");
                    chromeOptions.AddArgument("--lang=en-US");
                    chromeOptions.AddArguments(ChromeArguments);

                    driver = new ChromeDriver(driverService, chromeOptions);
                    break;
            }
            return driver;
        }

        public static void Quit() => driver.Quit();
    }
}

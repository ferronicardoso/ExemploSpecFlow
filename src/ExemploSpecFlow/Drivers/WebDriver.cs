using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;

namespace ExemploSpecFlow.Drivers
{
    public class WebDriver
    {
        private IWebDriver _currentWebDriver;
        private WebDriverWait _wait;

        private const int TIMEOUT = 10;
        private const string SELENIUM_BASE_PATH = @"C:\Selenium";

        public IWebDriver Current
        {
            get
            {
                if (_currentWebDriver == null)
                {
                    _currentWebDriver = GetWebDriver();
                }

                return _currentWebDriver;
            }
        }

        public WebDriverWait Wait
        {
            get
            {
                if (_wait == null)
                {
                    this._wait = new WebDriverWait(Current, TimeSpan.FromSeconds(TIMEOUT));
                }
                return _wait;
            }
        }

        private IWebDriver GetWebDriver()
        {
            IWebDriver _webDriver = null;

            switch (Environment.GetEnvironmentVariable("Test_Browser"))
            {
                case "Chrome":
                    _webDriver = new ChromeDriver($@"{SELENIUM_BASE_PATH}\ChromeDriver");
                    break;
                case "Firefox":
                    _webDriver = new FirefoxDriver($@"{SELENIUM_BASE_PATH}\FirefoxDriver");
                    break;
                case "IE":
                    var options = new InternetExplorerOptions { IgnoreZoomLevel = true };
                    _webDriver = new InternetExplorerDriver($@"{SELENIUM_BASE_PATH}\IEDriverServer", options);
                    break;
                case string browser:
                    throw new NotSupportedException($"{browser} is not a supported browser");
                default:
                    throw new NotSupportedException("not supported browser: <null>");
            }

            return _webDriver;
        }

        public void Quit()
        {
            _currentWebDriver?.Quit();
        }
    }
}

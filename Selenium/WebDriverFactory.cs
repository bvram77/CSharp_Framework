using com.venkat.framework.core;
using com.venkat.framework.selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Remote;
using System;

namespace com.venkat.framework.selenium
{
	public class WebDriverFactory
	{
		private static IProperties Properties;

		public static IWebDriver GetDriver(Browser browser)
		{
			IWebDriver driver = null;
			Properties = ISettings.Instance;
			switch (browser.innerEnumValue)
			{
				case Browser.InnerEnum.Firefox:
					//System.setProperty("IWebDriver.gecko.driver", Properties.Get("FirefoxDriverPath"));
					FirefoxProfile FFProfile = new FirefoxProfile();
					FFProfile.SetPreference("plugin.state.java", 2);
					FirefoxOptions firefoxOptions = new FirefoxOptions();
					driver = new FirefoxDriver(firefoxOptions);
					break;

				case Browser.InnerEnum.Chrome:
					//System.setProperty("IWebDriver.chrome.driver", Properties.Get("ChromeDriverPath"));
					driver = new ChromeDriver(WithChromeOption());
					break;

				case Browser.InnerEnum.Safari:
					driver = new SafariDriver();
					break;

				case Browser.InnerEnum.Mobile:
					break;

				default:
					throw new FrameworkException("Unhandled browser!");
			}
			return driver;
		}


        public static IWebDriver GetDriver(Browser browser, string remoteUrl)
		{
			return GetDriver(browser, null, null, remoteUrl);
		}	


		public static IWebDriver GetDriver(Browser browser, string browserVersion, Platform platform, string remoteUrl)
		{
			Properties = ISettings.Instance;
			Uri url = null;
			ICapabilities desiredCapabilities; //= new ReadOnlyDesiredCapabilities();

			if (browser.Equals(Browser.InnerEnum.Chrome))
            {
				desiredCapabilities.mertg

			}


			return null;

		}

		private static ChromeOptions WithChromeOption()
        {
			ChromeOptions Option = new ChromeOptions();
			Option.AddArgument("--start-maximized");
			Option.AddArgument("test-type");
			return Option;
        }
	}

}
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumConceptUnitTestProject
{
    public class Demo6
    {
        [Test]
        public void Demo6JS()
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("--disable-notifications");

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.malaysiaairlines.com/us/en/home.html";

            driver.FindElement(By.XPath("//span[text()='Accept all cookies']")).Click();

            //approach 1 - not working
            //driver.FindElement(By.XPath("//input[@name='dateDeparture']")).SendKeys("01 Oct 2024");

            //approach 2 - automate the date calendar

            //approach 3- javascript
            driver.ExecuteJavaScript("document.querySelector(\"input[name='dateDeparture']\").value='01 Oct 2024'");

            driver.ExecuteJavaScript("document.querySelector(\"input[name='dateReturn']\").value='11 Oct 2024'");
        }
    }
}

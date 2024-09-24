using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SeleniumConceptUnitTestProject
{
    public class Demo3FramTest
    {
        [Test]
        public void HdfcFrameTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));


            //enter userid as john123
            driver.FindElement(By.XPath("//input[@name='fldLoginUserId']")).SendKeys("Joh123");
            //Click on continue
            driver.FindElement(By.LinkText("CONTINUE")).Click();
            //Switch to main Html
            // driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame(driver.FindElement(By.LinkText("container")));           



        }
    }
}

﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConceptUnitTestProject
{
    public class Demo2Test
    {
        [Test]
        public void AlertTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";


            //to inspect--> f12 or ctrl+shift+c

            //click on Go
            //driver.FindElement(By.LinkText("text")).SendKeys("12345");
            driver.FindElement(By.XPath("//img[@alt='Go']")).Click();
            String ActualAlertText= driver.SwitchTo().Alert().Text;
            Console.WriteLine(ActualAlertText);
            driver.SwitchTo().Alert().Accept();

        }
    }
}

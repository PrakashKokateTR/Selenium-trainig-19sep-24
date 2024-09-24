using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConceptUnitTestProject
{
    public class Demo1SeleniumAdvance
    {
        [Test]
        public void Demo1MultipleTabsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.db4free.net/";

            //click on phpMyAdmin »
            //xpath-//b[contains(text(),'phpMyAdmin')]
            driver.FindElement(By.PartialLinkText("phpMyAdmin »")).Click();
            // Console.WriteLine(driver.WindowHandles[0]);
            //Console.WriteLine(driver.WindowHandles[0]);
            //Switch to 2nd tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.Id("input_username")).SendKeys("Admin");
            //enter password as admin123
            driver.FindElement(By.Id("input_password")).SendKeys("admin");
            driver.FindElement(By.Id("Log in")).Click();

            driver.Close();//current tab is close
            //switch to 1st window
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Console.WriteLine(driver.Title);
            driver.Quit();
        }
        [Test]
        public void Demo2TabsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.online.citibank.co.in/";

            //close all popup
            driver.FindElement(By.ClassName("newclose")).Click();
            driver.FindElement(By.ClassName("newclose2")).Click();
            //click on Banking
            driver.FindElement(By.Id("topMnubanking")).Click();
            //click on Citi Commercial Bank

            driver.FindElement(By.LinkText("Citi Commercial Bank")).Click();
            //Switch to 2de window
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            //click on Branch/ATM
            driver.FindElement(By.LinkText("Branch/ATM")).Click();
            //Select Citibank ATM as Bengaluru 
            driver.FindElement(By.XPath("//a[text='sbSelector']")).Click();
            driver.FindElement(By.LinkText("Bengaluru")).Click();

        }
    }
    }

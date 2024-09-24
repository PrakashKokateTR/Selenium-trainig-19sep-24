using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace SeleniumConceptUnitTestProject
{
     public class Demo4SeleniumAdavance
    {
        [Test]
        public void ValidDocUploadTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.ilovepdf.com/pdf_to_word";
            //Upload file
            driver.FindElement(By.XPath("//input[type='file']")).SendKeys(@"C:\\Users\\6124621\\OneDrive - Thomson Reuters Incorporated\\Documents\\word file.pdf\");
        }

        [Test]
        public void Demo3ActionsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://futureskillsprime.in/";


            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//span[text()='Explore']"))).Perform();

            //mouse over on FutureSkills Prime

            driver.FindElement(By.XPath("//a[text()='About Us']")).Click();

            Actions actions1 = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//span[text()='Explore']"))).Perform();
            driver.FindElement(By.XPath("//a[text()='About Us']")).Click();

        }
    }

}

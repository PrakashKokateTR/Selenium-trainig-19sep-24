
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo1
{
    public class Seleniumdemo1
    {
        IWebDriver driver = new cromedriver();
        Driver.Url= "https://www.facebook.com/";
        selectElement Selectyear = new selectElement(Driver.FindElement(By.Id("year")));
        Selectyear.SelectByText("1992");

    }
}

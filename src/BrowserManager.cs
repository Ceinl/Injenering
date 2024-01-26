
using Microsoft.VisualBasic.FileIO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

public static class BrowserManager {



    public static IWebDriver MyDriver = new ChromeDriver();




    /// <summary>
    /// Method to implement a diferent browser option, for usage. 
    /// </summary>
    public static IWebDriver BrowserPicker(string option) {
        if (option.ToLower() == "chrome")
        {
            return new ChromeDriver();
        }
        else if (option.ToLower() == "edge")
        {
            return new EdgeDriver();
        }
        else { return new ChromeDriver(); }
    }

    /// <summary>
    /// Method to implement ability to send text to website text fields.
    /// </summary>
    public static void BrowserWriter(string elementName, string elementype, string text) 
    {
        IWebElement webElement = setField(elementype, elementName);
        webElement.SendKeys(text);
        webElement.SendKeys(Keys.Enter);
    }

    /// <summary>
    /// Method to implement ability to click on elements in website.
    /// </summary>
    public static void BrowserClicker(string elementName, string elementype) 
    {
        IWebElement webElement = setField(elementype, elementName);
        webElement.Click();
    }

    /// <summary>
    /// Method to implement ability to navigete in internet.
    /// </summary>
    public static void BrowserNavigator(string url) 
    {
        if (MyDriver != null)
        {
            MyDriver.Navigate().GoToUrl(url);
        }
    }

    /// <summary>
    /// Method to implement finding element on webPage
    /// </summary>
    private static IWebElement setField(string option, string elementName)
    {
        if (option.ToLower() == "id")
        {
            return MyDriver.FindElement(By.Id(elementName));
        }
        else if (option.ToLower() == "name")
        {
            return MyDriver.FindElement(By.Name(elementName));
        }
        else if (option.ToLower() == "class")
        {
            return MyDriver.FindElement(By.ClassName(elementName));
        }
        else
        {
            return null;
        }

    }

}
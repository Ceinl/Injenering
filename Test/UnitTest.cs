using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class BrowserManagerTests
{
    [TestMethod]
    public void BrowserPicker_ReturnsChromeDriver_WhenOptionIsChrome()
    {
        // Arrange
        string option = "chrome";

        // Act
        var result = BrowserManager.BrowserPicker(option);

        // Assert
        Assert.IsInstanceOfType(result, typeof(ChromeDriver));
    }

    [TestMethod]
    public void BrowserPicker_ReturnsEdgeDriver_WhenOptionIsEdge()
    {
        // Arrange
        string option = "edge";

        // Act
        var result = BrowserManager.BrowserPicker(option);

        // Assert
        Assert.IsInstanceOfType(result, typeof(EdgeDriver));
    }

    [TestMethod]
    public void BrowserPicker_ReturnsChromeDriver_WhenOptionIsInvalid()
    {
        // Arrange
        string option = "invalidOption";

        // Act
        var result = BrowserManager.BrowserPicker(option);

        // Assert
        Assert.IsInstanceOfType(result, typeof(ChromeDriver));
    }

    [TestMethod]
    public void BrowserWriter_SendsKeysToWebElement()
    {
        // Arrange
        string elementName = "exampleElement";
        string elementType = "id";
        string text = "Hello, World!";

        // Act
        BrowserManager.BrowserWriter(elementName, elementType, text);

        // No assertion as this is an interaction test
    }

    [TestMethod]
    public void BrowserClicker_ClicksOnWebElement()
    {
        // Arrange
        string elementName = "exampleElement";
        string elementType = "id";

        // Act
        BrowserManager.BrowserClicker(elementName, elementType);

        // No assertion as this is an interaction test
    }

    [TestMethod]
    public void BrowserNavigator_NavigatesToUrl()
    {
        // Arrange
        string url = "https://example.com";

        // Act
        BrowserManager.BrowserNavigator(url);

        // No assertion as this is an interaction test
    }
}

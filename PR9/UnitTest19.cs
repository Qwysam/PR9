using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;

namespace PR9;

 
[TestFixture]
public class nUnitClass19
{
    public IWebDriver driver;
    [SetUp]
    public void SetUp()
    {
        var options = new ChromeOptions();
        options.AddArguments
        (
        "--start-maximized",
        "--disable-extensions",
        "--disable-notifications",
        "--disable-application-cache"
        );
        driver = new ChromeDriver(options);
        driver.Navigate().GoToUrl("https://www.saucedemo.com");
    }

    public void loginTest()
    {
        var Username = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div/div/form/div[1]/input"));
        Username.Click();
        Username.SendKeys("standard_user");
        Thread.Sleep(1000);
        var Password = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div/div/form/div[2]/input"));
        Password.Click();
        Password.SendKeys("secret_sauce");
        Thread.Sleep(1000);
        var ButtonSign = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div/div/form/input"));
        ButtonSign.Click();
    }

    public void addToCartTest()
    {
        var ButtonCart = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div/div/div[1]/div[2]/div[2]/button"));
        ButtonCart.Click();
    }


    public void removeFromCartTest()
    {
        var ButtonCart = driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[3]/a"));
        ButtonCart.Click();
        Thread.Sleep(1000);
        var ButtonRemove = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[1]/div[3]/div[2]/div[2]/button"));
        ButtonRemove.Click();
    }


    public void logOutTest()
    {
        var ButtonOptions = driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[1]/div/div[1]/div/button"));
        ButtonOptions.Click();
        Thread.Sleep(1000);
        var ButtonLogOut = driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[1]/div/div[2]/div[1]/nav/a[3]"));
        ButtonLogOut.Click();
    }

    [Test]
    public void fullTest()
    {
        loginTest();
        Thread.Sleep(1000);
        addToCartTest();
        Thread.Sleep(1000);
        removeFromCartTest();
        Thread.Sleep(1000);
        logOutTest();
    }

    [TearDown]
    public void ThearDown()
    {
    }
} 

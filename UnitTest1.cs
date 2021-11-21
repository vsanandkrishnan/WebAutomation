using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebAutomation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://classic.crmpro.com/index.html");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);


            driver.FindElement(By.Name("username")).SendKeys("batchautomation");
            driver.FindElement(By.Name("password")).SendKeys("Test@12345");
            driver.FindElement(By.CssSelector("div.input-group-btn input")).Click();

            var iframe=driver.FindElement(By.XPath("//frame[@name='mainpanel']"));
            driver.SwitchTo().Frame(iframe);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement element = wait.Until(e => e.FindElement(By.XPath("//a[contains(@href,'action=home')]")));
            Assert.IsTrue(element.Displayed, "The user didn't logged in");



            driver.Close();

     
        }
    }
}

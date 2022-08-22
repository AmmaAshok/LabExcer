using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;

using OpenQA.Selenium.Support.UI;

namespace LabExcer
{
    [TestClass]
    public class SeleniumCommandsTest
    {
      /*  [TestMethod]
        public void TestMethod()
        {
            IWebDriver driver =new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/buttons");
            Thread.Sleep(5000);

            IList<IWebElement> textBoxes = driver.FindElements(By.TagName("button"));              
            int countOfTextBoxes=textBoxes.Count;
            int expectedCount=4;
            Assert.AreEqual(expectedCount,countOfTextBoxes,"error");
        } */
         /*
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver =new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            Thread.Sleep(5000);

            IWebElement Email = driver.FindElement(By.XPath("//input[@id='userEmail']"));
            string actualValue=Email.GetAttribute("placeHolder");
            string expectValue="name@example.com";
            Assert.AreEqual(expectValue,actualValue,"error");
            driver.Quit()
        } */
        /*
        [TestMethod]
        public void TestMethod2()
        {
        IWebDriver driver = new ChromeDriver();
        SelectElement dropDown;
        driver.Navigate().GoToUrl("https://www.automationpractice.com");
        driver.Manage().Window.Maximize();
        IWebElement contactus = driver.FindElement(By.Id("contact-link"));
        contactus.Click();
        Thread.Sleep(5000);

        IWebElement master=driver.FindElement(By.XPath("//select[@id='id_contact']"));
        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true)",master);
        Thread.Sleep(5000);
        dropDown=new SelectElement(master);
        Thread.Sleep(5000);
        dropDown.SelectByText("Webmaster");
        Thread.Sleep(5000);
        driver.Quit();
        } */
        /*
        [TestMethod]
        public void TestMethod3()
        {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.automationpractice.com");
        IWebElement contactus = driver.FindElement(By.Id("contact-link"));
        contactus.Click();
        }*/

        [TestMethod]

        public void TestMethod1()



        {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.wikipedia.org/");
        Thread.Sleep(5000);
        IWebElement Text = driver.FindElement(By.Id("searchInput"));
        Text.SendKeys("Anna University");
        IWebElement Searchbutton = driver.FindElement(By.XPath("//i[@data-jsl10n='search-input-button']"));
        Searchbutton.Click();
        Thread.Sleep(5000);
        IWebElement othername = driver.FindElement(By.XPath("//*[contains(text(), 'Other name')]"));
        string expectedvalue = ("null");
        string actualvalue = othername.GetAttribute("Other name");
        Assert.AreEqual(expectedvalue,actualvalue,"other is not same");
    }
}

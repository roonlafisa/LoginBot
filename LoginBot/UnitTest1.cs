using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LoginBot
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            //Browser Driver
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();

            //Navigate
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");

            //Identify Login
            IWebElement lnkLogin = webDriver.FindElement(By.LinkText("Login"));

            //Click
            lnkLogin.Click();

            //Username
            var txtUserName = webDriver.FindElement(By.Name("UserName"));

            //Verify or Assert that Username is displayed
            Assert.That(txtUserName.Displayed, Is.True);

            //Write Username
            txtUserName.SendKeys("admin");

            //Write Password
            webDriver.FindElement(By.Name("Password")).SendKeys("password");

            //Identify and click Login
            webDriver.FindElement(By.XPath("//input[@value='Log in']")).Submit();


            //Username
            var lnkEmployeeDetails = webDriver.FindElement(By.LinkText("Employee Details"));

            //Verify or Assert that Employee Details
            Assert.That(lnkEmployeeDetails.Displayed, Is.True);
        }
    }
}
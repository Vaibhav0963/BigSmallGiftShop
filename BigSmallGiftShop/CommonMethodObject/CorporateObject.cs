using BigSmallGifProject.Utilites;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigSmallGiftShop.CommonMethodObject
{
    public class CorporateObject
    {
        public void ClickCorporate()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement home = BaseClass.driver.FindElement(By.XPath("//*[@id='myheader']/div[1]/div/div/ul/li[4]/a"));
            home.Click();
        }
        public void Name()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement Name = BaseClass.driver.FindElement(By.Id("contactFormName"));
            Name.SendKeys("Sharavri Athnikar");
        }
        public void Email()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement Email = BaseClass.driver.FindElement(By.XPath("//*[@id='contactFormEmail']"));
            Email.SendKeys("Sharavariathnikar@gmail.com");
        }
        public void Phone()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement Phone = BaseClass.driver.FindElement(By.XPath("//*[@id='contactFormPhone']"));
            Phone.SendKeys("1234567890");
        }
        public void Enquiry()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement Enquiry = BaseClass.driver.FindElement(By.XPath("//*[@id='contactFormMessage']"));
            Enquiry.SendKeys("Nice Product");
        }
        public void Submit()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement Submitbtn = BaseClass.driver.FindElement(By.XPath("//input[@type='submit'and @value='submit']"));
            Submitbtn.Click();
           // ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile("Test.png", ScreenshotImageFormat.Png);
        }

    }
}

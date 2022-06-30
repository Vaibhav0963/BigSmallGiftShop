using BigSmallGifProject.Utilites;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigSmallGiftShop.CommonMethodObject
{
    public class BigSmallObject
    {
        public void SelectLoginPage()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement logIn = BaseClass.driver.FindElement(By.XPath("//span[text()='sign in']"));
            logIn.Click();

        }
        public void EmailId()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement password = BaseClass.driver.FindElement(By.XPath("//input[@id='CustomerEmail']"));
            password.SendKeys("Sharavariathnikar@gmail.com");
        }
        public void Password()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement password = BaseClass.driver.FindElement(By.XPath("//input[@id='CustomerPassword']"));
            password.SendKeys("Shara14@");
        }
        public void SignInSuccessfully()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement signIn = BaseClass.driver.FindElement(By.XPath("//input[@type='submit']"));
            signIn.Click();

        }
        public void Gotohome()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement gotohome = BaseClass.driver.FindElement(By.XPath("//img[@class='small--hide']"));
            gotohome.Click();
        }

    }
}


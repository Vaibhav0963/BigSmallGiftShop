using BigSmallGifProject.Utilites;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigSmallGiftShop.CommonMethodObject
{
   public  class PinCodeObject
    {
        public void ClickOnGiftCard()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement GiftCard = BaseClass.driver.FindElement(By.XPath("//*[@id='myheader']/div[1]/header/div[2]/div[2]/div[4]/div/div/a[3]/i"));
            GiftCard.Click();
        }

        public void ClickOnPrice()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement ClickPrice = BaseClass.driver.FindElement(By.XPath("//label[@for='ProductSelect-738195636312-option-title-Rs.+1000']"));
            ClickPrice.Click();
        }

        public void EnterPincode()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement Pincode = BaseClass.driver.FindElement(By.XPath("//*[@id='PostalCode']"));
            Pincode.SendKeys("586101");


        }
        public void CheckPincode()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement Check = BaseClass.driver.FindElement(By.XPath("//*[@id='cod-cheker']/button"));
            Check.Click();
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile("Test.png", ScreenshotImageFormat.Png);
        }


    }
}

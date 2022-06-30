using BigSmallGifProject.Utilites;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigSmallGiftShop.CommonMethodObject
{

    public  class WishlistObject
    {
        public void ClickOnUniqueRakhi()
        {

            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement unique = BaseClass.driver.FindElement(By.XPath("//button[text()='Unique Rakhis']"));
            unique.Click();
        }
        public void ClickOnOneItem()

        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement item = BaseClass.driver.FindElement(By.XPath("//a[@href='/products/ludo-king-rakhi']"));
            item.Click();
        }

        public void ClickOnWishList()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement wishlist = BaseClass.driver.FindElement(By.XPath("//*[@id='ProductSection-4638094590040']/div/div/div[1]/div[2]/div/div[1]/div[1]/div/button"));
            wishlist.Click();
        }

        public void VerifyResult()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            IWebElement result = BaseClass.driver.FindElement(By.XPath("//a[@href='#swym-wishlist']"));
            result.Click();
        }
    }
}

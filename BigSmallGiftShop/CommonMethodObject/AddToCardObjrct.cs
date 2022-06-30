using BigSmallGifProject.Utilites;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigSmallGiftShop.CommonMethodObject
{
    public class AddToCardObjrct
    {
        public void ClickNewProducts()
        {

            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement NewProducts = BaseClass.driver.FindElement(By.XPath("//button[text()='New Products']"));
            NewProducts.Click();
        }
        public void ClickItem()

        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement Clickimg = BaseClass.driver.FindElement(By.XPath("//a[@href='/products/tom-jerry-rug']"));
            Clickimg.Click();
        }

        public void ClickAddToCard()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement AddToCard = BaseClass.driver.FindElement(By.XPath("//button[@name='add']"));
            AddToCard.Click();
        }

       
    }
}

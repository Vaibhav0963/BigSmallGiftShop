using BigSmallGiftShop.CommonMethodObject;
using System;
using TechTalk.SpecFlow;

namespace BigSmallGiftShop.StepDefinationFile
{
    [Binding]
    public class AddtoCartSteps
    {
        AddToCardObjrct CartObj = new AddToCardObjrct();

        [When(@"click on NewProduct")]
        public void WhenClickOnNewProduct()
        {
            CartObj.ClickNewProducts();
            Serilog.Log.Debug("click on NewProduct");
        }
        
        [When(@"click on any one item")]
        public void WhenClickOnAnyOneItem()
        {
            CartObj.ClickItem();
            Serilog.Log.Debug("click on any one item");
        }
        
        [When(@"click add to cart button")]
        public void WhenClickAddToCartButton()
        {
            CartObj.ClickAddToCard();
            Serilog.Log.Debug("click add to cart button");
        }
        
        [Then(@"item should be successfullly added in Cart")]
        public void ThenItemShouldBeSuccessfulllyAddedInCart()
        {
            
        }
    }
}

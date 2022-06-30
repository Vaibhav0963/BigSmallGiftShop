using BigSmallGiftShop.CommonMethodObject;
using System;
using TechTalk.SpecFlow;

namespace BigSmallGiftShop.StepDefinationFile
{
    [Binding]
    public class WishlistSteps
    {
        WishlistObject WishObj = new WishlistObject();

       [Given(@"User is on home page")]
        public void GivenUserIsOnHomePage()
        {
            
        }
        
        [When(@"click on unique rakhi")]
        public void WhenClickOnUniqueRakhi()
        {
            WishObj.ClickOnUniqueRakhi();
        }
        
        [When(@"click on item")]
        public void WhenClickOnItem()
        {
            WishObj.ClickOnOneItem();
        }
        
        [When(@"click add to wishlist button")]
        public void WhenClickAddToWishlistButton()
        {
            WishObj.ClickOnWishList();
        }
        
        [Then(@"item should be successfullly added in wishlist\.")]
        public void ThenItemShouldBeSuccessfulllyAddedInWishlist_()
        {
            WishObj.VerifyResult();
        }
    }
}

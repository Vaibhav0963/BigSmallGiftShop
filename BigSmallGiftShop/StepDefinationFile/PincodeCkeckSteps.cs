using BigSmallGiftShop.CommonMethodObject;
using System;
using TechTalk.SpecFlow;

namespace BigSmallGiftShop.StepDefinationFile
{
    [Binding]
    public class PincodeCkeckSteps
    {
        PinCodeObject PinObj = new PinCodeObject();

       [Given(@"User Clicks on Gift card")]
        public void GivenUserClicksOnGiftCard()
        {
            PinObj.ClickOnGiftCard();
        }
        
        [When(@"User Clicks on price")]
        public void WhenUserClicksOnPrice()
        {
            PinObj.ClickOnPrice();
        }
        
        [When(@"User Enters PinCode")]
        public void WhenUserEntersPinCode()
        {
            PinObj.EnterPincode();
        }
        
        [When(@"User Clicks on Check Button")]
        public void WhenUserClicksOnCheckButton()
        {
            PinObj.CheckPincode();
        }

        [Then(@"User shoud able to Your Pincode Or Not Succesfully")]
        public void ThenUserShoudAbleToYourPincodeOrNotSuccesfully()
        {
        }
    }
}

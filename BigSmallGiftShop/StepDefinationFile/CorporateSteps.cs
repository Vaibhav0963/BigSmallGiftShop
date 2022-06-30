using System;
using TechTalk.SpecFlow;
using BigSmallGiftShop.CommonMethodObject;

namespace BigSmallGiftShop.FeatureFile
{
    [Binding]
    public class CorporateSteps
    {
        CorporateObject CopObj = new CorporateObject();
        [Given(@"user is on the HomePage")]
        public void GivenUserIsOnTheHomePage()
        {
           
        }
        
        [When(@"User click on Coproate")]
        public void WhenUserClickOnCoproate()
        {
            CopObj.ClickCorporate();
        }
        
        [When(@"User Enter fullname")]
        public void WhenUserEnterFullname()
        {
            CopObj.Name();
        }
        
        [When(@"User Enter Email-id")]
        public void WhenUserEnterEmail_Id()
        {
            CopObj.Email();
        }
        
        [When(@"User Enter PhoneNo")]
        public void WhenUserEnterPhoneNo()
        {
            CopObj.Phone();
        }
        
        [When(@"User Fill Enquiry")]
        public void WhenUserFillEnquiry()
        {
            CopObj.Enquiry();
        }
        
        [When(@"Click on submit")]
        public void WhenClickOnSubmit()
        {
            CopObj.Submit();
        }
        
        [Then(@"Verify the messeage")]
        public void ThenVerifyTheMesseage()
        {
           
        }
    }
}

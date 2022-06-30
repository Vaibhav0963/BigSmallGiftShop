using BigSmallGiftShop.CommonMethodObject;
using System;
using TechTalk.SpecFlow;

namespace BigSmallGiftShop.StepDefinationFile
{
    [Binding]
    public class BigSmallSteps
    {
        BigSmallObject LogObj = new BigSmallObject();

        [When(@"User On Login page")]
        public void WhenUserOnLoginPage()
        {
            LogObj.SelectLoginPage();
        }
        
        [When(@"User Enter Email Id")]
        public void WhenUserEnterEmailId()
        {
            LogObj.EmailId();
        }
        
        [When(@"User Enter Password")]
        public void WhenUserEnterPassword()
        {
            LogObj.Password();
        }
        
        [When(@"User Click on SignIn Button")]
        public void WhenUserClickOnSignInButton()
        {
            LogObj.SignInSuccessfully();
        }
        
        [When(@"Go to Homepage")]
        public void WhenGoToHomepage()
        {
            LogObj.Gotohome();
        }
        
        [Then(@"User shoud able to Create Account Succesfully")]
        public void ThenUserShoudAbleToCreateAccountSuccesfully()
        {
            
        }
    }
}

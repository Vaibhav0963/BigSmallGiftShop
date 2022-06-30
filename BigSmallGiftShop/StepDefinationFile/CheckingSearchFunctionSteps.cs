using System;
using TechTalk.SpecFlow;
using BigSmallGiftShop.CommonMethodObject;

namespace BigSmallGiftShop.FeatureFile
{
    [Binding]
    public class CheckingSearchFunctionSteps
    {
        SearchBarObjects objSearch = new SearchBarObjects();
        [Given(@"The homepage of BigSmall Shopping site Page")]
        public void GivenTheHomepageOfBigSmallShoppingSitePage()
        {
            objSearch.HomePage();
        }
        
        [When(@"User Click on Search bar")]
        public void WhenUserClickOnSearchBar()
        {
            objSearch.OnSitePage();
        }
        
        [When(@"User enters ""(.*)"" data")]
        public void WhenUserEntersData(string SearchData)
        {
            objSearch.ClickOnSearch(SearchData);
        }
        
        [Then(@"System should display relevant search data")]
        public void ThenSystemShouldDisplayRelevantSearchData()
        {
            objSearch.VerifyResult();
        }
    }
}

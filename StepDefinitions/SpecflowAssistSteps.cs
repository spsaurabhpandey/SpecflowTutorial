using System;
using TechTalk.SpecFlow;

namespace SpecflowTutorial.StepDefinitions
{
    [Binding]
    public class SpecflowAssistSteps
    {
        [Given(@"susan wants to add the following places for de Zip code (.*)")]
        public void GivenSusanWantsToAddTheFollowingPlacesForDeZipCode(int p0, Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the country code de and zip code (.*)")]
        public void GivenTheCountryCodeDeAndZipCode(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"she submits the required data")]
        public void WhenSheSubmitsTheRequiredData()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I request the locations orresponding to these codes")]
        public void WhenIRequestTheLocationsOrrespondingToTheseCodes()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"she should receive a reply indicating success")]
        public void ThenSheShouldReceiveAReplyIndicatingSuccess()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the following places are returned")]
        public void ThenTheFollowingPlacesAreReturned(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}

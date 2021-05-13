using System;
using TechTalk.SpecFlow;

namespace SpecflowTutorial.StepDefinitions
{
    [Binding]
    public class ReturningLocationDataBasedOnCountryAndZipCodeSteps
    {
        [Given(@"the country code US and zip code (.*)")]
        public void GivenTheCountryCodeUSAndZipCode(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I request the locations corresponding to these codes")]
        public void WhenIRequestTheLocationsCorrespondingToTheseCodes()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the response contains the place name Beverly Hills")]
        public void ThenTheResponseContainsThePlaceNameBeverlyHills()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the response contains exactly (.*) location")]
        public void ThenTheResponseContainsExactlyLocation(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}

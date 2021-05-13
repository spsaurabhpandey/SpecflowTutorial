using System;
using TechTalk.SpecFlow;

namespace SpecflowTutorial.StepDefinitions
{
    [Binding]
    public class ReturningLocationDataBasedOnCountryAndZipCodeSteps
    {
        [Given(@"the country code (US|CA) and zip code (\d+)")]
        public void GivenTheCountryCodeUSAndZipCode(string countryCode, int zipCode)
        {
            
        }
        
        [When(@"I request the locations? corresponding to these codes")]
        public void WhenIRequestTheLocationsCorrespondingToTheseCodes()
        {
            
        }
        
        [Then(@"the response contains the place name Beverly Hills")]
        public void ThenTheResponseContainsThePlaceNameBeverlyHills()
        {
            
        }
        
        [Then(@"the response contains exactly (.*) location")]
        public void ThenTheResponseContainsExactlyLocation(int p0)
        {
            
        }
    }
}

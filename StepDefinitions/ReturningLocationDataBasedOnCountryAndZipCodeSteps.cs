using System;
using TechTalk.SpecFlow;

namespace SpecflowTutorial.StepDefinitions
{
    [Binding]
    public class ReturningLocationDataBasedOnCountryAndZipCodeSteps
    {
        [Given(@"the country code (US|CA) and zip code (.*)")]
        public void GivenTheCountryCodeUSAndZipCode(string countryCode, string zipCode)
        {
            
        }
        [When(@"I request the locations? corresponding to these codes")]
        public void WhenIRequestTheLocationCorrespondingToTheseCodes()
        {

        }

        [Then(@"the response contains the place name (.*)")]
        public void ThenTheResponseContainsThePlaceName(string placeName)
        {

        }

        [Then(@"the response contains exactly (.*) location")]
        public void ThenTheResponseContainsExactlyLocation(int numLocation)
        {

        }

               
    }
}

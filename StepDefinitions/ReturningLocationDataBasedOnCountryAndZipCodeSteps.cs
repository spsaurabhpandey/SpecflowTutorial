using System;
using TechTalk.SpecFlow;

namespace SpecflowTutorial.StepDefinitions
{
    [Binding]
    public class ReturningLocationDataBasedOnCountryAndZipCodeSteps
    {
<<<<<<< HEAD
        [Given(@"the country code (US|CA) and zip code (.*)")]
=======
        [Given(@"the country code (US|CA) and zip code (\d+)")]
>>>>>>> cb7520570397172e5f0370b3f91cecdd871d7dca
        public void GivenTheCountryCodeUSAndZipCode(string countryCode, int zipCode)
        {
            
        }
<<<<<<< HEAD
        [When(@"I request the locations? corresponding to these codes")]
        public void WhenIRequestTheLocationCorrespondingToTheseCodes()
        {

=======
        
        [When(@"I request the locations? corresponding to these codes")]
        public void WhenIRequestTheLocationsCorrespondingToTheseCodes()
        {
            
>>>>>>> cb7520570397172e5f0370b3f91cecdd871d7dca
        }

        [Then(@"the response contains the place name (.*)")]
        public void ThenTheResponseContainsThePlaceName(string placeName)
        {
<<<<<<< HEAD

=======
            
>>>>>>> cb7520570397172e5f0370b3f91cecdd871d7dca
        }

        [Then(@"the response contains exactly (.*) location")]
        public void ThenTheResponseContainsExactlyLocation(int numLocation)
        {
<<<<<<< HEAD

=======
            
>>>>>>> cb7520570397172e5f0370b3f91cecdd871d7dca
        }

               
    }
}

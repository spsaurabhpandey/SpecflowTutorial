Feature: learn how to use Background to replace multiple repeatitive Givens in different scenarios.
As a cutomer of the Zippopotam.us API
I want to recieve location data matching the country code and zip code I supply
I want to receive location data matching the country code and zip code I supply
So I can use this data to auto-complete forms on my web site.


Background: Set country and Zip codes
Given the country code US and zip code 90210

Scenario: An existing country and zip code yields the correct place name
	When I request the location corresponding to these codes
	Then the response contains the place name Beverly Hills

Scenario: An existing country and zip code yields the right number of results
When I request the locations corresponding to these codes
Then the response contains exactly 1 location
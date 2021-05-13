Feature:  scenario outline demo
As a cutomer of the Zippopotam.us API
I want to recieve location data matching the country code and zip code I supply
I want to receive location data matching the country code and zip code I supply
So I can use this data to auto-complete forms on my web site.

Scenario Outline: Country and zip codes yield the right place names
	Given the country code <countryCode> and zip code <zipCode>
	When I request the location corresponding to these codes
	Then the response contains the place name <placeName>
	Examples: 
	| countryCode | zipCode | placeName    |
	| US          | 90210   | Bevery Hills |
	| US          | 22222   | Arlington    |
	| CA          | Y1A     | WhiteHorse   |
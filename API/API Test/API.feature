Feature: API

@mytag
Scenario: GET Call
	Given I have HTTP Url 'ACG_Austin.JPG'
	When I execute GET request
	Then the response code is 200

Scenario: GET Acquirer
	Given I have HTTP Url '/api/eapp/rates/ems.uk'
	When I execute GET request
	Then the acquirerId is 'EMS.UK'
	Then the title is 'Elavon UK'
	Then the acquirerCode is 'EMS'
	Then the countryCode is 'UK'
	Then the currencyCode is 'GBP'

Scenario: POST Call
	Given I have HTTP Url '/index.html'
	When I Post the body 'seemless onboarding'
	Then the response is 'SEEMLESS ONBOARDING'

Scenario: Login 
	Given I have Url "http://jira.sohomouse.co.uk/secure/Dashboard.jspa"
	When I fill in username with "Ravali.Mandava"
	And I fill in password with "saibaba9"
	And I press "Login"
	Then I should see "Create" highlighted in the home page

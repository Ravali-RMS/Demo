Feature: Automating HelloWorld applicatons and building in Jenkins via Github
	

@mytag
Scenario: Demo Of CloudGuru
	Given I have webpage open "https://s3.amazonaws.com/asadcloudguru1234/index.html"
	When user enters "world" in the textfield
	And user presses the Click Me button
	Then the header displays "Hello WORLD"

Feature: TestFeature

@Test
Scenario: Log In
	Given Mission Control is running in Chrome
	When the user enters the username and password
	Then the user is logged in

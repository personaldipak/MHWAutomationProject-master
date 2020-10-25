Feature: MhwMainPage
        As a user I want select different langauge 
	    to access the offical site

Scenario: Access the Console offical site
       Given I am on the homepage 
	   And I click on messagebox 
	   When I have select the UK language 
	   Then Click on console offical site button

Scenario: Access the Steam offical site 
       Given I am on the homepage 
	   And I click on messagebox
	   When I have select the UK language 
	   Then Click on steam offical site button
         
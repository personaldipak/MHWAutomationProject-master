Feature: BuyNow
      As a user i want purchase game

Scenario: purchase game on the PS4
		Given I am on the HomePage
		And I am on Iceborne uk homepage
		And I click on ok messagebox
		And I click on Buy now button
		When I choose prefernce 2
		Then I click on buy now button 

Scenario: purchase game on the steam
		Given I am on the HomePage
		And I am on Iceborne uk homepage
		And I click on ok messagebox
		And I click on Buy now button
		When I choose prefernce 2
		Then I choose steam option 
		Then I should be able to see a message
		

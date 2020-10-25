Feature: Iceborne
       As a user i want to access iceborne offical site 
	   And access all the information relate to iceborne 

Scenario: Access iceborne offical site 
     Given I am on the Main-page
	 And I am on the iceborne homepage
	 And I click on consent messagebox
	 And I am on the EventQuest schedule 
	 When I am on the Master Rank
	 Then I should be able to see Event Schedule date

Scenario: Acess Master rank page table
	 Given I am on the Main-page
	 And I am on the iceborne homepage
	 And I click on consent messagebox
	 And I am on the EventQuest schedule 
	 When I am on the Master Rank
	 Then I should be able to see Event Schedule table

Scenario: Acess Master rank page table row
	 Given I am on the Main-page
	 And I am on the iceborne homepage
	 And I click on consent messagebox
	 And I am on the EventQuest schedule 
	 When I am on the Master Rank
	 Then I should be able to see Event Schedule table row

Scenario: Acess Master rank page table row image
	 Given I am on the Main-page
	 And I am on the iceborne homepage
	 And I click on consent messagebox
	 And I am on the EventQuest schedule 
	 When I am on the Master Rank
	 Then I should be able to see Event Schedule table row
	 And I should be able to see the image on table row

Scenario: Acess Master rank page table row level text
	 Given I am on the Main-page
	 And I am on the iceborne homepage
	 And I click on consent messagebox
	 And I am on the EventQuest schedule 
	 When I am on the Master Rank
	 Then I should be able to see Event Schedule table row
	 And I should be able to see the level text on table row

Scenario: Acess Master rank page table row overview link
	 Given I am on the Main-page
	 And I am on the iceborne homepage
	 And I click on consent messagebox
	 And I am on the EventQuest schedule 
	 When I am on the Master Rank
	 Then I should be able to see Event Schedule table row
	 And I should be able to click on quest details link on table row
	 And I should be able to see quest details information 
	 And I should be able to close the pop-up window
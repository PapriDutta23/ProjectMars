Feature: Seller can add profile details
	As a seller of this portal
	I want to add all the required information to my profile successfully

@mytag
#Scenario: Add profile using valid input details
#	Given I have logged into the website
#    And I have entered my availability , hours , earn target , location , firstname , lastname
#	#When I press save
#	#Then I am able to see it in my newly created profile

Scenario: Add language 
	Given I have logged into the website
	And I have added language  
	When I press the add button
    Then I should be able to view the added language 

	Scenario: Edit language 
	Given I have logged into the website
	And I have udpated language  
	When I press the update button
	Then I should be able to view the updated language 

	Scenario: Delete language 
	Given I have logged into the website
	And I have clicked the language tab  
	When I have pressed the delete sign
    Then I should be able to view no language

#
#	Scenario: Add skill
#	Given I have logged into the website
#	And I have added skill 
#    Then I should be able to view the added skill
#
#	Scenario: Edit skill 
#	Given I have logged into the website
#	And I have edited skill 
#    Then I should be able to view the edited skill
#
#	Scenario: Delete skill 
#	Given I have logged into the website
#	And I have deleted skill 
#    Then I should be able to view no skill
#
#	Scenario: Add education 
#	Given I have logged into the website
#	And I have added education 
#    Then I should be able to view the added education
#
#	Scenario: Edit education 
#	Given I have logged into the website
#	And I have edited education 
#    Then I should be able to view the edited education 
#
#	Scenario: Delete Education
#	Given I have logged into the website
#	And I have deleted education
#    Then I should be able to view no education
#	
#	Scenario: Add certificate 
#	Given I have logged into the website
#	And I have added certificate  
#    Then I should be able to view the added certificate
#
#	Scenario: Edit certificate
#	Given I have logged into the website
#	And I have edited certificate  
#    Then I should be able to view the edited certificate
#
#	Scenario: Delete certificate
#	Given I have logged into the website
#	And I have deleted certificate
#    Then I should be able to view no certificate


#	Scenario: Add languages  , skills , education , certificate with valid data
#	Given I have logged into the website
#	And I have entered language  , skills , education , certificate with Valid data
#    Then I should receive an alert message of 'Successful addition"
#
#	Scenario:Add  Profile Description(First Name , Last Name) with "NULL" values 
#	Given I have logged into the website and I go to My profile section
#	And I have selected valid data from dropdown for hours,avavilability,earn target 
#	Then I should receive message of successful addition 
#
#	Scenario: updating existing data from language , skill , education,certification tab
#	Given I have logged into the website and I go to My profile section
#	And I will click the "Update" button for the respective language , skill , education , certification tab and update the data
#	Then I should be able to view the update information in 'My Profile' section 

#   Scenario:  Add multiple no of educations and certifications
#   Given I have logged into the portal
#	And I have entered multiple educations and certifications
#	When  I press add button
#	Then I am able to see it in my newly created profile
#
#	Scenario: I should be able to fill up "Description" section
#	Given I have logged into the portal
#	And I have entered the description in "Description" field
#	When I press the 'save" button in "Description"
#	Then I should be able to see it in my profile section
#
#	Scenario: I should not be able to create a profile using invalid input in skills and language
#	Given I have logged into the portal
#	And I have entered invalid inputs in skills and language 
#	When I press add button
#	Then I should receive an error message
#
#	Scenario: I should not be able to create a profile using invalid educations and certifications 
#	Given I have logged into the portal
#	And I have entered invalid inputs in skills and language 
#	When I press add button
#	Then I should get notified by an error message
#
#	Scenario:I should not be able to create a profile using invalid/null data in profile section e.g first name ,last name
#	Given I have logged into the portal
#	And I have entered invalid /null details in profile section e.g first name , last name
#	When I press save button in profile section
#	Then I should not be able to create a profile
#
#	Scenario: I should be able to view my profile in profile page
#	Given I have logged into the portal
#	And When I click profile section
#	Then I should be able to see in  my profile
#
#	Scenario: I should be able to update my skills and language 
#	Given I have logged into the portal
#	And I have updated the  existing skills and language with new data
#	When I press the update button
#	Then I should be able to have a view the updated skills and language in my profile
#
#	Scenario: I should be able to upadte my educations and certifications
#	Given I have logged into the portal
#	And I have updated the  existing educations and certifications with new data
#	When I press the upadte button 
#	Then I should be able to have a view the updated educations and certifications  in my profile
#
#	Scenario: I should be able to update Description section 
#	Given I have logged into the portal
#	And I have updated the existing Description section
#	When I press the save button in Description section
#	Then I should be able to see the upadated "Description" section in my profile

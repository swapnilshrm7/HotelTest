Feature: Add hotel
	In order to simulate hotel management system
	As api consumer
	I want to be able to add hotel,get hotel details and book hotel

@AddHotel
Scenario Outline: User adds hotel in database by providing valid inputs
	Given User provided valid Id '<id>'  and '<name>' for hotel 
	And User has added required details for hotel
	When User calls AddHotel api
	Then Hotel with name '<name>' should be present in the response
Examples: 
| id | name   |
| 4  | hotel4 |
| 5  | hotel5 |
| 6  | hotel6 |

@GetHotelById
Scenario Outline: User adds a hotel and checks for the presence of that hotel by ID as an input
	Given User provided valid Id '<id>'  and '<name>' for hotel 
	And User has added required details for hotel
	And User calls AddHotel api
	And User provides Id '<id>' of hotel to be searched
	When User calls GetHotelByID api
	Then The result of the search should be '<name>'
Examples: 
| id | name   |
| 1  | hotel1 |
| 2  | hotel2 |
| 3  | hotel3 |

@AddAndGetMultipleHotels
Scenario Outline: User adds multiple hotels and checks for the presence of those hotels by ID as an input
	Given User provided valid Id '<id>'  and '<name>' for hotel 
	And User has added required details for hotel
	And User calls AddHotel api
	And User provided valid Id '<id1>'  and '<name1>' for hotel 
	And User has added required details for hotel
	And User calls AddHotel api
	And User provided valid Id '<id2>'  and '<name2>' for hotel 
	And User has added required details for hotel
	And User calls AddHotel api
	When User calls GetAllHotels api
	Then The result of the call should contain all the hotels should be 'present'
Examples: 
| id | name   | id1 | name1   | id2 | name2   |
| 7  | hotel7 | 8  | hotel8 | 9  | hotel9 |
#| 8  | hotel8 |
#| 9  | hotel9 |
#| 8  | hotel8 |
#| 9  | hotel9 |

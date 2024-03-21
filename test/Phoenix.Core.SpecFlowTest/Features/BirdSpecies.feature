Feature: BirdSpecies

@mytag
Scenario: Get Scientific Name
	Given I enter a bird species with the following values
		| Seq  | EnglishCommonName | Genus      | Species  |
		| 1001 | Blue Jay          | Cyanocitta | cristata |
	Then the scientific name should be "Cyanocitta cristata"
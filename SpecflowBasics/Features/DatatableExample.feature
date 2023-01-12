Feature: Working with datatables
  Exploring how the datatables are mapped

  @current
  Scenario: Scenario with tables
    Given I input the following numbers
      | Numbers |
      | 1506      |
      | 70      |
    And I input the following numbers with dynamic
      | Numbers |
      | 10      |
      | 20      |
      | 30      |
      | 40      |
    And I input the following numbers with dynamic single row multicolumn
      | Name    | Lastname  |
      | Diego   | Montoya   |
    When I input the following numbers with dynamic multi row multicolumn
      | Name    | Lastname  | Breed     |
      | Diego   | Montoya   | Cow     |
      | Ana     | Rojas     | Human     |
      | Blue    | Montoya   | Border    |
      | Grecia  | Montoya   | Yorkie    |

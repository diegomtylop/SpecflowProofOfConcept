@current
Feature: Feature combining the previous steps

    Feature created using the steps from the 3 steps definitions

    Scenario: Combined Scenario
        Given The first precondition
        When I do something
        And I do something different
        And I say my name is "Diego" regular
        And I input the following numbers with dynamic multi row multicolumn
            | Name    | Lastname  | Breed     |
            | Paco   | Montoya   | Criollo     |
            | Bongo     | Montoya     | Criollo     |
        Then I expect a result
        And The result should be different
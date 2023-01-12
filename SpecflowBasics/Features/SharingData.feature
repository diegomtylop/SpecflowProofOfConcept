Feature: Feature to see how to share data across steps and scenarios

    this features uses the dependcy injection mechanism tha
    spcflows has out of the box

    Scenario: Sharing data between steps
        Given The first precondition
        When I say my name is "Diego" regular
        Then I print my name
        When I say my name is "Estefania" regular
        Then I print my name

    Scenario: Sharing data between xscenarios
        Given The first precondition
        Then I print my name
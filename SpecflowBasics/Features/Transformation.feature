Feature: Feature that use the argument transformation

    Feature created to see how the argument transformation works
    https://docs.specflow.org/projects/specflow/en/latest/Bindings/Step-Argument-Conversions.html

    Scenario: Scenario with transformation
        Given The first precondition
        When I select the color "#fff"
        When I select the color "#fff"
        When I select the color "#657898"
        When I select the color "#000"
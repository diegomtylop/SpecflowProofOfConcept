namespace SpecflowBasics.StepDefinitions;

[Binding]
public class SecondSteps
{
    public SecondSteps()
    {
        Console.WriteLine("Instantiating the Steps class");
    }

    [When("I do something different")]
    public void FirstWhen()
    {
        Console.WriteLine("DOING SOMETHING DIFFERENT");
    }

    [Then(@"The result should be different")]
    public void ThenIExpectAResult()
    {
        Console.WriteLine("The result should be different");
    }
}


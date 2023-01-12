using static SpecflowBasics.StepDefinitions.StepWithTables;

namespace SpecflowBasics.StepDefinitions;

[Binding]
public class SimpleSteps
{
    private readonly ScenarioContext context;
    private readonly FeatureContext featureContext;

    public SimpleSteps(ScenarioContext context, FeatureContext featureContext)
    {
        Console.WriteLine("Instantiating the Steps class");
        this.context = context;
        this.featureContext = featureContext;
    }

    [Given("The first precondition")]
    public void FirstGiven()
    {
        Console.WriteLine("Running the first given");
    }

    [When("I do something")]
    public void FirstWhen()
    {
        Console.WriteLine("Running the first when");
        Console.Out.WriteLine("Running the first when");
    }

    [When($"^I say my name is \"(.*)\" interpolated$")]
    public void WhenWithParameterIterpolated(string name)
    {
        Console.WriteLine($"You said your name is as interpolated: {name}");
        storeNameInContext(name);
    }

    //The @ symbol means a verbatim string in c#
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/verbatim
    [When(@"I say my name is ""(.*)"" verbatim")]
    public void WhenWithParameterRegexp(string name)
    {
        Console.WriteLine($"You said your name is as verbatim: {name}");
        storeNameInContext(name);
    }

    [When("I say my name is \"(.*)\" regular")]
    public void WhenWithParameterNormal(string name)
    {
        Console.WriteLine($"You said your name is as regular string: {name}");
        storeNameInContext(name);
    }

    /**
     * Method to store the given name in the contexts
     * to be used for other steps
     */
    private void storeNameInContext(string name)
    {
        DiegoEntity person = new DiegoEntity()
        { Name = name };

        context.Set<DiegoEntity>(person);

        featureContext.Set<DiegoEntity>(person);

        //It is possible to access the scenario information in this way
        Console.WriteLine($"Scenario title: {context.ScenarioInfo.Title}");
    }

    [Then("I expect a result")]
    public void ThenIExpectAResult() => Console.WriteLine("Running the first then");
}


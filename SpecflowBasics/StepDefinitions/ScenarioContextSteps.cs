using System.Linq;
using static SpecflowBasics.StepDefinitions.StepWithTables;

namespace SpecflowBasics.StepDefinitions;

[Binding]
public class ScenarioContextSteps
{
    public readonly ScenarioContext context;
    private readonly FeatureContext featureContext;

    public ScenarioContextSteps( ScenarioContext context, FeatureContext featureContext)
    {
        Console.WriteLine("Instantiating the Steps class");
        this.context = context;
        this.featureContext = featureContext;
    }

    [Then("I print my name")]
    public void FirstWhen()
    {
        
        var savedUserFeature = featureContext.Get<DiegoEntity>();
        
        Console.WriteLine("Current name in feature is " + savedUserFeature.Name);

        try
        {
            var savedUser = context.Get<DiegoEntity>();
            Console.WriteLine("Current name in scenario is " + savedUser.Name);
        }catch(System.Collections.Generic.KeyNotFoundException)
        {
            Console.Error.WriteLine("KEY NOT FOUND");
        }
    }
}


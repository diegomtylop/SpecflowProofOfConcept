namespace SpecflowBasics.Hooks;

/**
 * Class with the different hooks
 */
[Binding]
public sealed class TestInitialize
{
    //This must be static
    [BeforeTestRun]
    public static void BeforeTestRun() => Console.WriteLine("RUNNING THE BEFORE TEST RUN");

    //Must be static
    [BeforeFeature(Order = 1)]
    public static void BeforeFeature() => Console.WriteLine("RUNNING BEFORE FEATURE");

    [BeforeScenario(Order = 1)]
    public void BeforeScenario() => Console.WriteLine("RUNNING BEFORE SCENARIO");

    [BeforeScenario("@current")]
    public void BeforeScenarioWithTag() => Console.WriteLine("RUNNING BEFORE SCENARIO with tag current");

    [AfterScenario(Order = 1)]
    public void AfterScenario() => Console.WriteLine("RUNNING After SCENARIO");
}

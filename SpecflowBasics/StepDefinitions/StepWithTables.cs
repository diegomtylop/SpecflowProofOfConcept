namespace SpecflowBasics.StepDefinitions;

[Binding]
public class StepWithTables
{
    private readonly ScenarioContext _scenarioContext;

    public StepWithTables(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given("I input the following numbers")]
    public void GivenWithTable(Table table)
    {
        Console.WriteLine($"Scenario with tables {table}");

        var header = table.Header;

        foreach (var head in header)
        {
            Console.WriteLine("current header: " + head);
        }

        foreach (var row in table.Rows)
        {
            var value = row[0];
            Console.WriteLine("current row value:" + value);
        }
    }

    //This method uses the dynamic helpers that applies
    //when the table contains a single column
    [Given("I input the following numbers with dynamic")]
    public void GivenWithTableWithDynamic(Table table)
    {
        Console.WriteLine($"Scenario with dynamic");

        //In order to use this dynamic data we need to include the package
        //Specflow.Assit.Dynamic
        dynamic data = table.CreateDynamicSet();

        foreach (var item in data)
        {
            Console.WriteLine($"The numbers are {item.Numbers}");
        }
    }

    /*
     * For working with multicolumn
     * will need to use the method CreateDynamicInstance
     */


    [Given("I input the following numbers with dynamic single row multicolumn")]
    public void GivenWithTableWithDynamicMulticolumn(Table table)
    {
        Console.WriteLine($"Scenario with dynamic multicolumn");

        //In order to use this dynamic data we need to include the package
        //Specflow.Assit.Dynamic
        dynamic data = table.CreateDynamicInstance();

        Console.WriteLine($"The numbers are {data.Name}");
        Console.WriteLine($"The numbers are {data.Lastname}");
    }

    [When("I input the following numbers with dynamic multi row multicolumn")]
    public void GivenWithTableWithDynamicMultiRowMulticolumn(Table table)
    {
        Console.WriteLine($"Scenario with dynamic multirow multicolumn");

        //In order to use this dynamic data we need to include the package
        //Specflow.Assit.Dynamic
        dynamic data = table.CreateSet<DiegoEntity>();

        foreach (var item in data)
        {
            Console.WriteLine($"Name {item.Name}, lastmane {item.Lastname}, Breed {item.Breed}");
        }
    }

    public record DiegoEntity
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Breed { get; set; }
    }
}
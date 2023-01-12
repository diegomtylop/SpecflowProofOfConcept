using System.Drawing;

namespace SpecflowBasics.StepDefinitions;

[Binding]
public class StepWithTransformations
{
    /*
     * Even though in the feature a string is provided
     * specflow automatically transform it into a "color" object
     * by using the Transformer defined on the class
     * ColorTransformer
     */
    [When("^I select the color \"(.*)\"$")]
    public void ConvertToColor(Color color) => Console.WriteLine($"I selected the color {color}");
}
using System.Drawing;

namespace SpecflowBasics.Transformers;

[Binding]
public class ColorTransformer
{
    //https://docs.specflow.org/projects/specflow/en/latest/Bindings/Step-Argument-Conversions.html
    [StepArgumentTransformation]
    public Color ConvertToColor(string colorString) => System.Drawing.ColorTranslator.FromHtml(colorString);
}


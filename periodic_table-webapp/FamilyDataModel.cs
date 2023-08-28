using Domain;

namespace UI;

public class FamilyDataModel
{
    public FamilyDataModel(Family initialValue)
    {
        Family = initialValue;
        Highlighted = true;
        CssColor = $"--family-{initialValue.Name.Replace("-", "").Replace(" ", "").ToLower()}-color";
    }

    public Family Family { get; }
    public bool Highlighted { get; set; }
    public string CssColor { get; }
}
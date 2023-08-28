using Domain;

namespace UI;

public class ElementDataModel
{
    public ElementDataModel(Element initialValue, FamilyDataModel familyDataModel)
    {
        Element = initialValue;
        MassHighlighted = false;
        FamilyDataModel = familyDataModel;
        Row = initialValue.Family == Domain.Family.Lanthanoids ? 8 : initialValue.Family == Domain.Family.Actinoids ? 9 : initialValue.Period;
        Column = initialValue.Group;
    }

    public Element Element { get; }
    public bool MassHighlighted { get; set; }
    public FamilyDataModel FamilyDataModel { get; }
    public int Row { get; }
    public int Column { get; }
}
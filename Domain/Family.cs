namespace Domain;

public record Family(string Name)
{
    public readonly static Family AlkaliMetals = new("Alkali Metals");
    public readonly static Family AlkalineEarthMetals = new("Alkaline Earth Metals");
    public readonly static Family PostTransitionMetals = new("Post-transition Metals");
    public readonly static Family TransitionMetals = new("Transition Metals");
    public readonly static Family Lanthanoids = new("Lanthanoids");
    public readonly static Family Actinoids = new("Actinoids");
    public readonly static Family Metalloids = new("Metalloids");
    public readonly static Family Nonmetals = new("Nonmetals");
    public readonly static Family Halogens = new("Halogens");
    public readonly static Family NobleGases = new("Noble Gases");

    public readonly static List<Family> All;
    static Family()
    {
        All = new()
        {
            AlkaliMetals,
            AlkalineEarthMetals,
            PostTransitionMetals,
            TransitionMetals,
            Lanthanoids,
            Actinoids,
            Metalloids,
            Nonmetals,
            Halogens,
            NobleGases
        };
    }
};
namespace Domain;

public record Element(
    string Symbol,
    string Name,
    Family Family,
    int AtomicNumber,
    double AtomicMass,
    double? IonizationEnergy,
    double? Electronegativity,
    List<int> OxidationStates,
    ElectronConfiguration ElectronConfiguration,
    int Period,
    int Group
)
{
    public bool HasRadiactiveMass => AtomicMass % 1 == 0;

    public readonly static Element Lithium = new("Li", nameof(Lithium), Family.AlkaliMetals, 3, 6.941, 520.2, 0.98, new() { 1, -1}, new(null, new() { 
        new("1s", 2), new("2s", 1) }), 2, 1);
    public readonly static Element Sodium = new("Na", nameof(Sodium), Family.AlkaliMetals, 11, 22.98976, 495.8, 0.93, new() { 1, -1}, new("Ne", new() { 
        new("3s", 1) }), 3, 1);
    public readonly static Element Potassium = new("K", nameof(Potassium), Family.AlkaliMetals, 19, 39.0983, 418.8, 0.82, new() { 1 }, new("Ar", new() { 
        new("4s", 1) }), 4, 1);
    public readonly static Element Rubidium = new("Rb", nameof(Rubidium), Family.AlkaliMetals, 37, 85.4678, 403.0, 0.82, new() { 1 }, new("Kr", new() { 
        new("5s", 1) }), 5, 1);
    public readonly static Element Ceasium = new("Cs", nameof(Ceasium), Family.AlkaliMetals, 55, 132.9054, 375.7, 79, new() { 1 }, new("Xe", new() { 
        new("6s", 1) }), 6, 1);
    public readonly static Element Francium = new("Fr", nameof(Francium), Family.AlkaliMetals, 87, 223, 380.0, 0.70, new() { 1 }, new("Rn", new() { 
        new("7s", 1) }), 7, 1);

    public readonly static Element Beryllium = new("Be", nameof(Beryllium), Family.AlkalineEarthMetals, 4, 9.012182, 889.5, 1.57, new() { 2 }, new(null, new() { 
        new("1s", 2), new("2s", 2) }), 2, 2);
    public readonly static Element Magnesium = new("Mg", nameof(Magnesium), Family.AlkalineEarthMetals, 12, 24.3050, 737.7, 1.31, new() { 2, 1 }, new("Ne", new() {
        new("3s", 2)}), 3, 2);
    public readonly static Element Calcium = new("Ca", nameof(Calcium), Family.AlkalineEarthMetals, 20, 40.078, 589.8, 1.00, new() { 2 }, new("Ar", new() {
        new("4s", 2)}), 4, 2);
    public readonly static Element Strontium = new("Sr", nameof(Strontium), Family.AlkalineEarthMetals, 38, 87.62, 549.5, 0.95, new() { 2 }, new("Kr", new() {
        new("5s", 2)}), 5, 2);
    public readonly static Element Barium = new("Ba", nameof(Barium), Family.AlkalineEarthMetals, 56, 137.327, 502.9, 0.89, new() { 2 }, new("Xe", new() {
        new("6s", 2)}), 6, 2);
    public readonly static Element Radium = new("Ra", nameof(Radium), Family.AlkalineEarthMetals, 88, 226, 509.3, 0.90, new() { 2 }, new("Rn", new() {
        new("7s", 2)}), 7, 2);

    public readonly static Element Aluminium = new("Al", nameof(Aluminium), Family.PostTransitionMetals, 13, 26.98153, 577.5, 1.61, new() { 3, 1 }, new("Ne", new() {
        new("3s", 2), new("3p", 1)}), 3, 13);
    public readonly static Element Gallium = new("Ga", nameof(Gallium), Family.PostTransitionMetals, 31, 69.723, 578.8, 1.81, new() { 3, 2, 1 }, new("Ar", new() {
        new("3d", 10), new("4s", 2), new("4p", 1)}), 4, 13);
    public readonly static Element Indium = new("In", nameof(Indium), Family.PostTransitionMetals, 49, 114.818, 558.3, 1.78, new() { 3, 2, 1 }, new("Kr", new() {
        new("4d", 10), new("5s", 2), new("5p", 1)}), 5, 13);
    public readonly static Element Thallium = new("Tl", nameof(Thallium), Family.PostTransitionMetals, 81, 204.3833, 589.4, 1.62, new() { 3, 1 }, new("Xe", new() {
        new("4f", 14), new("5d", 10), new("6s", 2), new("6p", 1)}), 6, 13);
    public readonly static Element Nihonium = new("Nh", nameof(Nihonium), Family.PostTransitionMetals, 113, 284, null, null, new() { 1, 3, 5 }, new("Rn", new() {
        new("5f", 14), new("6d", 10), new("7s", 2), new("7p", 1)}), 7, 13);
    public readonly static Element Tin = new("Sn", nameof(Tin), Family.PostTransitionMetals, 50, 118.871, 708.6, 1.96, new() { 4, 2, -4 }, new("Kr", new() {
        new("4d", 10), new("5s", 2), new("5p", 2)}), 5, 14);
    public readonly static Element Lead = new("Pb", nameof(Lead), Family.PostTransitionMetals, 82, 207.2, 715.6, 2.33, new() { 4, 2, -4 }, new("Xe", new() {
        new("4f", 14), new("5d", 10), new("6s", 2), new("6p", 2)}), 6, 14);
    public readonly static Element Flerovium = new("Fl", nameof(Flerovium), Family.PostTransitionMetals, 114, 289, null, null, new() { 2, 4 }, new("Rn", new() {
        new("5f", 14), new("6d", 10), new("7s", 2), new("7p", 2)}), 7, 14);
    public readonly static Element Bismuth = new("Bi", nameof(Bismuth), Family.PostTransitionMetals, 83, 208.9804, 703.0, 2.02, new() { 5, 3, -3 }, new("Xe", new() {
        new("4f", 14), new("5d", 10), new("6s", 2), new("6p", 3)}), 6, 15);
    public readonly static Element Moscovium = new("Mc", nameof(Moscovium), Family.PostTransitionMetals, 115, 288, null, null, new() { 1, 3 }, new("Rn", new() {
        new("5f", 14), new("6d", 10), new("7s", 2), new("7p", 3)}), 7, 15);
    public readonly static Element Livermorium = new("Lv", nameof(Livermorium), Family.PostTransitionMetals, 116, 292, null, null, new() { 2, 4 }, new("Lv", new() {
        new("5f", 14), new("6d", 10), new("7s", 2), new("7p", 4)}), 7, 16);

    public readonly static Element Scandium = new("Sc", nameof(Scandium), Family.TransitionMetals, 21, 44.95591, 633.1, 1.36, new() { 3, 2, 1 }, new("Ar", new() {
        new("3d", 1), new("4s", 2)}), 4, 3);
    public readonly static Element Titanium = new("Ti", nameof(Titanium), Family.TransitionMetals, 22, 47.867, 658.8, 1.54, new() { 4, 3, 2, 1, -1 }, new("Ar", new() {
        new("3d", 2), new("4s", 2)}), 4, 4);
    public readonly static Element Vanadium = new("V", nameof(Vanadium), Family.TransitionMetals, 23, 50.9415, 650.9, 1.63, new() { 5, 4, 3, 2, 1, -1 }, new("Ar", new() {
        new("3d", 3), new("4s", 2)}), 4, 5);
    public readonly static Element Chromium = new("Cr", nameof(Chromium), Family.TransitionMetals, 24, 51.9962, 652.9, 1.66, new() { 6, 5, 4, 3, 2, 1, -1, -2}, new("Ar", new() {
        new("3d", 5), new("4s", 1)}), 4, 6);
    public readonly static Element Manganese = new("Mn", nameof(Manganese), Family.TransitionMetals, 25, 54.93804, 717.3, 1.55, new() { 7, 6, 5, 4, 3, 2, 1, -1, -2, -3 }, new("Ar", new() {
        new("3d", 5), new("4s", 2)}), 4, 7);
    public readonly static Element Iron = new("Fe", nameof(Iron), Family.TransitionMetals, 26, 55.845, 762.5, 1.83, new() { 6, 5, 4, 3, 2, 1, -1, -2 }, new("Ar", new() {
        new("3d", 5), new("4s", 2)}), 4, 8);
    public readonly static Element Cobalt = new("Co", nameof(Cobalt), Family.TransitionMetals, 27, 58.93319, 760.4, 1.91, new() { 5, 4, 3, 2, 1, -1, -2 }, new("Ar", new() {
        new("3d", 5), new("4s", 2)}), 4, 9);
    public readonly static Element Nickel = new("Ni", nameof(Nickel), Family.TransitionMetals, 28, 58.6934, 737.1, 1.88, new() { 4, 3, 2, 1, -1 }, new("Ar", new() {
        new("3d", 6), new("4s", 2)}), 4, 10);
    public readonly static Element Copper = new("Cu", nameof(Copper), Family.TransitionMetals, 29, 63.546, 745.5, 1.90, new() { 4, 3, 2, 1 }, new("Ar", new() {
        new("3d", 7), new("4s", 2)}), 4, 11);
    public readonly static Element Zinc = new("Zn", nameof(Zinc), Family.TransitionMetals, 30, 65.38, 906.4, 1.65, new() { 2 }, new("Ar", new() {
        new("3d", 8), new("4s", 1)}), 4, 12);
    public readonly static Element Yttrium = new("Y", nameof(Yttrium), Family.TransitionMetals, 39, 88.90585, 600, 1.22, new() { 3, 2, 1 }, new("Kr", new() {
        new("4d", 1), new("5s", 2)}), 5, 3);
    public readonly static Element Zirconium = new("Zr", nameof(Zirconium), Family.TransitionMetals, 40, 91.224, 640.1, 1.33, new() { 4, 3, 2, 1 }, new("Kr", new() {
        new("4d", 2), new("5s", 2)}), 5, 4);
    public readonly static Element Niobium = new("Nb", nameof(Niobium), Family.TransitionMetals, 41, 92.90638, 652.1, 1.60, new() { 5, 4, 3, 2, -1 }, new("Kr", new() {
        new("4d", 4), new("5s", 1)}), 5, 5);
    public readonly static Element Molybdenum = new("Mo", nameof(Molybdenum), Family.TransitionMetals, 42, 95.96, 684.3, 2.16, new() { 6, 5, 4, 3, 2, 1, -1, -2 }, new("Kr", new() {
        new("4d", 5), new("5s", 1)}), 5, 6);
    public readonly static Element Technetium = new("Tc", nameof(Technetium), Family.TransitionMetals, 43, 98, 702.0, 1.90, new() { 7, 6, 5, 4, 3, 2, 1, -3 }, new("Kr", new() {
        new("4d", 5), new("5s", 2)}), 5, 7);
    public readonly static Element Ruthenium = new("Ru", nameof(Ruthenium), Family.TransitionMetals, 44, 101.07, 710.2, 2.20, new() { 8, 7, 6, 5, 4, 3, 2, 1, -2 }, new("Kr", new() {
        new("4d", 7), new("5s", 1)}), 5, 8);
    public readonly static Element Rhodium = new("Rh", nameof(Rhodium), Family.TransitionMetals, 45, 102.9055, 719.7, 2.28, new() { 6, 5, 4, 3, 2, 1, -1 }, new("Kr", new() {
        new("4d", 8), new("5s", 1)}), 5, 9);
    public readonly static Element Palladium = new("Pd", nameof(Palladium), Family.TransitionMetals, 46, 106.42, 804.4, 2.20, new() { 4, 2 }, new("Kr", new() {
        new("4d", 10)}), 5, 10);
    public readonly static Element Silver = new("Ag", nameof(Silver), Family.TransitionMetals, 47, 107.8682, 731.0, 1.93, new() { 3, 2, 1 }, new("Kr", new() {
        new("4d", 10), new("5s", 1)}), 5, 11);
    public readonly static Element Cadmium = new("Cd", nameof(Cadmium), Family.TransitionMetals, 48, 112.441, 867.8, 1.69, new() { 2 }, new("Kr", new() {
        new("4d", 10), new("5s", 2)}), 5, 12);
    public readonly static Element Lutetium = new("Lu", nameof(Lutetium), Family.TransitionMetals, 71, 174.9668, 523.5, 1.27, new() { 3 }, new("Xe", new() {
        new("4f", 14), new("5d", 1), new("6s", 2)}), 6, 3);
    public readonly static Element Hafnium = new("Hf", nameof(Hafnium), Family.TransitionMetals, 72, 178.49, 658.5, 1.30, new() { 4, 3, 2 }, new("Xe", new() {
        new("4f", 14), new("5d", 2), new("6s", 2)}), 6, 4);
    public readonly static Element Tantalum = new("Ta", nameof(Tantalum), Family.TransitionMetals, 73, 180.9478, 761.0, 1.50, new() { 5, 4, 3, 2, -1 }, new("Xe", new() {
        new("4f", 14), new("5d", 3), new("6s", 2)}), 6, 5);
    public readonly static Element Tungsten = new("W", nameof(Tungsten), Family.TransitionMetals, 74, 183.84, 770.0, 2.36, new() { 6, 5, 4, 3, 2, 1, -1, -2 }, new("Xe", new() {
        new("4f", 14), new("5d", 4), new("6s", 2)}), 6, 6);
    public readonly static Element Rhenium = new("Re", nameof(Rhenium), Family.TransitionMetals, 75, 186.207, 760.0, 1.90, new() { 7, 6, 5, 4, 3, 2, 1, -1, -3 }, new("Xe", new() {
        new("4f", 14), new("5d", 5), new("6s", 2)}), 6, 7);
    public readonly static Element Osmium = new("Os", nameof(Osmium), Family.TransitionMetals, 76, 190.23, 840.0, 2.20, new() { 8, 7, 6, 5, 4, 3, 2, 1, -2 }, new("Xe", new() {
        new("4f", 14), new("5d", 6), new("6s", 2)}), 6, 8);
    public readonly static Element Iridium = new("Ir", nameof(Iridium), Family.TransitionMetals, 77, 192.217, 880.0, 2.20, new() { 6, 5, 4, 3, 2, 1, -1, -3 }, new("Xe", new() {
        new("4f", 14), new("5d", 7), new("6s", 2)}), 6, 9);
    public readonly static Element Platinum = new("Pt", nameof(Platinum), Family.TransitionMetals, 78, 195.084, 870.0, 2.28, new() { 6, 5, 4, 2 }, new("Xe", new() {
        new("4f", 14), new("5d", 9), new("6s", 1)}), 6, 10);
    public readonly static Element Gold = new("Au", nameof(Gold), Family.TransitionMetals, 79, 196.9665, 890.01, 2.54, new() { 5, 3, 2, 1, -1 }, new("Xe", new() {
        new("4f", 14), new("5d", 10), new("6s", 1)}), 6, 11);
    public readonly static Element Mercury = new("Hg", nameof(Mercury), Family.TransitionMetals, 80, 200.59, 1007.1, 2.00, new() { 4, 2, 1 }, new("Xe", new() {
        new("4f", 14), new("5d", 10), new("6s", 2)}), 6, 12);
    public readonly static Element Lawrencium = new("Lr", nameof(Lawrencium), Family.TransitionMetals, 103, 262, 470.0, null, new() { 3 }, new("Rn", new() {
        new("5f", 14), new("7s", 2), new("7p", 1)}), 7, 3);
    public readonly static Element Rutherfordium = new("Rf", nameof(Rutherfordium), Family.TransitionMetals, 104, 261, 580.0, null, new() { 4 }, new("Rn", new() {
        new("5f", 14), new("6d", 2), new("7s", 2)}), 7, 4);
    public readonly static Element Dubnium = new("Db", nameof(Dubnium), Family.TransitionMetals, 105, 262, null, null, new() { 5 }, new("Rn", new() {
        new("5f", 14), new("6d", 3), new("7s", 2)}), 7, 5);
    public readonly static Element Seaborgium = new("Sg", nameof(Seaborgium), Family.TransitionMetals, 106, 266, null, null, new() { 6 }, new("Rn", new() {
        new("7s", 2), new("5f", 14), new("6d", 4)}), 7, 6);
    public readonly static Element Bohrium = new("Bh", nameof(Bohrium), Family.TransitionMetals, 107, 264, null, null, new() { 7 }, new("Rn", new() {
        new("5f", 14), new("6d", 5), new("7s", 2)}), 7, 7);
    public readonly static Element Hassium = new("Hs", nameof(Hassium), Family.TransitionMetals, 108, 277, null, null, new() { 8 }, new("Rn", new() {
        new("5f", 14), new("6d", 10), new("7s", 2)}), 7, 8);
    public readonly static Element Meitnerium = new("Mt", nameof(Meitnerium), Family.TransitionMetals, 109, 268, null, null, new() { 3, 1, 3, 5 }, new("Rn", new() {
        new("7s", 2), new("5f", 14), new("6d", 7)}), 7, 9);
    public readonly static Element Darmstadtium = new("Ds", nameof(Darmstadtium), Family.TransitionMetals, 110, 271, null, null, new() { 6 }, new("Rn", new() {
        new("7s", 2), new("5f", 14), new("6d", 8)}), 7, 10);
    public readonly static Element Roentgenium = new("Rg", nameof(Roentgenium), Family.TransitionMetals, 111, 272, null, null, new() { -1, 1, 3, 5 }, new("Rn", new() {
        new("5f", 14), new("6d", 10), new("7s", 1)}), 7, 11);
    public readonly static Element Copernicium = new("Cn", nameof(Copernicium), Family.TransitionMetals, 112, 285, null, null, new() { 4, 2 }, new("Rn", new() {
        new("5f", 14), new("6d", 10), new("7s", 2)}), 7, 12);

    public readonly static Element Lanthanum = new("La", nameof(Lanthanum), Family.Lanthanoids, 57, 138.9054, 538.1, 1.10, new() { 3, 2 }, new("Xe", new() {
        new("5d", 1), new("6s", 2)}), 8, 5);
    public readonly static Element Cerium = new("Ce", nameof(Cerium), Family.Lanthanoids, 58, 140.116, 534.4, 1.12, new() { 4, 3, 2 }, new("Xe", new() {
        new("4f", 1), new("5d", 1), new("6s", 2)}), 8, 6);
    public readonly static Element Praseodymium = new("Pr", nameof(Praseodymium), Family.Lanthanoids, 59, 140.9076, 527.0, 1.13, new() { 4, 3, 2 }, new("Xe", new() {
        new("4f", 3), new("6s", 2)}), 8, 7);
    public readonly static Element Neodymium = new("Nd", nameof(Neodymium), Family.Lanthanoids, 60, 144.242, 533.1, 1.14, new() { 3, 2 }, new("Xe", new() {
        new("4f", 4), new("6s", 2)}), 8, 8);
    public readonly static Element Promethium = new("Pm", nameof(Promethium), Family.Lanthanoids, 61, 145, 540, null, new() { 3 }, new("Xe", new() {
        new("4f", 5), new("6s", 2)}), 8, 9);
    public readonly static Element Samarium = new("Sm", nameof(Samarium), Family.Lanthanoids, 62, 150.36, 544.5, 1.17, new() { 3, 2 }, new("Xe", new() {
        new("4f", 6), new("6s", 2)}), 8, 10);
    public readonly static Element Europium = new("Eu", nameof(Europium), Family.Lanthanoids, 63, 151.964, 547.1, null, new() { 3, 2 }, new("Xe", new() {
        new("4f", 7), new("6s", 2)}), 8, 11);
    public readonly static Element Gadolinium = new("Gd", nameof(Gadolinium), Family.Lanthanoids, 64, 157.25, 593.4, 1.20, new() { 3, 2, 1 }, new("Xe", new() {
        new("4f", 7), new("5d", 1), new("6s", 2)}), 8, 12);
    public readonly static Element Terbium = new("Tb", nameof(Terbium), Family.Lanthanoids, 65, 158.9253, 565.8, null, new() { 4, 3, 2 }, new("Xe", new() {
        new("4f", 9), new("6s", 2)}), 8, 13);
    public readonly static Element Dysprosium = new("Dy", nameof(Dysprosium), Family.Lanthanoids, 66, 162.500, 573.0, 1.22, new() { 3, 2 }, new("Xe", new() {
        new("4f", 10), new("6s", 2)}), 8, 14);
    public readonly static Element Holmium = new("Ho", nameof(Holmium), Family.Lanthanoids, 67, 164.9303, 581.0, 1.23, new() { 3 }, new("Xe", new() {
        new("4f", 11), new("6s", 2)}), 8, 15);
    public readonly static Element Erbium = new("Er", nameof(Erbium), Family.Lanthanoids, 68, 167.259, 589.3, 1.24, new() { 3 }, new("Xe", new() {
        new("4f", 12), new("6s", 2)}), 8, 16);
    public readonly static Element Thulium = new("Tm", nameof(Thulium), Family.Lanthanoids, 69, 168.9342, 596.7, 1.25, new() { 3, 2 }, new("Xe", new() {
        new("4f", 13), new("6s", 2)}), 8, 17);
    public readonly static Element Ytterbium = new("Yb", nameof(Ytterbium), Family.Lanthanoids, 70, 173.054, 603.4, null, new() { 3, 2 }, new("Xe", new() {
        new("4f", 14), new("6s", 2)}), 8, 18);

    public readonly static Element Actinium = new("Ac", nameof(Actinium), Family.Actinoids, 89, 227, 499.0, 1.10, new() { 3 }, new("Rn", new() {
        new("6d", 1), new("7s", 2)}), 9, 5);
    public readonly static Element Thorium = new("Th", nameof(Thorium), Family.Actinoids, 90, 232.0380, 587.0, 1.30, new() { 4, 3, 2 }, new("Rn", new() {
        new("6d", 2), new("7s", 2)}), 9, 6);
    public readonly static Element Protactinium = new("Pa", nameof(Protactinium), Family.Actinoids, 91, 231.0358, 568.0, 1.50, new() { 5, 4, 3 }, new("Rn", new() {
        new("5f", 2), new("6d", 1), new("7s", 2)}), 9, 7);
    public readonly static Element Uranium = new("U", nameof(Uranium), Family.Actinoids, 92, 238.0289, 597.6, 1.38, new() { 6, 5, 4, 3 }, new("Rn", new() {
        new("5f", 3), new("6d", 1), new("7s", 2)}), 9, 8);
    public readonly static Element Neptunium = new("Np", nameof(Neptunium), Family.Actinoids, 93, 237, 604.5, 1.36, new() { 7, 6, 5, 4, 3 }, new("Rn", new() {
        new("5f", 4), new("6d", 1), new("7s", 2)}), 9, 9);
    public readonly static Element Plutonium = new("Pu", nameof(Plutonium), Family.Actinoids, 94, 244, 584.7, 1.28, new() { 7, 6, 5, 4, 3 }, new("Rn", new() {
        new("5f", 6), new("7s", 2)}), 9, 10);
    public readonly static Element Americium = new("Am", nameof(Americium), Family.Actinoids, 95, 243, 578.0, 1.30, new() { 6, 5, 4, 3, 2 }, new("Rn", new() {
        new("5f", 7), new("7s", 2)}), 9, 11);
    public readonly static Element Curium = new("Cm", nameof(Curium), Family.Actinoids, 96, 247, 581.0, 1.30, new() { 4, 3 }, new("Rn", new() {
        new("5f", 7), new("6d", 1), new("7s", 2)}), 9, 12);
    public readonly static Element Berkelium = new("Bk", nameof(Berkelium), Family.Actinoids, 97, 247, 601.0, 1.30, new() { 4, 3 }, new("Rn", new() {
        new("5f", 9), new("7s", 2)}), 9, 13);
    public readonly static Element Californium = new("Cf", nameof(Californium), Family.Actinoids, 98, 251, 608.0, 1.30, new() { 4, 3, 1 }, new("Rn", new() {
        new("5f", 10), new("7s", 2)}), 9, 14);
    public readonly static Element Einsteinium = new("Es", nameof(Einsteinium), Family.Actinoids, 99, 252, 619.0, 1.30, new() { 3, 2 }, new("Rn", new() {
        new("5f", 11), new("6s", 2)}), 9, 15);
    public readonly static Element Fermium = new("Fm", nameof(Fermium), Family.Actinoids, 100, 257, 627.0, 1.30, new() { 3, 2 }, new("Rn", new() {
        new("5f", 12), new("7s", 2)}), 9, 16);
    public readonly static Element Mendelevium = new("Md", nameof(Mendelevium), Family.Actinoids, 101, 258, 635.0, 1.30, new() { 3, 2 }, new("Rn", new() {
        new("5f", 13), new("7s", 2)}), 9, 17);
    public readonly static Element Nobelium = new("No", nameof(Nobelium), Family.Actinoids, 102, 259, 642.0, 1.30, new() { 3, 2 }, new("Rn", new() {
        new("5f", 14), new("7s", 2)}), 9, 18);

    public readonly static Element Boron = new("B", nameof(Boron), Family.Metalloids, 5, 10.811, 800.6, 2.04, new() { 3, 2, 1 }, new(null, new() {
        new("1s", 2), new("2s", 2), new("2p", 1)}), 2, 13);
    public readonly static Element Silicon = new("Si", nameof(Silicon), Family.Metalloids, 14, 28.0855, 786.5, 1.90, new() { 4, 3, 2, 1, -1, -2, -3, -4 }, new("Ne", new() {
        new("3s", 2), new("3p", 2)}), 3, 14);
    public readonly static Element Germanium = new("Ge", nameof(Germanium), Family.Metalloids, 32, 72.64, 762.0, 2.04, new() { 4, 3, 2, 1, -4 }, new("Ar", new() {
        new("3d", 10), new("4s", 2), new("4p", 2)}), 4, 14);
    public readonly static Element Arsenic = new("As", nameof(Arsenic), Family.Metalloids, 33, 74.92160, 947.0, 2.18, new() { 5, 3, 2, -3 }, new("Ar", new() {
        new("3d", 10), new("4s", 2), new("4p", 3)}), 4, 15);
    public readonly static Element Antimony = new("Sb", nameof(Antimony), Family.Metalloids, 51, 121.760, 834.0, 2.05, new() { 5, 3, -3 }, new("Kr", new() {
        new("4d", 10), new("5s", 2), new("5p", 3)}), 5, 15);
    public readonly static Element Tellurium = new("Te", nameof(Tellurium), Family.Metalloids, 52, 127.60, 869.3, 2.10, new() { 6, 5, 4, 2, -2 }, new("Kr", new() {
        new("4d", 10), new("5s", 2), new("5p", 4)}), 5, 16);
    public readonly static Element Polonium = new("Po", nameof(Polonium), Family.Metalloids, 84, 210, 812.1, 2.00, new() { 6, 4, 2, -2 }, new("Xe", new() {
        new("4f", 14), new("5d", 10), new("6s", 2), new("6p", 4)}), 6, 16);

    public readonly static Element Hydrogen = new("H", nameof(Hydrogen), Family.Nonmetals, 1, 1.00794, 1312.0, 2.20, new() { 1, -1 }, new(null, new() {
        new("1s", 1)}), 1, 1);
    public readonly static Element Carbon = new("C", nameof(Carbon), Family.Nonmetals, 6, 12.0107, 1086.5, 2.55, new() { 4, 3, 2, 1, -1, -2, -3, -4 }, new(null, new() {
        new("1s", 2), new("2s", 2), new("2p", 2)}), 2, 14);
    public readonly static Element Nitrogen = new("N", nameof(Nitrogen), Family.Nonmetals, 7, 14.0067, 1402.3, 3.04, new() { 5, 4, 3, 2, 1, -1, -2, -3 }, new(null, new() {
        new("1s", 2), new("2s", 2), new("2p", 3)}), 2, 15);
    public readonly static Element Oxygen = new("O", nameof(Oxygen), Family.Nonmetals, 8, 15.9994, 1313.9, 3.44, new() { 2, 1, -1, -2 }, new(null, new() {
        new("1s", 2), new("2s", 2), new("2p", 4)}), 2, 16);
    public readonly static Element Phosphorus = new("P", nameof(Phosphorus), Family.Nonmetals, 15, 30.97696, 1011.8, 2.19, new() { 5, 4, 3, 2, 1, -1, -2, -3 }, new("Ne", new() {
        new("3s", 2), new("3p", 3)}), 3, 15);
    public readonly static Element Sulfur = new("S", nameof(Sulfur), Family.Nonmetals, 16, 32.065, 999.6, 2.58, new() { 6, 5, 4, 3, 2, 1, -1, -2, }, new("Ne", new() {
        new("3s", 2), new("3p", 4)}), 3, 16);
    public readonly static Element Selenium = new("Se", nameof(Selenium), Family.Nonmetals, 34, 78.96, 941.0, 2.55, new() { 6, 4, 2, -2 }, new("Ar", new() {
        new("3d", 10), new("4s", 2), new("4p", 4)}), 4, 16);

    public readonly static Element Fluorine = new("F", nameof(Fluorine), Family.Halogens, 9, 18.998403, 1681.0, 3.98, new() { -1 }, new(null, new() {
        new("1s", 2), new("2s", 2), new("2p", 5)}), 2, 17);
    public readonly static Element Chlorine = new("Cl", nameof(Chlorine), Family.Halogens, 17, 35.453, 1251.2, 3.16, new() { 7, 6, 5, 4, 3, 2, 1, -1 }, new("Ne", new() {
        new("3s", 2), new("3p", 5)}), 3, 17);
    public readonly static Element Bromine = new("Br", nameof(Bromine), Family.Halogens, 35, 79.904, 1139.9, 2.96, new() { 7, 5, 4, 3, 1, -1 }, new("Ar", new() {
        new("3d", 10), new("4s", 2), new("4p", 5)}), 4, 17);
    public readonly static Element Iodine = new("I", nameof(Iodine), Family.Halogens, 53, 126.9044, 1008.4, 2.66, new() { 7, 5, 3, 1, -1 }, new("Kr", new() {
        new("4d", 10), new("5s", 2), new("5p", 5)}), 5, 17);
    public readonly static Element Astatine = new("At", nameof(Astatine), Family.Halogens, 85, 210, 890.0, 2.20, new() { 1, -1 }, new("Xe", new() {
        new("4f", 14), new("5d", 10), new("6s", 2), new("6p", 5)}), 6, 17);
    public readonly static Element Tennessine = new("Ts", nameof(Tennessine), Family.Halogens, 117, 294, null, null, new() { -1, 1, 3, 5 }, new("Rn", new() {
        new("5f", 14), new("6d", 10), new("7s", 2), new("7p", 5)}), 7, 17);

    public readonly static Element Helium = new("He", nameof(Helium), Family.NobleGases, 2, 4.002602, 2372.3, null, new(), new(null, new() {
        new("1s", 2)}), 1, 18);
    public readonly static Element Neon = new("Ne", nameof(Neon), Family.NobleGases, 10, 20.1797, 2080.7, null, new(), new(null, new() {
        new("1s", 2), new("2s", 2), new("2p", 6)}), 2, 18);
    public readonly static Element Argon = new("Ar", nameof(Argon), Family.NobleGases, 18, 39.948, 1520.6, null, new(), new("Ne", new() {
        new("3s", 2), new("3p", 6)}), 3, 18);
    public readonly static Element Krypton = new("Kr", nameof(Krypton), Family.NobleGases, 36, 83.798, 1350.8, 3.00, new() { 2 }, new("Ar", new() {
        new("3d", 10), new("4s", 2), new("4p", 6)}), 4, 18);
    public readonly static Element Xenon = new("Xe", nameof(Xenon), Family.NobleGases, 54, 131.293, 1170.4, 2.60, new() { 8, 6, 4, 2 }, new("Kr", new() {
        new("4d", 10), new("5s", 2), new("5p", 6)}), 5, 18);
    public readonly static Element Radon = new("Rn", nameof(Radon), Family.NobleGases, 86, 220, 1037.0, null, new(), new("Xe", new() {
        new("4f", 14), new("5d", 10), new("6s", 2), new("6p", 6)}), 6, 18);
    public readonly static Element Organesson = new("Og", nameof(Organesson), Family.NobleGases, 118, 294, null, null, new() { 2, 4 }, new("Rn", new() {
        new("5f", 14), new("6d", 10), new("7s", 2), new("7p", 6)}), 7, 18);

    public readonly static List<Element> All;
    static Element()
    {
        All = new()
        {
            Lithium,
            Sodium,
            Potassium,
            Rubidium,
            Ceasium,
            Francium,
            Beryllium,
            Magnesium,
            Calcium,
            Strontium,
            Barium,
            Radium,
            Aluminium,
            Gallium,
            Indium,
            Thallium,
            Nihonium,
            Tin,
            Lead,
            Flerovium,
            Bismuth,
            Moscovium,
            Livermorium,
            Scandium,
            Titanium,
            Vanadium,
            Chromium,
            Manganese,
            Iron,
            Cobalt,
            Nickel,
            Copper,
            Zinc,
            Yttrium,
            Zirconium,
            Niobium,
            Molybdenum,
            Technetium,
            Ruthenium,
            Rhodium,
            Palladium,
            Silver,
            Cadmium,
            Lutetium,
            Hafnium,
            Tantalum,
            Tungsten,
            Rhenium,
            Osmium,
            Iridium,
            Platinum,
            Gold,
            Mercury,
            Lawrencium,
            Rutherfordium,
            Dubnium,
            Seaborgium,
            Bohrium,
            Hassium,
            Meitnerium,
            Darmstadtium,
            Roentgenium,
            Copernicium,
            Lanthanum,
            Cerium,
            Praseodymium,
            Neodymium,
            Promethium,
            Samarium,
            Europium,
            Gadolinium,
            Terbium,
            Dysprosium,
            Holmium,
            Erbium,
            Thulium,
            Ytterbium,
            Actinium,
            Thorium,
            Protactinium,
            Uranium,
            Neptunium,
            Plutonium,
            Americium,
            Curium,
            Berkelium,
            Californium,
            Einsteinium,
            Fermium,
            Mendelevium,
            Nobelium,
            Fluorine,
            Chlorine,
            Bromine,
            Iodine,
            Astatine,
            Tennessine,
            Helium,
            Neon,
            Argon,
            Krypton,
            Xenon,
            Radon,
            Organesson,
            Boron,
            Silicon,
            Germanium,
            Arsenic,
            Antimony,
            Tellurium,
            Polonium,
            Hydrogen,
            Carbon,
            Nitrogen,
            Oxygen,
            Phosphorus,
            Sulfur,
            Selenium,
        };
    }
};
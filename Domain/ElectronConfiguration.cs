namespace Domain;

public record ElectronConfiguration(
    string? ElementSymbol,
    List<SubConfiguration> SubConfigurations
);
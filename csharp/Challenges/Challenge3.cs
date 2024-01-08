namespace Challenges;

// Worried about mapping a Animal to an MyNewAwesomeSpecies manually? Don't worry, ask Copilot.
public static class Challenge3
{
    public static MyNewAwesomeSpecies ToAwesomeSpecies(this Animal person)
    {
        throw new NotImplementedException();
    }
}

public class Animal
{
    public string Name { get; set; } = string.Empty;

    public string Species { get; set; } = string.Empty;

    public string Color { get; set; } = string.Empty;

    public int Age { get; set; }

    public double Weight { get; set; }

    public double Height { get; set; }

    public string Habitat { get; set; } = string.Empty;

    public bool IsHerbivore { get; set; }

    public bool IsCarnivore { get; set; }

    public bool IsEndangered { get; set; }

    public string Diet { get; set; } = string.Empty;

    public int Lifespan { get; set; }

    public string OriginCountry { get; set; } = string.Empty;

    public bool IsDomestic { get; set; }

    public string Sound { get; set; } = string.Empty;

    public string Classification { get; set; } = string.Empty;

    public string Family { get; set; } = string.Empty;

    public string Genus { get; set; } = string.Empty;

    public string Order { get; set; } = string.Empty;

    public string Phylum { get; set; } = string.Empty;

    public string Kingdom { get; set; } = string.Empty;

    public string Class { get; set; } = string.Empty;

    public string ConservationStatus { get; set; } = string.Empty;

    public string DietType { get; set; } = string.Empty;
    
    public string Predators { get; set; } = string.Empty;

    public string Prey { get; set; } = string.Empty;

    public string NaturalHabitat { get; set; } = string.Empty;

    public string Size { get; set; } = string.Empty;

    public int Population { get; set; }

    public int AverageSpeed { get; set; }

    public int TopSpeed { get; set; }

    public int AverageLifespan { get; set; }

    public string SkinType { get; set; } = string.Empty;

    public string FavouriteFood { get; set; } = string.Empty;

    public string SpecialFeatures { get; set; } = string.Empty;

    public string DistinctiveBehavior { get; set; } = string.Empty;

    public string MatingSeason { get; set; } = string.Empty;

    public int GestationPeriod { get; set; }

    public string AverageOffspring { get; set; } = string.Empty;

    public string DietConsistsOf { get; set; } = string.Empty;

    public string KnownPredators { get; set; } = string.Empty;

    public string FunFact { get; set; } = string.Empty;

    public string TypeOfAnimal { get; set; } = string.Empty;

    public string LocationFound { get; set; } = string.Empty;

    public double AverageWeight { get; set; }

    public double AverageLength { get; set; }

    public double AverageHeight { get; set; }

    public string ScientificName { get; set; } = string.Empty;

    public string GroupBehavior { get; set; } = string.Empty;

    public int EstimatedPopulationSize { get; set; }

    public string BiggestThreat { get; set; } = string.Empty;

    public string MostDistinctiveFeature { get; set; } = string.Empty;
}

public class MyNewAwesomeSpecies : Animal
{

}

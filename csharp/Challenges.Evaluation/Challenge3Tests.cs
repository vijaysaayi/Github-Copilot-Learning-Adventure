namespace Challenges.Evaluation;

public class Challenge3Tests
{
    [Fact]
    public void ToMammal_ValidAnimal_ReturnsMammal()
    {
        var animal = new Animal()
        {
            Name = "Dog",
            Species = "Canis lupus familiaris",
            Color = "Brown",
            Age = 5,
            Weight = 20,
            Height = 1.5,
            Habitat = "Domestic",
            IsHerbivore = false,
            IsCarnivore = true,
            IsEndangered = false,
            Diet = "Omnivore",
            Lifespan = 15,
            OriginCountry = "Germany",
            IsDomestic = true,
            Sound = "Bark",
            Classification = "Mammal",
            Family = "Canidae",
            Genus = "Canis",
            Order = "Carnivora",
            Phylum = "Chordata",
            Kingdom = "Animalia",
            Class = "Mammalia",
            ConservationStatus = "Least Concern",
            DietType = "Omnivore",
            Predators = "None",
            ScientificName = "Canis lupus familiaris",
            DietConsistsOf = "Meat",
            Size = "Medium",
            NaturalHabitat = "Domestic",
            Prey = "None",
            SkinType = "Fur",
            AverageHeight = 1.5,
            AverageWeight = 20,
            TopSpeed = 48,
            AverageLifespan = 15,
            FavouriteFood = "Meat",
            SpecialFeatures = "None",
            EstimatedPopulationSize = 900000000,
            MatingSeason = "Year-round",
            FunFact = "Dogs are the most popular pet in the world.",
            BiggestThreat = "None",
            MostDistinctiveFeature = "None",
            LocationFound = "Worldwide",
            GestationPeriod = 63,
            DistinctiveBehavior = "None",
            TypeOfAnimal = "Mammal",
            AverageSpeed = 48,
            AverageLength = 1.5,
            AverageOffspring = "None",
            KnownPredators = "None",
            Population = 900000000,
            GroupBehavior = "Pack"
        };

        var awesomeSpecies = animal.ToAwesomeSpecies();

        Assert.Equal("Dog", awesomeSpecies.Name);
        Assert.Equal("Canis lupus familiaris", awesomeSpecies.Species);
        Assert.Equal("Brown", awesomeSpecies.Color);
        Assert.Equal(5, awesomeSpecies.Age);
        Assert.Equal(20, awesomeSpecies.Weight);
        Assert.Equal(1.5, awesomeSpecies.Height);
        Assert.Equal("Domestic", awesomeSpecies.Habitat);
        Assert.False(awesomeSpecies.IsHerbivore);
        Assert.True(awesomeSpecies.IsCarnivore);
        Assert.False(awesomeSpecies.IsEndangered);
        Assert.Equal("Omnivore", awesomeSpecies.Diet);
        Assert.Equal(15, awesomeSpecies.Lifespan);
        Assert.Equal("Germany", awesomeSpecies.OriginCountry);
        Assert.True(awesomeSpecies.IsDomestic);
        Assert.Equal("Bark", awesomeSpecies.Sound);
        Assert.Equal("Mammal", awesomeSpecies.Classification);
        Assert.Equal("Canidae", awesomeSpecies.Family);
        Assert.Equal("Canis", awesomeSpecies.Genus);
        Assert.Equal("Carnivora", awesomeSpecies.Order);
        Assert.Equal("Chordata", awesomeSpecies.Phylum);
        Assert.Equal("Animalia", awesomeSpecies.Kingdom);
        Assert.Equal("Mammalia", awesomeSpecies.Class);
        Assert.Equal("Least Concern", awesomeSpecies.ConservationStatus);
        Assert.Equal("Omnivore", awesomeSpecies.DietType);
        Assert.Equal("None", awesomeSpecies.Predators);
        Assert.Equal("Canis lupus familiaris", awesomeSpecies.ScientificName);
        Assert.Equal("Meat", awesomeSpecies.DietConsistsOf);
        Assert.Equal("Medium", awesomeSpecies.Size);
        Assert.Equal("Domestic", awesomeSpecies.NaturalHabitat);
        Assert.Equal("None", awesomeSpecies.Prey);
        Assert.Equal("Fur", awesomeSpecies.SkinType);
        Assert.Equal(1.5, awesomeSpecies.AverageHeight);
        Assert.Equal(20, awesomeSpecies.AverageWeight);
        Assert.Equal(48, awesomeSpecies.TopSpeed);
        Assert.Equal(15, awesomeSpecies.AverageLifespan);
        Assert.Equal("Meat", awesomeSpecies.FavouriteFood);
        Assert.Equal("None", awesomeSpecies.SpecialFeatures);
        Assert.Equal(900000000, awesomeSpecies.EstimatedPopulationSize);
        Assert.Equal("Year-round", awesomeSpecies.MatingSeason);
        Assert.Equal("Dogs are the most popular pet in the world.", awesomeSpecies.FunFact);
        Assert.Equal("None", awesomeSpecies.BiggestThreat);
        Assert.Equal("None", awesomeSpecies.MostDistinctiveFeature);
        Assert.Equal("Worldwide", awesomeSpecies.LocationFound);
        Assert.Equal(63, awesomeSpecies.GestationPeriod);
        Assert.Equal("None", awesomeSpecies.DistinctiveBehavior);
        Assert.Equal("Mammal", awesomeSpecies.TypeOfAnimal);            
        Assert.Equal(48, awesomeSpecies.AverageSpeed);
        Assert.Equal(1.5, awesomeSpecies.AverageLength);
        Assert.Equal("None", awesomeSpecies.AverageOffspring);
        Assert.Equal("None", awesomeSpecies.KnownPredators);
        Assert.Equal(900000000, awesomeSpecies.Population);
        Assert.Equal("Pack", awesomeSpecies.GroupBehavior);
    }
}

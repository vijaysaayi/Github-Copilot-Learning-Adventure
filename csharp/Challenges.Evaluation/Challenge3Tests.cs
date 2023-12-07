namespace Challenges.Evaluation;

public class Challenge3Tests
{
    [Fact]
    public void ToEmployee_ValidPerson_ReturnsEmployee()
    {
        // Arrange
        var person = new Person
        {
            Id = 1,
            Name = "John Doe",
            Age = 30,
            Address = "123 Main St",
            PhoneNumber = "555-1234",
            City = "New York",
            Region = "NY",
            Country = "USA",
            PostalCode = "12345",
            EmailAddress = "john.doe@example.com",
            JobTitle = "Software Developer",
            CompanyName = "ABC Inc",
            CompanyAddress = "456 Elm St",
            CompanyPhoneNumber = "555-5678",
            CompanyCity = "New York",
            CompanyRegion = "NY",
            CompanyCountry = "USA",
            CompanyPostalCode = "54321",
            CompanyEmailAddress = "info@abcinc.com",
            CompanyWebsite = "www.abcinc.com",
            CompanyFaxNumber = "555-9012",
            CompanyJobTitle = "CEO",
            CompanyDepartment = "Engineering",
            CompanyDescription = "Software Development Company",
            CompanyLogo = "logo.png",
            CompanyBanner = "banner.png",
            CompanyFounded = "2000",
            CompanyEmployees = "100",
            CompanyRevenue = "$1,000,000",
            CompanySlogan = "Building the Future",
            CompanyVAT = "123456789"
        };

        // Act
        var result = person.ToEmployee();

        // Assert all properties of the result are equal to the person
        Assert.Equal(person.Id, result.Id);
        Assert.Equal(person.Name, result.Name);            
        Assert.Equal(person.Age, result.Age);
        Assert.Equal(person.Address, result.Address);
        Assert.Equal(person.PhoneNumber, result.PhoneNumber);
        Assert.Equal(person.City, result.City);
        Assert.Equal(person.Region, result.Region);
        Assert.Equal(person.Country, result.Country);
        Assert.Equal(person.PostalCode, result.PostalCode);
        Assert.Equal(person.EmailAddress, result.EmailAddress);
        Assert.Equal(person.JobTitle, result.JobTitle);
        Assert.Equal(person.CompanyName, result.CompanyName);
        Assert.Equal(person.CompanyAddress, result.CompanyAddress);
        Assert.Equal(person.CompanyPhoneNumber, result.CompanyPhoneNumber);
        Assert.Equal(person.CompanyCity, result.CompanyCity);
        Assert.Equal(person.CompanyRegion, result.CompanyRegion);
        Assert.Equal(person.CompanyCountry, result.CompanyCountry);
        Assert.Equal(person.CompanyPostalCode, result.CompanyPostalCode);
        Assert.Equal(person.CompanyEmailAddress, result.CompanyEmailAddress);
        Assert.Equal(person.CompanyWebsite, result.CompanyWebsite);
        Assert.Equal(person.CompanyFaxNumber, result.CompanyFaxNumber);
        Assert.Equal(person.CompanyJobTitle, result.CompanyJobTitle);
        Assert.Equal(person.CompanyDepartment, result.CompanyDepartment);
        Assert.Equal(person.CompanyDescription, result.CompanyDescription);
        Assert.Equal(person.CompanyLogo, result.CompanyLogo);
        Assert.Equal(person.CompanyBanner, result.CompanyBanner);
        Assert.Equal(person.CompanyFounded, result.CompanyFounded);
        Assert.Equal(person.CompanyEmployees, result.CompanyEmployees);
        Assert.Equal(person.CompanyRevenue, result.CompanyRevenue);
        Assert.Equal(person.CompanySlogan, result.CompanySlogan);
        Assert.Equal(person.CompanyVAT, result.CompanyVAT);
    }
}

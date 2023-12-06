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

        // Assert
        Assert.IsType<Employee>(result);
    }
}

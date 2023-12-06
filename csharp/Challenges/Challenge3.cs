namespace Challenges;

// Worried about mapping a Person to an Employee? Don't worry, ask Copilot.
public static class Challenge3
{
    public static Employee ToEmployee(this Person person)
    {
        throw new NotImplementedException();
    }
}

public class Person
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public int Age { get; set; }

    public string Address { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public string Region { get; set; } = string.Empty;

    public string Country { get; set; } = string.Empty;

    public string PostalCode { get; set; } = string.Empty;

    public string EmailAddress { get; set; } = string.Empty;

    public string JobTitle { get; set; } = string.Empty;

    public string CompanyName { get; set; } = string.Empty;

    public string CompanyAddress { get; set; } = string.Empty;

    public string CompanyPhoneNumber { get; set; } = string.Empty;

    public string CompanyCity { get; set; } = string.Empty;

    public string CompanyRegion { get; set; } = string.Empty;

    public string CompanyCountry { get; set; } = string.Empty;

    public string CompanyPostalCode { get; set; } = string.Empty;

    public string CompanyEmailAddress { get; set; } = string.Empty;

    public string CompanyWebsite { get; set; } = string.Empty;

    public string CompanyFaxNumber { get; set; } = string.Empty;

    public string CompanyJobTitle { get; set; } = string.Empty;

    public string CompanyDepartment { get; set; } = string.Empty;

    public string CompanyDescription { get; set; } = string.Empty;

    public string CompanyLogo { get; set; } = string.Empty;

    public string CompanyBanner { get; set; } = string.Empty;

    public string CompanyFounded { get; set; } = string.Empty;

    public string CompanyEmployees { get; set; } = string.Empty;

    public string CompanyRevenue { get; set; } = string.Empty;

    public string CompanySlogan { get; set; } = string.Empty;

    public string CompanyVAT { get; set; } = string.Empty;
}

public class Employee : Person
{

}
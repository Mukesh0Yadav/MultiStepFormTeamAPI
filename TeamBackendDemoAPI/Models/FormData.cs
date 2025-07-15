namespace TeamBackendDemoAPI.Models;

public class FormData
{
    public int Id { get; set; }

    // Personal Info
    public string FullName { get; set; }
    public DateTime Dob { get; set; }
    public string Gender { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Nationality { get; set; }

    // Address Info
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }

    // Account Info
    public string Username { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public string SecurityQuestion { get; set; }
    public string SecurityAnswer { get; set; }
}

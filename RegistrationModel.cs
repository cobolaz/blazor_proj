public class RegistrationModel
{
    [Required, MinLength(2)]
    public string Name { get; set; } = "";

    [Required, EmailAddress]
    public string Email { get; set; } = "";
}

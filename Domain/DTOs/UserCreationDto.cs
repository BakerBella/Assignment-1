namespace Domain.DTOs;

public class UserCreationDto
{
    public string UserName { get;}
    public string Password { get; }
    public int SecurityLevel { get; }

    public UserCreationDto(string userName, string password, int securityLevel)
    {
        UserName = userName;
        Password = password;
        SecurityLevel = securityLevel;
    }
}
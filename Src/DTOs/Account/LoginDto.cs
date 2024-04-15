using System.ComponentModel.DataAnnotations;
using courses_dotnet_api.Src.Controllers;
using courses_dotnet_api.Src.Interfaces;

namespace courses_dotnet_api.Src.DTOs.Account;


public class AccountController : BaseApiController{
    private readonly IUserRepository _userRepository;
    private readonly IAccountRepository _accountRepository;

    public AccountController(IUserRepository userRepository, IAccountRepository accountRepository)
    {
        _userRepository = userRepository;
        _accountRepository = accountRepository;
    }
public class LoginDto
{
    [EmailAddress]
    public required string Email { get; set; }

    [StringLength(
        20,
        MinimumLength = 8,
        ErrorMessage = "Password must be between 8 and 20 characters"
    )]
    public required string Password { get; set; }
}
}




namespace Ecomerce.Server;
[Route("[controller]")]
[ApiController]


public class UsersController : BaseUserController<User>
{
    public UsersController(IUserUnit unit) : base(unit)
    {
    }
}


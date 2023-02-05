namespace Ecomerce.Server;
[Route("[controller]")]
[ApiController]


public class UsersController : BaseSettingController<User>
{
    public UsersController(IUserUnit unit) : base(unit)
    {
    }
}


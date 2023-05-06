namespace Ecomerce.Server;
[Route("[controller]")]
[ApiController]


public class ManagersController : BaseUserController<Manager>
{
    public ManagersController(IManagerUnit unit) : base(unit)
    {
    }
}

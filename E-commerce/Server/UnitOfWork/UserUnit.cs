namespace Ecommerce.Server;

public class UserUnit : BaseUserUnit<User>, IUserUnit
{
    public UserUnit(IUserRepository repository) : base(repository)
    {
    }
}

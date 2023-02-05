namespace Ecommerce.Server;

public class UserUnit : BaseSettingUnit<User>, IUserUnit
{
    public UserUnit(IUserRepository repository) : base(repository)
    {
    }
}

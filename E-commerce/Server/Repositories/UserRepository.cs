namespace Ecommerce.Server;

public class UserRepository : BaseSettingRepository<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext context) : base(context)
    {
    }
}

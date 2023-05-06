namespace Ecommerce.Server;

public class UserRepository : BaseUserRepository<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext context) : base(context)
    {
    }
}

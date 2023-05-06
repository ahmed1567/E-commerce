namespace Ecommerce.Server;

public class ManagerRepository : BaseUserRepository<Manager>, IManagerRepository
{
    public ManagerRepository(ApplicationDbContext context) : base(context)
    {
    }
}
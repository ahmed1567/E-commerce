namespace Ecommerce.Server;

public class UserConfiguration : BaseUserConfiguration<User>,IEntityTypeConfiguration<User>
{
    public new virtual void Configure(EntityTypeBuilder<User> builder)
    {


        base.Configure(builder);
    }
}

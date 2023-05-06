namespace Ecommerce.Server;

public class ManagerConfiguration :BaseUserConfiguration<Manager>,  IEntityTypeConfiguration<Manager>
{
    public new void Configure(EntityTypeBuilder<Manager> builder)
    {
        builder.Property(M=>M.IsManager).HasDefaultValue(false);
        base.Configure(builder);
    }
}

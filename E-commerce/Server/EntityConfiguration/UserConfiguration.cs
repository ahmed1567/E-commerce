namespace Ecommerce.Server;

public class UserConfiguration : BaseSettingConfiguration<User>,IEntityTypeConfiguration<User>
{
    public new virtual void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(u => u.Mobile).HasMaxLength(11).IsRequired();
        builder.Property(u => u.Email).HasMaxLength(30).IsRequired();
        builder.Property(u => u.Password).IsRequired();
        builder.Property(u => u.Address).IsRequired();

        base.Configure(builder);
    }
}

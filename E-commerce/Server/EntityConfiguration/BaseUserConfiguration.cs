namespace Ecommerce.Server;

public class BaseUserConfiguration<TEntity> :BaseSettingConfiguration<TEntity>, IEntityTypeConfiguration<TEntity>
    where TEntity : BaseUser
{
    public new void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.Property(u => u.Mobile).HasMaxLength(11).IsRequired();
        builder.HasIndex(C => C.Email).IsUnique();
        builder.Property(u => u.Email).HasMaxLength(30).IsRequired();
        builder.Property(u => u.Password).IsRequired();
        builder.Property(u => u.Address).IsRequired();

        base.Configure(builder);
    }
}

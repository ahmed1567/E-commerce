namespace Ecommerce.Server;

public class BaseSettingConfiguration<TEntity> : BaseConfiguration<TEntity>, IEntityTypeConfiguration<TEntity>
    where TEntity : BaseSettingEntity
{
    public new virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.Property(e => e.Name).IsRequired();
        builder.Property(e => e.Name).HasMaxLength(100);
        base.Configure(builder);

    }
}

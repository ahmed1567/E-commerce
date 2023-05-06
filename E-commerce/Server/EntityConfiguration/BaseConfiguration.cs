namespace Ecommerce.Server;

public class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
    where TEntity : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.Property(e => e.Id).IsRequired();
        builder.Property(e=>e.Id).HasValueGenerator<GuidValueGenerator>();
    }
}

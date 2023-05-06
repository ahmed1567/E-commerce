namespace Ecommerce.Server;

public class CategoryConfiguration:BaseSettingConfiguration<Category>,IEntityTypeConfiguration<Category>
{
    public new virtual void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasIndex(C => C.Name).IsUnique();
        base.Configure(builder);
    }
}

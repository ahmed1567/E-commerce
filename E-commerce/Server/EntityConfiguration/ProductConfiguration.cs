namespace Ecommerce.Server;

public class ProductConfiguration:BaseSettingConfiguration<Product> ,IEntityTypeConfiguration<Product>
{
    public new virtual void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(p => p.Description).IsRequired().HasMaxLength(150).HasColumnName("Description");
        builder.Property(p => p.Image).IsRequired().HasMaxLength(50);
       
        base.Configure(builder);
    }
}

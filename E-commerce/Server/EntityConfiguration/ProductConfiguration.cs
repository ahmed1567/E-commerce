namespace Ecommerce.Server;

public class ProductConfiguration:BaseSettingConfiguration<Product> ,IEntityTypeConfiguration<Product>
{
    public new virtual void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(p => p.Description).IsRequired().HasMaxLength(150).HasColumnName("Description");
        builder.Property(p => p.Image).IsRequired().HasMaxLength(50);
        builder.Property(P=>P.Quantity).IsRequired().HasMaxLength(10).HasDefaultValue(0);
        builder.Property(P=>P.Price).IsRequired();

        builder.HasOne(P=>P.SubCategory).WithMany(SB=>SB.Products).HasForeignKey(P=>P.SubCategoryId);
        builder.HasOne(P=>P.Vendor).WithMany(V=>V.Products).HasForeignKey(P=>P.VendorId);
        base.Configure(builder);
    }
}

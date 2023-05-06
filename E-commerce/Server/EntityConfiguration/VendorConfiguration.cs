namespace Ecommerce.Server;

public class VendorConfiguration : BaseUserConfiguration<Vendor>, IEntityTypeConfiguration<Vendor>
{
    public new void Configure(EntityTypeBuilder<Vendor> builder)
    {
        builder.Property(V => V.TaxNumber).IsRequired();
        base.Configure(builder);
    }
}

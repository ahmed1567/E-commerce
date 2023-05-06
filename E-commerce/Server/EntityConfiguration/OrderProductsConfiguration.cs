namespace Ecommerce.Server;

public class OrderProductsConfiguration : IEntityTypeConfiguration<OrderProduct>
{
    public void Configure(EntityTypeBuilder<OrderProduct> builder)
    {
        builder.HasKey(R => new { R.ProductId, R.OrderId });

        builder.Property(OP => OP.ProductId).IsRequired();
        builder.Property(OP=>OP.OrderId).IsRequired();

        builder.HasOne(OP=>OP.Product).WithMany(P=>P.OrderProducts).HasForeignKey(OP=>OP.ProductId);
        builder.HasOne(OP=>OP.Order).WithMany(O=>O.OrderProducts).HasForeignKey(O=>O.OrderId);
    }
}

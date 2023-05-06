namespace Ecommerce.Server;

public class OrderConfiguration :BaseConfiguration<Order> , IEntityTypeConfiguration<Order>
{
    public new void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.Ignore(O => O.Total);

        builder.HasOne(O => O.User).WithMany(U => U.Orders).HasForeignKey(O => O.UserId);
        base.Configure(builder);
    } 
}

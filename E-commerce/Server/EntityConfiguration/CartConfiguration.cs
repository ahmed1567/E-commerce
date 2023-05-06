namespace Ecommerce.Server;

public class CartConfiguration:IEntityTypeConfiguration<Cart>
{
    public  void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.HasKey(R => new { R.ProductId, R.UserId });

        builder.Property(C=>C.UserId).IsRequired();
        builder.Property(C=>C.ProductId).IsRequired();

        builder.HasOne(C => C.Product).WithMany(P => P.Carts).HasForeignKey(C => C.ProductId);
        builder.HasOne(C => C.User).WithMany(P => P.Carts).HasForeignKey(C => C.UserId);


    }
}

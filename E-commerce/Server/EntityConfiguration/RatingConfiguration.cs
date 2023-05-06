namespace Ecommerce.Server;

public class RatingConfiguration : IEntityTypeConfiguration<Rating>
{
    public void Configure(EntityTypeBuilder<Rating> builder)
    {
        builder.HasKey(R => new { R.ProductId, R.UserId });

        builder.HasOne(R=>R.Product).WithMany(P=>P.Ratings).HasForeignKey(R => R.ProductId);

        builder.HasOne(R=>R.User).WithMany(U=>U.Ratings).HasForeignKey(R => R.UserId);
    }
}

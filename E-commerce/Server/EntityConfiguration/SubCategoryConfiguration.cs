namespace Ecommerce.Server;

public class SubCategoryConfiguration : BaseSettingConfiguration<SubCategory>, IEntityTypeConfiguration<SubCategory>
{
    public new void Configure(EntityTypeBuilder<SubCategory> builder)
    {
        builder.HasOne(SB => SB.Category).WithMany(C => C.SubCategories).HasForeignKey(SB => SB.CategoryId);
        
        base.Configure(builder);
    }
}

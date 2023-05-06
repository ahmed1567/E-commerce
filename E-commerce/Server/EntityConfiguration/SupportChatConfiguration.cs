namespace Ecommerce.Server;

public class SupportChatConfiguration :BaseConfiguration<SupportChat>, IEntityTypeConfiguration<SupportChat>
{
    public new void Configure(EntityTypeBuilder<SupportChat> builder)
    {
        builder.Property(SC=>SC.UserId).IsRequired();
        builder.Property(SC=>SC.ManagerId).IsRequired();

        builder.HasOne(SC => SC.User).WithMany(U => U.SupportChats).HasForeignKey(SC => SC.UserId);
        builder.HasOne(SC => SC.Manager).WithMany(M => M.SupportChats).HasForeignKey(SC => SC.ManagerId);
        base.Configure(builder);
    }
}

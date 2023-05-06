namespace Ecommerce.Server;

public class MessagesConfiguration :BaseConfiguration<Message>, IEntityTypeConfiguration<Message>
{
    public new void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.Property(M=>M.Content).IsRequired();
        builder.HasOne(M => M.SupportChat).WithMany(SC => SC.Messages).HasForeignKey(M => M.SupportChatId);
        base.Configure(builder);
    }
}

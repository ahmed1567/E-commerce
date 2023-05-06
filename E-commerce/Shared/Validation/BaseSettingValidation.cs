namespace Ecommerce.Shared;
public class BaseSettingValidation<TEntity>:BaseValidation<TEntity>
    where TEntity : BaseSettingEntity
{
    public BaseSettingValidation()
    {
        RuleFor(e => e.Name).NotEmpty().WithMessage("YOU MUST ENTER NAME");
    }
}

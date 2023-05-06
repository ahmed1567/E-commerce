namespace Ecommerce.Shared;

public class BaseValidation<TEntity>:AbstractValidator<TEntity>, IValidator<TEntity>
    where TEntity : BaseEntity
{

}

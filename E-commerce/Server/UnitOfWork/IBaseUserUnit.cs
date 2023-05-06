namespace Ecommerce.Server;

public interface IBaseUserUnit<TEntity>:IBaseSettingUnit<TEntity>
    where TEntity : BaseUser
{
}

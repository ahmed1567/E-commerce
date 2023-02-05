namespace Ecommerce.Server;

public class ProductUnit : BaseSettingUnit<Product>, IProductUnit
{
    public ProductUnit(IProductRepository repository) : base(repository)
    {
    }
}

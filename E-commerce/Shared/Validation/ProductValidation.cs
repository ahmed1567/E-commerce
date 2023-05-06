namespace Ecommerce.Shared;
public class ProductValidation : BaseSettingValidation<Product>
{
    public ProductValidation()
    {
        RuleFor(p => p.Price).NotEmpty().GreaterThan(2).WithMessage("PRODUCT PRICE MUST BE GREATER THAN 2");
        RuleFor(p => p.Description).Must(p => p != null && p.Length <= 200).WithMessage("DESCRIPTION MUST BE LESS THAN 200 CHARACTER ");
        RuleFor(p => p.Image).NotEmpty().WithMessage("PRODUCT IMAGE REQUIRED");
        RuleFor(p => p.Quantity).Must(p => p != 0).WithMessage("YOUR PRODUCT QUANTITY MUST BE MORE THAN 0");
        RuleFor(p => p.Quantity).LessThan(1000).WithMessage("PRODUCT QUANTITY MUST BE LESS THAN 1000");
        
    }
}


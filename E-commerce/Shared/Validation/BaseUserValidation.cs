namespace Ecommerce.Shared;
public class BaseUserValidation<TEntity> : BaseSettingValidation<TEntity>
    where TEntity : BaseUser
{
    public BaseUserValidation()
    {
        RuleFor(U => U.Email).EmailAddress().NotEmpty().WithMessage("Please Enter Your Email");
        RuleFor(U=>U.Address).NotEmpty().WithMessage("Please Enter Your Address");
        RuleFor(U=>U.Password).NotEmpty().WithMessage("Please Enter Your Password");
        RuleFor(U => U.Mobile).Must(U => U != null && U.Length ==11).WithMessage("Please Enter A Valid Number");

    }
}


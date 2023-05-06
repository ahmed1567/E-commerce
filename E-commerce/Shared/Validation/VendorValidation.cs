namespace Ecommerce.Shared;

public class VendorValidation:BaseUserValidation<Vendor>
{
	public VendorValidation()
	{
		RuleFor(V=>V.TaxNumber).Must(V => V != null && V.Length ==9).WithMessage(" Please Enter Valid TaxNumber");
    }
}

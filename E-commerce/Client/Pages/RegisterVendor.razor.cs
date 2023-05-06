namespace E_commerce.Client.Pages;

public partial class RegisterVendor
{
    Vendor Vendor = new();


    private async Task HandleValidSubmit()
    {
        await _client.PostAsJsonAsync("Vendors", Vendor);
        _navigationManager.NavigateTo("/allproducts");

    }
}

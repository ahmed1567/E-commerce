namespace E_commerce.Client.Pages;

public partial class AddRole
{
    Manager Manager = new();


    private async Task HandleValidSubmit()
    {
        await _client.PostAsJsonAsync("Managers", Manager);
        _navigationManager.NavigateTo("/allproducts");

    }
}

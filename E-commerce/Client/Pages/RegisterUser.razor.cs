namespace E_commerce.Client.Pages;

public partial class RegisterUser
{
    User User = new();


    private async Task HandleValidSubmit()
    {
        await _client.PostAsJsonAsync("Users", User);
        _navigationManager.NavigateTo("/allproducts");

    }


}

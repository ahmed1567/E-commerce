//namespace E_commerce.Client.Pages;

//public partial class AddProduct
//{
//    Product product = new();
//    List<Category>? categories = new List<Category>();


//    private async Task HandleValidSubmit()
//    {
//        await _client.PostAsJsonAsync("Products", product);
//        _navigationManager.NavigateTo("/allproducts");

//    }

//    public async Task<List<Category>?> GetCategories() => await _client.GetFromJsonAsync<List<Category>>("Categories");
    
//    protected override async Task OnInitializedAsync()
//    {
//        categories = await GetCategories();
//    }
//}

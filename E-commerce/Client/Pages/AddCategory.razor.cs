//using Ecommerce.Shared;

//namespace E_commerce.Client.Pages;

//public partial class AddCategory
//{

//    Category category = new();
//    string exception = "";

//    private async Task HandleValidSubmit()
//    {
//        try
//        {
//            await _client.PostAsJsonAsync("Categories", category);
//            _navigationManager.NavigateTo("/allproducts");
//        }
//        catch(Exception ex) 
//        {
//            Console.WriteLine(ex.Message);
//           exception=ex.Message;
//        }  
//    }
//}

using System.Net.Http.Json;

namespace Asp_Document_Reader.Client.Services;

public class MenuItemService : IMenuItemService
{
    private readonly HttpClient _http;

    public MenuItemService(HttpClient http)
    {
        _http = http;
    }

    public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
    List<MenuItem> IMenuItemService.MenuItems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public MenuItem CreateNewMenuItem()
    {
        throw new NotImplementedException();
    }

    //public async Task GetCategories()
    //{
    //    var response = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Category");
    //    if (response != null && response.Data != null)
    //        Categories = response.Data;
    //}

    public async Task GetMenuItems()
    {
        var response = await _http.GetFromJsonAsync<ServiceResponse<List<MenuItem>>> ("/menuitem");
      
    }
}

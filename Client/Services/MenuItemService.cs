

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

    public async Task<List<MenuItem>?> GetMenuItems()
    {
        var result =
            await _http.GetFromJsonAsync<List<MenuItem>>("menuitem");


        return result;



    }


}

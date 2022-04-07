namespace Asp_Document_Reader.Client.Services;

public interface IMenuItemService
{
    List<MenuItem> MenuItems { get; set; }

    Task<List<MenuItem>?> GetMenuItems();
}

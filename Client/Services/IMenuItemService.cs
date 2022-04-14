namespace Asp_Document_Reader.Client.Services;

public interface IMenuItemService
{
    public List<MenuItem> MenuItems { get;}

   public Task<List<MenuItem>?> GetMenuItems();
}

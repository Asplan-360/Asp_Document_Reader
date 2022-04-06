namespace Asp_Document_Reader.Server.Services;

public interface IMenuItemService
{
    Task<ServiceResponse<List<MenuItem>>> GetMenuItems();

    

}

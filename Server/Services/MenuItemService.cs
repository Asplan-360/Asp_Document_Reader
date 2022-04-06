using Microsoft.EntityFrameworkCore;

namespace Asp_Document_Reader.Server.Services;

public class MenuItemService : IMenuItemService
{

    private readonly AppDbContext _context;

    public MenuItemService(AppDbContext context)
    {
        _context = context;
    }

   
    public async Task<ServiceResponse<List<MenuItem>>> GetMenuItems()
    {
        var menuItems = await _context.MenuItems.ToListAsync();

        return new ServiceResponse<List<MenuItem>>
        {
            Data = menuItems
        };
    }



}


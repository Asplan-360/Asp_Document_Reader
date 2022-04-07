using Microsoft.EntityFrameworkCore;

namespace Asp_Document_Reader.Server.Services;

public class MenuItemService : IMenuItemService
{

    private readonly AppDbContext _context;

    public MenuItemService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<MenuItem>?> GetMenuItems()
    {
        var lista = await _context.MenuItems.ToListAsync();
        return lista;       


    }
}



using Microsoft.AspNetCore.Mvc;

namespace Asp_Document_Reader.Server.Controllers;

[Route("[controller]")]
[ApiController]
public class MenuItemController : ControllerBase
{

    private readonly IMenuItemService _menuService;
    private readonly ILogger<IMenuItemService> _logger;


    public MenuItemController(IMenuItemService menuService, ILogger<IMenuItemService> logger)
    {
        _menuService = menuService;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<MenuItem>>>> GetMenuItems()
    {
        var result = await _menuService.GetMenuItems();
        return result;
    }

   
}
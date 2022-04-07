using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Asp_Document_Reader.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MenuItemController : ControllerBase
{

    private readonly IMenuItemService _menuItemService;
   

    public MenuItemController(IMenuItemService menuItemService)
    {
        _menuItemService = menuItemService;
        
    }


    // GET: api/<MenuItemController>
    [HttpGet]
    public async Task<ActionResult<List<MenuItem>>> GetMenuItems()
    {
        var List = await _menuItemService.GetMenuItems();
        return Ok(List);
    }

}

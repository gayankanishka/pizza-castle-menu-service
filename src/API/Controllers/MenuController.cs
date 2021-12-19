using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PizzaCastle.MenuService.Application.MenuCategories.Commands.AddMenuCategory;
using PizzaCastle.MenuService.Application.MenuCategories.Queries.GetMenuCategories;
using PizzaCastle.MenuService.Application.MenuItems.Queries.GetMenuItemById;
using PizzaCastle.MenuService.Application.MenuItems.Queries.GetMenuItems;
using PizzaCastle.MenuService.Application.MenuItems.Queries.GetMenuItemsByCategoryId;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.API.Controllers
{
    [Route("api/v1/menu")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public MenuController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        // TODO: complete required endpoints
        // add crud operations
        // add commands and queries
        
        // GET api/v1/menu/items
        [HttpGet]
        [Route("items")]
        [ProducesResponseType(typeof(IEnumerable<MenuItemDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllMenuItemsAsync(CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetMenuItemsQuery(),
                cancellationToken);
            return Ok(results);
        }
        
        // GET api/v1/menu/items/{id}
        [HttpGet]
        [Route("items/{id:guid}")]
        [ProducesResponseType(typeof(MenuItemDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetMenuItemAsync(Guid id, CancellationToken cancellationToken)
        {
            if (id == Guid.Empty || !ModelState.IsValid)
            {
                return BadRequest();
            }
            
            var result = await _mediator.Send(new GetMenuItemByIdQuery(id), cancellationToken);

            if (result == null)
            {
                return NotFound();
            }
            
            return Ok(result);
        }
        
        // GET api/v1/menu/categories/{categoryId}/items
        [HttpGet]
        [Route("categories/{categoryId:guid}/items")]
        [ProducesResponseType(typeof(IEnumerable<MenuItemDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetMenuItemsByCategoryAsync(Guid categoryId, CancellationToken cancellationToken)
        {
            if (categoryId == Guid.Empty || !ModelState.IsValid)
            {
                return BadRequest();
            }
            
            var results = await _mediator.Send(new GetMenuItemsByCategoryIdQuery(categoryId),
                cancellationToken);

            return Ok(results);
        }
        
        // GET api/v1/menu/categories
        [HttpGet]
        [Route("categories")]
        [ProducesResponseType(typeof(IEnumerable<MenuCategoryDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetMenuCategoriesAsync(CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetMenuCategoriesQuery(),
                cancellationToken);
            return Ok(results);
        }
        
        // POST api/v1/menu/categories
        [HttpPost]
        [Route("categories")]
        [ProducesResponseType(typeof(MenuCategoryDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> AddMenuCategoryAsync([FromBody] AddMenuCategoryDto addMenuCategoryDto,
            CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new AddMenuCategoryCommand(addMenuCategoryDto),
                cancellationToken);
            return Created(nameof(AddMenuCategoryAsync), results);
        }
    }
}
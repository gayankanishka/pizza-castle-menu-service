using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PizzaCastle.MenuService.Application.MenuItems.Queries.GetAllMenuItems;
using PizzaCastle.MenuService.Application.MenuItems.Queries.GetMenuItemById;
using PizzaCastle.MenuService.Application.MenuItems.Queries.GetMenuItemsByTypeId;
using PizzaCastle.MenuService.Application.MenuItemTypes.Queries.GetMenuItemTypes;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public MenuController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        // TODO: complete required endpoints
        // add required repositories
        // add crud operations
        // add commands and queries
        
        // GET api/v1/[controller]/items
        [HttpGet]
        [Route("items")]
        [ProducesResponseType(typeof(IEnumerable<MenuItemDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllMenuItemsAsync(CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetAllMenuItemsQuery(),
                cancellationToken);
            return Ok(results);
        }
        
        // GET api/v1/[controller]/items/{id}
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
        
        // GET api/v1/[controller]/types/{typeId}/items
        [HttpGet]
        [Route("types/{typeId:guid}/items")]
        [ProducesResponseType(typeof(IEnumerable<MenuItemDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetMenuItemsByTypeAsync(Guid typeId, CancellationToken cancellationToken)
        {
            if (typeId == Guid.Empty || !ModelState.IsValid)
            {
                return BadRequest();
            }
            
            var results = await _mediator.Send(new GetMenuItemsByTypeIdQuery(typeId),
                cancellationToken);

            return Ok(results);
        }
        
        // GET api/v1/[controller]/types
        [HttpGet]
        [Route("types")]
        [ProducesResponseType(typeof(IEnumerable<MenuItemTypeDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetMenuItemsTypesAsync(CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetMenuItemTypesQuery(),
                cancellationToken);
            return Ok(results);
        }
    }
}
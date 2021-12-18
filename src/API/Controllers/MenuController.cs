using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PizzaCastle.MenuService.Application.MenuItems.Queries.GetAllMenuItems;
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
        
        // GET api/v1/[controller]/items
        [HttpGet]
        [Route("items")]
        [ProducesResponseType(typeof(IEnumerable<MenuItemDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllMenuItemsAsync(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllMenuItemsQuery(), cancellationToken);
            return Ok(result);
        }
        
        [HttpGet]
        [Route("items/{id:guid}")]
        [ProducesResponseType(typeof(MenuItemDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult GetMenuItem(Guid id, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
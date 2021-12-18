using MediatR;
using Microsoft.AspNetCore.Mvc;
using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public MenuController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet]
        public IActionResult GetAllMenuItems()
        {
            return Ok(new Pizza());
        }
        
        [HttpGet("{id:guid}")]
        public IActionResult GetMenuItem(Guid id)
        {
            return Ok();
        }
    }
}
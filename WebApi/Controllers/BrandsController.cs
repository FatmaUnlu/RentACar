using Appplication.Features.Brands.Commands.Create;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {
        private readonly IMediator _mediator;

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBrandCommand createBrandCommand)
        {
           CreatedBrandResponse createdBrandResponse = await Mediator.Send(createBrandCommand);

            return Ok(createdBrandResponse);
        }
    }
}

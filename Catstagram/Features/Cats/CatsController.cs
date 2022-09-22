using Catstagram.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Catstagram.Features.Cats
{
    public class CatsController : ApiController
    {
        private readonly ICatsService catsService;

        public CatsController(ICatsService catsService)
        {
            this.catsService = catsService;
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateCatRequestModel model)
        {
            var userId = this.User.GetId();

            var catId = await this.catsService.Create(
                model.ImageUrl,
                model.Description,
                userId);

            return Created(nameof(this.Create), catId);
        }
    }
}


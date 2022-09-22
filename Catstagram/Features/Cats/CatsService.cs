using Catstagram.Data;
using Catstagram.Data.Models;

namespace Catstagram.Features.Cats
{
    public class CatsService : ICatsService
    {
        private readonly CatstagramDbContext dbContext;

        public CatsService(CatstagramDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> Create(string imageUrl, string description, string userId)
        {
            var cat = new Cat
            {
                Description = description,
                ImageUrl = imageUrl,
                UserId = userId
            };

            this.dbContext.Cats.Add(cat);
            await this.dbContext.SaveChangesAsync();

            return cat.Id;
        }
    }
}


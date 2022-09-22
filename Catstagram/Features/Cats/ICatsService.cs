using System;
namespace Catstagram.Features.Cats
{
    public interface ICatsService
    {
        public Task<int> Create(string imageUrl, string description, string userId);
    }
}


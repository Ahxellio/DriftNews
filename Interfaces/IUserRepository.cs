using DriftNews.Models;

namespace DriftNews.Interfaces
{
    public interface IUserRepository
    {
        public IQueryable<User> GetAll();
        public Task<bool> Create(User entity);
        public Task<User> Get(int id);
        public Task<User> Update(User entity);
        public Task<User> GetByName(string name);

    }
}

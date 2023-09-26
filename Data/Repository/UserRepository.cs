using DriftNews.Interfaces;
using DriftNews.Models;
using Microsoft.EntityFrameworkCore;

namespace DriftNews.Data.Repository
{
    public class UserRepository : IUserRepository   
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<User> GetAll()
        {
            return _context.Users;
        }
        public async Task<bool> Create(User entity)
        {
            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<User> Get(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<User> Update(User entity)
        {
            _context.Users.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<User> GetByName(string name)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Username == name);
        }
    }
}

using DataAccesLayer.Data;
using DataAccesLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccesLayer.Repositories;

public class UserRepository(AppDbContext dbContext) : IUserInterface
{
    private readonly AppDbContext _dbContext = dbContext;

    public async Task<List<User>> GetAllUsers()
    {
        var users = await _dbContext.Users.ToListAsync();
        return users;
    }

    public async Task<List<User>> GetOnlineUsers()
    {
        var onlineUsers = await _dbContext.Users.Where(i => i.IsOnline == true).ToListAsync();
        return onlineUsers;
    }
}

using DataAccesLayer.Data;
using DataAccesLayer.Models;
using DataAccesLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace DataAccesLayer.Repositories;

public class ClientRepository(AppDbContext dbContext) : IClientInterface
{
    private readonly AppDbContext _dbContext = dbContext;

    public async Task Create(int userId, DateTime created)
    {
        Client client = new Client() { UserId = userId, CreatedDate = created};
        client.User = null;
        await _dbContext.Clients.AddAsync(client);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var client = await _dbContext.Clients.FirstOrDefaultAsync(i => i.Id == id);
        _dbContext.Clients.Remove(client);
        await _dbContext.SaveChangesAsync();
    }

    public int CountAllClient(int userid)
    {
        var clients = _dbContext.Clients.AsNoTracking().Where(i => i.Id == userid).ToList();
        return clients.Count();
    }
}

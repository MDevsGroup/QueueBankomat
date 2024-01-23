using DataAccesLayer.Models;

namespace DataAccesLayer.Repository;

public interface IClientInterface
{
    int CountAllClient(int userId);
    Task Create(int userId, DateTime created);
    Task DeleteAsync(int id);
}

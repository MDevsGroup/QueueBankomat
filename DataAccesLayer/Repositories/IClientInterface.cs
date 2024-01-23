using DataAccesLayer.Models;

namespace DataAccesLayer.Repository;

public interface IClientInterface
{
    int CountAllClient(int userId);
    Task Create(DateTime created);
    Task DeleteAsync(int id);
}

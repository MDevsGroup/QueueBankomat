using DataAccesLayer.Models;

namespace DataAccesLayer.Repositories;

public interface IUserInterface
{
    Task<List<User>> GetAllUsers();
    Task<List<User>> GetOnlineUsers();
}

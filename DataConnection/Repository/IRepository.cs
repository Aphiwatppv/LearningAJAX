using DataConnection.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataConnection.Repository
{
    public interface IRepository
    {
        Task<string> AddUserToDbAsync(User user);
        Task<IEnumerable<User>> getAllUsersAsync();
        Task<User> getSingleUserAsync(int Id);
    }
}
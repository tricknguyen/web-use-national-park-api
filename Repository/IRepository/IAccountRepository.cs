using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_App.Models;

namespace Web_App.Repository.IRepository
{
    public interface IAccountRepository : IRepository<User>
    {
        Task<bool> RegisterAsync(string url, User obj);
        Task<User> LoginAsync(string url, User obj);
    }
}

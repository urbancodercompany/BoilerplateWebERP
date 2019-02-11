using System.Threading.Tasks;
using BoilerplateWebERP.API.Models;

namespace BoilerplateWebERP.API.Data
{
    //Connect to the repositry to check user auth
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
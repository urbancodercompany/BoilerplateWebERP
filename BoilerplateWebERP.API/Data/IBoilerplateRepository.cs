using System.Collections.Generic;
using System.Threading.Tasks;
using BoilerplateWebERP.API.Models;

namespace BoilerplateWebERP.API.Data
{
    public interface IBoilerplateRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
        Task<Photo> GetPhoto(int id);
        Task<Photo> GetMainPhotoForUser(int userId);
    }
}
using System.Threading.Tasks;
using DotNetCore_WebAPI.Models;

namespace DotNetCore_WebAPI.Data
{
    public class AuthRepository : IAuthRepository
    {
        public Task<ServiceResponse<string>> Login(string userName, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<int>> Register(User user, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UserExists(string userName)
        {
            throw new System.NotImplementedException();
        }
    }
}
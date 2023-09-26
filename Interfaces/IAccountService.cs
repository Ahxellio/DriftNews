using DriftNews.Data.Response;
using DriftNews.Models;
using DriftNews.Models.Infrastructure;
using System.Security.Claims;

namespace DriftNews.Interfaces
{
    public interface IAccountService
    {
        Task<BaseResponse<ClaimsIdentity>> Register(RegisterViewModel model);
        Task<BaseResponse<ClaimsIdentity>> Login(LoginViewModel model);
        ClaimsIdentity Authenticate(User user);
    }
}

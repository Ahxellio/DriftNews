using DriftNews.Data.Enum;
using DriftNews.Data.Repository;
using DriftNews.Data.Response;
using DriftNews.Helpers;
using DriftNews.Interfaces;
using DriftNews.Models;
using DriftNews.Models.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace DriftNews.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserRepository _userRepository;
        private readonly ILogger<AccountService>  _logger;
        public AccountService(UserRepository userRepository, ILogger<AccountService> logger) 
        {
            _userRepository = userRepository;
            _logger = logger;
        }   
        public async Task<BaseResponse<ClaimsIdentity>> Register(RegisterViewModel model)
        {
            try
            {
                var user = await _userRepository.GetAll().FirstOrDefaultAsync(x => x.Username  == model.Username);
                if (user != null) 
                {
                    return new BaseResponse<ClaimsIdentity>
                    {
                        Description = "Пользователь с таким логином уже имеется"
                    };
                }
                user = new User()
                {
                    Username = model.Username,
                    Name = model.Name,
                    Role = Role.User,
                    Password = HashPasswordHelper.HashPassword(model.Password)
                };
                await _userRepository.Create(user);
                var result  = Authenticate(user);
                return new BaseResponse<ClaimsIdentity>
                {
                    Data = result,
                    Description = "Пользователь создан",
                    StatusCode = StatusCode.OK,
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[Register]: {ex.Message}");
                return new BaseResponse<ClaimsIdentity>
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError,
                };
            }

        }
        public async Task<BaseResponse<ClaimsIdentity>> Login(LoginViewModel model)
        {
            try
            {
                var user = await _userRepository.GetAll().FirstOrDefaultAsync(x => x.Username == model.Username);
                if (user == null)
                {
                    return new BaseResponse<ClaimsIdentity>()
                    {
                        Description = "Пользователь не найден"
                    };
                }
                if (user.Password != HashPasswordHelper.HashPassword(model.Password))
                {
                    return new BaseResponse<ClaimsIdentity>()
                    {
                        Description = "Неверный пароль"
                    };

                }
                var result = Authenticate(user);
                return new BaseResponse<ClaimsIdentity> { Data = result, StatusCode = StatusCode.OK, };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[Login]: {ex.Message}");
                return new BaseResponse<ClaimsIdentity>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError,
                };
            }
        }

        public ClaimsIdentity Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Name),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.ToString())
            };
            return new ClaimsIdentity(claims, "ApplicationCookie",
                ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
        }
    }
}

using System.Threading.Tasks;
using FormsApp.Application.DTOs.User;

namespace FormsApp.Application.Contracts.Services
{
    public interface IAccountService
    {
        Task RegisterUser(UserLoginDto userLogin);
        Task<UserDto> Login(UserLoginDto userLogin);
    }
}
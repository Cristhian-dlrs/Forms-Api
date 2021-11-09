using FormsApp.Application.DTOs.Base;

namespace FormsApp.Application.DTOs.User
{
    public class UserDto : BaseDto, IUserDto
    {
        public string Email { get; set; }
    }
}
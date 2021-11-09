namespace FormsApp.Application.DTOs.User
{
    public class UserLoginDto : IUserDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
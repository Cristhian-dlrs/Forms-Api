using FluentValidation;
using FormsApp.Application.DTOs.User;

namespace FormsApp.Application.Validators.UserValidators
{
    public class UserDtoValidator : AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            Include(new BaseDtoValidator());
            Include(new IUserValidator());
        }
    }
}
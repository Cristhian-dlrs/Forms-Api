using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FormsApp.Application.Contracts.Persistence;
using FormsApp.Application.Contracts.Services;
using FormsApp.Application.DTOs.User;
using FormsApp.Application.Exceptions;
using FormsApp.Domain.Entities;

namespace FormsApp.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AccountService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task RegisterUser(UserLoginDto userLogin)
        {
            var users = await _unitOfWork.Users.GetAll();
            var user = _mapper.Map<User>(userLogin);

            if (users.Any(x => x.Email == userLogin.Email))
                throw new BusinessException("Email is already in use.");

            var result  = await _unitOfWork.Users.Add(user);
            await _unitOfWork.Save();
        }

        public async Task<UserDto> Login(UserLoginDto userLogin)
        {
            var users = await _unitOfWork.Users.GetAll();
            var user = _mapper.Map<User>(userLogin);
            var validUser =
                users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);
            
            if (validUser == null)
                throw new BusinessException("Invalid credentials.");
            
            var result = _mapper.Map<UserDto>(validUser);

            return result;
        }
    }
}
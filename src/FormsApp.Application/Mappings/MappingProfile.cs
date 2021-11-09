using AutoMapper;
using FormsApp.Application.DTOs.Answer;
using FormsApp.Application.DTOs.Form;
using FormsApp.Application.DTOs.Question;
using FormsApp.Application.DTOs.Respondant;
using FormsApp.Application.DTOs.User;
using FormsApp.Domain.Entities;

namespace FormsApp.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region User Mappings
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserLoginDto>().ReverseMap();
            #endregion

            #region Form Mappings
            CreateMap<Form, FormDto>().ReverseMap();
            CreateMap<Form, CreateFormDto>().ReverseMap();
            CreateMap<Form, UpdateFormDto>().ReverseMap();
            #endregion

            #region Question Mappings
            CreateMap<Question, QuestionDto>().ReverseMap();
            CreateMap<Question, CreateQuesitonDto>().ReverseMap();
            CreateMap<Question, UpdateQuestonDto>().ReverseMap();
            #endregion

            #region Answer Mappings
            CreateMap<Answer, AnswerDto>().ReverseMap();
            CreateMap<Answer, CreateAnswerDto>().ReverseMap();
            #endregion
            
            #region Respondant Mappings
            CreateMap<Respondant, RespondantDto>().ReverseMap();
            CreateMap<Respondant, CreateRespondantDto>().ReverseMap();
            #endregion
        }
    }
}
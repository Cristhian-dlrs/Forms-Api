using System;
using System.Reflection;
using FluentValidation.AspNetCore;
using FormsApp.Application.Contracts.Services;
using FormsApp.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using AccountService = FormsApp.Application.Services.AccountService;

namespace FormsApp.Application
{
    public static class ApplicationServicesRegistration
    {
        public static IServiceCollection RegisterApplicationServices(
            this IServiceCollection services)
        {
            services.AddFluentValidation(options =>
                options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
            
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IFormService, FormService>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IAnswerService, AnswerService>();
            services.AddScoped<IRespondantService, RespondantService>();

            return services;
        }
    }
}
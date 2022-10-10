using ETicaret.Application.Validations;
using ETicaret.Application.ViewModels;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationService(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            services.AddScoped<IValidator<UserRegisterViewModel>, UserRegisterViewModelValidator>();
            services.AddScoped<IValidator<UserLoginViewModel>, UserLoginViewModelValidator>();
        }
    }
}

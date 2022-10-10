using ETicaret.Application.Interfaces.IRepository;
using ETicaret.Application.Interfaces.IUnitOfWork;
using ETicaret.Domain.Entities;
using ETicaret.Persistence.Contexts;
using ETicaret.Persistence.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {

            
            services.AddDbContext<ETicaretContext>(
                options => options.UseSqlServer("name=ConnectionStrings:SqlConnection"));

            services.AddAuthentication();
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 6; //En az kaç karakterli olması gerektiği
                options.Password.RequireNonAlphanumeric = false; //Alfanumeric olma zorunluluğunu kaldırıldı
                options.Password.RequireUppercase = false; //Büyük harf zorunluluğu kaldırıldı
                options.Password.RequireLowercase = false; //Küçük harf zorunluluğu kaldırıldı
                options.Password.RequireDigit = false; // 0-9 arası sayısal karakter zorunluluğu kaldırıldı 
                options.User.RequireUniqueEmail = true; //Email adresleri tekilleştirildi
            }).AddEntityFrameworkStores<ETicaretContext>();

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                            .RequireAuthenticatedUser()
                            .Build();
                config.Filters.Add(new AuthorizeFilter(policy));

            });


            services.ConfigureApplicationCookie(opt =>
            {
                opt.LoginPath = "/Login/Index";
                opt.LogoutPath = "/Login/Logout";
                opt.Cookie = new CookieBuilder
                {
                    Name = "AspNetCoreIdentityREV",
                    HttpOnly = true, //client-side tarafından Cookie'ye erişmesini engellendi
                    SecurePolicy = CookieSecurePolicy.Always //Sadece Https üzerinden erişim yapılabilir
                };

                opt.SlidingExpiration = true;
                opt.ExpireTimeSpan = TimeSpan.FromMinutes(60); //CookieBuilder nesnesinde tanımlanan Expiration değerinin varsayılan değerlerle ezilme ihtimaline karşın tekrardan Cookie vadesi burada da belirtiliyor
            });


            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IUnitOfWork, ETicaret.Persistence.UnitOfWork.UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>)); ;
        }


    }
}

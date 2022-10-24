using ETicaret.Application.Interfaces.IRepository;
using ETicaret.Application.Interfaces.IUnitOfWork;
using ETicaret.Domain.Entities;
using ETicaret.Persistence.Context;
using ETicaret.Persistence.Repository;
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

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IUnitOfWork, ETicaret.Persistence.UnitOfWork.UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>)); ;

        }
    }
}







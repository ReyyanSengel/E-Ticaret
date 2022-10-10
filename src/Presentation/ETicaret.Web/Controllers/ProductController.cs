
using ETicaret.Application.Interfaces.IService;
using ETicaret.Application.ViewModels;
using ETicaret.Domain.Entities;
using ETicaret.Persistence.Contexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ETicaret.Web.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IProductService _productService;
       




        public ProductController(IProductService productService,  UserManager<AppUser> userManager )
        {
            _productService = productService;
            _userManager = userManager;
            
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.User = user.Name;

             var products =await  _productService.GetProductWithAll();
            return View(products);
        }

        [HttpGet]
        public  IActionResult GetProductWithDetails(int id)
        {
            var product =  _productService.GetProductId(id);
            return View(product);
        }

       
        //[HttpGet]
        //public IActionResult AddComment()
        //{
            
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult AddComment()
        //{
        //    var addcomment=_productService.
        //    return View();
        //}





















    }
}

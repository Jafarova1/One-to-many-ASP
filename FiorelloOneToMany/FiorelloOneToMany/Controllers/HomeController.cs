using FiorelloOneToMany.Data;
using FiorelloOneToMany.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FiorelloOneToMany.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context= context;
        }


        public async Task<IActionResult> Index()
        {
            var data=_context.Blogs.ToList(); 
        

            return View();
        }
      
        
   
    }
}
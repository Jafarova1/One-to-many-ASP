using FrontendBackend.Data;
using FrontendBackend.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using FrontendBackend.Models;


namespace FrontendBackend.Controllers
{
    public class ProjectController : Controller
    {

        private readonly AppDbContext _context;

        public ProjectController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            if (id == null) return BadRequest();

            Projects project = await _context.Projects.Include(m=>m.Image).Where(m => !m.SoftDelete).FirstOrDefaultAsync();


            if (project is null) return NotFound();


            ProjectDetailVM model = new()
            {
              
                Id=project.Id,
                Title=project.Title,
                Description=project.Description,
                Image=project.Image,

               
               
                


            };
            return View(model);
        }
    }
}

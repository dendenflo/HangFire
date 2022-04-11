using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PublicacionesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PublicacionesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TBM_PUBLI>> MyMethod()
        {
            var model = await _context.TBM_PUBLI.ToListAsync();
            return model;
        }

        public IActionResult Index()
        {
            var model = _context.TBM_PUBLI.ToList();
            return View(model);
        }
    }
}
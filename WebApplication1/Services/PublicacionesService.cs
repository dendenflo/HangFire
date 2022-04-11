using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class PublicacionesService : IPublicacionesService
    {
        private readonly ApplicationDbContext _context;

        public PublicacionesService(ApplicationDbContext context)
        {
            _context = context;
        }

        //public Task<List<TBM_PUBLI>> MyMethod()
        //{
        //    var model = _context.TBM_PUBLI.ToList();
        //    return model;
        //}

        public async Task<List<TBM_PUBLI>> MyMethod()
        {
            var model = await _context.TBM_PUBLI.ToListAsync();

            var registro = new TBM_PUBLI();
            registro.COD_USUAR_REGIS = "prueba";
            _context.Add(registro);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
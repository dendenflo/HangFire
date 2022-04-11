using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IPublicacionesService
    {
        public Task<List<TBM_PUBLI>> MyMethod();
    }
}
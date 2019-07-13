using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ABMVuelos.Modelos;
using ABMVuelos.Models;

namespace ABMVuelos.Pages.Vuelos
{
    public class IndexModel : PageModel
    {
        private readonly ABMVuelos.Models.ABMVuelosContext _context;

        public IndexModel(ABMVuelos.Models.ABMVuelosContext context)
        {
            _context = context;
        }

        public IList<Vuelo> Vuelo { get;set; }

        public async Task OnGetAsync()
        {
            Vuelo = await _context.Vuelo.ToListAsync();
        }
    }
}

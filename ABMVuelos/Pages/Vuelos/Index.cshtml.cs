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

        // Para seguridad y evitar posibles cadenas malintencionadas
        [BindProperty(SupportsGet = true)]
        public string CodigoABuscar { get; set; }
        
        public async Task OnGetAsync()
        {
            var vuelos = from v in _context.Vuelo select v;
            if (!string.IsNullOrEmpty(CodigoABuscar))
            {
                vuelos = vuelos.Where(s => s.Codigo.Contains(CodigoABuscar)); //SQL LIKE
            }
            Vuelo = await vuelos.ToListAsync();
        }
    }
}

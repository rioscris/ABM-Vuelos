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
    public class DetailsModel : PageModel
    {
        private readonly ABMVuelos.Models.ABMVuelosContext _context;

        public DetailsModel(ABMVuelos.Models.ABMVuelosContext context)
        {
            _context = context;
        }

        public Vuelo Vuelo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vuelo = await _context.Vuelo.FirstOrDefaultAsync(m => m.ID == id);

            if (Vuelo == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

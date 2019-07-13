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
    public class DeleteModel : PageModel
    {
        private readonly ABMVuelos.Models.ABMVuelosContext _context;

        public DeleteModel(ABMVuelos.Models.ABMVuelosContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vuelo = await _context.Vuelo.FindAsync(id);

            if (Vuelo != null)
            {
                _context.Vuelo.Remove(Vuelo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

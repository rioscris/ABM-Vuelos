using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ABMVuelos.Modelos;
using ABMVuelos.Models;

namespace ABMVuelos.Pages.Vuelos
{
    public class EditModel : PageModel
    {
        private readonly ABMVuelos.Models.ABMVuelosContext _context;

        public EditModel(ABMVuelos.Models.ABMVuelosContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Vuelo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VueloExists(Vuelo.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool VueloExists(int id)
        {
            return _context.Vuelo.Any(e => e.ID == id);
        }
    }
}

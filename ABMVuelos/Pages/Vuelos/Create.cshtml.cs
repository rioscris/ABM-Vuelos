using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ABMVuelos.Modelos;
using ABMVuelos.Models;

namespace ABMVuelos.Pages.Vuelos
{
    public class CreateModel : PageModel
    {
        private readonly ABMVuelos.Models.ABMVuelosContext _context;

        public CreateModel(ABMVuelos.Models.ABMVuelosContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Vuelo Vuelo { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Vuelo.Add(Vuelo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
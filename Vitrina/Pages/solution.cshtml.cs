using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vitrina.Data;
using Vitrina.Models;

namespace Vitrina.Pages
{
    public class ADDTHEREQModel : PageModel
    {
        private readonly Vitrina.Data.VitrinaContext _context;

        public ADDTHEREQModel(Vitrina.Data.VitrinaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public StartupRequest StartupRequest { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            StartupRequest.Status = 0;
            if (!ModelState.IsValid)
            {
                return Page();
            }
            StartupRequest.Status = 0;
            _context.StartupRequest.Add(StartupRequest);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

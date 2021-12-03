using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vitrina.Data;
using Vitrina.Models;

namespace Vitrina.Pages.Requests
{
    public class DeleteModel : PageModel
    {
        private readonly Vitrina.Data.VitrinaContext _context;

        public DeleteModel(Vitrina.Data.VitrinaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StartupRequest StartupRequest { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StartupRequest = await _context.StartupRequest.FirstOrDefaultAsync(m => m.ID == id);

            if (StartupRequest == null)
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

            StartupRequest = await _context.StartupRequest.FindAsync(id);

            if (StartupRequest != null)
            {
                _context.StartupRequest.Remove(StartupRequest);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

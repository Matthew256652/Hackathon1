using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vitrina.Data;
using Vitrina.Models;

namespace Vitrina.Pages.Startups
{
    public class DeleteModel : PageModel
    {
        private readonly Vitrina.Data.VitrinaContext _context;

        public DeleteModel(Vitrina.Data.VitrinaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SingleStartup SingleStartup { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SingleStartup = await _context.SingleStartup.FirstOrDefaultAsync(m => m.ID == id);

            if (SingleStartup == null)
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

            SingleStartup = await _context.SingleStartup.FindAsync(id);

            if (SingleStartup != null)
            {
                _context.SingleStartup.Remove(SingleStartup);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

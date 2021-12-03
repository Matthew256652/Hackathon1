using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vitrina.Data;
using Vitrina.Models;

namespace Vitrina.Pages.Startups2
{
    public class EditModel : PageModel
    {
        private readonly Vitrina.Data.VitrinaContext _context;

        public EditModel(Vitrina.Data.VitrinaContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SingleStartup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleStartupExists(SingleStartup.ID))
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

        private bool SingleStartupExists(int id)
        {
            return _context.SingleStartup.Any(e => e.ID == id);
        }
    }
}

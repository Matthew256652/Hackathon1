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

namespace Vitrina.Pages.AdminPages
{
    public class EditModel : PageModel
    {
        private readonly Vitrina.Data.VitrinaContext _context;

        public EditModel(Vitrina.Data.VitrinaContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(StartupRequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StartupRequestExists(StartupRequest.ID))
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

        private bool StartupRequestExists(int id)
        {
            return _context.StartupRequest.Any(e => e.ID == id);
        }
    }
}

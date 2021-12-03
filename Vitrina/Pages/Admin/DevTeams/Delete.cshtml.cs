using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vitrina.Data;
using Vitrina.Models;

namespace Vitrina.Pages.Admin.DevTeams
{
    public class DeleteModel : PageModel
    {
        private readonly Vitrina.Data.VitrinaContext _context;

        public DeleteModel(Vitrina.Data.VitrinaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DevTeam DevTeam { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DevTeam = await _context.DevTeam.FirstOrDefaultAsync(m => m.ID == id);

            if (DevTeam == null)
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

            DevTeam = await _context.DevTeam.FindAsync(id);

            if (DevTeam != null)
            {
                _context.DevTeam.Remove(DevTeam);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

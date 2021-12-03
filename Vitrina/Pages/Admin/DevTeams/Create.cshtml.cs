using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vitrina.Data;
using Vitrina.Models;

namespace Vitrina.Pages.Admin.DevTeams
{
    public class CreateModel : PageModel
    {
        private readonly Vitrina.Data.VitrinaContext _context;

        public CreateModel(Vitrina.Data.VitrinaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DevTeam DevTeam { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DevTeam.Add(DevTeam);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

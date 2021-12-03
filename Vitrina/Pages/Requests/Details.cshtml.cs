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
    public class DetailsModel : PageModel
    {
        private readonly Vitrina.Data.VitrinaContext _context;

        public DetailsModel(Vitrina.Data.VitrinaContext context)
        {
            _context = context;
        }

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
    }
}

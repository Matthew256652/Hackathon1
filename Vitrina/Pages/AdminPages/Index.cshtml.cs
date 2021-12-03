using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vitrina.Data;
using Vitrina.Models;

namespace Vitrina.Pages.AdminPages
{
    public class IndexModel : PageModel
    {
        private readonly Vitrina.Data.VitrinaContext _context;

        public IndexModel(Vitrina.Data.VitrinaContext context)
        {
            _context = context;
        }

        public IList<StartupRequest> StartupRequest { get;set; }

        public async Task OnGetAsync()
        {
            StartupRequest = await _context.StartupRequest.ToListAsync();
        }
    }
}

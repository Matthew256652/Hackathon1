using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vitrina.Data;
using Vitrina.Models;

namespace Vitrina.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Vitrina.Data.VitrinaContext _context;

        public IndexModel(Vitrina.Data.VitrinaContext context)
        {
            _context = context;
        }

        public IList<SingleStartup> SingleStartup { get;set; }

        public async Task OnGetAsync()
        {
            SingleStartup = await _context.SingleStartup.ToListAsync();
        }
    }
}

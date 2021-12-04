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
    public class AllDevTeamsModel : PageModel
    {
        private readonly Vitrina.Data.VitrinaContext _context;

        public AllDevTeamsModel(Vitrina.Data.VitrinaContext context)
        {
            _context = context;
        }

        public IList<DevTeam> DevTeam { get;set; }

        public async Task OnGetAsync()
        {
            DevTeam = await _context.DevTeam.ToListAsync();
        }
    }
}

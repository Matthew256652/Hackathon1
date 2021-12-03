using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vitrina.Models;

namespace Vitrina.Data
{
    public class VitrinaContext : DbContext
    {
        public VitrinaContext (DbContextOptions<VitrinaContext> options)
            : base(options)
        {
        }

        public DbSet<Vitrina.Models.SingleStartup> SingleStartup { get; set; }

        public DbSet<Vitrina.Models.StartupRequest> StartupRequest { get; set; }

        public DbSet<Vitrina.Models.DevTeam> DevTeam { get; set; }
    }
}

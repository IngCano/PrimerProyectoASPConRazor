#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrimerProyectoASPConRazor.Models;

namespace PrimerProyectoASPConRazor.Data
{
    public class PrimerProyectoASPConRazorContext : DbContext
    {
        public PrimerProyectoASPConRazorContext (DbContextOptions<PrimerProyectoASPConRazorContext> options)
            : base(options)
        {
        }

        public DbSet<PrimerProyectoASPConRazor.Models.Movie> Movie { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ABMVuelos.Modelos;

namespace ABMVuelos.Models
{
    public class ABMVuelosContext : DbContext
    {
        public ABMVuelosContext (DbContextOptions<ABMVuelosContext> options)
            : base(options)
        {
        }

        public DbSet<ABMVuelos.Modelos.Vuelo> Vuelo { get; set; }
    }
}

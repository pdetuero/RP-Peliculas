using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Modelos;

namespace RP_Peliculas.Data
{
    public class RP_PeliculasContext : DbContext
    {
        public RP_PeliculasContext (DbContextOptions<RP_PeliculasContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Modelos.Pelicula> Pelicula { get; set; }
    }
}

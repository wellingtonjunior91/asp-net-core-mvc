using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebMvc.Models
{
    public class WebMvcContext : DbContext
    {
        public WebMvcContext (DbContextOptions<WebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedores> Vendedores { get; set; }
        public DbSet<RegistroDeVendas> RegistroDeVendas { get; set; }
    }
}

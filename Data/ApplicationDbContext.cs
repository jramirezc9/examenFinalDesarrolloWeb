using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenFinal.Models;

namespace ExamenFinal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Proveedor> Proveedor { get; set; }

        public DbSet<Producto> Producto { get; set; }

        public DbSet<Bodega> Bodega { get; set; }
    }
}

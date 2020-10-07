using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MariaParcial1_AP2.Models;

namespace MariaParcial1_AP2.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=DATA\PrimerParcial.db");
        }

        
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MateoJijon1_Ejercicio.Models;

namespace MateoJijon1_Ejercicio.Data
{
    public class MateoJijon1_EjercicioContext : DbContext
    {
        public MateoJijon1_EjercicioContext (DbContextOptions<MateoJijon1_EjercicioContext> options)
            : base(options)
        {
        }

        public DbSet<MateoJijon1_Ejercicio.Models.Burger> Burger { get; set; } = default!;
    }
}

using Microsoft.EntityFrameworkCore;
using WebApiEmpleado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiEmpleado.Helpers
{
    public class Datos : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; } //Tabla categoria de la base de datos

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string Conexion = @"Server = surtidorvelarde.database.windows.net;
                                Database = surtidorvelardedb; 
                                User = admindb; 
                                Password =luis1598*;";
            /*@"Server = surtidor.database.windows.net;
               Database = surtidordb;
               User = admindb;
               Password = 12AB34cd*;";*/ // Servidor Maestro Beltran
            optionsBuilder.UseSqlServer(Conexion);
        }
    }
}

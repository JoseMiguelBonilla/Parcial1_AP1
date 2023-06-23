using System;
using Prueba2.Models;
using Microsoft.EntityFrameworkCore;

namespace Prueba2.DAL
{
    public class Contexto : DbContext 
    {
        public DbSet<Prestamos> Prestamos { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options){}
    }
}
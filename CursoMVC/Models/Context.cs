﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(@"Server=(localdb)\DESKTOP-PT1KMTO\SQLEXPRESS;Database=CursoMVC;Integrated Security=True");
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-PT1KMTO\SQLEXPRESS;Initial Catalog=CursoMVC;Integrated Security=True");
        }
    }
}
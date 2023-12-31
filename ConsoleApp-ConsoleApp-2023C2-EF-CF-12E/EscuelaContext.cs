﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_ConsoleApp_2023C2_EF_CF_12E
{
    class EscuelaContext : DbContext
    {
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Curso> Curso { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
            optionsBuilder.UseSqlServer(@"Server=A-PROFH-360;Database=Escuela2023C212E;Trusted_Connection=True;"); }
    }
}

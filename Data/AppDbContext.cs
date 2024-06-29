﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Decision_Analisis.Models;

namespace Decision_Analisis.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<NPVResult> NPVResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=npvcalculator.db");
        }
    }
}

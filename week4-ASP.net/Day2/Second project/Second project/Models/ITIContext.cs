﻿using Microsoft.EntityFrameworkCore;

namespace Second_project.Models
{
    public class ITIContext:DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8RMR47N\\MSSQLSERVER01;Database=SP1;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

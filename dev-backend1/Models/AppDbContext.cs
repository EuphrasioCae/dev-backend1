﻿using Microsoft.EntityFrameworkCore;

namespace dev_backend1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
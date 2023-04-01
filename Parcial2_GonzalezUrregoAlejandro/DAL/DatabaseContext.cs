using System;
using Parcial2_GonzalezUrregoAlejandro.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Parcial2_GonzalezUrregoAlejandro.DAL
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
		{
		}

        public DbSet<Ticket> Tickets { get; set; }
    }
}


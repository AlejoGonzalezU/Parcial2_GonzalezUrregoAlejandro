using System;
using Parcial2_GonzalezUrregoAlejandro.DAL.Entities;

namespace Parcial2_GonzalezUrregoAlejandro.DAL
{
	public class SeederDb
	{
        #region Constructor

        private readonly DatabaseContext _context;

        public SeederDb(DatabaseContext context)
		{
            _context = context;
        }

        #endregion

        public async Task SeederAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await PopulateTasksAsync();
        }

        private async Task PopulateTasksAsync()
        {
            if (!_context.Tickets.Any())
            {
                for (int i = 1; i <= 500; i++)
                {
                    _context.Tickets.Add(new Ticket { CreatedDate = DateTime.Now, IsUsed = false });
                }
            }
            await _context.SaveChangesAsync();
        }
    }
}

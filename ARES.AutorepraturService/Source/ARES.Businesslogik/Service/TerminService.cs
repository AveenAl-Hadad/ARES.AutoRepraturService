using ARES.Businesslogik.Interface;
using ARES.Businesslogik.Models;
using ARES.WebApi.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARES.Businesslogik.Service
{
    public class TerminService : ITerminService
    {
        private readonly AresContext _context;
        public TerminService(AresContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Termin>> GetAllTermineAsync()
        {
            return await _context.Termine.Include(t => t.Auto).ThenInclude(a => a.Schäden).ToListAsync();
        }

        public async Task<Termin> GetTerminByIdAsync(int id)
        {
            return await _context.Termine.Include(t => t.Auto).ThenInclude(a => a.Schäden)
                                         .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task AddTerminAsync(Termin termin)
        {
            _context.Termine.Add(termin);
            await _context.SaveChangesAsync();
        }
    }
} 
using ARES.Businesslogik.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARES.Businesslogik.Interface
{
    public interface ITerminService
    {
        Task<IEnumerable<Termin>> GetAllTermineAsync();
        Task<Termin> GetTerminByIdAsync(int id);
        Task AddTerminAsync(Termin termin);
    }
}

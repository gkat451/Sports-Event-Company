using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K1748796.NETCWK.Models
{
    interface ISportRepository
    {
        Sport GetSport(int id);
        IEnumerable<Sport> GetAllSports();
        Sport Add(Sport sport);
        Sport Update(Sport sportChanges);
        Sport Delete(int id);
    }
}

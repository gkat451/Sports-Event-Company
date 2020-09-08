using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K1748796.NETCWK.Models
{
    interface IEventsRepository
    {
        Event GetEvent(int id);
        IEnumerable<Event> GetAllEvents();
        Event Add(Event events );
        // Update(Event eventChanges);
        Event Delete(int id);
    }
}

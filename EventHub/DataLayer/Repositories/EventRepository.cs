using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class EventRepository
    {
        public List<Event> GetAll()
        {
            var results = DbContext.Events;
            return results;
        }
        public Event GetById(int eventId)
        {
            var result = DbContext.Events.Where(e => e.Id == eventId).FirstOrDefault();
            return result;
        }

    }
}

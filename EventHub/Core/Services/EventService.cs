using Core.Dtos;
using DataLayer.Entities;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class EventService
    {
        private EventRepository eventRepository { get; set; }

        public EventService(EventRepository eventRepository)
        {
            this.eventRepository = eventRepository;
        }

        public List<Event> GetAll()
        {
            var results = eventRepository.GetAll();
            return results;
        }
        public Event GetById(int eventId)
        {
            var result = eventRepository.GetById(eventId);
            return result;
        }
        public bool EditName(EventUpdateDto payload)
        {
            if (payload == null || payload.Name == null)
            {
                return false;
            }

            var result = eventRepository.GetById(payload.Id);
            if (result == null) return false;

            result.Name = payload.Name;


            return true;
        }
    }
}

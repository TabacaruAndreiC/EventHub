using Core.Dtos;
using Core.Services;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EventHub.Controllers
{
    [ApiController]
    [Route("api/events")]
    public class EventController : ControllerBase
    {
        private EventService eventService { get; set; }

        private EventController(EventService eventService)
        {
            this.eventService = eventService;
        }

        [HttpGet("/get-all")]
        public ActionResult<List<Event>> GetAll()
        {
            var results = eventService.GetAll();

            return Ok(results);
        }
        [HttpGet("get/{eventId}")]
        public ActionResult<Event> GetById(int eventId)
        {
            var result = eventService.GetById(eventId);
            if (result == null)
            {
                return BadRequest("Event not found");
            }

            return Ok(result);
        }

        [HttpPatch("edit-name")]
        public ActionResult<bool> GetById([FromBody] EventUpdateDto eventUpdateDto)
        {
            var result = eventService.EditName(eventUpdateDto);
            if (!result)
            {
                return BadRequest("Event could not be updated.");
            }
            return result;
        }

    }
}

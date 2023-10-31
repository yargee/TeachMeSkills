using MeetingRoom.Models;
using MeetingRoom.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetingRoom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private IRoomServices _services;
        
        public RoomController(IRoomServices services)
        {
            _services = services;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult("fckmbrn");
        }

        [HttpPost]
        public IActionResult Post(Participier participier)
        {
            return Ok(participier);
        }
        /*
        
        [HttpGet]
        public IParticipier[] GetParticipiers()
        {
            return _services.GetParticipiers();
        }

        [HttpPost]
        public void AddParticipier([FromBody] IParticipier participier)
        {
            _services.AddParticipier(participier);
        }

        [HttpPost]
        public void RemoveParticipier(IParticipier participier)
        {
            _services.RemoveParticipier(participier);
        }*/
    }
}

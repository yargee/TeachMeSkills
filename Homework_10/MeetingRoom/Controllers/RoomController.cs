using MeetingRoom.Models;
using MeetingRoom.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetingRoom.Controllers
{
    [Route("api/[controller]")]  //что это значит и в чем котличие от mvc controller
    [ApiController]
    public class RoomController : ControllerBase
    {
        private IRoomServices _services;
        
        public RoomController(IRoomServices services)  //эта инициализация происходит под капотом?
        {
            _services = services;
        }        
        
        [HttpGet]
        public Participier[] GetParticipiers()
        {
            return _services.GetParticipiers();
        }


        [HttpPost]  //сваггер работает только если тут один метод с пост, если два, то сразу ошибка
        public void RemoveParticipier(Participier participier)
        {
            _services.RemoveParticipier(participier);
            //return Ok(); //что именно должно возвращаться? есть ли какой-то список рекомендуемых реализаций?
            //должно ли вообще возвращаться?
        }
        
        [HttpPost]
        public IActionResult AddParticipier(Participier participier)
        {
            _services.AddParticipier(participier);
            return Ok();
        }
        
    }
}

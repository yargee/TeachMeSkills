using MeetingRoom.Models;

namespace MeetingRoom.Services
{
    public class RoomServices : IRoomServices
    {
        private readonly List<Participier> _participiers = new List<Participier>();

        public int Id { get; private set; }

        public string Name { get; private set; }

        public void AddParticipier(Participier participier)
        {
            _participiers.Add(participier);
        }

        public void RemoveParticipier(Participier participier)
        {
            _participiers.Remove(participier);
        }

        public Participier[] GetParticipiers()
        {
            return _participiers.Select(x => new Participier(x.Name)).ToArray();
        }
    }
}

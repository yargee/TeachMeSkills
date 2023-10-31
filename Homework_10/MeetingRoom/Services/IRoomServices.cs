using MeetingRoom.Models;

namespace MeetingRoom.Services
{
    public interface IRoomServices
    {
        int Id { get; }
        string Name { get; }

        void AddParticipier(Participier participier);
        void RemoveParticipier(Participier participier);
        Participier[] GetParticipiers();
        
    }
}

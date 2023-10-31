namespace MeetingRoom.Models
{
    public class Participier
    {
        public string Name { get; private set; }

        public Participier(string name) 
        {
            Name = name;
        }
    }
}

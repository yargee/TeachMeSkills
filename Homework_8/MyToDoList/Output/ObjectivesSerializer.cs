using MyToDoList.Data;
using System.Text;
using System.Text.Json;

namespace MyToDoList.Output
{
    internal class ObjectivesSerializer
    {
        private readonly string _path = "..\\..\\..\\Objectives.txt";

        public void Reset()
        {
            File.WriteAllText(_path, string.Empty);
        }

        public void AddObjectivesToFile(List<IObjective> objectives)
        {
            var sb = new StringBuilder();

            foreach (var objective in objectives)
            {
                string jsonString = JsonSerializer.Serialize(objective);
                sb.Append("\n" + jsonString);
            }

            Console.WriteLine(sb.ToString());
            File.AppendAllText(_path, sb.ToString());
        }

        public IReadOnlyList<IObjective> ReadObjectivesFromFile()
        {
            var lines = File.ReadAllLines(_path);
            var objectives = new List<IObjective>();

            foreach (var objective in lines)
            {
                Console.WriteLine(objective);
                var deserializedObjective = JsonSerializer.Deserialize<IObjective>(objective);
                Console.WriteLine(deserializedObjective.Description);

                objectives.Add(deserializedObjective);
            }

            return objectives;
        }
    }
}

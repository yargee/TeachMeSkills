using MyToDoList.Data;
using System.Text.Json;

namespace MyToDoList.Output
{
    internal class ObjectivesSerializer
    {
        private readonly string _path = "..\\..\\..\\Objectives.json";

        public void Reset()
        {
            File.WriteAllText(_path, string.Empty);
        }

        public void AddObjectivesToFile(List<Objective> objectives)
        {

            string jsonString = JsonSerializer.Serialize(objectives);

            File.WriteAllText(_path, jsonString);
        }

        public List<Objective> ReadObjectivesFromFile()
        {
            var jsonString = File.ReadAllText(_path);

            if (string.IsNullOrEmpty(jsonString))
            {
                return null;
            }

            var objectives = new List<Objective>();

            objectives = JsonSerializer.Deserialize<List<Objective>>(jsonString);

            return objectives;
        }
    }
}

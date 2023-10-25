using MyToDoList.Output;

namespace MyToDoList.Data;

internal class ToDoList : IToDoList
{
    private readonly List<Objective> _toDoObjectives = new List<Objective>();
    private readonly List<Objective> _doneObjectives = new List<Objective>();

    public int ToDoCount => _toDoObjectives.Count;

    public ToDoList()
    {
        var objectivesSerializer = new ObjectivesSerializer();
        var objectives = objectivesSerializer.ReadObjectivesFromFile();

        if (objectives == null)
        {
            return;
        }
        else
        {
            foreach(var objective in objectives)
            {
                Console.WriteLine(objective.Description + " " + objective.Finished);

                if (objective.Finished == string.Empty)
                {                    
                    _toDoObjectives.Add(objective);
                }
                else
                {                    
                    _doneObjectives.Add(objective);
                }
            }
        }
    }

    public void Add(Objective objective)
    {
        _toDoObjectives.Add(objective);
    }

    public void Delete(int id)
    {
        _toDoObjectives.RemoveAt(id);
    }

    public void Finish(int id)
    {
        var objective = _toDoObjectives[id];
        _toDoObjectives.RemoveAt(id);
        _doneObjectives.Add(objective);
        objective.Finish();
    }

    public IReadOnlyList<Objective> ToDoObjectives()
    {
        return _toDoObjectives;
    }

    public IReadOnlyList<Objective> DoneObjectives()
    {
        return _doneObjectives;
    }

    public void Save()
    {
        var serializer = new ObjectivesSerializer();
        serializer.Reset();

        var newList = new List<Objective>();

        foreach(var objective in  _toDoObjectives)
        {
            newList.Add(objective);
        }
        foreach (var objective in _doneObjectives)
        {
            newList.Add(objective);
        }

        serializer.AddObjectivesToFile(newList);
    }
}

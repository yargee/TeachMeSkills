using MyToDoList.Output;

namespace MyToDoList.Data;

public class ToDoList : IToDoList
{
    private readonly List<IObjective> _toDoObjectives = new List<IObjective>();
    private readonly List<IObjective> _doneObjectives = new List<IObjective>();

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
            _toDoObjectives = (List<IObjective>)objectives.Where(x => x.Finished != default);
            _doneObjectives = (List<IObjective>)objectives.Where(x => x.Finished == default);
        }
    }

    public void Add(IObjective objective)
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

    public IReadOnlyList<IObjective> ToDoObjectives()
    {
        return _toDoObjectives;
    }

    public IReadOnlyList<IObjective> DoneObjectives()
    {
        return _doneObjectives;
    }

    public void Save()
    {
        var serializer = new ObjectivesSerializer();
        serializer.Reset();
        serializer.AddObjectivesToFile(_toDoObjectives);
        serializer.AddObjectivesToFile(_doneObjectives);
    }
}

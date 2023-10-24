namespace MyToDoList.Data;

public interface IToDoList
{
    void Add(IObjective objective);

    void Delete(int id);

    void Finish(int id);

    void Save();

    IReadOnlyList<IObjective> ToDoObjectives();
    IReadOnlyList<IObjective> DoneObjectives();
}

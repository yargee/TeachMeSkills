namespace MyToDoList.Data;

internal interface IToDoList
{
    void Add(Objective objective);

    void Delete(int id);

    void Finish(int id);

    void Save();

    IReadOnlyList<Objective> ToDoObjectives();
    IReadOnlyList<Objective> DoneObjectives();
}

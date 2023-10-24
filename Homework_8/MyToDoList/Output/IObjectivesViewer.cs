
using MyToDoList.Data;

internal interface IObjectivesViewer
    {
        void Print(IReadOnlyList<IObjective> objectives);
    }

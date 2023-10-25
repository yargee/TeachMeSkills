
using MyToDoList.Data;

internal interface IObjectivesViewer
    {
        void Print(IReadOnlyList<Objective> objectives);
    }

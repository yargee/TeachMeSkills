using MyToDoList.Data;

namespace MyToDoList.Output
{
    internal class ToDoViewer : IObjectivesViewer
    {
        public void Print(IReadOnlyList<IObjective> objectives)
        {
            for (int i = 0; i < objectives.Count(); i++)
            {
                Console.Write(i + "-> ");
                Console.WriteLine($"{objectives[i].Description}. " +
                                  $"Задача создана {objectives[i].Created}. " +
                                  $"Необходимо выполнить до {objectives[i].FinishBefore}");
            }
        }
    }
}

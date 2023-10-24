using MyToDoList.Data;

namespace MyToDoList.Output
{
    internal class DoneViewer : IObjectivesViewer
    {
        public void Print(IReadOnlyList<IObjective> objectives)
        {
            string before = "Выполнено в срок.";
            string after = "Выполнено с опозданием.";

            for (int i = 0; i < objectives.Count(); i++)
            {
                Console.Write(i + "-> ");
                Console.WriteLine($"{objectives[i].Description}. " +
                                  $"Задача создана {objectives[i].Created}. " +
                                  $"Задача выполнена {objectives[i].Finished}. " +
                                  $"{(objectives[i].FinishBefore > objectives[i].Finished ? before : after)}");
            }
        }
    }
}

using MyToDoList.Data;
using MyToDoList.Output;
using System.Runtime.InteropServices.JavaScript;

namespace MyToDoList.Commands;

internal class AddCommand : ICommand
{
    private readonly IToDoList _toDoList;

    public string Description => "Добавить задачу";

    public AddCommand(IToDoList toDoList)
    {
        _toDoList = toDoList;
    }

    public void Execute()
    {
        do
        {
            Console.WriteLine("Введи описание задачи");
            var objective = Console.ReadLine();
            Console.WriteLine("Введи дату выполнения задачи");
            var date = Console.ReadLine();

            if (objective != null && DateTime.TryParse(date, out DateTime parsedDate))
            {
                var newObjective = new Objective(objective, parsedDate);
                _toDoList.Add(newObjective);
                break;
            }
        } while (true);
    }
}

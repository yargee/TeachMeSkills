using MyToDoList.Commands;
using MyToDoList.Data;

namespace MyToDoList;
internal class Menu
{
    public Menu()
    {
    }



    public void Start()
    {
        var todoList = new ToDoList();
        List<ICommand> commands = new()
        {
            new ExitCommand(),
            new AddCommand(todoList),
            new RemoveCommand(todoList),
            new SetCompleteCommand(todoList)
        };

        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Задачи к выполнению:");
            PrintList(todoList.ToDoItems());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Выполненные задачи:");            
            PrintList(todoList.DoneItems());
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < commands.Count; i++)
            {
                Console.Write(i + ") ");
                Console.WriteLine(commands[i].Description);
            }
            Console.Write("=> ");

            if (int.TryParse(Console.ReadLine(), out int commandId) && commandId >= 0 && commandId < commands.Count)
            {
                commands[commandId].Execute();
            }
            else
            {
                Console.WriteLine("Недопустимое значение");
            }
        } while (true);
    }

    public static void PrintList(string[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write(i + "->");
            Console.WriteLine(list[i]);
        }

        Console.WriteLine();
    }
}

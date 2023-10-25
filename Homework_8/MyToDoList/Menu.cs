using MyToDoList.Commands;
using MyToDoList.Data;
using MyToDoList.Output;

namespace MyToDoList;
internal class Menu
{
    public void Start()
    {        
        var todoList = new ToDoList();

        List<ICommand> commands = new()
        {
            new ExitCommand(),
            new AddCommand(todoList),
            new RemoveCommand(todoList),
            new FinishCommand(todoList)
        };

        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Задачи к выполнению:");
            PrintList(new ToDoViewer(),  todoList.ToDoObjectives());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Выполненные задачи:");            
            PrintList(new DoneViewer(), todoList.DoneObjectives());
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

            todoList.Save();

        } while (true);
    }

    public static void PrintList(IObjectivesViewer viewer, IReadOnlyList<Objective> list)
    {
        viewer.Print(list);
    }
}

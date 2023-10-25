using MyToDoList.Data;

namespace MyToDoList.Commands
{
    internal class RemoveCommand : ICommand
    {
        private ToDoList _toDoList;

        public string Description => "Удалить задачу.";

        public RemoveCommand(ToDoList toDoList)
        {
            _toDoList = toDoList;
        }

        public void Execute()
        {
            do
            {
                Console.WriteLine("Введи номер задачи для удаления.");
                var input = Console.ReadLine();

                if(!int.TryParse(input, out int index))
                {
                    continue;
                }
                else
                {
                    if (index >= 0 && index < _toDoList.ToDoCount)
                    {
                        _toDoList.Delete(index);
                        break;
                    }
                }
            } while (true);
        }
    }
}
